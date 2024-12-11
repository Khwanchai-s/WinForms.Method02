namespace WinForms.Method02
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCircumference = new Button();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtInput = new TextBox();
            btnOutputParameter = new Button();
            btnRefParameter = new Button();
            txtSize = new TextBox();
            label8 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtLetter = new TextBox();
            btnTriangle01 = new Button();
            label6 = new Label();
            txtOutput = new TextBox();
            btnArrayParameter = new Button();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCircumference);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "รูปวงกลม";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(342, 90);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 5;
            label4.Text = "btnCircleArea";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(214, 90);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 5;
            label5.Text = "txtRadius";
            label5.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(478, 90);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 5;
            label2.Text = "btnCircumference";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(366, 151);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 5;
            label3.Text = "lblResult";
            label3.Visible = false;
            // 
            // btnCircumference
            // 
            btnCircumference.Location = new Point(478, 45);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(105, 43);
            btnCircumference.TabIndex = 4;
            btnCircumference.Text = "เส้นรอบวง";
            btnCircumference.UseVisualStyleBackColor = true;
            btnCircumference.Click += btnCircumference_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(342, 45);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(110, 43);
            btnCircleArea.TabIndex = 3;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(157, 54);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(150, 34);
            txtRadius.TabIndex = 2;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(192, 255, 192);
            lblResult.Location = new Point(157, 135);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(286, 44);
            lblResult.TabIndex = 1;
            lblResult.Text = "....";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 54);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "รัศมีวงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(txtInput);
            groupBox2.Controls.Add(btnOutputParameter);
            groupBox2.Controls.Add(btnRefParameter);
            groupBox2.Controls.Add(txtSize);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtLetter);
            groupBox2.Controls.Add(btnTriangle01);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(28, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(685, 450);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ function";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(345, 231);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(301, 34);
            txtInput.TabIndex = 10;
            // 
            // btnOutputParameter
            // 
            btnOutputParameter.Location = new Point(345, 370);
            btnOutputParameter.Name = "btnOutputParameter";
            btnOutputParameter.Size = new Size(313, 38);
            btnOutputParameter.TabIndex = 9;
            btnOutputParameter.Text = "ทดสอบ output Parameter";
            btnOutputParameter.UseVisualStyleBackColor = true;
            btnOutputParameter.Click += btnOutputParameter_Click;
            // 
            // btnRefParameter
            // 
            btnRefParameter.Location = new Point(340, 298);
            btnRefParameter.Name = "btnRefParameter";
            btnRefParameter.Size = new Size(313, 38);
            btnRefParameter.TabIndex = 9;
            btnRefParameter.Text = "ทดสอบ reference parameter";
            btnRefParameter.UseVisualStyleBackColor = true;
            btnRefParameter.Click += btnRefParameter_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(345, 141);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(113, 34);
            txtSize.TabIndex = 8;
            txtSize.Text = "5";
            txtSize.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(357, 178);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 5;
            label8.Text = "txtSize";
            label8.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(481, 411);
            label12.Name = "label12";
            label12.Size = new Size(193, 28);
            label12.TabIndex = 5;
            label12.Text = "btnOutputParameter";
            label12.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(561, 267);
            label11.Name = "label11";
            label11.Size = new Size(81, 28);
            label11.TabIndex = 5;
            label11.Text = "txtInput";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(476, 339);
            label10.Name = "label10";
            label10.Size = new Size(157, 28);
            label10.TabIndex = 5;
            label10.Text = "btnRefParameter";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(518, 113);
            label9.Name = "label9";
            label9.Size = new Size(132, 28);
            label9.TabIndex = 5;
            label9.Text = "btnTriangle01";
            label9.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(357, 104);
            label7.Name = "label7";
            label7.Size = new Size(85, 28);
            label7.TabIndex = 5;
            label7.Text = "txtLetter";
            label7.Visible = false;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(343, 67);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(115, 34);
            txtLetter.TabIndex = 7;
            txtLetter.Text = "A";
            txtLetter.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(518, 53);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(106, 57);
            btnTriangle01.TabIndex = 6;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(182, 339);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 5;
            label6.Text = "txtOutput";
            label6.Visible = false;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(26, 53);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(267, 336);
            txtOutput.TabIndex = 0;
            // 
            // btnArrayParameter
            // 
            btnArrayParameter.Location = new Point(774, 55);
            btnArrayParameter.Name = "btnArrayParameter";
            btnArrayParameter.Size = new Size(175, 88);
            btnArrayParameter.TabIndex = 2;
            btnArrayParameter.Text = "Parameter แบบ Array";
            btnArrayParameter.UseVisualStyleBackColor = true;
            btnArrayParameter.Click += btnArrayParameter_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(796, 146);
            label13.Name = "label13";
            label13.Size = new Size(177, 28);
            label13.TabIndex = 5;
            label13.Text = "btnArrayParameter";
            label13.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 701);
            Controls.Add(btnArrayParameter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label13);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Windows Form Method(Function)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private Label lblResult;
        private Label label1;
        private Label label3;
        private Button btnCircumference;
        private Label label4;
        private Label label5;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtOutput;
        private TextBox txtLetter;
        private Button btnTriangle01;
        private TextBox txtSize;
        private Label label8;
        private Label label7;
        private Label label9;
        private Button btnRefParameter;
        private Label label10;
        private TextBox txtInput;
        private Label label11;
        private Button btnOutputParameter;
        private Label label12;
        private Button btnArrayParameter;
        private Label label13;
    }
}
