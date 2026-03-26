using System.Data;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        //전역 변수
        int num1 = 0;       //처음 숫자
        string op = "";
        bool isNewNumber = false;  // txtb_mscal) 다음 입력이 새 숫자인지
        string expression = "";

        public Form1()
        {
            InitializeComponent();
            txtb_mscal.Text = "0";
            this.KeyPreview = true;
        }
        private void Input(string value)
        {
            expression += value;
            txtb_cal.Text = expression;
        }
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewNumber)
            {
                txtb_mscal.Clear();
                isNewNumber = false;
            }

            if (txtb_mscal.Text == "0")
                txtb_mscal.Clear();

            txtb_mscal.Text += btn.Text;

            if (!string.IsNullOrEmpty(op))
            {
                txtb_cal.Text = expression + txtb_mscal.Text;
            }
            else
            {
                txtb_cal.Text = txtb_mscal.Text;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 숫자 (상단 키보드)
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                string num = (e.KeyCode - Keys.D0).ToString();
                Number_KeyInput(num);
            }

            // 숫자 (넘버패드)
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                string num = (e.KeyCode - Keys.NumPad0).ToString();
                Number_KeyInput(num);
            }

            if (e.KeyCode == Keys.Add) btn_plus.PerformClick();
            if (e.KeyCode == Keys.Subtract) btn_minus.PerformClick();
            if (e.KeyCode == Keys.Multiply) btn_times.PerformClick();
            if (e.KeyCode == Keys.Divide) btn_division.PerformClick();

            if (e.KeyCode == Keys.Enter) btn_equal.PerformClick();
            if (e.KeyCode == Keys.Back) btn_del.PerformClick();

            // 연산자
            if (e.KeyCode == Keys.Add || (e.KeyCode == Keys.Oemplus && e.Shift))
                btn_plus.PerformClick();

            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                btn_minus.PerformClick();

            if (e.KeyCode == Keys.Multiply)
                btn_times.PerformClick();

            if (e.KeyCode == Keys.Divide)
                btn_division.PerformClick();

            if (e.KeyCode == Keys.Enter)
                btn_equal.PerformClick();

            if (e.KeyCode == Keys.Back)
                btn_del.PerformClick();

            if (e.KeyCode == Keys.Delete)
                btn_CE.PerformClick();
            if (e.KeyCode == Keys.D9 && e.Shift) Input("(");
            if (e.KeyCode == Keys.D0 && e.Shift) Input(")");
        }

        private void Number_KeyInput(string num)
        {
            if (isNewNumber)
            {
                txtb_mscal.Clear();
                isNewNumber = false;
            }

            if (txtb_mscal.Text == "0")
                txtb_mscal.Clear();

            txtb_mscal.Text += num;

            if (!string.IsNullOrEmpty(op))
                txtb_cal.Text = expression + txtb_mscal.Text;
            else
                txtb_cal.Text = txtb_mscal.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtb_mscal.Text = "0";
            txtb_cal.Text = "";

            num1 = 0;
            op = "";
            expression = "";
            isNewNumber = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtb_mscal.Text.Length > 1)
            {
                txtb_mscal.Text =
                    txtb_mscal.Text.Substring(0, txtb_mscal.Text.Length - 1);
            }
            else
            {
                txtb_mscal.Text = "0";
            }

            if (string.IsNullOrEmpty(op))
                txtb_cal.Text = txtb_mscal.Text;
            else
                txtb_cal.Text = expression + txtb_mscal.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtb_mscal.Text);
            op = "+";

            expression = txtb_mscal.Text + "+";
            txtb_cal.Text = expression;

            isNewNumber = true;
        }


        private void btn_equal_Click(object sender, EventArgs e)
        {
            int num2 = int.Parse(txtb_mscal.Text);
            int result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없음");
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            txtb_cal.Text = expression + num2.ToString() + "=" + result.ToString();
            txtb_mscal.Text = result.ToString();

            num1 = result;
            op = "";
            expression = "";

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtb_mscal.Text);
            op = "-";

            expression = txtb_mscal.Text + "-";
            txtb_cal.Text = expression;

            isNewNumber = true;
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtb_mscal.Text);
            op = "*";

            expression = txtb_mscal.Text + "×";
            txtb_cal.Text = expression;

            isNewNumber = true;
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtb_mscal.Text);
            op = "/";

            expression = txtb_mscal.Text + "÷";
            txtb_cal.Text = expression;

            isNewNumber = true;
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txtb_mscal.Text = "0";

            if (string.IsNullOrEmpty(op))
                txtb_cal.Text = "0";
            else
                txtb_cal.Text = expression;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_leftParen_Click(object sender, EventArgs e)
        {
            Input("(");
        }

        private void btn_rightParen_Click(object sender, EventArgs e)
        {
            Input(")");
        }
    }
}
