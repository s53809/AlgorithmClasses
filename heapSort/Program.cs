using System;
using System.Collections.Generic;

namespace heapSort
{
    class Heap
    {
        public int[] array;
        public int count;
        public int capacity; 
        public int heapType;

        public Heap (int _capacity, int _heapType)
        {
            this.capacity = _capacity;
            this.heapType = _heapType;
            this.count = 0;
            this.array = new int[this.capacity];
        }

        public int Parent(int index) // 부모 색인 반환
        {
            if (count == 0) return -1;
            return (index - 1) / 2;
        }

        public int LeftChild(int index)
        {
            if (this.count < index) return -1;
            int left = index * 2 + 1;
            if (left >= this.count) return -1;
            else return left;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
