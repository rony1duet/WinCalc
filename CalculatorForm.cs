namespace WinCalc
{
    public partial class CalculatorForm : Form
    {
        private double? previousValue = null;
        private string operation = null;
        private bool waitingForOperand = false;
        private double? lastOperand = null;
        private string lastOperation = null;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string digit = btn.Text;

            if (waitingForOperand)
            {
                txtDisplay.Text = digit;
                waitingForOperand = false;
            }
            else
            {
                txtDisplay.Text = (txtDisplay.Text == "0") ? digit : txtDisplay.Text + digit;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (waitingForOperand)
            {
                txtDisplay.Text = "0.";
                waitingForOperand = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string nextOperation = btn.Text;
            double inputValue = double.Parse(txtDisplay.Text);

            if (operation != null && waitingForOperand)
            {
                operation = nextOperation;
                lblFormula.Text = $"{previousValue} {operation}";
                return;
            }

            if (previousValue == null)
            {
                previousValue = inputValue;
                lblFormula.Text = $"{inputValue} {nextOperation}";
            }
            else if (operation != null)
            {
                double result = Calculate(previousValue.Value, inputValue, operation);
                previousValue = result;
                txtDisplay.Text = result.ToString();
                lblFormula.Text = $"{result} {nextOperation}";
            }
            else
            {
                previousValue = inputValue;
                lblFormula.Text = $"{inputValue} {nextOperation}";
            }

            waitingForOperand = true;
            operation = nextOperation;
        }

        private double Calculate(double prev, double current, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+": result = prev + current; break;
                case "-": result = prev - current; break;
                case "*": result = prev * current; break;
                case "/": result = current == 0 ? 0 : prev / current; break;
                default: return current;
            }
            return Math.Round(result, 10);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double inputValue = double.Parse(txtDisplay.Text);
            double? currentPrev = previousValue;
            string currentOp = operation;

            // Handle repeating equals functionality
            if (currentOp == null && lastOperation != null && lastOperand != null)
            {
                currentPrev = inputValue;
                currentOp = lastOperation;
                inputValue = lastOperand.Value;
            }

            if (currentOp != null && currentPrev != null)
            {
                double result = Calculate(currentPrev.Value, inputValue, currentOp);
                lblFormula.Text = $"{currentPrev} {currentOp} {inputValue} =";
                txtDisplay.Text = result.ToString();

                lastOperand = inputValue;
                lastOperation = currentOp;

                previousValue = null;
                operation = null;
                waitingForOperand = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblFormula.Text = "";
            previousValue = null;
            operation = null;
            waitingForOperand = false;
            lastOperand = null;
            lastOperation = null;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (!waitingForOperand)
            {
                if (txtDisplay.Text.Length > 1)
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                else
                    txtDisplay.Text = "0";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (double.Parse(txtDisplay.Text) * -1).ToString();
        }
    }
}
