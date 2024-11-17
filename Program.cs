using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms_grade_calculator_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sophia1 = 93;
            int Sophia2 = 87;
            int Sophia3 = 98;
            int Sophia4 = 95;
            int Sophia5 = 100;

            int Nicolas1 = 80;
            int Nicolas2 = 83;
            int Nicolas3 = 82;
            int Nicolas4 = 88;
            int Nicolas5 = 85;

            int Zahirah1 = 84;
            int Zahirah2 = 96;
            int Zahirah3 = 73;
            int Zahirah4 = 85;
            int Zahirah5 = 79;

            int Jeong1 = 90;
            int Jeong2 = 92;
            int Jeong3 = 98;
            int Jeong4 = 100;
            int Jeong5 = 97;
        
            int totalSubject = 5;

            int totalSophia = Sophia1 + Sophia2 + Sophia3 + Sophia4 + Sophia5;
            int totalNicolas = Nicolas1 + Nicolas2 + Nicolas3 + Nicolas4 + Nicolas5;
            int totalZahirah = Zahirah1 + Zahirah2 + Zahirah3 + Zahirah4 + Zahirah5;
            int totalJeong = Jeong1 + Jeong2 + Jeong3 + Jeong4 + Jeong5;

            decimal sophiaGrade = totalSophia/totalSubject;
            decimal nicolasGrade = totalNicolas / totalSubject;
            decimal zahirahGrade = totalZahirah / totalSubject;
            decimal jeongGrade = totalJeong / totalSubject;

            Console.WriteLine("Student\t\tGrade");
            Console.WriteLine("Sophia\t\t"+sophiaGrade+"\tA");
            Console.WriteLine("Nicolas\t\t" + nicolasGrade + "\tB");
            Console.WriteLine("Zahirah\t\t" + zahirahGrade + "\tB");
            Console.WriteLine("Jeong\t\t" + jeongGrade + "\tA");

        }
    }
}
