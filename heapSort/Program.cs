using System;
using System.Collections.Generic;

namespace heapSort
{
    enum HeapType
    {
        MAX_HEAP_TYPE,
        MIN_HEAP_TYPE
    }
    class Heap
    {
        public int[] array;
        public int count;
        public int capacity;
        public HeapType heapType; // 최대힙(0), 최소힙(1)

        public int Count { get => count; }
        public Heap(int _capacity, HeapType _heapType)
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

        public int LeftChild (int index)
        {
            if (this.count < index) return -1;
            int left = index * 2 + 1;
            if (left >= this.count) return -1;
            else return left;
        }

        public int RightChild(int index)
        {
            if (this.count < index) return -1;
            int right = index * 2 + 2;
            if (right >= this.count) return -1;
            else return right;
        }

        public int Insert(int data)
        {
            if(this.heapType == HeapType.MAX_HEAP_TYPE)
            {
                return MaxInsert(data);
            }
            else
            {
                return MinInsert(data);
            }
        }

        public int MaxInsert(int data)
        {
            int i = this.count;
            this.count++;

            while (i > 0 && data > this.array[Parent(i)])
            {
                this.array[i] = this.array[Parent(i)];
                i = Parent(i);
            }

            this.array[i] = data;
            return i;
        }

        public int MinInsert(int data)
        {
            int i = this.count;
            this.count++;

            while (i > 0 && data < this.array[Parent(i)])
            {
                this.array[i] = this.array[Parent(i)];
                i = Parent(i);
            }

            this.array[i] = data;
            return i;
        }

        public int DeleteMax()
        {
            if (this.count == 0) return -1;

            int data = this.array[0];
            this.array[0] = this.array[this.count - 1];
            this.count--;
            if (this.heapType != HeapType.MAX_HEAP_TYPE) PercolateDown(0);
            else MinPercolateDown(0);
            return data;
        }

        public int PercolateDown(int index)
        {
            if (this.count <= index) return -1;

            int max = index;
            int left = LeftChild(index);
            int right = RightChild(index);

            if (left != -1 && this.array[max] < this.array[left])
                max = left;
            if (right != -1 && this.array[max] < this.array[right])
                max = right;

            if(max != index)
            {
                int temp = this.array[index];
                this.array[index] = this.array[max];
                this.array[max] = temp;
                PercolateDown(max);
            }
            return max;
        }

        public int MinPercolateDown(int index)
        {
            if (this.count <= index) return -1;

            int max = index;
            int left = LeftChild(index);
            int right = RightChild(index);

            if (left != -1 && this.array[max] > this.array[left])
                max = left;
            if (right != -1 && this.array[max] > this.array[right])
                max = right;

            if (max != index)
            {
                int temp = this.array[index];
                this.array[index] = this.array[max];
                this.array[max] = temp;

                MinPercolateDown(max);
            }
            return max;
        }

        public void Print()
        {
            Console.WriteLine("\n Heap Data");
            foreach(int data in this.array)
            {
                Console.Write("{0} ", data);
            }
            Console.WriteLine("");
        }
    }

    class HeapSort
    {
        private Heap heap;
        private int[] result;

        public HeapSort(Heap _heap)
        {
            this.heap = _heap;
        }

        public int[] AscendingSort()
        {
            if (this.heap == null) return null;

            this.result = new int[this.heap.count];

            for (int i = 0; i < this.result.Length; i++)
            {
                this.result[i] = this.heap.DeleteMax();
            }

            return this.result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap(10, HeapType.MAX_HEAP_TYPE);
            Heap minHeap = new Heap(10, HeapType.MIN_HEAP_TYPE);

            Random rand = new Random();
            Random rand2 = new Random();

            for(int i = 0; i < 10; i++)
            {
                int data = rand.Next(1, 101);
                int data2 = rand.Next(1, 101);
                heap.Insert(data);
                minHeap.Insert(data2);
            }

            Console.Write("\n정렬 전 힙 데이터");
            heap.Print();
            minHeap.Print();

            HeapSort heapSort = new HeapSort(heap);
            HeapSort heapSort2 = new HeapSort(minHeap);
            int[] result = heapSort.AscendingSort();
            int[] result2 = heapSort2.AscendingSort();

            Console.WriteLine("\n힙 정렬 결과");
            foreach (int data in result)
            {
                Console.Write("{0} ", data);
            }
            Console.WriteLine();
            foreach (int data in result2)
            {
                Console.Write("{0} ", data);
            }
        }
    }
}
