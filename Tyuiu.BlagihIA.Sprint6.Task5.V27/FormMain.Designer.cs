namespace Tyuiu.BlagihIA.Sprint6.Task5.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonFile = new Button();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            dataGridViewNum = new DataGridView();
            panel3 = new Panel();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNum).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonFile);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 136);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = SystemColors.Control;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.ForeColor = SystemColors.Control;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.ImageAlign = ContentAlignment.TopCenter;
            buttonHelp.Location = new Point(750, 6);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(38, 40);
            buttonHelp.TabIndex = 24;
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Chartreuse;
            buttonDone.Location = new Point(455, 60);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(154, 49);
            buttonDone.TabIndex = 23;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // buttonFile
            // 
            buttonFile.BackColor = Color.Yellow;
            buttonFile.Location = new Point(455, 13);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(154, 28);
            buttonFile.TabIndex = 1;
            buttonFile.Text = "Открыть файл";
            buttonFile.UseVisualStyleBackColor = false;
            buttonFile.Click += buttonFile_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(443, 119);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 461);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewNum);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 461);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // dataGridViewNum
            // 
            dataGridViewNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNum.Location = new Point(5, 19);
            dataGridViewNum.Name = "dataGridViewNum";
            dataGridViewNum.RowHeadersVisible = false;
            dataGridViewNum.Size = new Size(158, 426);
            dataGridViewNum.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartDiag);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(175, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 461);
            panel3.TabIndex = 2;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            chartDiag.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(0, 0);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(625, 461);
            chartDiag.TabIndex = 0;
            chartDiag.Text = "chart1";
            chartDiag.Click += chart1_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(175, 136);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 461);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(431, 92);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView. Вывести все числа не кратные 5. Построить диаграмму по этим значениям.";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 636);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNum).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private DataGridView dataGridViewNum;
        private Panel panel3;
        private Splitter splitter1;
        private Button buttonFile;
        private GroupBox groupBox2;
        private Button buttonDone;
        private Button buttonHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private TextBox textBox1;
    }
}
