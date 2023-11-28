using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    internal class Heap
    {
        private List<int> _heap;

        public Heap() 
        { 
            _heap = new List<int>();
        }

        public Heap(List<int> heapD)
        {
            _heap = heapD;
        }

        public void push(int node)
        {
            _heap.Add(node);
        }

        public int pop()
        {
            int top = _heap.Last<int>();
            _heap.RemoveAt(top);
            return top;
        }

        public int top()
        {
            return _heap.Last<int>();
        }
    }
}
