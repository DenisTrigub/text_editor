using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_editor
{
    partial class text_editor
    {
        public void textBoxSearch_TextChanged(RichTextBox richTextBox1, RichTextBox textBoxSearch)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                int cursorPosition = richTextBox1.SelectionStart;

                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = Color.White;

                richTextBox1.Select(cursorPosition, 0);
                richTextBox1.SelectionBackColor = Color.White;
            }
        }

        public void buttonFind_Click(RichTextBox richTextBox1, RichTextBox textBoxSearch)
        {
            string searchText = textBoxSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Введіть текст для підсвічування.");
                return;
            }

            int originalSelectionStart = richTextBox1.SelectionStart;
            int originalSelectionLength = richTextBox1.SelectionLength;

            // Очистка предыдущей подсветки
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;

            int startIndex = 0;
            while (startIndex < richTextBox1.TextLength)
            {
                int index = richTextBox1.Find(searchText, startIndex, RichTextBoxFinds.None);
                if (index == -1)
                    break;

                richTextBox1.Select(index, searchText.Length);
                richTextBox1.SelectionBackColor = Color.Yellow;

                startIndex = index + searchText.Length;
            }

            // Возвращаем курсор
            richTextBox1.Select(originalSelectionStart, originalSelectionLength);
            richTextBox1.ScrollToCaret();
            richTextBox1.Focus();

            // Сброс стиля после подсветки
            int caretPosition = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
            richTextBox1.Select(caretPosition, 0);
            richTextBox1.SelectionBackColor = Color.White;
        }
    }
}
