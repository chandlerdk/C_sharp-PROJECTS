using System;
using static System.Console;

namespace Final_Project
{
    internal class Program
    {
        public static double[,] tArray = new double[3, 10];

/*Main method: uses switch case for menu selection, counter for data entries, while loops,
 *     and all other methods within the program*/
        static void Main(string[] args)
        {
            //Declare main variables
            int calculationCounter = 0;
            int userSelection = 0;
            double fTempInput;
            string escapeSent;

            //Main loop logic structure
            showMenu();
            userSelection = validateSelection();
            while (calculationCounter < 10 & userSelection < 4)
            {
                switch (userSelection)
                {
                    case 1:
                        WriteLine("Entries allowed = 10, This is entry #{0}\n", calculationCounter + 1);
                        fTempInput = validateTemp();
                        showCelsius(fTempInput, calculationCounter);
                        calculationCounter++;
                        break;
                    case 2:
                        WriteLine("Entries allowed = 10, This is entry #{0}\n", calculationCounter + 1);
                        fTempInput = validateTemp();
                        showKelvin(fTempInput, calculationCounter);
                        calculationCounter++;
                        break;
                    case 3:
                        displayData(tArray);
                        break;
                }
                showMenu();
                userSelection = validateSelection();
               
            }
            WriteLine("Either temp max(10) data entries reached or you chose to shut down" +
                "the program. Do you wish to see the data before you leave?");
            WriteLine("Type 'y' to see data, anything else will close program..");
                escapeSent = ReadLine();
            while (escapeSent == "y")
            {
                WriteLine("");
                displayData(tArray);
                WriteLine("");
                WriteLine("Type 'y' to see data, anything else will close program..");
                escapeSent = ReadLine();
            }
            WriteLine("Goodbye");
/*Method to display stored temperature data array*/
            static void displayData(double[,] A)
            {
                WriteLine("Data entered:");
                double[,] array = A;
                WriteLine("Farenheit: ");
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    var val = array[0, i];
                    string tempVal = val.ToString("0.##");
                    Write("\t{0}", tempVal);
                }
                WriteLine("\nCelsius: ");
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    var val = array[1, i];
                    string tempVal = val.ToString("0.##");
                    Write("\t{0}", tempVal);
                }
                WriteLine("\nKelvin:");
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    var val = array[2, i];
                    string tempVal = val.ToString("0.##");
                    Write("\t{0}", tempVal);
                }
            }

/*Method to display menu*/
            static void showMenu()
            {
                    WriteLine("\nSelect one of the following options:\n  1.\tConvert" +
                            " Fahrenheit to Celsius (Centigrade)\n  2.	Convert Fahrenheit to Kelvin\n" +
                            "  3.	Display Data\n  4.	Quit Program\n\nEnter your choice: ");
            }

 /*Method to calculate, store, and display Farenheit to Celsius data*/   
            static void showCelsius(double fTemp, int index)
            {
                double temp = fTemp;
                double cTemp = (temp - 32) * 5 / 9;
                double kTemp = cTemp + 273.15;
                WriteLine("\t{0} °Farenheit = {1} °Celsius", fTemp, cTemp);
                int a = index;
                tArray[0, a] = fTemp;
                tArray[1, a] = cTemp;
                tArray[2, a] = kTemp;
            }

 /*Method to calculate, store, and display Farenheit to Kelvin data*/
            static void showKelvin(double fTemp, int index)
            {
                double temp = fTemp;
                double cTemp = (temp - 32) * 5 / 9;
                double kTemp = cTemp + 273.15;
                WriteLine("\t{0} °Farenheit = {1} Kelvin", fTemp, kTemp);
                int a = index;
                tArray[0, a] = fTemp;
                tArray[1, a] = cTemp;
                tArray[2, a] = kTemp;
            }

/*Method to validate user selection is valid string input which can be 
 * converted to numerical value*/
            static int validateSelection()
            {
                int userSelection;
                try
                {
                    string strgInput = ReadLine();
                    userSelection = Convert.ToInt32(strgInput);
                    return userSelection;
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                    return 0;
                }
                finally
                {
                    userSelection = 0;
                }

            }

 /*Method to validate temperature input by checking string value can be
  * converted to valid numerical value and checking that
            the temp given is above 0 Kelvin*/
            static double validateTemp()
            {
                double fInput;
                try
                {
                    WriteLine("Enter a Fahrenheit temperature: ");
                    string strgInput = ReadLine();
                    fInput = Convert.ToDouble(strgInput);
                    if (fInput < -459.67)
                    {
                        WriteLine("Temperature must be above 0 Kelvin(-459.67°F)" +
                            "..try again.");
                        strgInput = ReadLine();
                        fInput = Convert.ToDouble(strgInput);
                        return fInput;
                    }
                    else
                    {
                        return fInput;
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message + "Try again...");
                    string strgInput = ReadLine();
                    fInput = Convert.ToDouble(strgInput);
                    if (fInput < -459.67)
                    {
                        WriteLine("Temperature must be above 0 Kelvin(-459.67°F)" +
                            "..try again.");
                        strgInput = ReadLine();
                        fInput = Convert.ToDouble(strgInput);
                        return fInput;
                    }
                    else
                    {
                        return fInput;
                    }
                }
                finally
                {
                    fInput = 0;
                }
            } 
        }
    }
}
