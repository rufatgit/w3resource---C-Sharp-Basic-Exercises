
                    Console.WriteLine("Hello World!");

                    Console.WriteLine(15+15);
                    Console.WriteLine(15/5);
                    Console.WriteLine(-1+4*6);
                    Console.WriteLine((35+5)%7);
                    Console.WriteLine(14+(-4)*6/11);
                    Console.WriteLine(2+15/6*1-7%2);

                    //EX 5. Write a C# Sharp program to swap two numbers.
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
        

            
                        //EX 6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
                        Console.WriteLine("1st factor to multiply:");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine("2nd factor to multiply:");
                        double d = double.Parse(Console.ReadLine());
                        Console.WriteLine("3rd factor to multiply:");
                        double e = double.Parse(Console.ReadLine());

                        double product = c * d * e;

                        Console.WriteLine("Product is "+product);
            
           
                        //EX 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
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
            


            //EX 8. Write a C# Sharp program that takes a number as input and print its multiplication table.
            
                        Console.WriteLine("Enter the number to see its multiplication table:");
                        double input=double.Parse(Console.ReadLine());

                        for(int i=0;i<=10;i++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", input, i, input*i);
                        }
            

                        //EX 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
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

            

            //EX 10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            
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

            //EX 11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
            
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

            //EX 12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then
            //four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
            
                        Console.WriteLine("Enter number for dummy exercise:");
                        double input = double.Parse(Console.ReadLine());

                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("{0} {0} {0} {0}", input);
                            Console.WriteLine("{0}{0}{0}{0}", input);
                        }
            

            

            //EX 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            
                        Console.WriteLine("Enter celcius degree:");
                        double c= double.Parse(Console.ReadLine());

                        double f = (c * 9 / 5) + 32;
                        double k = c + 273.15;

                        Console.WriteLine("From celcius to kelvin: "+k);
                        Console.WriteLine("From celcius to fahrenheit: "+f);
            

            //EX 15. Write a C# program remove specified a character from a non-empty string using index of a character. 
            
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
            

            //EX 16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            
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

            

                       //EX 17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.

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

           

            //EX 18. Write a C# program to check two given integers and return true if one is negative and one is positive.
                        Console.WriteLine("Enter two integers:");
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
            


                      //EX 19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
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

          
            
                        //EX 20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the 
                        //difference if the first number is greater than second number.
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
            

            //EX 21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            
                        Console.WriteLine("Enter two numbers:");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());

                        Console.WriteLine(a == 20 || b == 20 || a + b == 20);
            

            //EX 22. Write a C# program to check if an given integer is within 20 of 100 or 200.
            
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
            

            //EX 23. Write a C# program to convert a given string into lowercase.
            
                        Console.WriteLine("Input string:");
                        string input=Console.ReadLine();

                        Console.WriteLine(input.ToLower());
            

            //EX 24. Write a C# program to find the longest word in a string.
            
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

            

            //EX 25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            
                        for(int i=0; i<100; ++i)
                        {
                            if(i%2==1)
                            {
                                Console.WriteLine(i);
                            }
                        }
            

            //EX 26. Write a C# program to compute the sum of the first 500 prime numbers.

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





