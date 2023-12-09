using System;
using System.Text.RegularExpressions;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            Console.WriteLine("4 REQEMLI EDEDIN REQEMLEININ CEMI :");
            string num1 = Console.ReadLine();
            int result = int.Parse(num1);
            int sum = 0;
            while (result > 0)
            {
                sum += result % 10;
                result /= 10;
            }
            Console.WriteLine(sum);
            // //-------------------------------
            // //TASK2
            Console.WriteLine("6 REQEMLI EDEDIN ILK 3 REQEMININ CEMI"); //123456
            string num2 = Console.ReadLine();
            int result2 = int.Parse(num2);
            int dovr = result2 / 1000;
            int sum2 = 0;
            while (dovr > 0)
            {
                sum2 += dovr % 10;
                dovr /= 10;
            }
            Console.WriteLine(sum2);
            // //-----------------------------
            // //TASK3
            Console.WriteLine("9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi:"); //123456789
            string num3 = Console.ReadLine();
            int result3 = int.Parse(num3);
            int dovr2 = (result3 / 1000) % 1000;
            int sum3 = 0;
            while (dovr2 > 0)
            {
                sum3 += dovr2 % 10;
                dovr2 /= 10;
            }
            Console.WriteLine(sum3);
            // //---------------------
            // //TASK4
            Console.WriteLine("5 reqemli ilk ve son reqemlerinin ceminin kvadrati"); //12345
            string num4 = Console.ReadLine();
            int result4 = int.Parse(num4);
            int lastNum = result4 % 10;
            int firstNum = result4 / 10000;
            int son = (lastNum * lastNum) + firstNum * firstNum;
            Console.WriteLine(son);
            // //------------------------------
            // //TASK5
            Console.WriteLine("6 reqemli ededin 1 ci reqemini hemin ededin axirina at.");  //234567
            string num5 = Console.ReadLine();
            int result5 = int.Parse(num5);
            int son5 = result5 / 100000; //2
            result5 = result5 - (son5 * 100000);
            int yekun = result5 * 10 + son5;
            Console.WriteLine(yekun);
            // //-----------------------------
            // //TASK6
            Console.WriteLine(" 8 reqemli ededin ilk I ve axirinci reqemlerini legv et");  //12345678
            string num6 = Console.ReadLine();
            int result6 = int.Parse(num6);
            int yekun2 = result6 / 10;
            yekun2 = yekun2 % 1000000;
            Console.WriteLine(yekun2);
            // //------------------------
            //TASK7
            Console.Write("4 reqemli ededin tersine duzub axirina ve evveline 8 artir : "); //1234
            string num7 = Console.ReadLine();
            int result7 = int.Parse(num7);

            for (int i = 4; i > 0; i--)
            {
                int yekun71 = 800000 + i * 10 + 8;
                Console.WriteLine(yekun71);
            }
            ////TASK8
            Console.WriteLine("verilmiş ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap");
            string ystr = Console.ReadLine();
            bool eded2 = int.TryParse(ystr, out int f);
            int yekun4 = (f / 100) % 10 + f % 10;
            Console.WriteLine(yekun4);
            ////-----------------------
            //TASK9
            Console.WriteLine("9 reqemli ededdin tek yerde dayananlardan bir eded duzlet : ");
            string bbu = Console.ReadLine();
            int yekun99 = int.Parse(bbu);
            int count = 0;
            int digit = 0;
            int newNumber = 0;
            int step = 1;
            while (yekun99 > 0)
            {
                count++;                           //Deqiqlesdir!

                if (count % 2 != 0)
                {
                    digit = yekun99 % 10;
                    newNumber = newNumber + step * digit;
                    step = step * 10;

                }
                yekun99 /= 10;

            }
            Console.WriteLine(newNumber);
            //--------------------
            //TASK10
            Console.WriteLine(" 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet   sonra cut yerde dayanlarinda bir eded duzlet,  sonra onlari topla");
            string num10 = Console.ReadLine();
            int result10 = int.Parse(num10);
          
            int count1 = 0;
            
            int digit1 = 0;
            
            int newNum1 = 0;
           
            int step56 = 1;
            
            while (result10 > 0)
            {
                count1++;
                    if(count1%2!=0)
                {
                    digit1 = result10 % 10;
                    newNum1 = newNum1 + step56 * digit1;
                    step56 = step56 * 10;
                }
                result10 = result10 / 10;
            }
            Console.WriteLine(newNum1);
            Console.WriteLine("INPUT SECOND 9 DIGIT NUMBER");
            string num102 = Console.ReadLine();
            int result102 = int.Parse(num102);
            int count2 = 0;
            int newNum2 = 0;
            int digit2 = 0;
            int step2 = 1;
            while (result102 > 0) { 
                count2++;
                if(count2% 2==0) { 
                    digit2 = result102 % 10;
                    newNum2 = newNum2 + step2 * digit2;
                    step2= step2 * 10;
                }
                result102 = result102 / 10;
            }
            Console.WriteLine(newNum2);
            Console.WriteLine($"NUMBERS SUM : {newNum1+newNum2}");


            //------------------------------
            //TASK11
            Console.WriteLine("eded daxil et");
            string num11 = Console.ReadLine();
            int result11 = int.Parse(num11);
            int qroup = 0;
            int count121 = 0;
            while (result11 > 0)
            {
                qroup += qroup % 100;
                qroup /= 100;

            }
            Console.WriteLine(qroup);

       
        /* static int Task4(int num)
         {
             int lastNum = num % 10;
             int firstNum = num / 10000;
             int son = (lastNum * lastNum) + firstNum * firstNum;
             return son;
         }*/

        Console.WriteLine("INPUT FIRST  NUMBERS");
            string dstr = Console.ReadLine();
            bool dery = int.TryParse(dstr, out int d);

            int sum6 = 0;

            while (d > 0)
            {
                sum6 += d % 10;
                d /= 10;
            }
            Console.WriteLine(sum6);

            Console.WriteLine("INPUT SECOND NUMBER");
            string bstr = Console.ReadLine();
            bool fer = int.TryParse(bstr, out int b);
            int sum23 = 1;
            while (b > 0)
            {

                sum23 *= b % 10;
                b /= 10;

            }
            Console.WriteLine($" Netice {sum2 + sum6}");
            //// Task 13AA
            /*Console.WriteLine("3 dene 5 reqemi eded daxil edin");
            string num1Str = Console.ReadLine();
            string num2Str = Console.ReadLine();
            string num3Str = Console.ReadLine();
              // bunu tam anlamadim
            int num11 = int.Parse(num1Str);
            int num2 = int.Parse(num2Str);
            int num3 = int.Parse(num3Str);
            double result1 = FirstLastNumber(num11) + FirstLastNumber(num2) + FirstLastNumber(num3);
            double result5 = (result * 50) / 100 + result1;
            Console.WriteLine(result);*/

            Console.WriteLine("INCLUDE FIRST NUMBER");
            string? fstr = Console.ReadLine();
            int edg = int.Parse(fstr);
            int ilkucEded3 = edg / 1000;
            int sum1 = 0;
            while (ilkucEded3 > 0)
            {
                sum1 += ilkucEded3 % 10;
                ilkucEded3 /= 10;
            }
            Console.WriteLine(sum1);

            Console.WriteLine("INCLUDE SECOND NUMBER");
            string rstr = Console.ReadLine();
            int ed1 = int.Parse(rstr);
            int ilkucEded2 = ed1 / 1000;
            int sum20 = 0;
            while (ilkucEded2 > 0)
            {
                sum20 += ilkucEded2 % 10;
                ilkucEded2 /= 10;
            }
            Console.WriteLine(sum23);

            Console.WriteLine("INCLUDE THIRD NUMBER");
            string cstr = Console.ReadLine();
            int ed2 = int.Parse(cstr);
            int ilkucEded4 = ed2 / 1000;
            int sum30 = 0;
            while (ilkucEded4 > 0)
            {
                sum30 += ilkucEded4 % 10;
                ilkucEded4 /= 10;
            }
            Console.WriteLine(sum30);
            int yekun5 = sum30 + sum20 + sum1;
            Console.WriteLine($" UC EDEDIN ILK UC REQEMLERININ CEMI : {yekun5}");
            // ----------------------------------
            Console.WriteLine("INPUT 7 NUMBERS");
            string jstr = Console.ReadLine();
            int eded7reqm = int.Parse(jstr);
            int digitSeven = eded7reqm % 10000;    //1234567 son4 reqem = 4567
            int yeddireqemliededsonrdordReqemliEded = digitSeven + yekun5;
            Console.WriteLine($"neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel : {yeddireqemliededsonrdordReqemliEded}");        //digitSeven+yekun
            int sevenNumber = eded7reqm / 10000;
            int sum4 = 1;
            while (sevenNumber > 0)
            {
                sum4 *= sevenNumber % 10;
                sevenNumber /= 10;
            }
            Console.WriteLine($"7 reqemli ededin ilk uc denesinin hasili {sum4}"); //7 reqemli ededin ilk uc denesinin hasili
            Console.WriteLine($"Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi : {yeddireqemliededsonrdordReqemliEded - sum4}");
            int son8 = yeddireqemliededsonrdordReqemliEded - sum4;
            son8 = son8 % 60 + 60;
            son8= son8 % 18;
            Console.WriteLine(son8);
        }
        
        }
    }


