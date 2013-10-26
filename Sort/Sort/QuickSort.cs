using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class QuickSort
    {
    	private static Random random = new Random();
        public static void QuickSortTest()
        {
            MyArray array = new MyArray(6);
            
            array = new MyArray(new int[]{5,4,3,2,1});
            array.DisplayArray();

            Console.WriteLine("Quick Sort");

            QuickSort2(array, 0, array.UpperIndex);
            
            array.DisplayArray();
        }

        private static void QuickSort1(MyArray array, int startIndex, int endIndex)
        {
        	if(startIndex >= endIndex)
        		return;
        	
        	int splitIndex = Partition1(array, startIndex, endIndex);
        	Console.WriteLine("split index: "+splitIndex);
        	Console.Write("first part: ");
        	array.DisplayArray(startIndex, splitIndex - 1);
        	Console.Write("last part: ");
        	array.DisplayArray(splitIndex + 1, endIndex);
        	
        	Console.Write("Full array: ");
        	array.DisplayArray();
        	
        	//Console.Read();
        	
        	QuickSort1(array, 0, splitIndex -1);
        	QuickSort1(array, splitIndex +1, endIndex);
        	
        }
        
       /// <summary>
       /// Partition1 will use first element as key value and compare with others
        /// Will have 2 cursors first and last to split the array
       /// </summary>
       /// <param name="array"></param>
       /// <returns>the split index</returns>
        private static int Partition1(MyArray array, int startIndex,  int endIndex)
        {
        	int first = startIndex + 1;
        	int last = endIndex;
        	
        	
        	do
        	{
        		do
        		{
        			if(array[first] > array[startIndex] )
	        			break;
        			
    				first++;
        		}while (first <= last) ;
        		
        		if(first > last)
        		   break;
	        	
	        	do
	        	{
	        		if(array[last] < array[startIndex])
	        			break;
	        		
	        		last--;
	        	}while (last >= first && last > 0);
	        	
        		if(first > last)
        		   break;
	        	
	        	if(last > first)
	        	{         
		        	int temp = array[last];
		        	array[last] = array[first];
		        	array[first] = temp;
	        	}
        	}
        	while (last >= first && last > 0);
        	
        	//swap array[startIndex] and last
        	if(last != startIndex)
        	{
        		int temp = array[last];
	        	array[last] = array[startIndex];
	        	array[startIndex] = temp;
        	}
        	
        	return last;
        }
        
  	  	private static void QuickSort2(MyArray array, int startIndex, int endIndex)
        {
        	if(startIndex >= endIndex)
        		return;
        	
        	int splitIndex = Partition2(array, startIndex, endIndex);
        	Console.WriteLine("split index: "+splitIndex);
        	Console.Write("first part: ");
        	array.DisplayArray(startIndex, splitIndex - 1);
        	Console.Write("last part: ");
        	array.DisplayArray(splitIndex + 1, endIndex);
        	
        	Console.Write("Full array: ");
        	array.DisplayArray();
        	
        	//Console.Read();
        	
        	QuickSort2(array, 0, splitIndex -1);
        	QuickSort2(array, splitIndex +1, endIndex);
        	
        }
  	  	
  	  	private static int Partition2(MyArray array, int startIndex, int endIndex)
  	  	{
  	  		if(array == null || array.ArraySize == 0 || endIndex <= startIndex)
  	  			return endIndex;
  	  		
  	  		int keyValueIndex = random.Next(startIndex, endIndex);
  	  		
  	  		//swap keyvalue and endindex
  	  		if(keyValueIndex != endIndex)
  	  		{
  	  			int temp = array[keyValueIndex];
  	  			array[keyValueIndex] = array[endIndex];
  	  			array[endIndex] = temp;
  	  		}
  	  		
  	  		int storedIndex = startIndex;
  	  		for (int i = startIndex; i < endIndex; i++) {
  	  			if(array[i] < array[endIndex])
  	  			{
  	  				int temp = array[i];
	  	  			array[i] = array[storedIndex];
	  	  			array[storedIndex] = temp;
	  	  			
	  	  			storedIndex++;
  	  			}
  	  		}
  	  		
  	  		//swap key value and stroed index element
  	  		if(storedIndex != endIndex)
  	  		{
  	  			int temp = array[storedIndex];
  	  			array[storedIndex] = array[endIndex];
  	  			array[endIndex] = temp;
  	  		}
  	  		
  	  		return storedIndex;
  	  	}
  	  	
  	  	
    }
}
