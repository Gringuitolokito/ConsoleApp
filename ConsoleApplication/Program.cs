using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            String cDate = DateTime.Now.ToString("MM.dd.yyyy");
            DateTime daysLeft = DateTime.Parse("12/25/2019 12:00:01 AM");
            DateTime startDate = DateTime.Now;
            TimeSpan t = daysLeft - startDate;
            string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds til Christmas!", t.Days, t.Hours, t.Minutes, t.Seconds);
            
            //Say Hello
            Console.WriteLine("Hello!");
            //Prompt For Name
            Console.WriteLine("Enter Full Name");
            //Store Input
            String FullName = Console.ReadLine();
            //Prompt For Location
            Console.WriteLine("Your Lcation (in terms of state or country): ");
            //Store Input
            String Location = Console.ReadLine();
            //Prompt For Width
            Console.WriteLine("Enter Width Of Window (in inches): ");
            //Store Input
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            //Prompt For Height
            Console.WriteLine("Enter Height Of Window (in inches): ");
            //Store Input
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            
            //Math part
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("Current Date: " + cDate);
            Console.WriteLine(countDown);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Current Location: " + Location);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet" ) ;
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres") ;
        }
    }
}
