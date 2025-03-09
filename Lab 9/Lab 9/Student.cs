using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Student
    {
        // Add member fields here
        private string firstName;
        private string lastName;
        private int idNumber;

        // Add default and overloaded constructors here
        public Student(string last, string first, int idNo)
        {
            firstName = first;
            lastName = last;
            idNumber = idNo;
        }
        public Student()
        {
            firstName = "";
            lastName = "";
            idNumber = 1000000;
        }


        // add Getters and Setters here
        
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public int GetIDNumber()
        {
            return idNumber;
        }
        public void SetFirstName(string first)
        {
            firstName = first;
        }
        public void SetLastName(string last)
        {
            lastName = last;
        }
        public void SetIDNumber(int idNo)
        {
            idNumber = idNo;
        }



        

        





















/******************************************************************************************************
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                      do not modify any of the following code                                        *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
******************************************************************************************************/
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + ", " + GetFirstName();
        }

        public override bool Equals(object obj)
        {
            bool same = true;
            Student s2 = (Student)obj;
            if (this.GetLastName() != s2.GetLastName() || this.GetFirstName() != s2.GetFirstName() || this.GetIDNumber() != s2.GetIDNumber())
            {
                same = false;
            }
            return same;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
