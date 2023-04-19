namespace Prog_226_S23_L5_Lambdas
{
    internal class Program
    {
        //static Action displayThisGlobally = () => Console.WriteLine("Print that");
        ////Field
        //static string _name;
        //// Property
        //public static string Name { get => _name; set => _name = value; }

        static void Main(string[] args)
        {
         
        
            // Links
            //https://www.csharptutorial.net/csharp-tutorial/csharp-lambda-expression/ 
            //https://www.c-sharpcorner.com/UploadFile/bd6c67/lambda-expressions-in-C-Sharp/

        }  // Main



        // Method signature - return type, name, parameters
        public static void ListDisplay(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        } // ListDisplay()


        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Example()
        {
            // Lambdas

            // How to declare a lambda
            //(parameters) => expression
            // => Lambda Symbol

            // Add
            int sum = 5 + 8;
            //int sumMethod = Add(5, 8);

            Func<int, int, int> sumLambda = // 
                                            // Method Body
                (num1, num2) => // Parameters int num1 and int num2
                num1 + num2; // Method Body - return num1 + num2

            Func<int, int, int> sumLambda2 = Add;

            // We have to use a Delegate

            List<int> _numbers = new List<int>() { 1, 234, 65, 2, 4, 6, 3, 234 };
            List<int> _numbers2 = new List<int>() { 453, 12, 765 };
            //ListDisplay(_numbers);

            // Delegates
            // Action - void return type
            // Predicate - bool return type
            // Func - Pass in param and return type

            Action<List<int>> displayList = (list) =>
            {
                foreach (int item in list)
                {
                    Console.WriteLine(item);
                }
            };

            displayList(_numbers);
            Console.WriteLine("-----------------------");

            displayList = (list) =>
            {
                foreach (int item in list)
                {
                    if (item % 2 != 0)
                    {
                        Console.WriteLine(item);
                    }
                }
            };


            displayList(_numbers);

        }

        public static void NoteExamples()
        {
            List<int> numbers = new List<int>() { 1, 25, 3, 1, 5 };

            var findAllGreater = numbers.FindAll(x => x > 2);

            var displayList = (List<int> list) =>
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            };

            displayList(findAllGreater);
        }

    } // class

} // namespace