using System;
using System.Runtime.CompilerServices;
using System.Xml.Resolvers;

namespace Prog_226_S23_L5_Lambdas
{
    internal class Program
    {
        static List<Player> players = new List<Player>();
        //static Action displayThisGlobally = () => Console.WriteLine("Print that");
        ////Field
        //static string _name;
        //// Property
        //public static string Name { get => _name; set => _name = value; }

        static void Main(string[] args)
        {

            Preload();

            var playersBelow53 = players // List of Players
                .FindAll( (y) => y.Hp < 90 && y.Hp >72 ) // Find all characters with hp between 90 and 72
                .FindAll( x => x.FirstName[0] == 'A'); // Find all Characters with name starting with A

            var player = players.Find(x => x.Hp < 87);
            var playerLast = players.FindLast(x => x.FirstName == "Bob");
            Console.WriteLine(playerLast);

            //foreach (Player player1 in playersBelow53)
            //{
            //    Console.WriteLine(player1);
            //}

        }  // Main

        public static void Preload()
        {

            string[] firstNames = { "Alice", "Bob", "Charlie", "David", "Emily", "Frank", "Grace", "Haley", "Isaac", "Julia" };
            string[] lastNames = { "Smith", "Johnson", "Brown", "Garcia", "Jones", "Davis", "Miller", "Wilson", "Moore", "Taylor" };
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                string firstName = firstNames[rand.Next(firstNames.Length)];
                string lastName = lastNames[rand.Next(lastNames.Length)];
                int hp = rand.Next(50, 101); // generate a random HP between 50 and 100

                Player player = new Player(firstName, lastName, hp);
                players.Add(player);
            }
        }

        public static void Example3()
        {
            // Using Lambdas
            // Created a lambda that generates a list of numbers
            Func<int, List<int>> listOfNumbers = (count) =>
            {
                Random rand = new Random();
                List<int> temp = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    temp.Add(rand.Next(0, 1000));
                }

                return temp;
            };
            // Created a lambda that displays a list of numbers
            Action<List<int>> displayList = (list) =>
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            };

            List<int> myList = listOfNumbers(15);
            displayList(myList);

            Console.WriteLine("Found Result-------------------");
            var findAllGreater = myList.FindAll((x) => x > 500 && x <= 689);

            // ---------------------------------------
            displayList(findAllGreater);

            Console.WriteLine(findAllGreater);

            //myList.Find();
        }

        // 1 2 3 4 5 6
        // FindNumber(list, 3);
        public static int FindNumber(List<int> list, int numberToBeGreaterThan)
        {
            
            foreach (int num in list)
            {
                if (num > numberToBeGreaterThan)
                {
                    return num;
                }
            }

            return -1;
        }


        // Method signature - return type, name, parameters
        public static void ListDisplay(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        } // ListDisplay()

        public static void VarExample()
        {
            // Var is loosely typed
            var variableName = "35345";
            var varNum = 3454;
            var varBool = true;
            //var varPlayer = new Player();

            Console.WriteLine(variableName.GetType());
            Console.WriteLine(varNum.GetType());
            Console.WriteLine(varBool.GetType());
            //Console.WriteLine(varPlayer.GetType());
        }

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

        // Links
        //https://www.csharptutorial.net/csharp-tutorial/csharp-lambda-expression/ 
        //https://www.c-sharpcorner.com/UploadFile/bd6c67/lambda-expressions-in-C-Sharp/


    } // class

} // namespace