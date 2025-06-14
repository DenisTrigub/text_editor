﻿using System;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using PdfSharp.Pdf.IO;



namespace text_editor
{
    partial class text_editor
    {
        private string currentFilePath = null;

        public void CreateNewDocument(RichTextBox editorTextBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|PDF Files (*.pdf)|*.pdf",
                Title = "Створити новий документ"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                return;

            string path = saveFileDialog.FileName;
            string ext = System.IO.Path.GetExtension(path).ToLower();

            try
            {
                switch (ext)
                {
                    case ".txt":
                        File.WriteAllText(path, "");
                        break;
                    case ".rtf":
                        using (RichTextBox rtb = new RichTextBox())
                        {
                            rtb.SaveFile(path);
                        }
                        break;
                    case ".pdf":
                        SaveAsPdf(path, "");
                        break;
                    default:
                        MessageBox.Show("Формат не підтримується!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                currentFilePath = path;
                editorTextBox.Clear();
                MessageBox.Show("Новий документ створено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при створенні файлу:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void OpenFile(RichTextBox editorTextBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|PDF Files (*.pdf)|*.pdf",

                Title = "Відкрити файл"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string ext = System.IO.Path.GetExtension(path).ToLower();

                try
                {
                    switch (ext)
                    {
                        case ".txt":
                            editorTextBox.Text = File.ReadAllText(path);
                            break;
                        case ".rtf":
                            editorTextBox.LoadFile(path);
                            break;
                        case ".pdf":
                            OpenPdf(path, editorTextBox);
                            break;
                        default:
                            MessageBox.Show("Формат не підтримується!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    currentFilePath = path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при відкритті файлу:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SaveFile(RichTextBox editorTextBox)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {

                MessageBox.Show("Файл не відкрито або не створено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ext = System.IO.Path.GetExtension(currentFilePath).ToLower();

            try
            {
                switch (ext)
                {
                    case ".txt":
                        File.WriteAllText(currentFilePath, editorTextBox.Text);
                        break;
                    case ".rtf":
                        editorTextBox.SaveFile(currentFilePath);
                        break;
                    case ".pdf":
                        SaveAsPdf(currentFilePath, editorTextBox.Text);
                        break;
                    default:
                        MessageBox.Show("Формат не підтримується!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                MessageBox.Show("Файл збережено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні файлу:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveAsFile(RichTextBox editorTextBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|PDF Files (*.pdf)|*.pdf",
                Title = "Зберегти як"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                SaveFile(editorTextBox);
            }
        }

        public void SaveAsPdf(string path, string content)
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument();
                document.Info.Title = "Текстовий документ";

                PdfSharp.Pdf.PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 12, XFontStyle.Regular);

                string[] lines = content.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                double y = 40;
                double lineHeight = font.Size * 1.2;

                foreach (string line in lines)
                {
                    if (y + lineHeight > page.Height - 40)
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        y = 40;
                    }

                    gfx.DrawString(line, font, XBrushes.Black,
                        new XRect(40, y, page.Width - 80, lineHeight),
                        XStringFormats.TopLeft);

                    y += lineHeight;
                }

                document.Save(path);
                document.Close();

                MessageBox.Show("PDF успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні PDF:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenPdf(string path, RichTextBox editorTextBox)
        {
            try
            {
                StringBuilder text = new StringBuilder();

                iTextSharp.text.pdf.PdfReader pdfReader = new iTextSharp.text.pdf.PdfReader(path);
                for (int i = 1; i <= pdfReader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(pdfReader, i));
                }
                pdfReader.Close();

                editorTextBox.Text = text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося відкрити PDF:\n" + ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public string GetCurrentFilePath()
        {
            return currentFilePath;
        }

    }
}