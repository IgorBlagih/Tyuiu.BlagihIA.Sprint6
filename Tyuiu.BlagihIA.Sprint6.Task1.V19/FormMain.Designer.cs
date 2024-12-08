namespace Tyuiu.BlagihIA.Sprint6.Task1.V19
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
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBoxVarStop = new TextBox();
            textBox5 = new TextBox();
            textBoxVarStart = new TextBox();
            groupBox1 = new GroupBox();
            buttonHelp = new Button();
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBoxVarStop);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBoxVarStart);
            groupBox2.Location = new Point(12, 273);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(283, 84);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(162, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 15);
            textBox3.TabIndex = 5;
            textBox3.Text = "Конец шага:";
            // 
            // textBoxVarStop
            // 
            textBoxVarStop.BackColor = SystemColors.Window;
            textBoxVarStop.Location = new Point(162, 48);
            textBoxVarStop.Name = "textBoxVarStop";
            textBoxVarStop.Size = new Size(109, 22);
            textBoxVarStop.TabIndex = 4;
            textBoxVarStop.KeyPress += textBoxVarStop_KeyPress;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(23, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(109, 15);
            textBox5.TabIndex = 3;
            textBox5.Text = "Начало шага:";
            // 
            // textBoxVarStart
            // 
            textBoxVarStart.BackColor = SystemColors.Window;
            textBoxVarStart.Location = new Point(23, 48);
            textBoxVarStart.Name = "textBoxVarStart";
            textBoxVarStart.Size = new Size(109, 22);
            textBoxVarStart.TabIndex = 0;
            textBoxVarStart.KeyPress += textBoxVarStart_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 244);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DeepSkyBlue;
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(318, 283);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(145, 29);
            buttonHelp.TabIndex = 11;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Location = new Point(474, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(227, 338);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Cursor = Cursors.IBeam;
            textBoxResult.Location = new Point(6, 15);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(215, 319);
            textBoxResult.TabIndex = 3;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Chartreuse;
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(318, 315);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(145, 41);
            buttonDone.TabIndex = 13;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 368);
            Controls.Add(buttonDone);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private TextBox textBoxVarStart;
        private GroupBox groupBox1;
        private Button buttonHelp;
        private TextBox textBox3;
        private TextBox textBoxVarStop;
        private GroupBox groupBox3;
        private TextBox textBoxResult;
        private Button buttonDone;
    }
}
