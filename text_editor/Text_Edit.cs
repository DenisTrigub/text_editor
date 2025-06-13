using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace text_editor
{
    public partial class text_editor
    {
        public void ToggleStyle(FontStyle style, RichTextBox richTextBox1)
        {
            if (richTextBox1.SelectionFont == null) return;

            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle = currentFont.Style.HasFlag(style)
                ? currentFont.Style & ~style
                : currentFont.Style | style;

            richTextBox1.SelectionFont = new Font(currentFont, newStyle);
        }

        public void buttonCut_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.Cut();
        public void buttonCopy_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.Copy();
        public void buttonPaste_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.Paste();
        public void buttonAlignLeft_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        public void buttonAlignCenter_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        public void buttonAlignRight_Click(object sender, EventArgs e, RichTextBox richTextBox1) => richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        public void buttonFont_Click(object sender, EventArgs e, RichTextBox richTextBox1)
        {
            using FontDialog fontDialog = new FontDialog();
            if (richTextBox1.SelectionFont != null)
                fontDialog.Font = richTextBox1.SelectionFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog.Font;
        }

        public void buttonColor_Click(object sender, EventArgs e, RichTextBox richTextBox1)
        {
            using ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog.Color;
        }

        public void buttonHighlight_Click(object sender, EventArgs e, RichTextBox richTextBox1)
        {
            using ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog.Color;
            }
        }

        public void buttonNumbering_Click(object sender, EventArgs e, RichTextBox richTextBox1)
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

        public void buttonApplyBullet_Click(object sender, EventArgs e, RichTextBox richTextBox1)
        {
            string bullet = "•";

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

        public void richTextBox1_KeyDown(object sender, KeyEventArgs e, RichTextBox richTextBox1, ComboBox comboBoxBullets)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int currentLine = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
                string lineText = richTextBox1.Lines.Length > currentLine ? richTextBox1.Lines[currentLine] : "";

                var matchNumber = Regex.Match(lineText, @"^(\d+)\.\s");
                if (matchNumber.Success)
                {
                    e.Handled = true;
                    int number = int.Parse(matchNumber.Groups[1].Value);
                    richTextBox1.SelectedText = "\n" + (number + 1) + ". ";
                    return;
                }

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
