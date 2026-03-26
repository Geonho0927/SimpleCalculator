namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int op = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                txtInput.Text += button.Text;
            }
        }


        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtInput.Text == "") return;

            if (btn.Text == "+")
            {
                txtInput.Text += " + ";
            }
            else if (btn.Text == "-")
            {
                txtInput.Text += " - ";
            }
            else if (btn.Text == "*")
            {
                txtInput.Text += " x ";
            }
            else if (btn.Text == "/")
            {
                txtInput.Text += " / ";
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

                txtResult.Text = (num1 + num2).ToString();
            }
            else if (input.Contains("-"))
            {
                string[] parts = input.Split('-');

                int num1 = int.Parse(parts[0].Trim());
                int num2 = int.Parse(parts[1].Trim());

                txtResult.Text = (num1 - num2).ToString();
            }
            else if (input.Contains("x"))
            {
                string[] parts = input.Split('x');

                int num1 = int.Parse(parts[0].Trim());
                int num2 = int.Parse(parts[1].Trim());

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

                txtResult.Text = (num1 / num2).ToString();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 1)
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
            }
            else
            {
                txtInput.Text = "";
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
            }
            else if (input.Contains("-"))
            {
                string[] parts = input.Split('-');

                int num1 = int.Parse(parts[0].Trim());

                txtInput.Text = (num1).ToString() + " - ";
            }
            else if (input.Contains("x"))
            {
                string[] parts = input.Split('x');

                int num1 = int.Parse(parts[0].Trim());

                txtInput.Text = (num1).ToString() + " x ";
            }
            else if (input.Contains("/"))
            {
                string[] parts = input.Split('/');

                int num1 = int.Parse(parts[0].Trim());

                txtInput.Text = (num1).ToString() + " / ";
            }
            else
            {
                txtInput.Text = "";
            }
        }
    }
}
