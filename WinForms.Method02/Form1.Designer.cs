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
            label1 = new Label();
            lblResult = new Label();
            txtRadius = new TextBox();
            btnCircleArea = new Button();
            btnCircumference = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            txtOutput = new TextBox();
            label6 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 54);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 0;
            label1.Text = "รัศมีวงกลม";
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
            // txtRadius
            // 
            txtRadius.Location = new Point(157, 54);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(150, 34);
            txtRadius.TabIndex = 2;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
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
            // btnCircumference
            // 
            btnCircumference.Location = new Point(478, 45);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(105, 43);
            btnCircumference.TabIndex = 4;
            btnCircumference.Text = "เส้นรอบวง";
            btnCircumference.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Location = new Point(28, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(685, 412);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ function";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(26, 53);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(267, 336);
            txtOutput.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(184, 349);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 5;
            label6.Text = "txtOutput";
            label6.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 681);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Windows Form Method(Function)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
    }
}
