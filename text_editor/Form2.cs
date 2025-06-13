using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace text_editor
{
    public partial class Form2 : Form
    {

        private text_editor textEditor = new text_editor();
        private ToolTip toolTip = new ToolTip();
        private string dictionaryPath = "ru_RU.dic";
        public Form2()
        {
            InitializeComponent();
            menuStrip1.ShowItemToolTips = true;
            menuStrip2.ShowItemToolTips = true;
            MenutoolStripMenuItem1.ToolTipText = "Меню";
            FattyToolStripMenuItem.ToolTipText = "Жирний";
            ItalicsToolStripMenuItem.ToolTipText = "Курсив";
            UnderlinedToolStripMenuItem.ToolTipText = "Підкреслений";
            PaletteToolStripMenuItem.ToolTipText = "Колір тексту";
            BackgroundColorToolStripMenuItem.ToolTipText = "Колір фону";
            FontSelectionToolStripMenuItem.ToolTipText = "Вибір шрифту";
            CutOutToolStripMenuItem.ToolTipText = "Вирізати";
            CopyToolStripMenuItem.ToolTipText = "Копіювати";
            InsertToolStripMenuItem.ToolTipText = "Вставити";
            NumeberingToolStripMenuItem.ToolTipText = "Нумерація";
            levelingToolStripMenuItem.ToolTipText = "Вирівнювання";
            MarkerToolStripMenuItem.ToolTipText = "Маркер";
            UploadImageToolStripMenuItem1.ToolTipText = "Завантажити зображення";
            chekToolStripMenuItem.ToolTipText = "Перевірити синтаксис";


        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           // textEditor.Syntax_highlighting(richTextBox1, dictionaryPath);
           // textEditor.UnderlineMisspelledWords(richTextBox1);
        }
        private void editorTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            textEditor.HandleMouseMove(richTextBox1, toolTip, e);
        }

        private void editorTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            textEditor.HandleRightClick(richTextBox1, e, dictionaryPath);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            textEditor.buttonFind_Click(richTextBox1, richTextBox2);
        }

        private void нумерацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonNumbering_Click(sender, e, richTextBox1);
        }

        private void кнопка1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.ToggleStyle(FontStyle.Bold, richTextBox1);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            textEditor.OpenFile(richTextBox1);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            textEditor.SaveAsFile(richTextBox1);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            textEditor.SaveFile(richTextBox1);
        }

        private void кнопка2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.ToggleStyle(FontStyle.Italic, richTextBox1);
        }

        private void кнопка3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.ToggleStyle(FontStyle.Underline, richTextBox1);
        }

        private void кнопка4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonColor_Click(sender, e, richTextBox1);
        }

        private void кнопка5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonHighlight_Click(sender, e, richTextBox1);
        }

        private void кнопка6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonFont_Click(sender, e, richTextBox1);
        }

        private void кнопка7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonCut_Click(sender, e, richTextBox1);
        }

        private void кнопка8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonCopy_Click(sender, e, richTextBox1);
        }

        private void кнопка9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonPaste_Click(sender, e, richTextBox1);
        }

        private void влевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonAlignLeft_Click(sender, e, richTextBox1);
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonAlignCenter_Click(sender, e, richTextBox1);
        }

        private void вправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonAlignRight_Click(sender, e, richTextBox1);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            textEditor.textBoxSearch_TextChanged(richTextBox1, richTextBox2);
        }


        private void кнопка12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.buttonApplyBullet_Click(sender, e, richTextBox1);
        }

        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofd.FileName;
                    textEditor.InsertImage(richTextBox1, imagePath);
                }
            }
        }

        private void chekToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            textEditor.Syntax_highlighting(richTextBox1, dictionaryPath);
            textEditor.UnderlineMisspelledWords(richTextBox1);
        }
    }
   }

