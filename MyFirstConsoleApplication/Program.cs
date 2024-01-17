// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

//two variables to store your values (name, country).
string firstName = "Elroe";
string country = "Ethiopia";

//Display introduction.
Console.WriteLine($"My name is {firstName}, I am from {country}");

//Get current Date and display it.
DateTime currentDate = DateTime.Today;
Console.WriteLine(currentDate.ToString());

//Get the christmas date and save it in a varriable.
DateTime christmas = new DateTime(2024, 12, 25);

//subtract the dates to get the days til christmas. 
TimeSpan diff = christmas - currentDate;

// Get the total number of days as an integer
int days = diff.Days;

// Print the result with a label
Console.WriteLine(days + " days until Christmas");

//Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
double width, height, woodLength, glassArea;
string widthString, heightString;

//Get the width from user.
Console.WriteLine("What is the width of the window? ");
widthString = Console.ReadLine();
width = double.Parse(widthString);

//Get the height from user.
Console.WriteLine("What is the height of the window? ");
heightString = Console.ReadLine();
height = double.Parse(heightString);

//Calculate the wood length with width and height.
woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);

//Display result to the user.
Console.WriteLine("The length of the wood is " +
woodLength + " feet");
Console.WriteLine("The area of the glass is " +
glassArea + " square metres");





//Output the number of days until Christmas this year and, of course, apply an appropriate label to that output.
//Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
//Add these requirements to the code:
//Provide appropriate text labels when requesting dimensional input.
//Cause the program to pause in the console so that the application does not automatically terminate when launched from the Visual Studio run debugger tool. 
//Hint: Consider Console.ReadKey()
//You do NOT need to add any sort of input validation.