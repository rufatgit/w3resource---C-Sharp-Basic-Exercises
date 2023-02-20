using System;
using System.Collections.Generic;
using System.Text;


namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*        Console.WriteLine("Hello World!");

                    Console.WriteLine(15+15);
                    Console.WriteLine(15/5);
                    Console.WriteLine(-1+4*6);
                    Console.WriteLine((35+5)%7);
                    Console.WriteLine(14+(-4)*6/11);
                    Console.WriteLine(2+15/6*1-7%2);

                    //EX5
                    Console.WriteLine("Input the first number:");
                    double a=double.Parse(Console.ReadLine());
                    Console.WriteLine("Input the second number");
                    double b=double.Parse(Console.ReadLine());

                    double tmp;
                    tmp = a;
                    a = b;
                    b = tmp;
                    Console.WriteLine("a- "+a);
                    Console.WriteLine("b- "+b);
        */

            /*
                        //EX6
                        Console.WriteLine("1st factor to multiply:");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine("2nd factor to multiply:");
                        double d = double.Parse(Console.ReadLine());
                        Console.WriteLine("3rd factor to multiply:");
                        double e = double.Parse(Console.ReadLine());

                        double product = c * d * e;

                        Console.WriteLine("Product is "+product);
            */
            /*
                        //EX7
                        Console.WriteLine("First number:");
                        double a=double.Parse(Console.ReadLine());
                        Console.WriteLine("First number:");
                        double b = double.Parse(Console.ReadLine());

                        double addition = a + b;
                        double subtraction = a - b;
                        double multiplication = a * b;
                        double divison = a / b;
                        double remainder = a % b;

                        Console.WriteLine("{0} + {1} = {2}", a,b,addition);
                        Console.WriteLine("{0} - {1} = {2}", a, b, subtraction);
                        Console.WriteLine("{0} x {1} = {2}", a, b, multiplication);
                        Console.WriteLine("{0} / {1} = {2}", a, b, divison);
                        Console.WriteLine("{0} % {1} = {2}", a, b, remainder);
            */


            //EX8
            /*
                        Console.WriteLine("Enter the number to see its multiplication table:");
                        double input=double.Parse(Console.ReadLine());

                        for(int i=0;i<=10;i++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", input, i, input*i);
                        }
            */

            /*            //EX9
                        Console.WriteLine("Enter 4 numbers to calculate their average:");
                        string input = Console.ReadLine();


                        List<double> list = new List<double>();


                        foreach (string s in input.Split(' '))
                        {
                            list.Add(double.Parse(s));
                        }

                        double sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }

                        sum = sum / list.Count;
                        Console.Write("The average of ");
                        for (int i = 0; i < list.Count; ++i)
                        {
                            if (i == list.Count - 1)
                            {
                                Console.Write(list[i] + " ");
                            }
                            else
                            {
                                Console.Write(list[i] + ", ");

                            }
                        }
                        Console.Write("is: " + sum);

            */

            //EX10
            /*
                        Console.WriteLine("Enter 3 numbers: ");
                        double x = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter 3 numbers: ");
                        double y = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter 3 numbers: ");
                        double z = double.Parse(Console.ReadLine());

                        double sm = (x + y) * z;
                        double msm = x * y + y * z;
                        Console.Write("Specified numbers are {0},{1} and {2}, ({0} + {1})*{2} is ", x, y, z);
                        Console.Write(sm + " and {0}*{1}+{1}*{2}", x, y, z);
                        Console.Write(" is " + msm);
            */

            //EX11
            /*
                        Console.WriteLine("Write your age:");
                        string input = Console.ReadLine();




                        try
                        {
                            if (int.Parse(input) < 0 || int.Parse(input) > 120)
                            {
                                Console.WriteLine("input is out of age range.");
                            }
                            else
                            {
                                Console.WriteLine("You look older than " + input);

                            }
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine("Message: " + err.Message);
                            Console.WriteLine("Stack Trace: " + err.StackTrace);
                        }
            */

            //EX12
            /*
                        Console.WriteLine("Enter number for dummy exercise:");
                        double input = double.Parse(Console.ReadLine());

                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("{0} {0} {0} {0}", input);
                            Console.WriteLine("{0}{0}{0}{0}", input);
                        }
            */

            //EX13-dummy

            //EX14
            /*
                        Console.WriteLine("Enter celcius degree:");
                        double c= double.Parse(Console.ReadLine());

                        double f = (c * 9 / 5) + 32;
                        double k = c + 273.15;

                        Console.WriteLine("From celcius to kelvin: "+k);
                        Console.WriteLine("From celcius to fahrenheit: "+f);
            */

            //EX15
            /*
                        Console.WriteLine("Input string:");
                        string i=Console.ReadLine();
                        Console.WriteLine("Enter index number to delete specified character: ");
                        int index=int.Parse(Console.ReadLine());

                        try
                        {
                            Console.WriteLine(">>" + i.Remove(index, 1));
                        }
                        catch(Exception err)
                        {
                            Console.WriteLine("Message: "+err.Message);
                        }
            */

            //EX16
            /*
                        Console.WriteLine("Enter string to swap its first and last characters.");
                        string input = Console.ReadLine();

                        StringBuilder sb = new StringBuilder();

                        foreach (char s in input)
                        {
                            sb.Append(s);  
                        }


                        char tmp = sb[0];
                        sb[0] = sb[sb.Length - 1];
                        sb[sb.Length - 1] = tmp;

                        Console.WriteLine(sb);

            */

            /*           //EX17

                       Console.WriteLine("Enter string to add its first character at the front and back: ");
                       string input = Console.ReadLine();

                       if (input.Length > 1)
                       {

                           StringBuilder sb = new StringBuilder();
                           sb.Append(input[0]);

                           foreach (char c in input)
                           {
                               sb.Append(c);
                           }

                           sb.Append(input[0]);

                           Console.WriteLine(sb);
                       }
                       else
                       {
                           Console.WriteLine("Input length should be bigger than 1.");
                       }

                       if (input.Length > 1)
                       {

                           string c = input.Substring(0, 1);
                           Console.WriteLine(c + input + c);
                       }
                       else
                       {
                           Console.WriteLine("Input length should be bigger than 1.");
                       }

           */

            //EX18
            /*            Console.WriteLine("Enter two integers:");
                        double i=Convert.ToDouble(Console.ReadLine());
                        double j=Convert.ToDouble(Console.ReadLine());
                        bool ij=true;
                        if(i>0 && j<0 || i < 0 && j > 0)
                        {
                            Console.WriteLine(ij);
                        }
                        else
                        {
                            ij=false;
                            Console.WriteLine(ij);
                        }
                        Console.WriteLine((i > 0 && j < 0 || i < 0 && j > 0));
            */


            /*          //EX19
                      Console.WriteLine("Enter two integers:");
                      double a=double.Parse(Console.ReadLine());
                      double b = double.Parse(Console.ReadLine());

                      if(a==b)
                      {
                          Console.WriteLine("Triple of their sum: "+3*(a+b));
                      }
                      else
                      {
                          Console.WriteLine("Sum: "+(a+b));
                      }

          */
            /*
                        //EX20
                        Console.WriteLine("Enter two numbers:");
                        double a=double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());

                        double abs =Math.Abs(a - b);
                        if((a-b)<0)
                        {
                            Console.WriteLine("Absolute value is "+abs);
                        }
                        else
                        {
                            Console.WriteLine("Absolute value is abs+abs= "+2*abs);
                        }
            */

            //EX21
            /*
                        Console.WriteLine("Enter two numbers:");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());

                        Console.WriteLine(a == 20 || b == 20 || a + b == 20);
            */

            //EX22
            /*
                        Console.WriteLine("Enter two numbers");
                        int a = int.Parse(Console.ReadLine());
                        bool b = true;
                        if (Math.Abs(a - 100) <= 20 || Math.Abs(a - 200) <= 20)
                        {
                            Console.WriteLine(b);
                        }
                        else
                        {
                            b = false;
                            Console.WriteLine(b);
                        }
            */

            //EX23
            /*
                        Console.WriteLine("Input string:");
                        string input=Console.ReadLine();

                        Console.WriteLine(input.ToLower());
            */

            //EX24
            /*
                        Console.WriteLine("Input string");
                        string input=Console.ReadLine();

                        string[] array = input.Split(' ');

                        foreach(string s in array)
                        {
                            Console.WriteLine(s);
                        }

                        string max="1";

                        for(int i=0; i<array.Length; ++i)
                        {
                            if(array[i].Length > max.Length)
                            {
                                max = array[i];
                            }
                        }

                        Console.WriteLine("Longest word is "+max);

            */

            //EX25
            /*
                        for(int i=0; i<100; ++i)
                        {
                            if(i%2==1)
                            {
                                Console.WriteLine(i);
                            }
                        }
            */

            //EX26

            int sum = 0;
            int n = 2;
            for(int i=0; i<500; )
            {
                if(Prime(n))
                {
                    //Console.WriteLine(i);
                    sum += n;
                    ++i;
                }
                ++n;
            }

            Console.WriteLine("Sum of the first 500 prime numbers:");
            Console.WriteLine(sum);






        }

        public static bool Prime(int i)
        {
            int x=(int)Math.Floor(Math.Sqrt(i));

            if(i==1) return false;
            if(i==2) return true;

            for(int j=2; j<=x; j++)
            {
                if(i%j==0)
                {
                    return false;
                }
            }


            return true;

        }




    }
}
