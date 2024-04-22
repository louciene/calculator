namespace calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(201, 29);
            label1.Name = "label1";
            label1.Size = new Size(247, 39);
            label1.TabIndex = 0;
            label1.Text = "CALCULATOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 267);
            label2.Name = "label2";
            label2.Size = new Size(280, 27);
            label2.TabIndex = 1;
            label2.Text = "Enter your first number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 353);
            label3.Name = "label3";
            label3.Size = new Size(319, 27);
            label3.TabIndex = 2;
            label3.Text = "Enter your second number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Historic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(213, 90);
            label4.Name = "label4";
            label4.Size = new Size(354, 128);
            label4.TabIndex = 3;
            label4.Text = "answer";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(94, 447);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 35);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "ADD";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(252, 447);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(177, 35);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "SUBTRACT";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(57, 553);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(170, 35);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "MULTIPLY";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(274, 553);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(133, 35);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "DIVIDE";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.FlatStyle = FlatStyle.Flat;
            radioButton5.Font = new Font("Rockwell", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton5.Location = new Point(463, 495);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(104, 35);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "MOD";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.OldLace;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Simple Indust Outline", 10F, FontStyle.Bold, GraphicsUnit.Point, 178);
            textBox1.Location = new Point(400, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 44);
            textBox1.TabIndex = 9;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.OldLace;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Simple Indust Outline", 10F, FontStyle.Bold, GraphicsUnit.Point, 178);
            textBox2.Location = new Point(400, 345);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 44);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(123, 630);
            button1.Name = "button1";
            button1.Size = new Size(179, 102);
            button1.TabIndex = 11;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(323, 630);
            button2.Name = "button2";
            button2.Size = new Size(179, 102);
            button2.TabIndex = 12;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.calcu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(639, 757);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
