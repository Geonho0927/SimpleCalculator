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
            btnCE = new Button();
            btnC = new Button();
            btnDel = new Button();
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
            txtInput.BackColor = Color.FromArgb(255, 255, 128);
            txtInput.Location = new Point(31, 77);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(349, 23);
            txtInput.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(255, 255, 192);
            txtResult.Location = new Point(31, 117);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(349, 23);
            txtResult.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(192, 255, 255);
            btn1.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(20, 215);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 40);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click_1;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(192, 255, 255);
            btn2.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(116, 215);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 40);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn1_Click_1;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(192, 255, 255);
            btn3.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(212, 215);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 40);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn1_Click_1;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.FromArgb(255, 192, 192);
            btnMul.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnMul.ForeColor = Color.Red;
            btnMul.Location = new Point(308, 215);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(90, 40);
            btnMul.TabIndex = 6;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnSub_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(255, 192, 192);
            btnSub.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnSub.ForeColor = Color.Red;
            btnSub.Location = new Point(308, 261);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(90, 40);
            btnSub.TabIndex = 10;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(192, 255, 255);
            btn6.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(212, 261);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 40);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn1_Click_1;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(192, 255, 255);
            btn5.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(116, 261);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 40);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn1_Click_1;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(192, 255, 255);
            btn4.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(20, 261);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 40);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn1_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(308, 307);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 40);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnSub_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(192, 255, 255);
            btn9.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(212, 307);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 40);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn1_Click_1;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(192, 255, 255);
            btn8.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(116, 307);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 40);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn1_Click_1;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(192, 255, 255);
            btn7.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(20, 307);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 40);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn1_Click_1;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 128, 128);
            btnEqual.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnEqual.Location = new Point(308, 353);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(90, 40);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(128, 128, 255);
            btnDot.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnDot.Location = new Point(212, 353);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(90, 40);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(192, 255, 255);
            btn0.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(116, 353);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 40);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn1_Click_1;
            // 
            // btnEtc
            // 
            btnEtc.BackColor = Color.FromArgb(128, 128, 255);
            btnEtc.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnEtc.Location = new Point(20, 353);
            btnEtc.Name = "btnEtc";
            btnEtc.Size = new Size(90, 40);
            btnEtc.TabIndex = 15;
            btnEtc.Text = "+/-";
            btnEtc.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(255, 192, 192);
            btnDiv.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnDiv.ForeColor = Color.Red;
            btnDiv.Location = new Point(308, 169);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(90, 40);
            btnDiv.TabIndex = 19;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnSub_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(128, 255, 128);
            btnCE.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnCE.Location = new Point(20, 169);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(90, 40);
            btnCE.TabIndex = 20;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(128, 255, 128);
            btnC.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnC.Location = new Point(116, 169);
            btnC.Name = "btnC";
            btnC.Size = new Size(90, 40);
            btnC.TabIndex = 21;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(128, 255, 128);
            btnDel.Font = new Font("문체부 돋음체", 16F, FontStyle.Bold);
            btnDel.Location = new Point(212, 169);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(90, 40);
            btnDel.TabIndex = 22;
            btnDel.Text = "DEL";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCE);
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
        private Button btnCE;
        private Button btnC;
        private Button btnDel;
    }
}
