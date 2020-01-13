/*
    Author : CHIRAG BARANDA
    Student ID: 000759867
    Date : 20-09-2018
    I, CHIRAG BARANDA, student number 000759867, certify that all code submitted is my own work; 
    that I have not copied it from any other source.  
    I also certify that I have not allowed my work to be copied by others.

    Program Description : This program is employee class.

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Employee class, contains private variable and public methods
    /// </summary>
    class Employee
    {
        private string name; 
        private int number; 
        private Decimal rate; 
        private double hours; 
        private Decimal gross; 


        /// <summary>
        /// employee construor , set the varialbe value from the parameter values and calculate the gross values 
        /// </summary>
        /// <param name="name"> employee name</param>
        /// <param name="number">employee number</param>
        /// <param name="rate">employee pay rate</param>
        /// <param name="hours">employe work hours</param>
        public Employee(string name, int number, Decimal rate, double hours) 
        {
            //set parameter values to the class variable using this
            this.name = name; 
            this.number = number;
            this.rate = rate;
            this.hours = hours;
            if (hours < 40.0)
                this.gross = (Decimal)hours * rate;
            else
                this.gross = Convert.ToDecimal(hours * 1.5) * rate ;
        } //end of constructor

        /// <summary>
        /// Respond on call GetGross() from any Employee class element
        /// </summary>
        /// <returns> decimal Gross</returns>
        public decimal GetGross()
        {
            return gross;
        }

        /// <summary>
        /// Respond on call GetHours() from any Employee class element
        /// </summary>
        /// <returns>Double hours</returns>
        public double GetHours()
        {
            return hours;
        }

        /// <summary>
        /// Respond on call GetName() from any Employee class element
        /// </summary>
        /// <returns>String name</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Respond on call GetNumber() from any Employee class element
        /// </summary>
        /// <returns>int number</returns>
        public int GetNumber()
        {
            return number;
        }

        /// <summary>
        /// Respond on call GetRate() from any Employee class element
        /// </summary>
        /// <returns>decimal rate</returns>
        public decimal GetRate()
        {
            return rate;
        }

        /// <summary>
        /// Respond on call ToString() from any Employee class element
        /// </summary>
        /// <returns>Output String combining all the employee class data as required</returns>
        public string Tostring()
        {
            return "Employee              Number    Rate  Hours  Gross Pay \n" +
                    "====================  ======  ======  =====  =========  \n " +
                    " " + GetName() + GetNumber() + GetRate() + GetHours() + GetGross() + "";                                                 ;
        }

        /// <summary>
        /// Recieve data on call SetHours() from any Employee class element and set parameter 'hours' value to local variable to hours
        /// </summary>
        /// <param name="hours"></param>
        public void SetHours(double hours)
        {
            this.hours = hours;
        }

        /// <summary>
        /// Recieve data on call SetName() from any Employee class element and set parameter value 'name' to local variable to name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }


        /// <summary>
        /// Recieve data on call SetNumber() from any Employee class element and set parameter 'number' value to local variable to number
        /// </summary>
        /// <param name="number"></param>
        public void SetNumber(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// Recieve data on call SetRate() from any Employee class element and set parameter value 'rate' to local variable root
        /// </summary>
        /// <param name="rate"></param>
        public void SetRate(decimal rate)
        {
            this.rate = rate;
        }
    }
}
