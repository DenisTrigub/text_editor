using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_editor
{
    partial class text_editor
    {
        public void InsertImage(RichTextBox richTextBox, string imagePath)
        {

            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
            {
                MessageBox.Show("File not found!");
                return;
            }

            try
            {
                Image img = Image.FromFile(imagePath);

                Clipboard.SetImage(img);

                richTextBox.Paste();

                img.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

