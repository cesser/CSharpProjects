using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public class FindLongestCommonString
    {

        public string FindLCS(string string1, string string2)
        {
            if(string.IsNullOrEmpty(string1) || string.IsNullOrEmpty(string2))
                throw new NullReferenceException();

            int[,] array = new int[string1.Length, string2.Length];
            int longestNumber = -1;
            string result = string.Empty;
            for (int i = 0; i < string1.Length; i++)
            {
                for (int j = 0; j < string2.Length; j++)
                {
                    if (string1[i] == string2[j])
                    {
                        if (i > 0 && j > 0)
                            array[i, j] = array[i - 1, j - 1] + 1;
                        else if(i == 0 || j ==0)
                            array[i, j] = 1;

                        if (array[i, j] > longestNumber)
                        {
                            longestNumber = array[i, j];
                            result = string1.Substring(i +1 -longestNumber, longestNumber);
                        }
                    }
                }
            }


            return result;
        }
    }
}
