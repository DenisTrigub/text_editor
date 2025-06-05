using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace text_editor
{
    partial class text_editor
    {

        private static HashSet<string> dictionary;
        private static string loadedPath;
        private static List<(string Word, int Index, int Length)> misspelledWords = new();

        public void Syntax_highlighting(RichTextBox editor, string dictionaryPath)
        {
            if (dictionary == null || loadedPath != dictionaryPath)
            {
                dictionary = new HashSet<string>();
                using (StreamReader reader = new StreamReader(dictionaryPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        dictionary.Add(line.ToLower());
                }
                loadedPath = dictionaryPath;
            }
            misspelledWords.Clear();

            int cursorPosition = editor.SelectionStart;
            int selectionLength = editor.SelectionLength;

            string text = editor.Text;
            editor.SelectAll();
            editor.SelectionColor = Color.Black;

            string[] words = Regex.Split(text, @"\W+");
            int searchStart = 0;

            foreach (string word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                    continue;

                int index = text.IndexOf(word, searchStart, StringComparison.OrdinalIgnoreCase);
                if (index == -1) continue;

                searchStart = index + word.Length;

                if (!dictionary.Contains(word.ToLower()))
                {
                    editor.Select(index, word.Length);
                    editor.SelectionColor = Color.Red;

                    misspelledWords.Add((word, index, word.Length));
                }
            }

            editor.Select(cursorPosition, selectionLength);
            editor.SelectionColor = Color.Black;
        }

        public void HandleMouseMove(RichTextBox editor, ToolTip tooltip, MouseEventArgs e)
        {
            int charIndex = editor.GetCharIndexFromPosition(e.Location);

            foreach (var misspelled in misspelledWords)
            {
                if (charIndex >= misspelled.Index && charIndex < misspelled.Index + misspelled.Length)
                {
                    string suggestion = FindSuggestion(misspelled.Word);
                    tooltip.SetToolTip(editor, $"Можливо ви мали на увазі: {suggestion}\n(ПКМ — додати до словника)");
                    return;
                }
            }
            tooltip.SetToolTip(editor, string.Empty);
        }
        public void HandleRightClick(RichTextBox editor, MouseEventArgs e, string dictionaryPath)
        {
            if (e.Button != MouseButtons.Right)
                return;

            int charIndex = editor.GetCharIndexFromPosition(e.Location);

            foreach (var misspelled in misspelledWords)
            {
                if (charIndex >= misspelled.Index && charIndex < misspelled.Index + misspelled.Length)
                {
                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    ToolStripMenuItem addWordItem = new ToolStripMenuItem("Додати до словника");

                    addWordItem.Click += (s, ev) =>
                    {
                        string wordToAdd = misspelled.Word.ToLower();
                        if (!dictionary.Contains(wordToAdd))
                        {
                            File.AppendAllText(dictionaryPath, wordToAdd + Environment.NewLine);
                            dictionary.Add(wordToAdd);
                            MessageBox.Show($"Слово \"{misspelled.Word}\" додано до словника.", "Словник", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    };

                    contextMenu.Items.Add(addWordItem);
                    contextMenu.Show(editor, e.Location);
                    return;
                }
            }
        }

        private string FindSuggestion(string word)
        {
            string lower = word.ToLower();
            var candidates = dictionary
                .Where(d => d.StartsWith(lower.Substring(0, 1)))
                .OrderBy(d => LevenshteinDistance(lower, d))
                .Take(1);

            return candidates.FirstOrDefault() ?? "(немає варіантів)";
        }

        private int LevenshteinDistance(string a, string b)
        {
            int[,] dp = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i <= a.Length; i++) dp[i, 0] = i;
            for (int j = 0; j <= b.Length; j++) dp[0, j] = j;

            for (int i = 1; i <= a.Length; i++)
            {
                for (int j = 1; j <= b.Length; j++)
                {
                    int cost = a[i - 1] == b[j - 1] ? 0 : 1;

                    dp[i, j] = Math.Min(
                        Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1),
                        dp[i - 1, j - 1] + cost);
                }
            }

            return dp[a.Length, b.Length];
        }
    }
}