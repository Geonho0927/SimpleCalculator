namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 1)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtInput.Text = "";
                txtResult.Text = "";
            }
        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                txtInput.Text += button.Text;
                txtResult.Text += button.Text;
            }
        }


        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtInput.Text == "") return;

            if (btn.Text == "+")
            {
                txtInput.Text += " + ";
                txtResult.Text = "";
            }
            else if (btn.Text == "-")
            {
                txtInput.Text += " - ";
                txtResult.Text = "";
            }
            else if (btn.Text == "*")
            {
                txtInput.Text += " x ";
                txtResult.Text = "";
            }
            else if (btn.Text == "/")
            {
                txtInput.Text += " / ";
                txtResult.Text = "";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (input.Contains("+"))
            {
                string[] parts = input.Split('+');

                int num1 = int.Parse(parts[0].Trim());
                int num2 = int.Parse(parts[1].Trim());

                txtInput.Text += " = " + (num1 + num2).ToString();
                txtResult.Text = (num1 + num2).ToString();
            }
            else if (input.Contains("-"))
            {
                string[] parts = input.Split('-');

                int num1 = int.Parse(parts[0].Trim());
                int num2 = int.Parse(parts[1].Trim());

                txtInput.Text += " = " + (num1 - num2).ToString();
                txtResult.Text = (num1 - num2).ToString();
            }
            else if (input.Contains("x"))
            {
                string[] parts = input.Split('x');

                int num1 = int.Parse(parts[0].Trim());
                int num2 = int.Parse(parts[1].Trim());

                txtInput.Text += " = " + (num1 * num2).ToString();
                txtResult.Text = (num1 * num2).ToString();
            }
            else if (input.Contains("/"))
            {
                string[] parts = input.Split('/');

                int num1 = int.Parse(parts[0].Trim());
                int num2 = int.Parse(parts[1].Trim());

                if (num2 == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.");
                    return;
                }

                txtInput.Text += " = " + (num1 / num2).ToString();
                txtResult.Text = (num1 / num2).ToString();
            }

        }

        

        private void btnC_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtResult.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (input.Contains("+"))
            {
                string[] parts = input.Split('+');

                int num1 = int.Parse(parts[0].Trim());

                txtInput.Text = (num1).ToString() + " + ";
                txtResult.Text = "";
            }
            else if (input.Contains("-"))
            {
                string[] parts = input.Split('-');

                int num1 = int.Parse(parts[0].Trim());

                txtInput.Text = (num1).ToString() + " - ";
                txtResult.Text = "";
            }
            else if (input.Contains("x"))
            {
                string[] parts = input.Split('x');

                int num1 = int.Parse(parts[0].Trim());

                txtInput.Text = (num1).ToString() + " x ";
                txtResult.Text = "";
            }
            else if (input.Contains("/"))
            {
                string[] parts = input.Split('/');

                int num1 = int.Parse(parts[0].Trim());

                txtInput.Text = (num1).ToString() + " / ";
                txtResult.Text = "";
            }
            else
            {
                txtInput.Text = "";
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 엔터 키가 눌렸을 때만 가로채기
            if (keyData == Keys.Enter)
            {
                btnEqual.PerformClick(); // = 버튼 클릭 실행
                return true; // "내가 처리했으니 다른 버튼(C버튼 등)은 반응하지 마!"라는 뜻
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) { btn0.PerformClick(); }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) { btn1.PerformClick(); }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) { btn2.PerformClick(); }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) { btn3.PerformClick(); }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) { btn4.PerformClick(); }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) { btn5.PerformClick(); }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) { btn6.PerformClick(); }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) { btn7.PerformClick(); }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8) { btn8.PerformClick(); }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) { btn9.PerformClick(); }
            else if (e.KeyCode == Keys.Add)
            {
                btnAdd.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                btnSub.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                btnMul.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                btnDiv.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnC.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                btnDel.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnEqual.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
