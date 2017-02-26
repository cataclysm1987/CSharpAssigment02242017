using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Console;

namespace CSharpAssignment02242017
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.MainMenu();
        }

        public class Rectangle
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public double GetArea()
            {
                return Length*Width;
            }

            public void AcceptDetails()
            {
                WriteLine("Length is " + Length + ". Width is " + Width);
                WriteLine("Do you accept these details? Enter Y for Yes or N for No.");
                var answer = ReadLine().ToLower();
                if (answer == "y")
                {
                    WriteLine("Thank you! Rectangle saved.");
                } else if (answer == "n")
                {
                    WriteLine("Please reenter the length: ");
                    Length = Convert.ToDouble(ReadLine());
                    WriteLine("Please reenter the width: ");
                    Width = Convert.ToDouble(ReadLine());
                }
                else
                {
                    WriteLine("Invalid response. Please try again.");
                    AcceptDetails();
                }

            }

            public void Display()
            {
                WriteLine("Here is a picture of your rectangle.");
                for (int y = 0; y < Length; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }

        public class Triangle
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public Triangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public double GetArea()
            {
                return (Length * Width) / 2;
            }

            public void AcceptDetails()
            {
                WriteLine("Length is " + Length + ". Width is " + Width);
                WriteLine("Do you accept these details? Enter Y for Yes or N for No.");
                var answer = ReadLine().ToLower();
                if (answer == "y")
                {
                    WriteLine("Thank you! Rectangle saved.");
                }
                else if (answer == "n")
                {
                    WriteLine("Please reenter the length: ");
                    Length = Convert.ToDouble(ReadLine());
                    WriteLine("Please reenter the width: ");
                    Width = Convert.ToDouble(ReadLine());
                }
                else
                {
                    WriteLine("Invalid response. Please try again.");
                    AcceptDetails();
                }

            }

            public void Display()
            {
                WriteLine("Here is a picture of your triangle.");
                WriteLine("*");
                int x = 1;
                int y = 1;
                while (y++ < Width)
                {
                    
                    Write("*");

                    
                    var l = (int)Length * y / Width;

                    
                    x = 1;
                    while (x++ < l - 3)
                    {
                        Write(" ");
                    }
                    WriteLine("*");
                }

                
                x = 0;
                while (x++ < Length)
                {
                    Write("*");
                }
                WriteLine();
            }
        }

        public class Octagon
        {
            
        }

        public class Square
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public Square(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public double GetArea()
            {
                return Length * Width;
            }

            public void AcceptDetails()
            {
                WriteLine("Length is " + Length + ". Width is " + Width);
                WriteLine("Do you accept these details? Enter Y for Yes or N for No.");
                var answer = ReadLine().ToLower();
                if (answer == "y")
                {
                    WriteLine("Thank you! Square saved.");
                }
                else if (answer == "n")
                {
                    WriteLine("Please reenter the length and width: ");
                    Length = Convert.ToDouble(ReadLine());
                    Width = Length;
                }
                else
                {
                    WriteLine("Invalid response. Please try again.");
                    AcceptDetails();
                }

            }

            public void Display()
            {
                WriteLine("Here is a picture of your square.");
                for (int y = 0; y < Length; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        Write("*");
                    }

                    WriteLine();
                }
            }
        }

        public class TimesTable
        {
            public double Number { get; set; }

            public TimesTable(double n)
            {
                Number = n;
            }

            public void Display()
            {
                WriteLine("Here is your times table:");
                for (int i = 0; i <= 10; i++)
                {
                    WriteLine(Number * i);
                }
            }
        }

        public static class Menu
        {
            public static void MainMenu()
            {
                WriteLine("Welcome to the Math assignment in C Sharp!");
                WriteLine("Enter 1 to build a rectangle, 2 for a square, 3 for a triangle, 4 for an octogon or 5 for a times table.");
                var answer = ReadLine();
                if (answer == "1")
                {
                    WriteLine("Enter the length of your rectangle: ");
                    var length = Convert.ToDouble(ReadLine());
                    WriteLine("Enter the width of your rectangle: ");
                    var width = Convert.ToDouble(ReadLine());

                    Rectangle rectangle = new Rectangle(length, width);

                    WriteLine("The area of your rectangle is " + rectangle.GetArea());
                    rectangle.AcceptDetails();
                    rectangle.Display();


                }
                else if (answer == "2")
                {
                    WriteLine("Enter the length and width of your square: ");
                    var length = Convert.ToDouble(ReadLine());
                    var width = length;

                    Square square = new Square(length, width);

                    WriteLine("The area of your rectangle is " + square.GetArea());
                    square.AcceptDetails();
                    square.Display();
                }
                else if (answer == "3")
                {
                    WriteLine("Enter the length of your triangle: ");
                    var length = Convert.ToDouble(ReadLine());
                    WriteLine("Enter the width of your triangle: ");
                    var width = Convert.ToDouble(ReadLine());

                    Triangle triangle = new Triangle(length, width);

                    WriteLine("The area of your triangle is " + triangle.GetArea());
                    triangle.AcceptDetails();
                    triangle.Display();
                }
                else if (answer == "4")
                {
                    WriteLine("Hey look an octagon!");
                }
                else if (answer == "5")
                {
                    WriteLine("Please enter your value for a times table.");
                    var value = Convert.ToDouble(ReadLine());
                    TimesTable table = new TimesTable(value);
                    table.Display();
                }
                else
                {
                    WriteLine("Invalid response! Try again.");
                    Menu.MainMenu();
                }
            }
        }
    }
}
