namespace DES
{
    partial class Form1
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
            txtBoxText = new TextBox();
            txtBoxKey = new TextBox();
            comboBox = new ComboBox();
            comboBoxMode = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtBoxResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IVtxt = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtBoxText
            // 
            txtBoxText.Location = new Point(78, 41);
            txtBoxText.Multiline = true;
            txtBoxText.Name = "txtBoxText";
            txtBoxText.Size = new Size(262, 59);
            txtBoxText.TabIndex = 0;
            // 
            // txtBoxKey
            // 
            txtBoxKey.Location = new Point(78, 135);
            txtBoxKey.MaxLength = 8;
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(262, 27);
            txtBoxKey.TabIndex = 1;
            txtBoxKey.TextChanged += textBox1_TextChanged;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Sifravimas", "Desifravimas" });
            comboBox.Location = new Point(473, 53);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(257, 28);
            comboBox.TabIndex = 2;
            // 
            // comboBoxMode
            // 
            comboBoxMode.FormattingEnabled = true;
            comboBoxMode.Items.AddRange(new object[] { "ECB", "CBC", "CFB" });
            comboBoxMode.Location = new Point(473, 134);
            comboBoxMode.Name = "comboBoxMode";
            comboBoxMode.Size = new Size(257, 28);
            comboBoxMode.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(201, 219);
            button1.Name = "button1";
            button1.Size = new Size(117, 41);
            button1.TabIndex = 4;
            button1.Text = "Vykdyti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(337, 219);
            button2.Name = "button2";
            button2.Size = new Size(119, 41);
            button2.TabIndex = 5;
            button2.Text = "Issaugoti faile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(473, 219);
            button3.Name = "button3";
            button3.Size = new Size(118, 41);
            button3.TabIndex = 6;
            button3.Text = "Skaityti is failo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtBoxResult
            // 
            txtBoxResult.Location = new Point(27, 310);
            txtBoxResult.Multiline = true;
            txtBoxResult.Name = "txtBoxResult";
            txtBoxResult.Size = new Size(747, 65);
            txtBoxResult.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 8;
            label1.Text = "Tekstas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 18);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 9;
            label2.Text = "Sifravimas/Desifravimas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 103);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 10;
            label3.Text = "Raktas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 103);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 11;
            label4.Text = "Moda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 274);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 12;
            label5.Text = "Rezultatas";
            // 
            // IVtxt
            // 
            IVtxt.Location = new Point(27, 401);
            IVtxt.Multiline = true;
            IVtxt.Name = "IVtxt";
            IVtxt.Size = new Size(747, 37);
            IVtxt.TabIndex = 13;
            IVtxt.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 378);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 14;
            label6.Text = "Vektorius";
            label6.Visible = false;
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 383);
            Controls.Add(label6);
            Controls.Add(IVtxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxResult);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxMode);
            Controls.Add(comboBox);
            Controls.Add(txtBoxKey);
            Controls.Add(txtBoxText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxText;
        private TextBox txtBoxKey;
        private ComboBox comboBox;
        private ComboBox comboBoxMode;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtBoxResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox IVtxt;
        private Label label6;
    }
}
