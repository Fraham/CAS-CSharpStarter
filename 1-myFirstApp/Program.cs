using System; // this is a statement to add libaries to the current file
// for this project we have the System library imported, this library allows to write text to the console (terminal)

namespace _1_myFirstApp //we don't need to go into namespaces in this workshop but more information about them can be found at https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/
{
    class Program // notice that the class name and the file name match
    {
        /*
            This is the main method of our project.
            This is the standard starting point for the code, so when you run your application this is where it will start.

            static means that the Main method can be reference without having a object
            void means that the method does not return any values
            Main is the name of the method
            Anything in the brackets is the arguments for the method
            The arguments for this method is a string array
        */
        static void Main(string[] args)
        {
            /*
                This is the only line code we have for this project
                This will write `Hellow World!` to the console/terminal

                We use Console to interact with the command line.
                For example Console.ReadLine() will read a line that the user enters into the command line. More information https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1
            */
            Console.WriteLine("Hello World!");
        }
    }
}
