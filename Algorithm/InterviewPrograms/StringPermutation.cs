using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public class StringPermutation
    {
        public string[] GetAllPermuation(string s)
        { 
            if(string.IsNullOrWhiteSpace(s))
            {
                return null;
            }

            if (s.Length == 1)
            { 
                return new string[]{s};
            }


            char c = s[0];

            var sub = s.Substring(1);

            string[] subPermutation = GetAllPermuation(sub);

            if (subPermutation != null)
            {
                var result = new List<string>();
                for (int i = 0; i < subPermutation.Length; i++)
                {
                    foreach (var item in InsertChartToString(c, sub))
                    {
                        result.Add(item);
                    }
                }

                return result.ToArray();
            }


            return null;
        }

        private IEnumerable<string> InsertChartToString(char c, string sub)
        {
            for (int i = 0; i <= sub.Length; i++)
            {
                yield return sub.Insert(i, c.ToString());
            }
        }

       
    }
}
