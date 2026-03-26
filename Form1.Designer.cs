namespace SimpleCalculator
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
            lbl1 = new Label();
            txtb_cal = new TextBox();
            txtb_mscal = new TextBox();
            btn_CE = new Button();
            btn_C = new Button();
            btn_del = new Button();
            btn_division = new Button();
            btn_9 = new Button();
            btn_times = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_6 = new Button();
            btn_minus = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_3 = new Button();
            btn_plus = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_dot = new Button();
            btn_equal = new Button();
            btn_0 = new Button();
            btn_pm = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(55, 62);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(375, 60);
            lbl1.TabIndex = 0;
            lbl1.Text = "Simple Calculator";
            // 
            // txtb_cal
            // 
            txtb_cal.Location = new Point(61, 135);
            txtb_cal.Name = "txtb_cal";
            txtb_cal.Size = new Size(358, 31);
            txtb_cal.TabIndex = 1;
            // 
            // txtb_mscal
            // 
            txtb_mscal.Location = new Point(61, 172);
            txtb_mscal.Name = "txtb_mscal";
            txtb_mscal.Size = new Size(358, 31);
            txtb_mscal.TabIndex = 2;
            txtb_mscal.TextChanged += textBox2_TextChanged;
            // 
            // btn_CE
            // 
            btn_CE.BackColor = Color.Orange;
            btn_CE.Font = new Font("맑은 고딕", 10F);
            btn_CE.Location = new Point(61, 221);
            btn_CE.Name = "btn_CE";
            btn_CE.Size = new Size(85, 50);
            btn_CE.TabIndex = 3;
            btn_CE.Text = "CE";
            btn_CE.UseVisualStyleBackColor = false;
            btn_CE.Click += btn_CE_Click;
            // 
            // btn_C
            // 
            btn_C.BackColor = Color.Orange;
            btn_C.Font = new Font("맑은 고딕", 10F);
            btn_C.Location = new Point(152, 221);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(85, 50);
            btn_C.TabIndex = 4;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = false;
            btn_C.Click += button2_Click;
            // 
            // btn_del
            // 
            btn_del.BackColor = Color.Orange;
            btn_del.Font = new Font("맑은 고딕", 10F);
            btn_del.Location = new Point(243, 221);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(85, 50);
            btn_del.TabIndex = 6;
            btn_del.Text = "del";
            btn_del.UseVisualStyleBackColor = false;
            btn_del.Click += button3_Click;
            // 
            // btn_division
            // 
            btn_division.BackColor = Color.DarkKhaki;
            btn_division.Font = new Font("맑은 고딕", 10F);
            btn_division.Location = new Point(334, 221);
            btn_division.Name = "btn_division";
            btn_division.Size = new Size(85, 50);
            btn_division.TabIndex = 5;
            btn_division.Text = "÷";
            btn_division.UseVisualStyleBackColor = false;
            btn_division.Click += btn_division_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.PowderBlue;
            btn_9.Font = new Font("맑은 고딕", 10F);
            btn_9.Location = new Point(243, 277);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(85, 50);
            btn_9.TabIndex = 10;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += Number_Click;
            // 
            // btn_times
            // 
            btn_times.BackColor = Color.DarkKhaki;
            btn_times.Font = new Font("맑은 고딕", 10F);
            btn_times.Location = new Point(334, 277);
            btn_times.Name = "btn_times";
            btn_times.Size = new Size(85, 50);
            btn_times.TabIndex = 9;
            btn_times.Text = "X";
            btn_times.UseVisualStyleBackColor = false;
            btn_times.Click += btn_times_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.PowderBlue;
            btn_8.Font = new Font("맑은 고딕", 10F);
            btn_8.Location = new Point(152, 277);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(85, 50);
            btn_8.TabIndex = 8;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += Number_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.PowderBlue;
            btn_7.Font = new Font("맑은 고딕", 10F);
            btn_7.Location = new Point(61, 277);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(85, 50);
            btn_7.TabIndex = 7;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += Number_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.PowderBlue;
            btn_6.Font = new Font("맑은 고딕", 10F);
            btn_6.ImageAlign = ContentAlignment.MiddleRight;
            btn_6.Location = new Point(243, 333);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(85, 50);
            btn_6.TabIndex = 14;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += Number_Click;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.DarkKhaki;
            btn_minus.Font = new Font("맑은 고딕", 10F);
            btn_minus.Location = new Point(334, 333);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(85, 50);
            btn_minus.TabIndex = 13;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.PowderBlue;
            btn_5.Font = new Font("맑은 고딕", 10F);
            btn_5.Location = new Point(152, 333);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(85, 50);
            btn_5.TabIndex = 12;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += Number_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.PowderBlue;
            btn_4.Font = new Font("맑은 고딕", 10F);
            btn_4.Location = new Point(61, 333);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(85, 50);
            btn_4.TabIndex = 11;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += Number_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.PowderBlue;
            btn_3.Font = new Font("맑은 고딕", 10F);
            btn_3.Location = new Point(243, 389);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(85, 50);
            btn_3.TabIndex = 18;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += Number_Click;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = Color.DarkKhaki;
            btn_plus.Font = new Font("맑은 고딕", 10F);
            btn_plus.Location = new Point(334, 389);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(85, 50);
            btn_plus.TabIndex = 17;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.PowderBlue;
            btn_2.Font = new Font("맑은 고딕", 10F);
            btn_2.Location = new Point(152, 389);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(85, 50);
            btn_2.TabIndex = 16;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += Number_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.PowderBlue;
            btn_1.Font = new Font("맑은 고딕", 10F);
            btn_1.Location = new Point(61, 389);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(85, 50);
            btn_1.TabIndex = 15;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += Number_Click;
            // 
            // btn_dot
            // 
            btn_dot.BackColor = Color.BurlyWood;
            btn_dot.Font = new Font("맑은 고딕", 10F);
            btn_dot.Location = new Point(243, 445);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(85, 50);
            btn_dot.TabIndex = 22;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = false;
            // 
            // btn_equal
            // 
            btn_equal.BackColor = Color.DarkKhaki;
            btn_equal.Font = new Font("맑은 고딕", 10F);
            btn_equal.Location = new Point(334, 445);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(85, 50);
            btn_equal.TabIndex = 21;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.PowderBlue;
            btn_0.Font = new Font("맑은 고딕", 10F);
            btn_0.Location = new Point(152, 445);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(85, 50);
            btn_0.TabIndex = 20;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += Number_Click;
            // 
            // btn_pm
            // 
            btn_pm.BackColor = Color.BurlyWood;
            btn_pm.Font = new Font("맑은 고딕", 10F);
            btn_pm.Location = new Point(61, 445);
            btn_pm.Name = "btn_pm";
            btn_pm.Size = new Size(85, 50);
            btn_pm.TabIndex = 19;
            btn_pm.Text = "+/-";
            btn_pm.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(483, 588);
            Controls.Add(btn_dot);
            Controls.Add(btn_equal);
            Controls.Add(btn_0);
            Controls.Add(btn_pm);
            Controls.Add(btn_3);
            Controls.Add(btn_plus);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_6);
            Controls.Add(btn_minus);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_9);
            Controls.Add(btn_times);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_del);
            Controls.Add(btn_division);
            Controls.Add(btn_C);
            Controls.Add(btn_CE);
            Controls.Add(txtb_mscal);
            Controls.Add(txtb_cal);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtb_cal;
        private TextBox txtb_mscal;
        private Button btn_CE;
        private Button btn_C;
        private Button btn_del;
        private Button btn_division;
        private Button btn_9;
        private Button btn_times;
        private Button btn_8;
        private Button btn_7;
        private Button btn_6;
        private Button btn_minus;
        private Button btn_5;
        private Button btn_4;
        private Button btn_3;
        private Button btn_plus;
        private Button btn_2;
        private Button btn_1;
        private Button btn_dot;
        private Button btn_equal;
        private Button btn_0;
        private Button btn_pm;
    }
}
