namespace Lab01_1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            num7_Btn = new Button();
            displayBox = new TextBox();
            num8_Btn = new Button();
            num9_Btn = new Button();
            num4_Btn = new Button();
            num5_Btn = new Button();
            num6_Btn = new Button();
            num1_Btn = new Button();
            num2_Btn = new Button();
            num3_Btn = new Button();
            minus_Btn = new Button();
            plus_Btn = new Button();
            num0_Btn = new Button();
            clear_Btn = new Button();
            signChange_Btn = new Button();
            dot_Btn = new Button();
            divide_Btn = new Button();
            multi_Btn = new Button();
            result_Btn = new Button();
            backspace_Btn = new Button();
            SuspendLayout();
            // 
            // num7_Btn
            // 
            num7_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num7_Btn.Cursor = Cursors.Hand;
            num7_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num7_Btn.ForeColor = SystemColors.ButtonFace;
            num7_Btn.Location = new Point(15, 107);
            num7_Btn.Name = "num7_Btn";
            num7_Btn.Size = new Size(80, 80);
            num7_Btn.TabIndex = 1;
            num7_Btn.Text = "7";
            num7_Btn.UseCompatibleTextRendering = true;
            num7_Btn.UseVisualStyleBackColor = false;
            num7_Btn.Click += number_Click;
            // 
            // displayBox
            // 
            displayBox.BackColor = Color.FromArgb(32, 32, 32);
            displayBox.Cursor = Cursors.IBeam;
            displayBox.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            displayBox.ForeColor = SystemColors.ButtonFace;
            displayBox.Location = new Point(15, 18);
            displayBox.MaximumSize = new Size(469, 74);
            displayBox.MaxLength = 0;
            displayBox.MinimumSize = new Size(469, 74);
            displayBox.Name = "displayBox";
            displayBox.ReadOnly = true;
            displayBox.Size = new Size(469, 74);
            displayBox.TabIndex = 0;
            displayBox.TabStop = false;
            displayBox.Text = "0 ";
            displayBox.TextAlign = HorizontalAlignment.Right;
            // 
            // num8_Btn
            // 
            num8_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num8_Btn.Cursor = Cursors.Hand;
            num8_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num8_Btn.ForeColor = SystemColors.ButtonFace;
            num8_Btn.Location = new Point(112, 107);
            num8_Btn.Name = "num8_Btn";
            num8_Btn.Size = new Size(80, 80);
            num8_Btn.TabIndex = 2;
            num8_Btn.Text = "8";
            num8_Btn.UseCompatibleTextRendering = true;
            num8_Btn.UseVisualStyleBackColor = false;
            num8_Btn.Click += number_Click;
            // 
            // num9_Btn
            // 
            num9_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num9_Btn.Cursor = Cursors.Hand;
            num9_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num9_Btn.ForeColor = SystemColors.ButtonFace;
            num9_Btn.Location = new Point(208, 107);
            num9_Btn.Name = "num9_Btn";
            num9_Btn.Size = new Size(80, 80);
            num9_Btn.TabIndex = 3;
            num9_Btn.Text = "9";
            num9_Btn.UseCompatibleTextRendering = true;
            num9_Btn.UseVisualStyleBackColor = false;
            num9_Btn.Click += number_Click;
            // 
            // num4_Btn
            // 
            num4_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num4_Btn.Cursor = Cursors.Hand;
            num4_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num4_Btn.ForeColor = SystemColors.ButtonFace;
            num4_Btn.Location = new Point(15, 203);
            num4_Btn.Name = "num4_Btn";
            num4_Btn.Size = new Size(80, 80);
            num4_Btn.TabIndex = 6;
            num4_Btn.Text = "4";
            num4_Btn.UseCompatibleTextRendering = true;
            num4_Btn.UseVisualStyleBackColor = false;
            num4_Btn.Click += number_Click;
            // 
            // num5_Btn
            // 
            num5_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num5_Btn.Cursor = Cursors.Hand;
            num5_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num5_Btn.ForeColor = SystemColors.ButtonFace;
            num5_Btn.Location = new Point(112, 203);
            num5_Btn.Name = "num5_Btn";
            num5_Btn.Size = new Size(80, 80);
            num5_Btn.TabIndex = 7;
            num5_Btn.Text = "5";
            num5_Btn.UseCompatibleTextRendering = true;
            num5_Btn.UseVisualStyleBackColor = false;
            num5_Btn.Click += number_Click;
            // 
            // num6_Btn
            // 
            num6_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num6_Btn.Cursor = Cursors.Hand;
            num6_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num6_Btn.ForeColor = SystemColors.ButtonFace;
            num6_Btn.Location = new Point(208, 203);
            num6_Btn.Name = "num6_Btn";
            num6_Btn.Size = new Size(80, 80);
            num6_Btn.TabIndex = 8;
            num6_Btn.Text = "6";
            num6_Btn.UseCompatibleTextRendering = true;
            num6_Btn.UseVisualStyleBackColor = false;
            num6_Btn.Click += number_Click;
            // 
            // num1_Btn
            // 
            num1_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num1_Btn.Cursor = Cursors.Hand;
            num1_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num1_Btn.ForeColor = SystemColors.ButtonFace;
            num1_Btn.Location = new Point(15, 298);
            num1_Btn.Name = "num1_Btn";
            num1_Btn.Size = new Size(80, 80);
            num1_Btn.TabIndex = 11;
            num1_Btn.Text = "1";
            num1_Btn.UseCompatibleTextRendering = true;
            num1_Btn.UseVisualStyleBackColor = false;
            num1_Btn.Click += number_Click;
            // 
            // num2_Btn
            // 
            num2_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num2_Btn.Cursor = Cursors.Hand;
            num2_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num2_Btn.ForeColor = SystemColors.ButtonFace;
            num2_Btn.Location = new Point(112, 298);
            num2_Btn.Name = "num2_Btn";
            num2_Btn.Size = new Size(80, 80);
            num2_Btn.TabIndex = 12;
            num2_Btn.Text = "2";
            num2_Btn.UseCompatibleTextRendering = true;
            num2_Btn.UseVisualStyleBackColor = false;
            num2_Btn.Click += number_Click;
            // 
            // num3_Btn
            // 
            num3_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num3_Btn.Cursor = Cursors.Hand;
            num3_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num3_Btn.ForeColor = SystemColors.ButtonFace;
            num3_Btn.Location = new Point(208, 298);
            num3_Btn.Name = "num3_Btn";
            num3_Btn.Size = new Size(80, 80);
            num3_Btn.TabIndex = 13;
            num3_Btn.Text = "3";
            num3_Btn.UseCompatibleTextRendering = true;
            num3_Btn.UseVisualStyleBackColor = false;
            num3_Btn.Click += number_Click;
            // 
            // minus_Btn
            // 
            minus_Btn.BackColor = Color.FromArgb(44, 44, 44);
            minus_Btn.Cursor = Cursors.Hand;
            minus_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            minus_Btn.ForeColor = SystemColors.ButtonFace;
            minus_Btn.Location = new Point(307, 203);
            minus_Btn.Name = "minus_Btn";
            minus_Btn.Size = new Size(80, 80);
            minus_Btn.TabIndex = 9;
            minus_Btn.Text = "-";
            minus_Btn.UseCompatibleTextRendering = true;
            minus_Btn.UseVisualStyleBackColor = false;
            minus_Btn.Click += operator_Click;
            // 
            // plus_Btn
            // 
            plus_Btn.BackColor = Color.FromArgb(44, 44, 44);
            plus_Btn.Cursor = Cursors.Hand;
            plus_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            plus_Btn.ForeColor = SystemColors.ButtonFace;
            plus_Btn.Location = new Point(307, 107);
            plus_Btn.Name = "plus_Btn";
            plus_Btn.Size = new Size(80, 80);
            plus_Btn.TabIndex = 4;
            plus_Btn.Text = "+";
            plus_Btn.UseCompatibleTextRendering = true;
            plus_Btn.UseVisualStyleBackColor = false;
            plus_Btn.Click += operator_Click;
            // 
            // num0_Btn
            // 
            num0_Btn.BackColor = Color.FromArgb(59, 59, 59);
            num0_Btn.Cursor = Cursors.Hand;
            num0_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            num0_Btn.ForeColor = SystemColors.ButtonFace;
            num0_Btn.Location = new Point(112, 393);
            num0_Btn.Name = "num0_Btn";
            num0_Btn.Size = new Size(80, 80);
            num0_Btn.TabIndex = 16;
            num0_Btn.Text = "0";
            num0_Btn.UseCompatibleTextRendering = true;
            num0_Btn.UseVisualStyleBackColor = false;
            num0_Btn.Click += number_Click;
            // 
            // clear_Btn
            // 
            clear_Btn.BackColor = Color.FromArgb(44, 44, 44);
            clear_Btn.Cursor = Cursors.Hand;
            clear_Btn.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            clear_Btn.ForeColor = SystemColors.ButtonFace;
            clear_Btn.Location = new Point(404, 203);
            clear_Btn.Name = "clear_Btn";
            clear_Btn.Size = new Size(80, 80);
            clear_Btn.TabIndex = 10;
            clear_Btn.Text = "C";
            clear_Btn.UseCompatibleTextRendering = true;
            clear_Btn.UseVisualStyleBackColor = false;
            clear_Btn.Click += clear_Click;
            // 
            // signChange_Btn
            // 
            signChange_Btn.BackColor = Color.FromArgb(44, 44, 44);
            signChange_Btn.Cursor = Cursors.Hand;
            signChange_Btn.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            signChange_Btn.ForeColor = SystemColors.ButtonFace;
            signChange_Btn.Location = new Point(15, 393);
            signChange_Btn.Name = "signChange_Btn";
            signChange_Btn.Size = new Size(80, 80);
            signChange_Btn.TabIndex = 15;
            signChange_Btn.Text = "⁺∕₋";
            signChange_Btn.UseCompatibleTextRendering = true;
            signChange_Btn.UseVisualStyleBackColor = false;
            signChange_Btn.Click += signChange_Click;
            // 
            // dot_Btn
            // 
            dot_Btn.BackColor = Color.FromArgb(44, 44, 44);
            dot_Btn.Cursor = Cursors.Hand;
            dot_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            dot_Btn.ForeColor = SystemColors.ButtonFace;
            dot_Btn.Location = new Point(208, 393);
            dot_Btn.Name = "dot_Btn";
            dot_Btn.Size = new Size(80, 80);
            dot_Btn.TabIndex = 17;
            dot_Btn.Text = ".";
            dot_Btn.UseCompatibleTextRendering = true;
            dot_Btn.UseVisualStyleBackColor = false;
            dot_Btn.Click += number_Click;
            // 
            // divide_Btn
            // 
            divide_Btn.BackColor = Color.FromArgb(44, 44, 44);
            divide_Btn.Cursor = Cursors.Hand;
            divide_Btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            divide_Btn.ForeColor = SystemColors.ButtonFace;
            divide_Btn.Location = new Point(307, 393);
            divide_Btn.Name = "divide_Btn";
            divide_Btn.Size = new Size(80, 80);
            divide_Btn.TabIndex = 18;
            divide_Btn.Text = "/";
            divide_Btn.UseCompatibleTextRendering = true;
            divide_Btn.UseVisualStyleBackColor = false;
            divide_Btn.Click += operator_Click;
            // 
            // multi_Btn
            // 
            multi_Btn.BackColor = Color.FromArgb(44, 44, 44);
            multi_Btn.Cursor = Cursors.Hand;
            multi_Btn.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point);
            multi_Btn.ForeColor = SystemColors.ButtonFace;
            multi_Btn.Location = new Point(307, 298);
            multi_Btn.Name = "multi_Btn";
            multi_Btn.Size = new Size(80, 80);
            multi_Btn.TabIndex = 14;
            multi_Btn.Text = "x";
            multi_Btn.UseCompatibleTextRendering = true;
            multi_Btn.UseVisualStyleBackColor = false;
            multi_Btn.Click += operator_Click;
            // 
            // result_Btn
            // 
            result_Btn.BackColor = Color.DarkRed;
            result_Btn.Cursor = Cursors.Hand;
            result_Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            result_Btn.ForeColor = SystemColors.ButtonFace;
            result_Btn.Location = new Point(404, 298);
            result_Btn.Name = "result_Btn";
            result_Btn.Size = new Size(80, 175);
            result_Btn.TabIndex = 19;
            result_Btn.Text = "=";
            result_Btn.UseCompatibleTextRendering = true;
            result_Btn.UseVisualStyleBackColor = false;
            result_Btn.Click += result_Click;
            // 
            // backspace_Btn
            // 
            backspace_Btn.BackColor = Color.FromArgb(44, 44, 44);
            backspace_Btn.BackgroundImage = (Image)resources.GetObject("backspace_Btn.BackgroundImage");
            backspace_Btn.BackgroundImageLayout = ImageLayout.Zoom;
            backspace_Btn.Cursor = Cursors.Hand;
            backspace_Btn.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            backspace_Btn.ForeColor = SystemColors.ButtonFace;
            backspace_Btn.Location = new Point(404, 107);
            backspace_Btn.Name = "backspace_Btn";
            backspace_Btn.Size = new Size(80, 80);
            backspace_Btn.TabIndex = 5;
            backspace_Btn.UseCompatibleTextRendering = true;
            backspace_Btn.UseVisualStyleBackColor = false;
            backspace_Btn.Click += backspace_Click;
            // 
            // Calculator
            // 
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(497, 480);
            Controls.Add(displayBox);
            Controls.Add(num3_Btn);
            Controls.Add(num6_Btn);
            Controls.Add(plus_Btn);
            Controls.Add(result_Btn);
            Controls.Add(signChange_Btn);
            Controls.Add(multi_Btn);
            Controls.Add(divide_Btn);
            Controls.Add(dot_Btn);
            Controls.Add(backspace_Btn);
            Controls.Add(clear_Btn);
            Controls.Add(minus_Btn);
            Controls.Add(num9_Btn);
            Controls.Add(num2_Btn);
            Controls.Add(num5_Btn);
            Controls.Add(num8_Btn);
            Controls.Add(num0_Btn);
            Controls.Add(num1_Btn);
            Controls.Add(num4_Btn);
            Controls.Add(num7_Btn);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(515, 527);
            MinimumSize = new Size(515, 527);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator by Paweł Kasztura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button num7_Btn;
        private TextBox displayBox;
        private Button num8_Btn;
        private Button num9_Btn;
        private Button num4_Btn;
        private Button num5_Btn;
        private Button num6_Btn;
        private Button num1_Btn;
        private Button num2_Btn;
        private Button num3_Btn;
        private Button minus_Btn;
        private Button plus_Btn;
        private Button num0_Btn;
        private Button clear_Btn;
        private Button signChange_Btn;
        private Button dot_Btn;
        private Button divide_Btn;
        private Button multi_Btn;
        private Button result_Btn;
        private Button backspace_Btn;
    }
}