using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{   //Liam Sullivan Student ID: 30022060
    class Salary
    {

        private double annual;
        private double weekly;

        public double Annual { get { return annual; } set { annual = value; } }
        public double Weekly { get { return weekly; } set { weekly = value; } }

        public Salary(double _annual, double _weekly)
        {
            Annual = _annual;
            Weekly = _weekly;
        }
        public string Income()
        {
            return "\nYour yearly income is: $" + Annual + "\nYour weekly income is: $" + Weekly;

        }


    }

    class Wage
    {
        private double hourly;
        private int num;
        private double weeklywages;

        public double Hourly { get { return hourly; } set { hourly = value; } }
        public int Num { get { return num; } set { num = value; } }
        public double Weeklywages { get { return weeklywages; } set { weeklywages = value; } }

        public Wage(double _hourly, int _num, double _weeklywages)
        {
            Hourly = _hourly;
            Num = _num;
            Weeklywages = _weeklywages;

        }

        public string Wages()
        {
            return "\nYour wages per week: $" + Weeklywages;
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            double annual = 80000; //Set yearly income 
            double weekly = 33.72; //Set weekly income
            double hourly = 33.72;


            Console.WriteLine("****PAYROLL INFO****\n--------------------");
            Console.WriteLine("Welcome to the staff Payroll System. \nEnter 1 to display Salary.\nEnter 2 to display Wages.");
            int option = int.Parse(Console.ReadLine());

            
                
                Salary salary1 = new Salary(annual, weekly);
                if (option == 1)

                Console.WriteLine(salary1.Income()); //Displays Weekly and Annual Income

            else if (option == 2)
            { 
                
                    Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nThis prog will calculate your weekly wages. \nPlease enter number of hours worked per week: ");
                int num = int.Parse(Console.ReadLine()); //Hours worked
                double weeklywages = hourly * num; //Multiplies hourly wage by hours worked
                Console.WriteLine($"Your Weekly wage is: ${weeklywages}");  //Displays Income for hours worked per week
            }
                else
                Console.WriteLine("ERROR INVALID INPUT. CLOSING...");
                Console.ReadLine();
              
            

        }
    }
}