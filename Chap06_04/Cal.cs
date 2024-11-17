using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06_04
{
    internal class Cal
    {
        public static double cal_text(string text)
        {
            text = text.Replace(" ", "");
            return Math.Round(cal_func_plus(text),8);
        }


        private static double cal_func_blanket(string text)
        {

            if (text == null) return 1;

            if (text[0] != '(')
            {
                return double.Parse(text);
            }
            else
            {
                text = text.Substring(1, text.Length - 2);
                return cal_func_plus(text);
            }
        }
        private static double cal_func_multipy(string text)
        {
            Queue<double> num = new Queue<double>();
            Queue<char> oper = new Queue<char>();
            char temp;

            double result;
            if (text == null) return 1;

            for (int i = 1; i <text.Length; i++)
            {
                if (text[i] == '*' || text[i] == '/')
                {
                    num.Enqueue(cal_func_blanket(text.Substring(0, i)));
                    oper.Enqueue(text[i]);
                    text = text.Remove(0, i + 1);
                    i = 0;
                }
            }
            num.Enqueue(cal_func_blanket(text));

            result = num.Dequeue();
            while (num.Count > 0)
            {
                temp = oper.Dequeue();
                if (temp == '/')
                {
                    result /= num.Dequeue();
                }
                else
                {
                    result *= num.Dequeue();
                }
            }

            return result;
        }
        private static double cal_func_plus(string text)
        {
            Queue<double> num = new Queue<double>();
            Queue<char> oper = new Queue<char>();
            char temp;

            double result;
            if (text == null) return 0;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == '+' || text[i] == '-')
                {
                    num.Enqueue(cal_func_multipy(text.Substring(0,i)));
                    oper.Enqueue(text[i]);
                    text = text.Remove(0, i + 1);
                    i = 0;
                }
            }
            num.Enqueue(cal_func_multipy(text));

            result = num.Dequeue();
            while (num.Count > 0)
            {
                temp = oper.Dequeue();
                if (temp == '-')
                {
                    result -= num.Dequeue();
                }
                else
                {
                    result += num.Dequeue();
                }
            }
            return result;
        }
    }
}
