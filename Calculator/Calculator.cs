using System.Reflection;

namespace Lab01_1
{
    public partial class Calculator : Form
    {
        private double _firstValue = 0;
        private double _secondValue = 0;
        private string _operator = "0";
        private bool _operatorSelected = false;
        private bool _dotted = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            var value = (sender as Button)!.Text;

            if (displayBox.Text is "Cannot divide by 0 " or "Too big value " or "Too small value ")
                displayBox.Text = "0 ";

            if (_operatorSelected)
            {
                displayBox.Text = "0 ";
                _operatorSelected = false;
            }

            switch (displayBox.Text.Length)
            {
                case > 18:
                    return;
                case > 15:
                    displayBox.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
                    break;
                default:
                    displayBox.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
                    break;
            }

            if (value == "." && !_dotted)
            {
                displayBox.Text = displayBox.Text.Trim() + value + " ";
                _dotted = true;
            }
            else if (value != ".")
            {
                if (displayBox.Text == "0 ")
                    displayBox.Text = value + " ";
                else
                    displayBox.Text = displayBox.Text.Trim() + value + " ";
            }

            clear_Btn.Text = "CE";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            ResetColor();

            if (displayBox.Text is "Cannot divide by 0 ")
                return;

            if (!_operatorSelected)
                Operation();

            _firstValue = double.Parse(displayBox.Text);

            _operatorSelected = true;

            _operator = (sender as Button)!.Text;
            _dotted = false;

            switch (_operator)
            {
                case "+":
                    plus_Btn.BackColor = Color.DarkRed;
                    break;
                case "-":
                    minus_Btn.BackColor = Color.DarkRed;
                    break;
                case "x":
                    multi_Btn.BackColor = Color.DarkRed;
                    break;
                case "/":
                    divide_Btn.BackColor = Color.DarkRed;
                    break;
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (displayBox.Text.Length < 18)
                displayBox.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);

            if (displayBox.Text is "Cannot divide by 0 " or "Too big value " or "Too small value ")
                displayBox.Text = "0 ";

            if (displayBox.Text.Trim().Length == 1)
            {
                displayBox.Text = "0 ";
                clear_Btn.Text = "C";
            }
            else if (displayBox.Text[^2] == '.')
            {
                _dotted = false;
                displayBox.Text = displayBox.Text.Remove(displayBox.Text.Length - 2) + " ";
            }
            else
                displayBox.Text = displayBox.Text.Remove(displayBox.Text.Length - 2) + " ";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            displayBox.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);

            ResetColor();

            clear_Btn.Text = "C";
            _dotted = false;

            if (displayBox.Text == "0 ")
            {
                _firstValue = 0;
                _secondValue = 0;
                _operator = "0";
            }
            else
                displayBox.Text = "0 ";
        }

        private void signChange_Click(object sender, EventArgs e)
        {
            if (displayBox.Text is "Cannot divide by 0 ")
                return;

            if (double.Parse(displayBox.Text.Trim()) != 0)
            {
                var value = double.Parse(displayBox.Text.Trim()) * -1;
                
                if (!value.ToString().Contains("."))
                {
                    _dotted = false;
                    displayBox.Text = value + " ";
                }
                else
                    displayBox.Text = value + " ";
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            ResetColor();

            if (displayBox.Text is "Cannot divide by 0 ")
                return;

            if (_firstValue > 2_147_483_647 || _secondValue > 2_147_483_647)
            {
                displayBox.Text = "Too big value ";
                return;
            }
            if (_firstValue < -2_147_483_647 || _secondValue < -2_147_483_647)
            {
                displayBox.Text = "Too small value ";
                return;
            }

            Operation();

            if (!_operatorSelected)
                _operator = "0";

            _dotted = false;

            //_resultBtnClicked = true;
        }

        private void Operation()
        {
            double currentValue = 0;

            if (displayBox.Text != "Cannot divide by 0 ")
                _secondValue = double.Parse(displayBox.Text);
            else return;

            switch (_operator)
            {
                case "+":
                    currentValue = (double)decimal.Add((decimal)_firstValue,
                        (decimal)_secondValue);
                    break;
                case "-":
                    currentValue = (double)decimal.Subtract((decimal)_firstValue,
                        (decimal)_secondValue);
                    break;
                case "x":
                    currentValue = (double)decimal.Multiply((decimal)_firstValue,
                        (decimal)_secondValue);
                    break;
                case "/":
                    if (double.Parse(displayBox.Text) is 0)
                    {
                        displayBox.Text = "Cannot divide by 0 ";
                        return;
                    }
                    currentValue = (double)decimal.Divide((decimal)_firstValue,
                        (decimal)_secondValue);
                    break;
                case "0":
                    _firstValue = double.Parse(displayBox.Text);
                    return;
            }

            _secondValue = currentValue;
            //_firstValue = currentValue;

            if (currentValue == 0)
                displayBox.Text = "0 ";
            else
                displayBox.Text = Math.Round(currentValue, 8) + " ";

            if (displayBox.Text.Length > 15)
                displayBox.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            if (displayBox.Text.Length > 19)
                displayBox.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);

        }

        private void ResetColor()
        {
            plus_Btn.BackColor = Color.FromArgb(44, 44, 44);
            minus_Btn.BackColor = Color.FromArgb(44, 44, 44);
            multi_Btn.BackColor = Color.FromArgb(44, 44, 44);
            divide_Btn.BackColor = Color.FromArgb(44, 44, 44);
        }
    }
}