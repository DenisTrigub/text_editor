namespace text_editor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            FattyToolStripMenuItem = new ToolStripMenuItem();
            ItalicsToolStripMenuItem = new ToolStripMenuItem();
            UnderlinedToolStripMenuItem = new ToolStripMenuItem();
            PaletteToolStripMenuItem = new ToolStripMenuItem();
            BackgroundColorToolStripMenuItem = new ToolStripMenuItem();
            FontSelectionToolStripMenuItem = new ToolStripMenuItem();
            CutOutToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem = new ToolStripMenuItem();
            InsertToolStripMenuItem = new ToolStripMenuItem();
            NumeberingToolStripMenuItem = new ToolStripMenuItem();
            levelingToolStripMenuItem = new ToolStripMenuItem();
            влевоToolStripMenuItem = new ToolStripMenuItem();
            поЦентруToolStripMenuItem = new ToolStripMenuItem();
            вправоToolStripMenuItem = new ToolStripMenuItem();
            MarkerToolStripMenuItem = new ToolStripMenuItem();
            UploadImageToolStripMenuItem1 = new ToolStripMenuItem();
            chekToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            MenutoolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.HideSelection = false;
            richTextBox1.ImeMode = ImeMode.NoControl;
            richTextBox1.Location = new Point(126, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(595, 842);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.MouseDown += editorTextBox_MouseDown;
            richTextBox1.MouseMove += editorTextBox_MouseMove;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FattyToolStripMenuItem, ItalicsToolStripMenuItem, UnderlinedToolStripMenuItem, PaletteToolStripMenuItem, BackgroundColorToolStripMenuItem, FontSelectionToolStripMenuItem, CutOutToolStripMenuItem, CopyToolStripMenuItem, InsertToolStripMenuItem, NumeberingToolStripMenuItem, levelingToolStripMenuItem, MarkerToolStripMenuItem, UploadImageToolStripMenuItem1, chekToolStripMenuItem });
            menuStrip1.Location = new Point(0, 40);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 755);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // FattyToolStripMenuItem
            // 
            FattyToolStripMenuItem.Image = (Image)resources.GetObject("FattyToolStripMenuItem.Image");
            FattyToolStripMenuItem.Name = "FattyToolStripMenuItem";
            FattyToolStripMenuItem.Size = new Size(143, 24);
            FattyToolStripMenuItem.ToolTipText = "Жирний";
            FattyToolStripMenuItem.Click += кнопка1ToolStripMenuItem_Click;
            // 
            // ItalicsToolStripMenuItem
            // 
            ItalicsToolStripMenuItem.Image = (Image)resources.GetObject("ItalicsToolStripMenuItem.Image");
            ItalicsToolStripMenuItem.Name = "ItalicsToolStripMenuItem";
            ItalicsToolStripMenuItem.Size = new Size(143, 24);
            ItalicsToolStripMenuItem.ToolTipText = "Курсив";
            ItalicsToolStripMenuItem.Click += кнопка2ToolStripMenuItem_Click;
            // 
            // UnderlinedToolStripMenuItem
            // 
            UnderlinedToolStripMenuItem.Image = (Image)resources.GetObject("UnderlinedToolStripMenuItem.Image");
            UnderlinedToolStripMenuItem.Name = "UnderlinedToolStripMenuItem";
            UnderlinedToolStripMenuItem.Size = new Size(143, 24);
            UnderlinedToolStripMenuItem.ToolTipText = "Підкреслено";
            UnderlinedToolStripMenuItem.Click += кнопка3ToolStripMenuItem_Click;
            // 
            // PaletteToolStripMenuItem
            // 
            PaletteToolStripMenuItem.Image = (Image)resources.GetObject("PaletteToolStripMenuItem.Image");
            PaletteToolStripMenuItem.Name = "PaletteToolStripMenuItem";
            PaletteToolStripMenuItem.Size = new Size(143, 24);
            PaletteToolStripMenuItem.ToolTipText = "Палітра";
            PaletteToolStripMenuItem.Click += кнопка4ToolStripMenuItem_Click;
            // 
            // BackgroundColorToolStripMenuItem
            // 
            BackgroundColorToolStripMenuItem.Image = (Image)resources.GetObject("BackgroundColorToolStripMenuItem.Image");
            BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem";
            BackgroundColorToolStripMenuItem.Size = new Size(143, 24);
            BackgroundColorToolStripMenuItem.ToolTipText = "Колір фону";
            BackgroundColorToolStripMenuItem.Click += кнопка5ToolStripMenuItem_Click;
            // 
            // FontSelectionToolStripMenuItem
            // 
            FontSelectionToolStripMenuItem.Image = (Image)resources.GetObject("FontSelectionToolStripMenuItem.Image");
            FontSelectionToolStripMenuItem.Name = "FontSelectionToolStripMenuItem";
            FontSelectionToolStripMenuItem.Size = new Size(143, 24);
            FontSelectionToolStripMenuItem.ToolTipText = "Вибір шрифту";
            FontSelectionToolStripMenuItem.Click += кнопка6ToolStripMenuItem_Click;
            // 
            // CutOutToolStripMenuItem
            // 
            CutOutToolStripMenuItem.Image = (Image)resources.GetObject("CutOutToolStripMenuItem.Image");
            CutOutToolStripMenuItem.Name = "CutOutToolStripMenuItem";
            CutOutToolStripMenuItem.Size = new Size(143, 24);
            CutOutToolStripMenuItem.Click += кнопка7ToolStripMenuItem_Click;
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Image = (Image)resources.GetObject("CopyToolStripMenuItem.Image");
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.Size = new Size(143, 24);
            CopyToolStripMenuItem.Click += кнопка8ToolStripMenuItem_Click;
            // 
            // InsertToolStripMenuItem
            // 
            InsertToolStripMenuItem.Image = (Image)resources.GetObject("InsertToolStripMenuItem.Image");
            InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            InsertToolStripMenuItem.Size = new Size(143, 24);
            InsertToolStripMenuItem.Click += кнопка9ToolStripMenuItem_Click;
            // 
            // NumeberingToolStripMenuItem
            // 
            NumeberingToolStripMenuItem.Name = "NumeberingToolStripMenuItem";
            NumeberingToolStripMenuItem.Size = new Size(143, 24);
            NumeberingToolStripMenuItem.Text = "1. 2 .3.";
            NumeberingToolStripMenuItem.Click += нумерацияToolStripMenuItem_Click;
            // 
            // levelingToolStripMenuItem
            // 
            levelingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { влевоToolStripMenuItem, поЦентруToolStripMenuItem, вправоToolStripMenuItem });
            levelingToolStripMenuItem.Image = (Image)resources.GetObject("levelingToolStripMenuItem.Image");
            levelingToolStripMenuItem.Name = "levelingToolStripMenuItem";
            levelingToolStripMenuItem.Size = new Size(143, 24);
            // 
            // влевоToolStripMenuItem
            // 
            влевоToolStripMenuItem.Image = (Image)resources.GetObject("влевоToolStripMenuItem.Image");
            влевоToolStripMenuItem.Name = "влевоToolStripMenuItem";
            влевоToolStripMenuItem.Size = new Size(224, 26);
            влевоToolStripMenuItem.Text = "вліво";
            влевоToolStripMenuItem.Click += влевоToolStripMenuItem_Click;
            // 
            // поЦентруToolStripMenuItem
            // 
            поЦентруToolStripMenuItem.Image = (Image)resources.GetObject("поЦентруToolStripMenuItem.Image");
            поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            поЦентруToolStripMenuItem.Size = new Size(224, 26);
            поЦентруToolStripMenuItem.Text = "по центру";
            поЦентруToolStripMenuItem.Click += поЦентруToolStripMenuItem_Click;
            // 
            // вправоToolStripMenuItem
            // 
            вправоToolStripMenuItem.Image = (Image)resources.GetObject("вправоToolStripMenuItem.Image");
            вправоToolStripMenuItem.Name = "вправоToolStripMenuItem";
            вправоToolStripMenuItem.Size = new Size(224, 26);
            вправоToolStripMenuItem.Text = "вправо";
            вправоToolStripMenuItem.Click += вправоToolStripMenuItem_Click;
            // 
            // MarkerToolStripMenuItem
            // 
            MarkerToolStripMenuItem.Image = (Image)resources.GetObject("MarkerToolStripMenuItem.Image");
            MarkerToolStripMenuItem.Name = "MarkerToolStripMenuItem";
            MarkerToolStripMenuItem.Size = new Size(143, 24);
            MarkerToolStripMenuItem.Click += кнопка12ToolStripMenuItem_Click;
            // 
            // UploadImageToolStripMenuItem1
            // 
            UploadImageToolStripMenuItem1.Image = (Image)resources.GetObject("UploadImageToolStripMenuItem1.Image");
            UploadImageToolStripMenuItem1.Name = "UploadImageToolStripMenuItem1";
            UploadImageToolStripMenuItem1.Size = new Size(143, 24);
            UploadImageToolStripMenuItem1.Click += imageToolStripMenuItem1_Click;
            // 
            // chekToolStripMenuItem
            // 
            chekToolStripMenuItem.Image = (Image)resources.GetObject("chekToolStripMenuItem.Image");
            chekToolStripMenuItem.Name = "chekToolStripMenuItem";
            chekToolStripMenuItem.Size = new Size(143, 24);
            chekToolStripMenuItem.Click += chekToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ButtonHighlight;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { MenutoolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(796, 40);
            menuStrip2.TabIndex = 7;
            menuStrip2.Text = "menuStrip2";
            // 
            // MenutoolStripMenuItem1
            // 
            MenutoolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem10, toolStripMenuItem11, toolStripMenuItem12 });
            MenutoolStripMenuItem1.Image = (Image)resources.GetObject("MenutoolStripMenuItem1.Image");
            MenutoolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            MenutoolStripMenuItem1.Name = "MenutoolStripMenuItem1";
            MenutoolStripMenuItem1.RightToLeftAutoMirrorImage = true;
            MenutoolStripMenuItem1.Size = new Size(46, 36);
            MenutoolStripMenuItem1.ToolTipText = "Меню";
            MenutoolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Image = (Image)resources.GetObject("toolStripMenuItem10.Image");
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(263, 26);
            toolStripMenuItem10.Text = "Відкрити файл";
            toolStripMenuItem10.Click += toolStripMenuItem10_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Image = (Image)resources.GetObject("toolStripMenuItem11.Image");
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(263, 26);
            toolStripMenuItem11.Text = "Зберегти файл";
            toolStripMenuItem11.Click += toolStripMenuItem11_Click;
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Image = (Image)resources.GetObject("toolStripMenuItem12.Image");
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(263, 26);
            toolStripMenuItem12.Text = "Зберегти як Новий файл";
            toolStripMenuItem12.Click += toolStripMenuItem12_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.None;
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Location = new Point(315, -22);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(180, 29);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(251, -17);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 9;
            label1.Text = "Пошук:";
            label1.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(796, 795);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Текстовий редактор";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FattyToolStripMenuItem;
        private ToolStripMenuItem UnderlinedToolStripMenuItem;
        private ToolStripMenuItem PaletteToolStripMenuItem;
        private ToolStripMenuItem BackgroundColorToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem MenutoolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private RichTextBox richTextBox2;
        private Label label1;
        private ToolStripMenuItem FontSelectionToolStripMenuItem;
        private ToolStripMenuItem ItalicsToolStripMenuItem;
        private ToolTip toolTip1;
        private ToolStripMenuItem CutOutToolStripMenuItem;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private ToolStripMenuItem NumeberingToolStripMenuItem;
        private ToolStripMenuItem MarkerToolStripMenuItem;
        private ToolStripMenuItem levelingToolStripMenuItem;
        private ToolStripMenuItem влевоToolStripMenuItem;
        private ToolStripMenuItem поЦентруToolStripMenuItem;
        private ToolStripMenuItem вправоToolStripMenuItem;
        private ToolStripMenuItem InsertToolStripMenuItem;
        private ToolStripMenuItem UploadImageToolStripMenuItem1;
        private ToolStripMenuItem chekToolStripMenuItem;
    }
}