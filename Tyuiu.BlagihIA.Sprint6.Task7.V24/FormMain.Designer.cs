namespace Tyuiu.BlagihIA.Sprint6.Task7.V24
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
            toolTip1 = new ToolTip(components);
            buttonComp = new Button();
            buttonOpenFile = new Button();
            buttonSave = new Button();
            groupBox3 = new GroupBox();
            dataGridViewOutMatrix = new DataGridView();
            panel5 = new Panel();
            splitter1 = new Splitter();
            groupBoxIn = new GroupBox();
            dataGridViewInMatrix = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            buttonHelp = new Button();
            panel1 = new Panel();
            button1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            panel5.SuspendLayout();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
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
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ButtonFace;
            buttonSave.Enabled = false;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.ForeColor = SystemColors.Control;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(182, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(82, 67);
            buttonSave.TabIndex = 26;
            toolTip1.SetToolTip(buttonSave, "Производит поиск в файле вхождений Н и компилирует строки в которых встречается эт буква");
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOutMatrix);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(453, 289);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.ColumnHeadersVisible = false;
            dataGridViewOutMatrix.Dock = DockStyle.Fill;
            dataGridViewOutMatrix.Location = new Point(3, 19);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.RowHeadersVisible = false;
            dataGridViewOutMatrix.Size = new Size(447, 267);
            dataGridViewOutMatrix.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(463, 161);
            panel5.Name = "panel5";
            panel5.Size = new Size(453, 289);
            panel5.TabIndex = 9;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(460, 161);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 289);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(dataGridViewInMatrix);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(460, 289);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод:";
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.ColumnHeadersVisible = false;
            dataGridViewInMatrix.Dock = DockStyle.Fill;
            dataGridViewInMatrix.Location = new Point(3, 19);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.RowHeadersVisible = false;
            dataGridViewInMatrix.Size = new Size(454, 267);
            dataGridViewInMatrix.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxIn);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 289);
            panel3.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 84);
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
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 84);
            panel2.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Location = new Point(466, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(459, 373);
            panel4.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = SystemColors.GradientInactiveCaption;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.ForeColor = SystemColors.ButtonFace;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(1563, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(74, 67);
            buttonHelp.TabIndex = 25;
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonComp);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 77);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(830, 4);
            button1.Name = "button1";
            button1.Size = new Size(74, 67);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(panel5);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            panel5.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private Button buttonComp;
        private Button buttonOpenFile;
        private GroupBox groupBox3;
        private Panel panel5;
        private Splitter splitter1;
        private GroupBox groupBoxIn;
        private OpenFileDialog openFileDialogTask;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Panel panel2;
        private Panel panel4;
        private Button buttonHelp;
        private Panel panel1;
        private DataGridView dataGridViewOutMatrix;
        private DataGridView dataGridViewInMatrix;
        private Button buttonSave;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
    }
}
