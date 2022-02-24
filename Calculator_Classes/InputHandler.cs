namespace Calculator_Classes
{
    public class InputHandler
    {
        Messages message = new Messages();

        /// <summary>
        /// Finds out if the input is a valid sign (or xyzzy/quit)
        /// </summary>
        /// <returns></returns>
        public string ReadOperator()
        {
            string op;
            while (true)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                 op = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                // Doing a Null check inside CheckSpecialOperation()
                // becuse im allsow calling CheckSpecialOperation() inside ReadNumber()
                if (CheckSpecialOperation(op))
                    continue;
                else
                {
                    bool isValidInput = ControlInput(op);
                    if (isValidInput)
                    {
                        break;
                    }
                    else
                    {
                        message.Text($"{op} is not a valid symbol try:", ConsoleColor.Red);
                        message.Text("+, -, *, /, C, F", ConsoleColor.Red);
                    }
                }
            }
            return op;
        }
        /// <summary>
        /// Checks if the user wants to do something "special"
        /// </summary>
        /// <param name="input">Input from the user</param>
        /// <returns></returns>
        public bool CheckSpecialOperation(string input) // Could have been private but i have choosen to test it
        {
            if (string.IsNullOrEmpty(input))
            {
                message.Text("Can't handle a null value", ConsoleColor.Red);
                return true;
            }
            else if (input == "xyzzy")
            {
                message.Text("Nothing happens", ConsoleColor.Yellow);
                return true;
            }
            else
            {
                input = input.ToLower();
                if (input == "quit")
                {
                    Environment.Exit(0);
                }
                return false;
            }
        }
        /// <summary>
        /// Checks if the input is a valid operator
        /// </summary>
        /// <param name="input">Input from the user</param>
        /// <returns></returns>
        public bool ControlInput(string input) // Could have been private but i have choosen to test it
        {
            
            // Tried to use Enum but wont work sense you cant have special chars in an enum
            // then thought about Dictionary but after consideration desided its not super neccesary for sutch a little projekt
            if (input == "+" || input == "-" || input == "*" || input == "/" || input == "c" || input == "f")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        /// <summary>
        /// Finds out if the input is a valid number (or xyzzy/quit)
        /// </summary>
        /// <param name="op">Operator</param>
        /// <param name="secondOperand">Shall be set to true if it is the second operand</param>
        /// <returns></returns>
        public decimal ReadNumber(string op, bool secondOperand = false)
        {
            decimal inputDecimal;
            while (true)
            {
#pragma warning disable CS8600
                string input = Console.ReadLine();
#pragma warning restore CS8600

                if (CheckSpecialOperation(input))
                    continue;
                else
                {
                    bool isNumber = decimal.TryParse(input, out inputDecimal);
                    // Makes sure you cant divide by 0 thanks to secondOperand input
                    if (op == "/" && secondOperand && inputDecimal == 0)
                    {
                        message.Text("You can't divide by 0 try again:", ConsoleColor.Red);
                    }
                    else if (isNumber)
                    {
                        break;
                    }
                    else
                    {
                        message.Text($"{input} is not a valid decimal try again:", ConsoleColor.Red);
                    }
                }
            }
            return inputDecimal;
        }
        /// <summary>
        /// Displays the history from a List
        /// </summary>
        /// <param name="history">A list with former equations</param>
        public void ShowHistory(List<string> history)
        {
            message.Text("Press H for history or anything else to continue", ConsoleColor.Blue);
            if (Console.ReadKey().KeyChar == 'h')
            {
                Console.Clear();
                foreach (string historyItem in history)
                {
                    message.Text(historyItem, ConsoleColor.Green);
                }
            }
            else
            {
                Console.Clear();
            }
        }
    }
}