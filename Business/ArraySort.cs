using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ArraySort
    {
        //        [2,4,6,8,10];
        //        int[] demo = new int[];
        //        demo = [0,2,3,7,1,9,4];
        //        demo = [0,2,3,1,7,4,9];
        //        demo = [0,2,1,3,4,7,9];
        //        demo = [0,1,2,3,4,7,9];

        //      Unit Testing
        

        // string[] dsaLinkUpNames = string[]{"Ayoola", "Chuks", "Femi", "Mary", "Ope", "Seyi", "Wale"}
        // int elementDsaCount = dsaLinkUpNames.Length;
        // string first = dsaLinkUpNames[0];
        // string third = dsaLinkUpNames[3];
        // string last = dsaLinkUpNames[6];
        // Bubble Sort Implementation
        public void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length-1; partIndex > 0; partIndex--)
            {
                bool swapped = false;
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        public void MergeSort(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                    return;

                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid +1 , high);
            }

        }
         
        public int IterativeFactorial(int number)
        {
            if (number == 0)
                return 1;
            
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public int RecursiveFactorial(int number)
        {
            if (number == 0)
                return 1;

            return number * RecursiveFactorial(number - 1);
        }

        public void ShellSort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length /3)
                gap = 3 * gap + 1;

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = 1; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, i, j - gap);
                    }
                }

                gap /= 3;
            }
        }
        //

        // Swap function
        private void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;


        }
    }
}
