using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms.Recusion
{
    public class Parentheses
    {
        public string[] GetAllParentheses(int numberOfPair)
        {
            var result = new List<string>();
            GetResult(numberOfPair, numberOfPair, new char[numberOfPair * 2], 0, ref result);

            return result.ToArray();
        }

        void GetResult(int left, int right, char[] array, int index,ref List<string> result )
        {
            if (left == right && right == 0 && array != null)
                result.Add(array.ToString2());

            if (left > 0)
            { 
                array[index] = '(';
                GetResult(left - 1, right, array, index + 1, ref result);
            }

            if (right > left)
            {
                array[index] = ')';
                GetResult(left, right - 1, array, index + 1, ref result);
            }

        }

        
    }

    public static class Util
    {
        public static string  ToString2(this char[] array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(array);
            return sb.ToString();
        }
    }
}
