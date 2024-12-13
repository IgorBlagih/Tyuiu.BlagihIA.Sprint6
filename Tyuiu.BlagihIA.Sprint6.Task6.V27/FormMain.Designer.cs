namespace Tyuiu.BlagihIA.Sprint6.Task6.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonComp = new Button();
            buttonOpenFile = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            groupBoxIn = new GroupBox();
            textBoxIn = new TextBox();
            splitter1 = new Splitter();
            panel5 = new Panel();
            groupBox3 = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxIn.SuspendLayout();
            panel5.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonComp);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 77);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = SystemColors.GradientInactiveCaption;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.ForeColor = SystemColors.ButtonFace;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(847, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(74, 67);
            buttonHelp.TabIndex = 25;
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonComp
            // 
            buttonComp.BackColor = SystemColors.ButtonFace;
            buttonComp.Enabled = false;
            buttonComp.FlatStyle = FlatStyle.Popup;
            buttonComp.ForeColor = SystemColors.Control;
            buttonComp.Image = (Image)resources.GetObject("buttonComp.Image");
            buttonComp.Location = new Point(94, 4);
            buttonComp.Name = "buttonComp";
            buttonComp.Size = new Size(82, 67);
            buttonComp.TabIndex = 1;
            toolTip1.SetToolTip(buttonComp, "Производит поиск в файле вхождений Н и компилирует строки в которых встречается эт буква");
            buttonComp.UseVisualStyleBackColor = false;
            buttonComp.Click += buttonComp_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = SystemColors.ButtonFace;
            buttonOpenFile.FlatStyle = FlatStyle.Popup;
            buttonOpenFile.ForeColor = SystemColors.Control;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(6, 4);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(82, 67);
            buttonOpenFile.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 84);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(924, 84);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(10, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(908, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel4
            // 
            panel4.Location = new Point(466, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(459, 373);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxIn);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 370);
            panel3.TabIndex = 2;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxIn);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(460, 370);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод:";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 19);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(454, 348);
            textBoxIn.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(460, 161);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 370);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(463, 161);
            panel5.Name = "panel5";
            panel5.Size = new Size(461, 370);
            panel5.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxOut);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(461, 370);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(3, 19);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(455, 348);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 531);
            Controls.Add(panel5);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(940, 570);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            panel5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button buttonComp;
        private Button buttonOpenFile;
        private GroupBox groupBox1;
        private Panel panel3;
        private Splitter splitter1;
        private Panel panel5;
        private Button buttonHelp;
        private TextBox textBox1;
        private GroupBox groupBoxIn;
        private TextBox textBoxIn;
        private GroupBox groupBox3;
        private TextBox textBoxOut;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialogTask;
    }
}
