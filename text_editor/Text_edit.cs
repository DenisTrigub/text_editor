using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace test_editor
{
    partial class text_editor
    {
        private void ToggleStyle(FontStyle style, RichTextBox richTextBox1)
        {
            if (richTextBox1.SelectionFont == null) return;

            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle = currentFont.Style.HasFlag(style)
                ? currentFont.Style & ~style
                : currentFont.Style | style;

            richTextBox1.SelectionFont = new Font(currentFont, newStyle);
        }

        private void buttonBold_Click(object sender, EventArgs e, RichTextBox richTextBox1) => ToggleStyle(FontStyle.Bold, richTextBox1);
        private void buttonItalic_Click(object sender, EventArgs e, RichTextBox richTextBox1) => ToggleStyle(FontStyle.Italic, richTextBox1);
        private void buttonUnderline_Click(object sender, EventArgs e, RichTextBox richTextBox1) => ToggleStyle(FontStyle.Underline, richTextBox1);


        private void buttonFont_Click(object sender, EventArgs e , RichTextBox richTextBox1)
        {
            using FontDialog fontDialog = new FontDialog();
            if (richTextBox1.SelectionFont != null)
                fontDialog.Font = richTextBox1.SelectionFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog.Font;
        }

        private void buttonColor_Click(object sender, EventArgs e, RichTextBox richTextBox1)
        {
            using ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog.Color;
        }

        private void buttonCut_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.Cut();
        private void buttonCopy_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.Copy();
        private void buttonPaste_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.Paste();

        private void buttonAlignLeft_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        private void buttonAlignCenter_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        private void buttonAlignRight_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        private void buttonNumbering_Click(object sender, EventArgs e, RichTextBox richTextBox1)
        {
            int start = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;

            int startLine = richTextBox1.GetLineFromCharIndex(start);
            int endLine = richTextBox1.GetLineFromCharIndex(start + Math.Max(length - 1, 0));

            var lines = richTextBox1.Lines;

            bool alreadyNumbered = true;
            for (int i = startLine; i <= endLine; i++)
            {
                if (i < lines.Length && !Regex.IsMatch(lines[i], @"^\d+\.\s"))
                {
                    alreadyNumbered = false;
                    break;
                }
            }

            for (int i = startLine, n = 1; i <= endLine; i++, n++)
            {
                if (i >= lines.Length) continue;

                if (alreadyNumbered)
                    lines[i] = Regex.Replace(lines[i], @"^\d+\.\s", "");
                else
                    lines[i] = $"{n}. {lines[i]}";
            }

            richTextBox1.Lines = lines;
        }

        private void buttonApplyBullet_Click(object sender, EventArgs e, RichTextBox richTextBox1, ComboBox comboBoxBullets)
        {
            string bullet = comboBoxBullets.SelectedItem?.ToString() ?? "•";

            int start = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;

            int startLine = richTextBox1.GetLineFromCharIndex(start);
            int endLine = richTextBox1.GetLineFromCharIndex(start + Math.Max(length - 1, 0));

            var lines = richTextBox1.Lines;

            for (int i = startLine; i <= endLine; i++)
            {
                if (i >= lines.Length) continue;

                if (lines[i].TrimStart().StartsWith(bullet))
                {
                    lines[i] = lines[i].Substring(lines[i].IndexOf(bullet) + bullet.Length).TrimStart();
                }
                else
                {
                    lines[i] = bullet + " " + lines[i];
                }
            }

            richTextBox1.Lines = lines;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e, RichTextBox richTextBox1, ComboBox comboBoxBullets)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int currentLine = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
                string lineText = richTextBox1.Lines.Length > currentLine ? richTextBox1.Lines[currentLine] : "";

                // Проверка на нумерацию "1. ", "2. ", и т.д.
                var matchNumber = Regex.Match(lineText, @"^(\d+)\.\s");
                if (matchNumber.Success)
                {
                    e.Handled = true;
                    int number = int.Parse(matchNumber.Groups[1].Value);
                    richTextBox1.SelectedText = "\n" + (number + 1) + ". ";
                    return;
                }

                // Проверка на маркер (например "• ")
                if (comboBoxBullets.SelectedItem != null)
                {
                    string bullet = comboBoxBullets.SelectedItem.ToString();

                    if (lineText.StartsWith(bullet + " "))
                    {
                        e.Handled = true;
                        richTextBox1.SelectedText = "\n" + bullet + " ";
                        return;
                    }
                }
            }
        }
    }
}
