using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

public partial class my_row
{
    public string name, surname;
    public int exam;
    public List<int> homework;
    public double avg, median;
    public double final;
    public my_row() {  }
/*    public my_row(string e1, string e2, int e3, List<int> e4, double e5, double e6, double e7) {
        name = e1; surname=e2; exam=e3; homework=e4; avg = e5; median=e6; final=e7; }
        */

    public  double to_av() {
            
            return (double)(homework.Sum())/homework.Count();
        }
    public float to_med()
    { int i = 0;
        homework.Sort();
        if (homework.Count() % 2 == 1) i = homework[(int)(homework.Count() / 2 + 1)];
         else  i = (homework[(int)(homework.Count() / 2 + 1)]+homework[(int)(homework.Count() / 2 )])/2;
        return i;

    }

   };
namespace Task3_4




{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int n, t=10;
            Console.WriteLine("Please write how many rows you have: ");
            n = int.Parse(Console.ReadLine());
            my_row [] my_data = new my_row[n];
            
            
            for (int i = 0; i < n; i++)
            {   
            my_data[i] = new my_row();
            my_data[i].homework=new List<int>();
                WriteLine("Please write {0} input name ", (i+1));
                my_data[i].name= Console.ReadLine();
                Console.WriteLine("Please input surname: ");
                my_data[i].surname = Console.ReadLine();

                Console.WriteLine("Please input Homework Mark: ");
                my_data[i].homework.Clear();
                WriteLine("Input HW marks manualy or generate them? M/\'any simbol\'");
                if (Convert.ToChar(Console.ReadLine()) == 'M')
                {
                    t = 1;
                    while (t != 0)
                    {
                        t = Convert.ToInt32(Console.ReadLine());
                        if (t != 0 && t < 11) my_data[i].homework.Add(t);
                    }
                    Console.WriteLine("Please input Exam Mark: ");
                    my_data[i].exam = int.Parse(Console.ReadLine());
                }
                else {
                    WriteLine("How many HW marks You want to generate?");
                    int b = Convert.ToInt32(Console.ReadLine());
                    for (int bi=0;bi<b;bi++)
                    {
                        t = random.Next(1, 11);
                        if (t != 0 && t < 11) my_data[i].homework.Add(t);
                    }
                    my_data[i].exam = random.Next(1, 11);
                }


                my_data[i].avg = my_data[i].to_av();
                my_data[i].median= my_data[i].to_med();
                my_data[i].final = my_data[i].avg * 0.3 + my_data[i].exam * 0.7;
               

            }

            foreach (var a in my_data) 
                Console.WriteLine("Name: {0}| surname: {1}| Exam: {2}| Average {3:N2} | Median {4} | Final {5}  ",a.name ,a.surname,a.exam ,a.avg ,a.median, a.final);

            
            Console.ReadKey();

        }
    }
}







