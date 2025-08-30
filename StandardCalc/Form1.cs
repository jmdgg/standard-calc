using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StandardCalculator
{
    public partial class Form1 : Form
    {
        string firstNumber = "";
        string secondNumber = "";
        bool secondNumAdd = false;
        string currentOperation = "";
        List<string> expression = new List<string>();
        bool isOperatorClicked = false;
        bool isClearClicked = false;
        bool historyVisible = true;
        private Queue<string> entries = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            checkSecondNum();
            calculate();
        }





        private void btnClr_Click(object sender, EventArgs e)
        {
            disp.Text = "";
            firstNumber = "";
            secondNumber = "";
            currentOperation = "";
            expression = [];
            isOperatorClicked = false;
            secondNumAdd = false;
            isClearClicked = true;
        }

        private void initBtn(Button btn, string fieldName)
        {
            ;
            string num = fieldName;
            if (isOperatorClicked)
            {
                disp.Text = "";
                isOperatorClicked = false;
            }
            if (isClearClicked)
            {
                disp.Text = "";
                isClearClicked = false;
            }
            if (num == "." && disp.Text.Contains("."))
            {
                //check if current number already has decimal point
                return;
            }
            if (char.IsDigit(num[0]) || num == ".")
            {     // Only allow number and decimal point
                disp.Text += num;
                if (currentOperation == null) //switch if current display is in first or second eq
                {
                    firstNumber = disp.Text;
                }
                else
                {
                    secondNumber = disp.Text;
                }
            }
        }

        private void checkSecondNum()
        {
            if (!string.IsNullOrEmpty(secondNumber))
            {
                if (expression.Count == 0 || expression[expression.Count - 1] != secondNumber)
                {
                    expression.Add(secondNumber);
                    secondNumAdd = true;
                }
            }
        }

        private void initOps(Button btn, string operand)
        {

            string operation = btn.Text;
            string lastChar = disp.Text.Length > 0
        ? disp.Text.Substring(disp.Text.Length - 1)
        : "";

            if (!string.IsNullOrEmpty(lastChar) && !char.IsDigit(lastChar[0]))
            {
                disp.Text = disp.Text.Substring(0, disp.Text.Length - 1) + operation;

                if (expression.Count > 0)
                {
                    expression[expression.Count - 1] = operation;
                }

                currentOperation = operation;
                return;
            }

            if (!string.IsNullOrEmpty(firstNumber) && currentOperation == null)
                expression.Add(firstNumber);

            checkSecondNum();

            disp.Text += operation;
            currentOperation = operation;

            expression.Add(currentOperation);
            isOperatorClicked = true;

        }


        private void calculate()
        {

            if (expression.Count < 3)
            {
                return;
            }
            if (secondNumAdd)
            {
                double first = Convert.ToDouble(expression[expression.Count - 3]);
                string operation = expression[expression.Count - 2];
                double second = Convert.ToDouble(expression[expression.Count - 1]);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = first + second;
                        break;
                    case "-":
                        result = first - second;
                        break;
                    case "*":
                        result = first * second;
                        break;
                    case "%":
                        if (second == 0)
                        {
                            disp.Text = ("Undefined.");
                        }
                        result = first % second;
                        break;
                    case "/":
                        if (second == 0)
                        {
                            disp.Text = ("Cannot divide by zero.");
                        }
                        else
                        {
                            result = first / second;
                        }
                        break;
                    default:
                        return;
                }
                disp.Text = result.ToString();
                firstNumber = result.ToString();
                secondNumber = "";
                string entry = $"{first} {operation} {second} = {result}";
                addHistory(entry);
                currentOperation = "";
                expression.Clear();
                expression.Add(result.ToString());
                secondNumAdd = false;

            }
        }
        //Getter-setter for Result to be used in recent entries


        private void btn7_Click(object sender, EventArgs e)
        {
            initBtn(btn7, "7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            initBtn(btn8, "8");

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            initBtn(btn9, "9");

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            initBtn(btn0, "0");

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            initBtn(btn1, "1");

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            initBtn(btn2, "2");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            initBtn(btn3, "3");

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            initBtn(btn4, "4");

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            initBtn(btn5, "5");

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            initBtn(btn6, "6");

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            initBtn(btnDot, ".");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            initOps(btnMult, "*");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            initOps(btnSub, "-");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            initOps(btnAdd, "+");

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            initOps(btnDiv, "/");

        }



        private void btnMod_Click(object sender, EventArgs e)
        {
            initOps(btnMod, "%");

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (disp.Text.Length > 0)
            {
                disp.Text = disp.Text.Remove(disp.Text.Length - 1);
            }
            else
            {
                disp.Text = "";
            }
        }

        private void btnSgnChg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(disp.Text))
                return;
            // Try to parse whatever is currently on the display
            if (double.TryParse(disp.Text, out double value))
            {
                value = -value; // flips sign
                disp.Text = value.ToString();
                // To know which current num we're at
                if (currentOperation == null)
                {
                    firstNumber = disp.Text;
                }
                else
                {
                    secondNumber = disp.Text;
                }
            }
        }


        private void btnSqr_Click(object sender, EventArgs e)
        {

            if (double.TryParse(disp.Text, out double value))
            {
                double oldValue = value;
                value = value * value;
                string entry = $"sqr({oldValue}) = {value}";
                addHistory(entry);
                disp.Text = value.ToString();
                firstNumber = disp.Text;
                secondNumber = "";

            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(disp.Text, out double value) && value >= 0)
            {
                double oldValue = value;
                value = Math.Sqrt(value);
                string entry = $"√({oldValue}) = {value}";

                addHistory(entry);
                disp.Text = value.ToString();
                firstNumber = disp.Text;
                secondNumber = "";
            }
        }
        //LIFO stack; Latest Entry first, Oldest Entry out.
        private void addHistory(string entry)
        {
            if (entries.Count >= 10)
                entries.Dequeue(); // removes oldest
            entries.Enqueue(entry);

            // ListBox updater
            boxHis.Items.Clear();
            foreach (var item in entries.Reverse()) // makes listbox displays newest items on top
            {
                boxHis.Items.Add(item);
            }
        }

        private void boxHis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When user clicks specific equation, displays the expression
            disp.Text = boxHis.SelectedItem.ToString().Split('=')[0].Trim();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (!historyVisible)
            {
                this.Width = 811; 
                boxHis.Visible = true;
                historyVisible = true;
            }
            else
            {
                this.Width = 490; 
                boxHis.Visible = false;
                historyVisible = false;
            }
        }
    }
}
