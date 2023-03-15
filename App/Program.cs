using System.ComponentModel.Design;
using System.Globalization;
using System.Net.Http.Headers;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A drawn triangle

            /*
             Console.WriteLine("   /|");
             Console.WriteLine("  / |");
             Console.WriteLine(" /  |");
             Console.WriteLine("/___|");
            */

            // Variables

            /*
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Josip";
            characterAge = 23;
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            */

            // Data Types

            /*
            string phrase = "Academy";
            char grade = 'A';
            int age = 25;
            double gpa = 3.2;
            bool isMale = true;
            */

            // Working with Strings

            /*
            string phrase = "Josip Harci";
                        //   01234 678910
            string phraseTwo = "Josip Harci " + "is cool";

            Console.WriteLine("Josip Harci");
            Console.WriteLine("Josip\nHarci"); //  Division new line
            Console.WriteLine("Josip\"Harci");
            Console.WriteLine(phrase);
            Console.WriteLine(phraseTwo);
            Console.WriteLine(phrase.Length); // Number char
            Console.WriteLine(phraseTwo.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phraseTwo.Contains("Josip"));
            Console.WriteLine(phrase[6]);
            Console.WriteLine(phrase.IndexOf("Josip") ); //Start ID
            Console.WriteLine(phrase.IndexOf("s") );
            Console.WriteLine(phrase.IndexOf("f") ); // It's not in sequence
            Console.WriteLine(phrase.Substring(8,3) );
            */

            // Working with Numbers

            /*
            Console.WriteLine(50);
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 / 8);
            Console.WriteLine(5 % 2); // Ostatak
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(5.0 + 8.1); // Isto
            Console.WriteLine(5 + 8.1); // Isto

            Console.WriteLine(5 / 2.0);

            int num = 6;
            num++;
            Console.WriteLine(num);

            int numTwo = 6;
            numTwo--;
            Console.WriteLine(numTwo);

            Console.WriteLine(Math.Abs(-40) );

            Console.WriteLine(Math.Pow(2 , 3));

            Console.WriteLine(Math.Sqrt(36));

            Console.WriteLine(Math.Min(36,100));

            Console.WriteLine(Math.Max(36,100));

            Console.WriteLine(Math.Round(2.3));
            */

            // Getting User Input

            /*
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            // Console.WriteLine("Hello " + name);

            Console.Write("Enter your age: ");
            String age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);

            
            */

            // Building a calculator

            /* 
            Console.Write("Enter the first number: ");
            Double numOne = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            Double numTwo = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine(numOne + numTwo);
            */


            // Building a Mad Libs Game

            /*
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine( pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
            */

            // Arrays

            /*
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "John";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1] );
            */

            //SayHi("Mike", 33);

            /*
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
            */

            //ifstate();
            //moreIfState();
            //Calculator();
            //SwitchState();
            //While();
            //Game();
            //Loop();
            //ExpMet();
            //Array2d();
            //ExpHand();



            //Class


            /*
            Book book1 = new Book("Harry Potter","JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein" , 700);

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine("Pages: " + book1.pages);

            Console.WriteLine("-----");

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine("Pages: " + book2.pages);
            */

            /*
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);


            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            */

          
            /*
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating); 
            */

            Song holiday = new Song("Holiday","Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());
           // Console.WriteLine(kashmir.title);

            Console.ReadLine();
        }

        // Methods
        // Return Statement

        static void SayHi(string name,int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);

        }

        static double cube(int num) 
        {
            int result = num * num * num;
            return result;

        }

        // If Statements

        static void ifstate()
        {
            /*
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }
            */

            /*
            bool isMale = false;
            bool isTall = false;

            if (isMale || isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }
            */

            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a not male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }
        }

        static void moreIfState()
        {
            /*
            Console.WriteLine(GetMax(2, 10));
            static int GetMax(int num1 , int num2)
            {
                int result;
                if(num1 > num2)
                {
                    result = num1;
                }
                else
                {
                    result = num2;
                }


                return result;
            }
            */

            Console.WriteLine(GetMax(2, 10 , 15));
            static int GetMax(int num1, int num2 , int num3)
            {
                int result;

                if (num1 >= num2 && num1 >= num3)
                {
                    result = num1;
                } 
                else if(num2 >= num1 && num2 >= num3)
                {
                    result = num2;
                }
                else
                {
                    result = num3;
                }

                return result;
            }
        }

        // Building a better Calculator

        static void Calculator()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();


            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if(op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator!");
            }

        }

        // Switch Statements

        static void SwitchState()
        {
            Console.Write("Enter Num Day: ");
            int num = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine(GetDay(num));

            static string GetDay(int dayNum)
            {
                string dayName;

                switch (dayNum)
                {
                    case 0:
                        dayName = "Sunday";
                        break;
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName = "Tuseday";
                        break;
                    case 3:
                        dayName = "Wednesday";
                        break;
                    case 4:
                        dayName = "Thursday";
                        break;
                    case 5:
                        dayName = "Friday";
                        break;
                    case 6:
                        dayName = "Saturday";
                        break;
                    default:
                        dayName = "Invalid Day Number!";
                        break;
                }

                return dayName;

            }
        }

        // While Loops

        static void While()
        {
            /*
            int index = 1;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            */

            int index = 6;

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

        }

        // Building a Guessing Game

        static void Game()
        {
            string secretWord = "intellitest";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if ( guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }
            
        }

        //For Loops

        static void Loop()
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);

            }
        }

        //Building an Exponent Method

        static void ExpMet()
        {
            Console.Write("Enter Base Number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Pow Number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetPow(numOne, numTwo));

            static int GetPow(int baseNum, int powNum)
            {
                int result = 1;

                for( int i = 0; i < powNum; i++ )
                {
                    result = result * baseNum;
                }

                return result; 
            }
        }

        // 2d array

        static void Array2d()
        {
            int[,] numberGrid = {
                { 1 , 2 },
                { 3 , 4},
                { 5,  6}
            };
            int[,] myArray = new int[2 , 3];

            Console.WriteLine(numberGrid[1, 1]);
        }

        // Exception Handling

         static void ExpHand()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
           

        }



    }
}