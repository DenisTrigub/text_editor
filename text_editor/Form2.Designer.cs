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
            кнопка1ToolStripMenuItem = new ToolStripMenuItem();
            курсивToolStripMenuItem = new ToolStripMenuItem();
            кнопка2ToolStripMenuItem = new ToolStripMenuItem();
            кнопка2ToolStripMenuItem1 = new ToolStripMenuItem();
            червонийToolStripMenuItem = new ToolStripMenuItem();
            синійToolStripMenuItem = new ToolStripMenuItem();
            кнопка4ToolStripMenuItem = new ToolStripMenuItem();
            червонийToolStripMenuItem1 = new ToolStripMenuItem();
            синійToolStripMenuItem1 = new ToolStripMenuItem();
            вибірШрифтуToolStripMenuItem = new ToolStripMenuItem();
            червонийToolStripMenuItem2 = new ToolStripMenuItem();
            синійToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
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
            richTextBox1.Anchor = AnchorStyles.Top;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ImeMode = ImeMode.NoControl;
            richTextBox1.Location = new Point(110, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(595, 842);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.Right;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { кнопка1ToolStripMenuItem, курсивToolStripMenuItem, кнопка2ToolStripMenuItem, кнопка2ToolStripMenuItem1, кнопка4ToolStripMenuItem, вибірШрифтуToolStripMenuItem });
            menuStrip1.Location = new Point(640, 40);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 755);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // кнопка1ToolStripMenuItem
            // 
            кнопка1ToolStripMenuItem.Image = (Image)resources.GetObject("кнопка1ToolStripMenuItem.Image");
            кнопка1ToolStripMenuItem.Name = "кнопка1ToolStripMenuItem";
            кнопка1ToolStripMenuItem.Size = new Size(143, 24);
            кнопка1ToolStripMenuItem.ToolTipText = "Жирний";
            // 
            // курсивToolStripMenuItem
            // 
            курсивToolStripMenuItem.Image = (Image)resources.GetObject("курсивToolStripMenuItem.Image");
            курсивToolStripMenuItem.Name = "курсивToolStripMenuItem";
            курсивToolStripMenuItem.Size = new Size(143, 24);
            курсивToolStripMenuItem.ToolTipText = "Курсив";
            // 
            // кнопка2ToolStripMenuItem
            // 
            кнопка2ToolStripMenuItem.Image = (Image)resources.GetObject("кнопка2ToolStripMenuItem.Image");
            кнопка2ToolStripMenuItem.Name = "кнопка2ToolStripMenuItem";
            кнопка2ToolStripMenuItem.Size = new Size(143, 24);
            кнопка2ToolStripMenuItem.ToolTipText = "Підкреслено";
            // 
            // кнопка2ToolStripMenuItem1
            // 
            кнопка2ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { червонийToolStripMenuItem, синійToolStripMenuItem });
            кнопка2ToolStripMenuItem1.Image = (Image)resources.GetObject("кнопка2ToolStripMenuItem1.Image");
            кнопка2ToolStripMenuItem1.Name = "кнопка2ToolStripMenuItem1";
            кнопка2ToolStripMenuItem1.Size = new Size(143, 24);
            кнопка2ToolStripMenuItem1.ToolTipText = "Палітра";
            // 
            // червонийToolStripMenuItem
            // 
            червонийToolStripMenuItem.Name = "червонийToolStripMenuItem";
            червонийToolStripMenuItem.Size = new Size(224, 26);
            червонийToolStripMenuItem.Text = "Червоний";
            // 
            // синійToolStripMenuItem
            // 
            синійToolStripMenuItem.Name = "синійToolStripMenuItem";
            синійToolStripMenuItem.Size = new Size(224, 26);
            синійToolStripMenuItem.Text = "Синій";
            // 
            // кнопка4ToolStripMenuItem
            // 
            кнопка4ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { червонийToolStripMenuItem1, синійToolStripMenuItem1 });
            кнопка4ToolStripMenuItem.Image = (Image)resources.GetObject("кнопка4ToolStripMenuItem.Image");
            кнопка4ToolStripMenuItem.Name = "кнопка4ToolStripMenuItem";
            кнопка4ToolStripMenuItem.Size = new Size(143, 24);
            кнопка4ToolStripMenuItem.ToolTipText = "Колір фону";
            // 
            // червонийToolStripMenuItem1
            // 
            червонийToolStripMenuItem1.Name = "червонийToolStripMenuItem1";
            червонийToolStripMenuItem1.Size = new Size(163, 26);
            червонийToolStripMenuItem1.Text = "Червоний";
            // 
            // синійToolStripMenuItem1
            // 
            синійToolStripMenuItem1.Name = "синійToolStripMenuItem1";
            синійToolStripMenuItem1.Size = new Size(163, 26);
            синійToolStripMenuItem1.Text = "Синій";
            // 
            // вибірШрифтуToolStripMenuItem
            // 
            вибірШрифтуToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { червонийToolStripMenuItem2, синійToolStripMenuItem2 });
            вибірШрифтуToolStripMenuItem.Image = (Image)resources.GetObject("вибірШрифтуToolStripMenuItem.Image");
            вибірШрифтуToolStripMenuItem.Name = "вибірШрифтуToolStripMenuItem";
            вибірШрифтуToolStripMenuItem.Size = new Size(143, 24);
            вибірШрифтуToolStripMenuItem.ToolTipText = "Вибір шрифту";
            // 
            // червонийToolStripMenuItem2
            // 
            червонийToolStripMenuItem2.Name = "червонийToolStripMenuItem2";
            червонийToolStripMenuItem2.Size = new Size(163, 26);
            червонийToolStripMenuItem2.Text = "Червоний";
            // 
            // синійToolStripMenuItem2
            // 
            синійToolStripMenuItem2.Name = "синійToolStripMenuItem2";
            синійToolStripMenuItem2.Size = new Size(163, 26);
            синійToolStripMenuItem2.Text = "Синій";
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ButtonHighlight;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(796, 40);
            menuStrip2.TabIndex = 7;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem10, toolStripMenuItem11, toolStripMenuItem12 });
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.RightToLeftAutoMirrorImage = true;
            toolStripMenuItem1.Size = new Size(46, 36);
            toolStripMenuItem1.ToolTipText = "Меню";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Image = (Image)resources.GetObject("toolStripMenuItem10.Image");
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(263, 26);
            toolStripMenuItem10.Text = "Відкрити файл";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Image = (Image)resources.GetObject("toolStripMenuItem11.Image");
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(263, 26);
            toolStripMenuItem11.Text = "Зберегти файл";
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Image = (Image)resources.GetObject("toolStripMenuItem12.Image");
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(263, 26);
            toolStripMenuItem12.Text = "Зберегти як Новий файл";
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Location = new Point(572, 42);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(180, 25);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(508, 42);
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
            AutoSize = true;
            ClientSize = new Size(796, 795);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Текстовий ркедактор";
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
        private ToolStripMenuItem кнопка1ToolStripMenuItem;
        private ToolStripMenuItem кнопка2ToolStripMenuItem;
        private ToolStripMenuItem кнопка2ToolStripMenuItem1;
        private ToolStripMenuItem кнопка4ToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private RichTextBox richTextBox2;
        private Label label1;
        private ToolStripMenuItem вибірШрифтуToolStripMenuItem;
        private ToolStripMenuItem червонийToolStripMenuItem;
        private ToolStripMenuItem синійToolStripMenuItem;
        private ToolStripMenuItem червонийToolStripMenuItem1;
        private ToolStripMenuItem синійToolStripMenuItem1;
        private ToolStripMenuItem червонийToolStripMenuItem2;
        private ToolStripMenuItem синійToolStripMenuItem2;
        private ToolStripMenuItem курсивToolStripMenuItem;
        private ToolTip toolTip1;
    }
}