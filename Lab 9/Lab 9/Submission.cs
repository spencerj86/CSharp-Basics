using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Submission
    {
        public static Student[] enrollment = new Student[0];

        public static Student Test1(string last, string first, int idNo)
        {
            Student s1 = new Student(last, first, idNo);
            return s1;
        }

        public static Student Test2()
        {
            Student s1 = new Student();
            return s1;
        }

        public static bool Test3(Student enrolled)
        {
            bool test = false;
            for (int ndx = 0; ndx < enrollment.Length; ndx++)
            {
                if (enrollment[ndx] == null)
                {
                    enrollment[ndx] = enrolled;
                    test = true;
                    break;
                }
            }
            return test;
        }

        public static bool Test4(int idNumber)
        {
            bool success = true;
            for (int ndx = 0; ndx < enrollment.Length; ndx++)
            {
                if (enrollment[ndx] != null && enrollment[ndx].GetIDNumber() == idNumber)
                {
                    enrollment[ndx] = null;
                    success = false;
                    break;
                }
            }
            return success;
        }

        public static Student Test5(int idNumber)
        {
            Student s1 = null;
            for (int ndx = 0; ndx < enrollment.Length; ndx++)
            {
                if (enrollment[ndx] != null && enrollment[ndx].GetIDNumber() == idNumber)
                {
                    s1 = enrollment[ndx];
                    break;
                }
            }
            return s1;
        }
    }
}
