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
                    secondNumber = inputHandler.ReadNumber(op, true);
                    (ecuation, ecuals) = calculate.Calculating(op, firstNumber, secondNumber);
                }
                if (ecuals == 69)
                {
                    message.Text("RickRoll", ConsoleColor.Yellow);      // TODO: Make this a real Rick Roll
                }
                message.Text(ecuation, ConsoleColor.Green);

                history.Add(ecuation);
                inputHandler.ShowHistory(history);

                message.Text("Type +, -, *, /, F, C for another ecuation", ConsoleColor.Blue);
                message.Text("or type QUIT to exit", ConsoleColor.Blue);
            } while (true);
        }
    }
    // TODO: om x = 69 rickroll?
    // TDOD: fixa tester
    // TODO: fixa klass för operatorer (Fråga Alex)
    // TODO: gör så att +, -, /, *, f, c, är Char (Fråga Alex)
    // TODO: kan man fixa så att man inte behöver ha "string.IsNullOrEmpty()" två gånger (Fråga Alex)
    // TODO: vill du att det ska finnas ett speciellt meddelande för att talet är för stort (Fråga Alex)
}