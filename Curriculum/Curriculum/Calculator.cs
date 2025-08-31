using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Curriculum
{
    public partial class Calculator : Form
    {
        private List<double> numbers = new List<double>();
        private List<string> operators = new List<string>();
        private bool isOperationPerformed = false;
        private string currentInput = "";
        private bool isResultDisplayed = false;

        public Calculator()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
            this.KeyPreview = true;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            lblPrevious.Text = "";
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                switch (e.KeyChar)
                {
                    case '0':
                        if (currentInput != "0")
                        {
                            btn0_Click(sender, e);
                        }
                        break;
                    case '1': btn1_Click(sender, e); break;
                    case '2': btn2_Click(sender, e); break;
                    case '3': btn3_Click(sender, e); break;
                    case '4': btn4_Click(sender, e); break;
                    case '5': btn5_Click(sender, e); break;
                    case '6': btn6_Click(sender, e); break;
                    case '7': btn7_Click(sender, e); break;
                    case '8': btn8_Click(sender, e); break;
                    case '9': btn9_Click(sender, e); break;
                }
                e.Handled = true;
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                switch (e.KeyChar)
                {
                    case '+': btnaddition_Click(sender, e); break;
                    case '-': btnsubstraction_Click(sender, e); break;
                    case '*': btnmultiply_Click(sender, e); break;
                    case '/': btndivide_Click(sender, e); break;
                }
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                btndecimal_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                btnequal_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                btnremove_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                btnclear_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyChar == '%')
            {
                btnPercent_Click(sender, e);
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void UpdateDisplay()
        {
            // Build the full expression for lblPrevious
            string expression = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                expression += numbers[i].ToString();
                if (i < operators.Count)
                {
                    expression += " " + (operators[i] == "*" ? "×" : operators[i] == "/" ? "÷" : operators[i]) + " ";
                }
            }
            // Append the result if equals was clicked
            if (isResultDisplayed && currentInput.Length > 0)
            {
                expression += " = " + currentInput;
            }
            lblPrevious.Text = expression;

            // Set txttotal: Current input or "0" if empty
            txttotal.Text = currentInput.Length > 0 ? currentInput : "0";
        }

        private double EvaluateExpression()
        {
            List<double> tempNumbers = new List<double>(numbers);
            List<string> tempOperators = new List<string>(operators);

            for (int i = 0; i < tempOperators.Count; i++)
            {
                if (tempOperators[i] == "*" || tempOperators[i] == "/")
                {
                    double result;
                    if (tempOperators[i] == "*")
                    {
                        result = tempNumbers[i] * tempNumbers[i + 1];
                    }
                    else // "/"
                    {
                        if (tempNumbers[i + 1] == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return double.NaN;
                        }
                        result = tempNumbers[i] / tempNumbers[i + 1];
                    }
                    tempNumbers[i] = result;
                    tempNumbers.RemoveAt(i + 1);
                    tempOperators.RemoveAt(i);
                    i--;
                }
            }

            double finalResult = tempNumbers[0];
            for (int i = 0; i < tempOperators.Count; i++)
            {
                if (tempOperators[i] == "+")
                {
                    finalResult += tempNumbers[i + 1];
                }
                else // "-"
                {
                    finalResult -= tempNumbers[i + 1];
                }
            }

            return finalResult;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            if (txttotal.Text != "0")
            {
                txttotal.AppendText("0");
            }
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            if (!string.IsNullOrEmpty(txttotal.Text))
            {
                txttotal.AppendText("00");
            }
            else
            {
                txttotal.AppendText("0");
            }
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("1");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("2");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("3");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("4");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("5");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("6");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("7");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("8");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed || txttotal.Text == "0")
            {
                txttotal.Clear();
                isOperationPerformed = false;
            }
            txttotal.AppendText("9");
            currentInput = txttotal.Text;
            UpdateDisplay();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            operators.Clear();
            currentInput = "";
            isOperationPerformed = false;
            isResultDisplayed = false;
            lblPrevious.Text = "";
            UpdateDisplay();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddition_Click(object sender, EventArgs e)
        {
            // If an operator was just entered, replace the last operator
            if (isOperationPerformed && string.IsNullOrEmpty(currentInput) && operators.Count > 0)
            {
                operators[operators.Count - 1] = "+";
                UpdateDisplay();
                return;
            }

            if (double.TryParse(currentInput, out double number))
            {
                // If a result is displayed, start new expression with the result
                if (isResultDisplayed)
                {
                    numbers.Clear();
                    operators.Clear();
                    numbers.Add(number);
                    operators.Add("+");
                    isResultDisplayed = false;
                }
                else
                {
                    numbers.Add(number);
                    operators.Add("+");
                }
                isOperationPerformed = true;
                currentInput = "";
                UpdateDisplay();
            }
        }

        private void btnsubstraction_Click(object sender, EventArgs e)
        {
            // If an operator was just entered, replace the last operator
            if (isOperationPerformed && string.IsNullOrEmpty(currentInput) && operators.Count > 0)
            {
                operators[operators.Count - 1] = "-";
                UpdateDisplay();
                return;
            }

            if (double.TryParse(currentInput, out double number))
            {
                if (isResultDisplayed)
                {
                    numbers.Clear();
                    operators.Clear();
                    numbers.Add(number);
                    operators.Add("-");
                    isResultDisplayed = false;
                }
                else
                {
                    numbers.Add(number);
                    operators.Add("-");
                }
                isOperationPerformed = true;
                currentInput = "";
                UpdateDisplay();
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            // If an operator was just entered, replace the last operator
            if (isOperationPerformed && string.IsNullOrEmpty(currentInput) && operators.Count > 0)
            {
                operators[operators.Count - 1] = "/";
                UpdateDisplay();
                return;
            }

            if (double.TryParse(currentInput, out double number))
            {
                if (isResultDisplayed)
                {
                    numbers.Clear();
                    operators.Clear();
                    numbers.Add(number);
                    operators.Add("/");
                    isResultDisplayed = false;
                }
                else
                {
                    numbers.Add(number);
                    operators.Add("/");
                }
                isOperationPerformed = true;
                currentInput = "";
                UpdateDisplay();
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            // If an operator was just entered, replace the last operator
            if (isOperationPerformed && string.IsNullOrEmpty(currentInput) && operators.Count > 0)
            {
                operators[operators.Count - 1] = "*";
                UpdateDisplay();
                return;
            }

            if (double.TryParse(currentInput, out double number))
            {
                if (isResultDisplayed)
                {
                    numbers.Clear();
                    operators.Clear();
                    numbers.Add(number);
                    operators.Add("*");
                    isResultDisplayed = false;
                }
                else
                {
                    numbers.Add(number);
                    operators.Add("*");
                }
                isOperationPerformed = true;
                currentInput = "";
                UpdateDisplay();
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(currentInput, out double number))
            {
                numbers.Add(number);
                double result = EvaluateExpression();
                if (!double.IsNaN(result))
                {
                    // Do not clear numbers and operators to preserve the expression
                    currentInput = result.ToString();
                    isOperationPerformed = true;
                    isResultDisplayed = true;
                    UpdateDisplay();
                }
                else
                {
                    numbers.Clear();
                    operators.Clear();
                    currentInput = "";
                    isResultDisplayed = false;
                    lblPrevious.Text = "";
                    UpdateDisplay();
                }
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                // Delete last character from currentInput
                currentInput = currentInput.Remove(currentInput.Length - 1);
            }
            else if (operators.Count > 0)
            {
                // Remove last operator
                operators.RemoveAt(operators.Count - 1);
                isOperationPerformed = false;
            }
            else if (numbers.Count > 0)
            {
                // Remove last number and set currentInput to it
                currentInput = numbers[numbers.Count - 1].ToString();
                numbers.RemoveAt(numbers.Count - 1);
                isOperationPerformed = false;
            }
            UpdateDisplay();
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += currentInput.Length == 0 ? "0." : ".";
            }
            UpdateDisplay();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(currentInput, out double number))
            {
                if (numbers.Count > 0 && operators.Count > 0)
                {
                    double lastNumber = numbers[numbers.Count - 1];
                    double percentValue = lastNumber * (number / 100.0);
                    currentInput = percentValue.ToString();
                    UpdateDisplay();
                }
                else
                {
                    currentInput = (number / 100.0).ToString();
                    UpdateDisplay();
                }
                isOperationPerformed = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CV calcu = new CV();
            calcu.Show();
            this.Hide();
        }

        private void lblPrevious_Click(object sender, EventArgs e)
        {
        }
    }
}