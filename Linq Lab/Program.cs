using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3964, 2942, 50 };

            List<Students> students = new List<Students>();
            students.Add(new Students("Jimmy", 13));
            students.Add(new Students("Hannah Banana", 21));
            students.Add(new Students("Justin", 30));
            students.Add(new Students("Sarah", 53));
            students.Add(new Students("Hannibal", 15));
            students.Add(new Students("Philip", 16));
            students.Add(new Students("Maria", 63));
            students.Add(new Students("Abe", 33));
            students.Add(new Students("Curtis", 10));

            //for nums:
            //Method syntax is commented out but works.
            Console.WriteLine("NUMS QUESTIONS\n");

            double Q1 = nums.Min();
            Console.WriteLine("question 1n: " + Q1);
            Console.WriteLine();

            double Q2 = nums.Max();
            Console.WriteLine("question 2n: " + Q2);
            Console.WriteLine();

            double Q3 = (from x in nums where x < 10000 select x).Max();
            Console.WriteLine("question 3n: " + Q3);
            Console.WriteLine();

            //METHOD SYNTAX IS COMMENTED OUT
            //double Q3M = nums.Where(x => x < 10000).Max();
            //Console.WriteLine(Q3M);

            Console.WriteLine("Question 4n:");
            int[] Q4 = (from x in nums where x > 10 && x < 100 select x).ToArray();
            foreach (int num in Q4)
            {
                Console.WriteLine(num );
            }
            Console.WriteLine();

            //METHOD SYNTAX IS COMMENTED OUT
            //int[] Q4M = nums.Where(x => x > 10 && x < 100).ToArray();
            //foreach (int num in Q4M)
            //{
            //    Console.WriteLine(num);
            //}

            Console.WriteLine("Question 5n:");
            int[] Q5 = (from x in nums where x >= 100000 && x <= 999999 select x).ToArray();
            foreach(int num in Q5)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //METHOD SYNTAX IS COMMENTED OUT
            //int[] Q5M = nums.Where(x => x >= 100000 && x <= 999999).ToArray();
            //foreach (int num in Q5M)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();

            Console.WriteLine("Question 6n:");
            int[] Q6 = (from x in nums where x % 2 == 0 select x).ToArray();
            foreach(int num in Q6)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //METHOD SYNTAX IS COMMENTED OUT
            //int[] Q6M = nums.Where(x => x % 2 == 0).ToArray();
            //foreach (int num in Q6M)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();

            //for students:
            Console.WriteLine("STUDENTS QUESTIONS\n");

            Console.WriteLine("Question 1s:");
            List <Students> Q7 = (from student in students
                                where student.Age >= 21
                                select student).ToList();
            PrintStudentsList(Q7);
            Console.WriteLine();

            //METHOD SYNTAX IS COMMENTED OUT
            //List<Students> Q7M = students.Where(x => x.Age >= 21).ToList();
            //PrintStudentsList(Q7M);

            Console.WriteLine("Question 2s:");
            Students Q8 = students.OrderByDescending(x => x.Age).FirstOrDefault();
            Console.WriteLine(Q8.Name + ", "+ Q8.Age);
            Console.WriteLine();

            Console.WriteLine("Question 3s:");
            Students Q9 = students.OrderByDescending(x => x.Age).Last();
            Console.WriteLine(Q9.Name + ", " + Q9.Age);
            Console.WriteLine();

            Console.WriteLine("Question 4s:");
            Students Q10 = (from stu in students
                           where stu.Age < 25
                           select stu).ToList().OrderByDescending(x => x.Age).FirstOrDefault();
            //Students s = Q10.OrderByDescending(x => x.Age).FirstOrDefault();
            //this line above is the last 2 methods of the Q10 line so this wasnt needed but im keeping
            //here just so I can read the line
            Console.WriteLine(Q10.Name + ", " + Q10.Age);
            Console.WriteLine();

            //METHOD SYNTAX IS COMMENTED OUT
            //Students Q10M = students.Where(x => x.Age < 25).OrderByDescending(x => x.Age).FirstOrDefault();
            //Console.WriteLine(Q10M.Name + ", " + Q10M.Age);

            Console.WriteLine("Question 5s:");
            List<Students> Q11 = (from stu in students
                                  where stu.Age > 21 && stu.Age % 2 == 0
                                  select stu).ToList();
            PrintStudentsList(Q11);
            Console.WriteLine();

            //METHOD SYNTAX IS COMMENTED OUT
            //List<Students> Q11M = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            //PrintStudentsList(Q11M);

            Console.WriteLine("Question 6s:");
            List<Students> Q12 = (from stu in students
                                  where stu.Age >= 13 && stu.Age <= 19
                                  select stu).ToList();
            PrintStudentsList(Q12);
            Console.WriteLine();

            //METHOD SYNTAX IS COMMENTED OUT
            //List<Students> Q12M = students.Where(x => x.Age >= 13 %% x.Age <= 19).ToList();
            //PrintStudentsList(Q12M);

            //is there a way to do this without having to list out all the vowels?
            //i tried putting them into a char[] then calling them in a foreach loop but that caused
            //all sorts of problems
            Console.WriteLine("Question 7s:");
            List<Students> Q13 = (from stu in students
                                  where stu.Name.StartsWith('A') || 
                                  stu.Name.StartsWith('E') || 
                                  stu.Name.StartsWith('I') || 
                                  stu.Name.StartsWith('O') || 
                                  stu.Name.StartsWith('U')
                                  select stu).ToList();
            PrintStudentsList(Q13);

            //METHOD SYNTAX IS COMMENTED OUT
            //List<Students> Q13M = students.Where(x => x.Name.StartsWith('A') ||
            //                      x.Name.StartsWith('E') ||
            //                      x.Name.StartsWith('I') ||
            //                      x.Name.StartsWith('O') ||
            //                      x.Name.StartsWith('U')).ToList();
            //PrintStudentsList(Q13M);
        }

        public static void PrintStudentsList(List<Students> students)
        {
            foreach(Students stu in students)
            {
                Console.WriteLine(stu.Name+ ", " + stu.Age);
            }
        }
    }
}
