namespace Tyuiu.BlagihIA.Sprint6.Task3.V11
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

        private TextBox textBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewMTRX;
        private GroupBox groupBox2;
        private Button buttonDone;
        private Button buttonHelp;
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridViewMTRX = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewRes = new DataGridView();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMTRX).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 162);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в первом столбце.\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 262);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // dataGridViewMTRX
            // 
            dataGridViewMTRX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMTRX.ColumnHeadersVisible = false;
            dataGridViewMTRX.Location = new Point(317, 22);
            dataGridViewMTRX.Name = "dataGridViewMTRX";
            dataGridViewMTRX.ReadOnly = true;
            dataGridViewMTRX.RowHeadersVisible = false;
            dataGridViewMTRX.Size = new Size(216, 199);
            dataGridViewMTRX.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewRes);
            groupBox2.Location = new Point(539, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 224);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результат";
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.ColumnHeadersVisible = false;
            dataGridViewRes.Location = new Point(19, 20);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.ReadOnly = true;
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.Size = new Size(216, 199);
            dataGridViewRes.TabIndex = 5;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Chartreuse;
            buttonDone.Location = new Point(409, 234);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(124, 41);
            buttonDone.TabIndex = 19;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DeepSkyBlue;
            buttonHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(317, 233);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(86, 41);
            buttonHelp.TabIndex = 18;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(833, 286);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(dataGridViewMTRX);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMTRX).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dataGridViewRes;
    }
}
