using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    internal class Queue
    {
        private int rear, front, size;
        private int[] arr;

        public Queue(int capasity)
        {
            size= capasity;
            front= -1;
            size= 0;
            rear = - 1;
            arr = new int[size];
        }

        public void Enqueue(int node)
        {
            if(isFull())
            {
                Console.WriteLine("Overflow");
                return;
            }
            else
            {
                if (front == -1) front = 0;
    
                arr[rear++] = node;

                Console.WriteLine("Inserted node {0}", arr[rear]);
            }
        }

        public int Dequeue()
        {
            if(isEmpty())
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }
            else
            {
                int node = arr[front];

                if (front == rear) 
                {
                    ResetQueue();
                }
                else
                {
                    front++;
                }

                Console.WriteLine("Deleted node {0}", node);

                return node;
            }
        }

        public int Front()
        {
            return arr[front];
        }

        public int Rear()
        {
            return arr[rear];
        }

        public bool isFull()
        {
            if (front == 0 && rear == size - 1)
                return true;
            
            return false;
        }

        public bool isEmpty()
        {
            if(front==-1)
                return true;
            return false;
        }
    
        public void ResetQueue()
        {
            front = rear = -1;
        }
    }
}
