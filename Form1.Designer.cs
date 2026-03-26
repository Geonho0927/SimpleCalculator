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
            mainLbl = new Label();
            txtInput = new TextBox();
            txtResult = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMul = new Button();
            btnSub = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAdd = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnEqual = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnEtc = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // mainLbl
            // 
            mainLbl.AutoSize = true;
            mainLbl.Font = new Font("맑은 고딕", 28F, FontStyle.Bold);
            mainLbl.ForeColor = SystemColors.MenuHighlight;
            mainLbl.Location = new Point(0, 0);
            mainLbl.Name = "mainLbl";
            mainLbl.Size = new Size(339, 51);
            mainLbl.TabIndex = 0;
            mainLbl.Text = "Simple Calculator";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(31, 77);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(349, 23);
            txtInput.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(31, 117);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(349, 23);
            txtResult.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(20, 215);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 40);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click_1;
            // 
            // btn2
            // 
            btn2.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(116, 215);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 40);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn1_Click_1;
            // 
            // btn3
            // 
            btn3.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(212, 215);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 40);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn1_Click_1;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnMul.ForeColor = Color.Red;
            btnMul.Location = new Point(308, 215);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(90, 40);
            btnMul.TabIndex = 6;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnSub_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnSub.ForeColor = Color.Red;
            btnSub.Location = new Point(308, 261);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(90, 40);
            btnSub.TabIndex = 10;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(212, 261);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 40);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn1_Click_1;
            // 
            // btn5
            // 
            btn5.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(116, 261);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 40);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn1_Click_1;
            // 
            // btn4
            // 
            btn4.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(20, 261);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 40);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn1_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(308, 307);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 40);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnSub_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(212, 307);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 40);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn1_Click_1;
            // 
            // btn8
            // 
            btn8.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(116, 307);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 40);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn1_Click_1;
            // 
            // btn7
            // 
            btn7.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(20, 307);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 40);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn1_Click_1;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnEqual.Location = new Point(308, 353);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(90, 40);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnDot.Location = new Point(212, 353);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(90, 40);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(116, 353);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 40);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn1_Click_1;
            // 
            // btnEtc
            // 
            btnEtc.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnEtc.Location = new Point(20, 353);
            btnEtc.Name = "btnEtc";
            btnEtc.Size = new Size(90, 40);
            btnEtc.TabIndex = 15;
            btnEtc.Text = "+/-";
            btnEtc.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnDiv.ForeColor = Color.Red;
            btnDiv.Location = new Point(308, 169);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(90, 40);
            btnDiv.TabIndex = 19;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnSub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(btnDiv);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnEtc);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMul);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtResult);
            Controls.Add(txtInput);
            Controls.Add(mainLbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLbl;
        private TextBox txtInput;
        private TextBox txtResult;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMul;
        private Button btnSub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdd;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnEqual;
        private Button btnDot;
        private Button btn0;
        private Button btnEtc;
        private Button btnDiv;
    }
}
