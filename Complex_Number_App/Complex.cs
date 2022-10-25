/*
 * Complex class contains some utilities "methods" to deal with complex numbers
 * Change: method to take complex number as string and convert it to real part and imaginary part
 * Add: method that takes 2 complex numbers as strings and return summation of them as string
 * Sub: method that takes 2 complex numbers as srings and return subtraction of them as string
 * Multi: method that takes 2 complex numbers as string and return multiplication of them as string
 * Devide: method that takes 2 complex numbers as string and return devision of them as string
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Number_App
{
    internal class Complex
    {
        /*
         * Change method to convert from complex number as string to real part and imginary part
         * pre: passing complex number as string & passing real variable by ref & passing img variable by ref
         * post: assign real part of num in real and imaginary part in img
         */
        public static void Change(string num, ref double real, ref double img)
        {
            if (num.Contains("+"))  //check if img part is positive or negative
            {
                real = double.Parse(num.Split(new string[] { "+i*" }, StringSplitOptions.None)[0]);  //cutting real part
                img = double.Parse(num.Split(new string[] {"+i*"}, StringSplitOptions.None)[1]); //cutting imag part
            }
            else
            {
                real = double.Parse(num.Split(new string[] { "-i*" }, StringSplitOptions.None)[0]);
                img = double.Parse(num.Split(new string[] { "-i*" }, StringSplitOptions.None)[1]);
            }
        }

        /*
         * Add method to add 2 complex numbers 
         * pre: passing 2 complex numbers as strings and passing result variable as string by ref 
         * post: change value of res with the answer of summation
         */
        public static void Add(string num1, string num2, ref string res)
        {
            double real1 = 0, img1 = 0, real2 = 0, img2 = 0;

            //invoking Change function to get real and imginary part of each number
            Change(num1, ref real1, ref img1);
            Change(num2, ref real2, ref img2);

            double realRes = real1 + real2;
            double imgRes = img1 + img2;

            if (imgRes > 0)
                res = realRes + "+i*" + imgRes;
            else
                res = realRes + "-i*" + -imgRes;
        }


        /*
         * Sub method to add 2 complex numbers 
         * pre: passing 2 complex numbers as strings and passing result variable as string by ref 
         * post: change value of res with the answer of subtraction
         */
        public static void Sub(string num1, string num2, ref string res)
        {
            double real1 = 0, img1 = 0, real2 = 0, img2 = 0;

            //invoking Change function to get real and imginary part of each number
            Change(num1, ref real1, ref img1);
            Change(num2, ref real2, ref img2);

            double realRes = real1 - real2;
            double imgRes = img1 - img2;

            if (imgRes > 0)
                res = realRes + "+i*" + imgRes;
            else
                res = realRes + "-i*" + -imgRes;
        }

        /*
         *  Multi method to multi 2 complex numbers
         *  pre: passing 2 complex numbers as strings and passing result variable as string by ref
         *  post: change value of res with the answer fo mulitplication
         */
        public static void Multi(string num1, string num2, ref string res)
        {
            double real1 = 0, img1 = 0, real2 = 0, img2 = 0;

            //invoking Change function to get real and imginary part of each number
            Change(num1, ref real1, ref img1);
            Change(num2, ref real2, ref img2);

            double realRes = real1 * real2 - img1 * img2;   
            double imgRes = real1 * img2 + real2 * img1;

            if (imgRes > 0)
                res = realRes + "+i*" + imgRes;
            else
                res = realRes + "-i*" + -imgRes;    
        }


        /*
         *  Multi method to multi 2 complex numbers
         *  pre: passing 2 complex numbers as strings and passing result variable as string by ref
         *  post: change value of res with the answer fo mulitplication
         */
        public static void Divide(string num1, string num2, ref string res)
        {
            double real1 = 0, img1 = 0, real2 = 0, img2 = 0;

            //invoking Change function to get real and imginary part of each number
            Change(num1, ref real1, ref img1);
            Change(num2, ref real2, ref img2);

            img2 = -img2;

            double realRes = Math.Round((real1 * real2 - img1 * img2) / (real2 * real2 + img2 * img2), 2);
            double imgRes = Math.Round((real1 * img2 + real2 * img1) / (real2 * real2 + img2 * img2), 2);

            if (imgRes > 0)
                res = realRes + "+i*" + imgRes;
            else
                res = realRes + "-i*" + -imgRes;
        }
    }
}
