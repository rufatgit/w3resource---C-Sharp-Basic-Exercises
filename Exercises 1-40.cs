
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


//EX 30. Write a C# program to convert a hexadecimal number to decimal number.

            string hex = "5F";
            Console.WriteLine("Hexadecimal number: "+hex);
            int decimal_value=int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert  to-");
            Console.WriteLine("Decimal number: " + decimal_value);


//EX 31. Write a C# program to multiply corresponding elements of two arrays of integers.

            Console.WriteLine("Enter first array:");
            string input1 = Console.ReadLine();

            List<int> list1 = new List<int>();

            foreach (string s in input1.Split(' '))
            {
                list1.Add(int.Parse(s));
            }

            Console.WriteLine("Enter second array:");
            string input2 = Console.ReadLine();

            List<int> list2 = new List<int>();

            foreach (string s in input2.Split(' '))
            {
                list2.Add(int.Parse(s));
            }


            if (list1.Count == list2.Count)
            {
                List<int> product = new List<int>();

                for (int i = 0; i < list1.Count; i++)
                {
                    product.Add(list1[i] * list2[i]);
                }

                foreach (int i in product)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                Console.WriteLine("Array sizes should be same!");
            }



//EX 32. Write a C# program to create a new string of four copies, taking last four characters 
//from a given string. If the length of the given string is less than 4 return the original one.

            try
            {
                Console.WriteLine("Enter string to print out its last 4 characters");
                StringBuilder sb = new StringBuilder(Console.ReadLine());


                if(sb.Length >= 4) 
                {
                    string last4 = sb.ToString(sb.Length - 4, 4);
                    string s = last4 + last4 + last4 + last4;
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("String size should be bigger than or equal 4.");
                }
                

            }
            catch (Exception err)
            {
                Console.WriteLine("Message: "+err.Message);
                Console.WriteLine("Stack trace: "+err.StackTrace);
            }



//EX 33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.


            Console.WriteLine("Enter positive integer");
            int input=int.Parse(Console.ReadLine());
            int inp3 = input % 3;
            int inp2 = input % 7;

            if (input > 0)
            {
                if (inp3 == 0 || inp2 == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else
            {
                Console.WriteLine("Should be greater than 0");
            }
           




//EX 34. Write a C# program to check if a string starts with a specified word. 

            Console.WriteLine("Enter sentence: ");
            string input = Console.ReadLine();

            if (input.StartsWith("hello", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


//EX 35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
            Console.WriteLine("Enter two numbers:");
            double a=double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());

            Console.WriteLine(a<100 && b>200);


//EX 36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. 

            Console.WriteLine("Enter two integers");
            int i=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            Console.WriteLine(-10<=i && i<=10 || -10<=b && b<=10);

//EX 37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".


            Console.WriteLine("Enter text to check \"HP\": ");
            string hp=Console.ReadLine();

            Console.WriteLine((hp.Substring(1,2).Equals("HP") ? hp.Remove(1,2) : hp));


//EX 38. Write a C# program to get a new string of two characters from a given string. The first and second character of 
//the given string must be "P" and "H", so PHP will be "PH". 


            Console.WriteLine("Enter text to check \"PH\"");
            string input = Console.ReadLine();

            try
            {
                if (input[..2].Equals("PH", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("ph");
                }
                else
                {
                    Console.WriteLine(false);
                }

            }
            catch (Exception err)
            {
                Console.WriteLine("Message: "+ err.Message);
            }


//EX 39. Write a C# program to find the largest and lowest values from three integer values.

            Console.WriteLine("Enter 3 values to find lowest and largest:");
            string input=Console.ReadLine();

            List<double> values=new List<double>();

            foreach(string s in input.Split(' '))
            {
                values.Add(double.Parse(s));
            }
            double largest = values[0];
            double lowest = values[0];
            for(int i=0; i<values.Count; i++)
            {
                if(values[i] > largest)
                {
                    largest = values[i];
                }

                if(values[i] < lowest)
                {
                    lowest = values[i];
                }    
            }

            Console.WriteLine("Largest: "+largest);
            Console.WriteLine("lowest: " + lowest);



//EX 40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.


            Console.WriteLine("Enter two numbers to find nearest of 20");
            double a=double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());

            if(20-a<20-b)
            {
                Console.WriteLine("Nearest value to 20 is "+ a);
            }
            else if (a==b)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine("Nearest value to 20 is " + b);
            }





