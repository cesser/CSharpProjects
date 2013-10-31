using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrograms
{
    public class Permutation
    {
        public List<int[]> AlgorithmL(int[] array)
        {
            throw new NotImplementedException();
        }

        public List<List<int>> RecusiveSlove(int[] array)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> selectionSet = array.ToList();
            RecusivePermutation(new int[array.Length], 0, selectionSet, ref result);

            return result;
        }

        private void RecusivePermutation(int[] result, int i, List<int> selectionSet, ref List<List<int>> results)
        {
            if (selectionSet.Count == 0)
                CopyResultToList(result, results);
              
            //find a set doesn't have any duplicated elements
            var nonDuplicationSet = RemoveDuplicatElement(selectionSet);

            foreach (int s in nonDuplicationSet)
            {
                result[i] = s;
                RecusivePermutation(result, i + 1, RemoveSpecificItem(selectionSet, s), ref results);
            }

        }

        private void CopyResultToList(int[] array, List<List<int>> results)
        {
            if (array != null && results != null)
            {
                results.Add(array.ToList());
            }
        }

        private List<int> RemoveSpecificItem(List<int> selectionSet, int s)
        {
            List<int> newList = new List<int>();
            bool found = false;
            foreach (var item in selectionSet)
            {
                if (item == s && !found)
                {
                    found = true;
                    continue;
                }

                newList.Add(item);
            }
            return newList;
        }

        private List<int> RemoveDuplicatElement(List<int> selectionSet)
        {
            HashSet<int> hashSet = new HashSet<int>();
            foreach (var item in selectionSet)
            {
                if (!hashSet.Contains(item))
                    hashSet.Add(item);
            }

            return hashSet.ToList();
        }
    }
}
