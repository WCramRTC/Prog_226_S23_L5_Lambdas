namespace Prog_226_S23_L5_Lambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lambdas
            Console.WriteLine("Hello, World!");

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

        // Links
        //https://www.csharptutorial.net/csharp-tutorial/csharp-lambda-expression/ 
        //https://www.c-sharpcorner.com/UploadFile/bd6c67/lambda-expressions-in-C-Sharp/

        }  // Main

    } // class

} // namespace