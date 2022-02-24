using Calculator_Classes;

// I have added if you get an ecuation = 69 you will get rickrolled
// Also added a history function

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Adams Calculator";
            Messages message = new Messages();
            message.Text("Type in ONE of the following signs to start:", ConsoleColor.Blue);
            message.Text("+, -, *, /, F, C", ConsoleColor.Blue);
            message.Text("or type QUIT at any time to close the aplication", ConsoleColor.Blue);

            InputHandler inputHandler = new InputHandler();
            // Considered using char, but i started with a string (stupidly enough) so decided that it wont make to mutch of a difference
            string op; // Operator
            string ecuation;
            decimal ecuals;
            List<string> history = new List<string>();

            Calculate calculate = new Calculate();
            do
            {
                op = inputHandler.ReadOperator();

                message.StateNumber(op);
                decimal firstNumber;
                decimal secondNumber;

                if (op == "f" || op == "c")
                {
                    firstNumber = inputHandler.ReadNumber(op);
                    (ecuation, ecuals) = calculate.Calculating(op, firstNumber);
                }
                else
                {
                    firstNumber = inputHandler.ReadNumber(op);
                    // Made it so that you can choose if its the second number so that i dident
                    // have to make a completly new method just becuse you cant divide by 0
                    secondNumber = inputHandler.ReadNumber(op, true);
                    (ecuation, ecuals) = calculate.Calculating(op, firstNumber, secondNumber);
                }
                if (ecuals == 69)
                {
                    // Tried to make this a real rickroll but wasent able to
                    // so this will have to do (for now)
                    message.Text("RickRoll", ConsoleColor.Yellow); 
                }
                message.Text(ecuation, ConsoleColor.Green);

                history.Add(ecuation);
                inputHandler.ShowHistory(history);

                message.Text("Type +, -, *, /, F, C for another ecuation", ConsoleColor.Blue);
                message.Text("or type QUIT to exit", ConsoleColor.Blue);
            } while (true);
        }
    }
}