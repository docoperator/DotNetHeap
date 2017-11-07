using System;
using System.Collections.Generic;
using System.Text;

namespace CoreHeap
{
    public class Heap
    {
        public int[] something;


        public int getParentIndex(int index)
        {
            int result = 0;

            result = (index - 2) / 2;

            return result;
        }

        public int getLeftChildIndex(int index)
        {
            int result = 0;
            return result;
        }

        public bool hasLeftChild(int index)
        {


            return false;
        }

        public void swapNodes(int firstNode, int secondNode)
        {

        }

    }
}
