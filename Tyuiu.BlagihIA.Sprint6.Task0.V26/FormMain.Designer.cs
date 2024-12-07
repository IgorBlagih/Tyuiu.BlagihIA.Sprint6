namespace Tyuiu.BlagihIA.Sprint6.Task0.V26
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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            textBoxVarX = new TextBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 162);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вычислить выражение";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(534, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 72);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(695, 210);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBoxVarX);
            groupBox2.Location = new Point(12, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 105);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(62, 37);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(115, 16);
            textBox5.TabIndex = 3;
            textBox5.Text = "Переменная X:";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(62, 66);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(115, 23);
            textBoxVarX.TabIndex = 0;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Location = new Point(437, 248);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(235, 105);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(22, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 16);
            textBox2.TabIndex = 7;
            textBox2.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(22, 66);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(127, 23);
            textBoxResult.TabIndex = 6;
            textBoxResult.TextChanged += buttonDone_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(540, 354);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(128, 37);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(498, 354);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(39, 37);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 395);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private TextBox textBoxVarX;
        private GroupBox groupBox3;
        private TextBox textBoxResult;
        private Button buttonDone;
        private TextBox textBox2;
        private Button buttonHelp;
    }
}
