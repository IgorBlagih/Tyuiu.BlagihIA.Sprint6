namespace Tyuiu.BlagihIA.Sprint6.Task4.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox3 = new GroupBox();
            textBoxRes = new TextBox();
            buttonDone = new Button();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBoxVarStop = new TextBox();
            textBox5 = new TextBox();
            textBoxVarStart = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonHelp = new Button();
            buttonSave = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            splitter2 = new Splitter();
            splitter1 = new Splitter();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxRes);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(176, 408);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBoxRes
            // 
            textBoxRes.Dock = DockStyle.Fill;
            textBoxRes.Location = new Point(3, 19);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(170, 386);
            textBoxRes.TabIndex = 2;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.BackColor = Color.Chartreuse;
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(589, 109);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(184, 41);
            buttonDone.TabIndex = 22;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBoxVarStop);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBoxVarStart);
            groupBox2.Location = new Point(490, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 84);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(162, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 16);
            textBox3.TabIndex = 5;
            textBox3.Text = "Конец шага:";
            // 
            // textBoxVarStop
            // 
            textBoxVarStop.BackColor = SystemColors.Window;
            textBoxVarStop.Location = new Point(162, 48);
            textBoxVarStop.Name = "textBoxVarStop";
            textBoxVarStop.Size = new Size(109, 23);
            textBoxVarStop.TabIndex = 4;
            textBoxVarStop.KeyPress += textBoxVarStop_KeyPress;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(23, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(109, 16);
            textBox5.TabIndex = 3;
            textBox5.Text = "Начало шага:";
            // 
            // textBoxVarStart
            // 
            textBoxVarStart.BackColor = SystemColors.Window;
            textBoxVarStart.Location = new Point(23, 48);
            textBoxVarStart.Name = "textBoxVarStart";
            textBoxVarStart.Size = new Size(109, 23);
            textBoxVarStart.TabIndex = 0;
            textBoxVarStart.KeyPress += textBoxVarStart_KeyPress;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(6, 0);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(607, 411);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            title1.Font = new Font("Gill Sans MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction.Titles.Add(title1);
            chartFunction.Click += chartFunction_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(9, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 205);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = Color.DeepSkyBlue;
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(502, 109);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(81, 76);
            buttonHelp.TabIndex = 21;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.BackColor = Color.DeepSkyBlue;
            buttonSave.Location = new Point(589, 156);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(184, 29);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(buttonHelp);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 217);
            panel1.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.Location = new Point(174, 216);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 411);
            panel3.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(1, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 408);
            panel2.TabIndex = 27;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(chartFunction);
            panel4.Controls.Add(splitter2);
            panel4.Controls.Add(splitter1);
            panel4.Location = new Point(174, 216);
            panel4.Name = "panel4";
            panel4.Size = new Size(613, 411);
            panel4.TabIndex = 28;
            panel4.Paint += panel4_Paint;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(3, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 411);
            splitter2.TabIndex = 1;
            splitter2.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 411);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 627);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            MinimumSize = new Size(803, 666);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button buttonDone;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBoxVarStop;
        private TextBox textBox5;
        private TextBox textBoxVarStart;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonHelp;
        private Button buttonSave;
        private TextBox textBoxRes;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Panel panel4;
        private Splitter splitter1;
        private Splitter splitter2;
    }
}
