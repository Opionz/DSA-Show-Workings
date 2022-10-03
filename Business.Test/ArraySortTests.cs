using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Test
{
    [TestFixture]
    public class ArraySortTests
    {
        // Sample Data for Test
        private int[][] Samples()
        {
            int[][] samples = new int[1][];
            samples[0] = new int[] { 0, 2, 3, 7, 1, 9, 4 };
            //samples[1] = new int[] { 2, 3, 7, 8, 12 };
            //samples[2] = new int[] { 2, 1, 3 };
            //samples[3] = new int[] { 1, 1, 1 };
            //samples[4] = new int[] { 2, -1, 3, 3 };
            //samples[5] = new int[] { 4, -5, 3, 3 };
            //samples[6] = new int[] { 0, -5, 3, 3 };
            //samples[7] = new int[] { 4, -5, 3, 0 };
            //samples[8] = new int[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return samples;
        }

        private void RunSortingAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }

        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("-----------TRACE-----------\n");
            foreach (var el in array)
            {
                TestContext.Write(el + " ");
            }
            TestContext.WriteLine("\n----------------------------------\n");
        }

        [Test]
        public void BubbbleSortValidInput_SortedInput()
        {
            ArraySort sort = new ArraySort();
            RunSortingAlgorithm(sort.BubbleSort);
        }
    }
}
