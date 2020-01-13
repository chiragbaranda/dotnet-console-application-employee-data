/*
    Author : CHIRAG BARANDA
    Student ID: 000759867
    Date : 20-09-2018
    I, CHIRAG BARANDA, student number 000759867, certify that all code submitted is my own work; 
    that I have not copied it from any other source.  
    I also certify that I have not allowed my work to be copied by others.

    Program Description : This program takes Employee.txt file as an ipnut and raf the file.
                          Using sorting fnction this program  sort the data using different credentials.  
                          This Programs make use of a employee class.

     Refrence : For sorting algorithm :  http://rextester.com/discussion/VDVGG22680/Selection-Sort-Algorithm

*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{


    class Program
    {

        private static Employee[] employees = new Employee[100]; // stattic employee array to store the information form the text file
        private static int count; //statuc int count, store the number of index for the array

        static void Main(string[] args)
        {
            int ConsoleInput; //store user input from the console

            StreamReader file = new StreamReader("employees.txt"); //Read file data from the employee.txt
            string line; //declration of variable to store 

            while ((line = file.ReadLine()) != null) //reading file untill end of line
            {
                string[] data = line.Split(','); // split the data from ',' and store in data array

                employees[count] = new Employee(data[0], Convert.ToInt32(data[1].Trim()), Convert.ToDecimal(data[2].Trim()), Convert.ToDouble(data[3].Trim())); //store the data in employee array in sequence sucha as number, name, rate and hours

                //Console.WriteLine(employees[count]); //printing the data of array

                count++; //incresing the array count starting from zero to length of the file size
                
            }

            /*
            foreach (var element in employees)
            {
                Console.Write(" for each element.ToString() calling :");
                Console.Write($" {element}");

            }
            */

            
            


            do //do-while loop for user input as per menu selection and process
                {
                    Console.WriteLine("\nChoose any function below: \n");
                    Console.WriteLine("1.Sort by Employee Name (ascending) \n2.Sort by Employee Number (ascending) \n3.Sort by Employee Pay Rate (descending) \n4.Sort by Employee Hours (descending)  \n5.Sort by Employee Gross Pay (descending)  \n6.Exit");

                    Console.WriteLine("Enter Your Choice:");
                    ConsoleInput = int.Parse(Console.ReadLine()); //take user input 

                    switch (ConsoleInput) //switch case for user's selection
                    {
                        case 1: // case 1 to Sort by Employee Name (ascending)
                                Console.WriteLine("*******Case 1: Sort by Employee Name (ascending)*******");
                        //function1

                        for (int x = 0; x < count; x++)
                        {

                            int min_index = x;
                            for (int y = x; y < count; y++)
                            {

                               /* if (employees[min_index].GetName() > employees[y].GetName())
                                {
                                    min_index = y;
                                    //Console.WriteLine("MId index changed to :" + min_index);
                                }*/
                            }
                            var temp = employees[x];
                            employees[x] = employees[min_index];
                            employees[min_index] = temp;


                        }

                        Console.WriteLine("last value" + employees[13].GetNumber());



                        break;


                        case 2: //case 2 Sort by Employee Number (ascending)
                                Console.WriteLine("*******Case 2: Sort by Employee Number (ascending)*******");
                        //function 2

                        for (int x = 0; x < count; x++)
                        {
                            
                            int min_index = x; //assuming the minimim value is the initial value
                            for (int y = x; y < count; y++)
                            {
                                //looks for minimun amount of element 
                                if (Convert.ToInt32(employees[min_index].GetNumber()) > Convert.ToInt32(employees[y].GetNumber()))
                                {
                                    min_index = y;
                                    //Console.WriteLine("MId index changed to :" + min_index);
                                }
                            }
                            //swapping and putting the mimimim value to its proper location
                            var temp = employees[x];
                            employees[x] = employees[min_index];
                            employees[min_index] = temp;


                        }

                        Console.WriteLine("last value" + employees[13].GetNumber());

                        /* //printing sorted array
                         foreach (var element in employees)
                        {
                            Console.Write(" for each element.ToString() calling :");
                            Console.Write($" {element}");

                        }*/

                        break;
                        case 3: //case 3 Sort by Employee Pay Rate (descending)
                                Console.WriteLine("*******Case 3: Sort by Employee Pay Rate (descending)*******");
                                //function 3
                            break;
                        case 4: //case 4 Sort by Employee Hours (descending)
                                Console.WriteLine("*******Case 4: Sort by Employee Hours (descending)*******");
                                //fnction 4
                            break;
                        case 5: // case 5 Sort by Employee Gross Pay (descending)
                                Console.WriteLine("*******Case 5: Sort by Employee Gross Pay (descending)*******");
                                //function 5
                            break;
                        case 6: //case 6 if user input 6, program will exit the loop
                                Console.WriteLine("Exiting the program.....");
                                //exit();
                            break;
                        default: //default case, if user input anything else rather than 1 to 6
                                 Console.WriteLine("*******Invalid Input! Please Try Again!!*******");
                            break;
                    }//end ofswitch case

             } while (!(ConsoleInput == 6)); //end of do-while loop

                Console.WriteLine("Thanks for using Application!!");
         }//end of main method


    }//end of class program

} //end of namespace lab1
