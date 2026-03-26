namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int result;
        int op;
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

            txtInput.Text += " " + btn.Text + " ";
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
            else if (input.Contains("*"))
            {
                string[] parts = input.Split('*');

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
    }
}
