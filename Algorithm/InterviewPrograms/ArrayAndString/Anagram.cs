using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms.ArrayAndString
{
    public class Anagram
    {
        public bool CheckAnagram(string a, string b)
        {
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
            {
                return true;
            }

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return false;
            }

            if (a.Length != b.Length)
            {
                return false;
            }

            var c1 = a.ToList<char>();
            var c2 = b.ToList<char>();

            for (int i = c1.Count - 1; i >= 0; i--)
            {
                if (c2.Contains(c1[i]))
                {
                    c2.Remove(c1[i]);
                    c1.RemoveAt(i);
                }
                else
                {
                    return false;
                }
            }
            
            return true;
        }

        public bool CheckAnagram2(string a, string b)
        {
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
            {
                return true;
            }

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return false;
            }

            if (a.Length != b.Length)
            {
                return false;
            }

            for (int i = 0; i < a.Length -1; i++)
            {
                int index = b.IndexOf(a[i]);
                if (index >= 0)
                {
                    a.Remove(i, 1);
                    b.Remove(index, 1);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
