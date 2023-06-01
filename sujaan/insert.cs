using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sujaan
{
    internal class insert
    {
        string z, div;

        enum Choice
        {
            Roll,
            Name,
            Marks_of_NCC,
            Marks_of_CDC,
            Marks_of_SE



        }
        public void Data()
        {
            // This will create a file named sample.txt
            // at the specified location 
            // StreamWriter sw = new StreamWriter(@"D:\suuuu\sujaan\roll.txt");




            // To write on the console screen


            Console.WriteLine("1. Add new record \t 2. Return to list");

            // To read the input from the user
            int input = int.Parse(Console.ReadLine());


            if (input == 1)
            {

                Choice obj2 = Choice.Roll;
                Console.WriteLine(obj2);
                String stroll = Console.ReadLine();
                // save input provides bu user into file.
                // sw.WriteLine("Roll: " + stroll);

                Choice obj3 = Choice.Name;
                Console.WriteLine(obj3);
                String stname = Console.ReadLine();
                // sw.WriteLine("Name: " + stname);

                Choice obj4 = Choice.Marks_of_NCC;
                Console.WriteLine(obj4);
                int stncc = int.Parse(Console.ReadLine());
                //   sw.WriteLine("Marks in NCC: " + stncc);

                Choice obj5 = Choice.Marks_of_CDC;
                Console.WriteLine(obj5);
                int stcdc = int.Parse(Console.ReadLine());
                //  sw.WriteLine("Marks in CDC: " + stcdc);

                Choice obj6 = Choice.Marks_of_SE;
                Console.WriteLine(obj6);
                int stse = int.Parse(Console.ReadLine());
                //   sw.WriteLine("Marks in SE" + stse);
                // total
                int total = stncc + stcdc + stse;
                Console.WriteLine("Total marks = " + total);
                //sw.WriteLine("Total Marks: " + total);



                //Percentage

                float per = (float)(total * 0.56);
                Console.WriteLine("Perentage = " + per);
                // sw.WriteLine("Percentage = " + per);

                //grade

                if (per >= 60)
                    div = "First";
                else
               if (per < 60 && per >= 50)
                    div = "Second";
                else
                  if (per < 50 && per >= 40)
                    div = "Third";
                else
               if (per < 40 && per >= 32)
                    div = "Pass";
                else
                    div = "Fail";
                Console.Write("Division = {0}\n", div);

                //  sw.WriteLine("Grade = " + div);

                var formattedString = $"{stroll}||{stname}||{stncc}||{stcdc}||{stse}||{total}||{per}||{div}";
                // sw.WriteLine(formattedString);
                File.AppendAllText(@"D:\suuuu\sujaan\roll.txt", formattedString);


                Console.WriteLine("Do you want to continue ? Yes or No");
                var ans = Console.ReadLine();

                if (ans == z)
                {
                    Data();
                }


            }

            else if (input == 2)
                try
                {
                    readdata();


                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");

                }
                finally
                {
                    readdata();
                }








            // To write a line in buffer
            // sw.WriteLine(input); 

            // To write in output stream
            //sw.Flush();

            // To close the stream
            // sw.Close();
        }

        public void readdata()
        {
            try
            {
                StreamReader sr = new StreamReader(@"D:\suuuu\sujaan\roll.txt");


                // This is use to specify from where 
                // to start reading input stream
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream
                string str = sr.ReadLine();

                // To read the whole file line by line
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();

                // to close the stream
                sr.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }





        }
    }
}
