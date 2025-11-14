namespace Calculator
{
    public partial class Form1 : Form
    {
        double first_input_num = 0;
        double second_input_num = 0;
        char state;

        public Form1()
        {
            InitializeComponent();

            textbox_result.PlaceholderText = "¬ведите вашу операцию";
        }

        private void Digit_Choose_Click(object sender, EventArgs e) //¬вод цифр с циферблата
        {
            if (sender is Button button)
            {
                string digit = button.Tag?.ToString();

                textbox_result.Text += digit;
            }
        }

        private int test_if_digit(string input) //ѕроверка €вл€ютс€ ли введенные данные числом
        {
            if (double.TryParse(textbox_result.Text, out _))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void operation_Click(object sender, EventArgs e)
        {
            if (test_if_digit(textbox_result.Text) is 0)
            {
                textbox_result.Text = "";
                textbox_result.PlaceholderText = "ќшибка";
            }
            else
            {
                first_input_num = Convert.ToDouble(textbox_result.Text);
                textbox_result.PlaceholderText = first_input_num.ToString();
                textbox_result.Text = null;
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "+":
                            state = '+';
                            break;
                        case "-":
                            state = '-';
                            break;
                        case "*":
                            state = '*';
                            break;
                        case "/":
                            state = '/';
                            break;
                        case "%":
                            state = '%'; ;
                            break;
                        default:
                            textbox_result.Text = "¬ведите операцию";
                            break;
                    }
                }
            }
        }

        public static double operation_function (double first_input, double second_input, char operation)
        {
            switch (operation)
            {
                case '+':
                    return first_input += second_input;
                case '-':
                    return first_input -= second_input;
                case '*':
                    return first_input *= second_input;
                case '/':
                    return first_input /= second_input;
                case '%':
                    return first_input %= second_input;
            }
            return 0;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            second_input_num = Convert.ToDouble(textbox_result.Text);
            textbox_result.Text = operation_function(first_input_num, second_input_num, state).ToString();
            first_input_num = 0;
            second_input_num = 0;
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            textbox_result.Text = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            first_input_num = 0;
            state = ' ';
            textbox_result.Text = null;
            textbox_result.PlaceholderText = null;
            textbox_result.PlaceholderText = "¬ведите вашу операцию";
        }
    }
}