using System;
using System.Collections.Generic;
using System.Linq;

namespace Amnon_sProjects.ShortestPath
{
    internal class Heap<T> where T : IComparable
    {
        // Data
        private int _heapSize;
        private readonly List<T> _heap;
        private readonly bool _isMin;
        
        // Ctor
        public Heap(bool isMin)
        {
            this._isMin = isMin;
            this._heapSize = 0;
            this._heap = new List<T>();
        }

        public bool IsEmpty => this._heapSize == 0;
        public int Size => this._heapSize;
        
        // -------------------------- Help Functions ---------------------------
        private int GetParentIndex(int child){ return (child - 1) / 2; }
        private int GetLeftChildIndex(int parentIndex){ return parentIndex * 2 + 1; }
        private int GetRightChildIndex(int parentIndex) { return parentIndex * 2 + 2; }

        private T Parent(int child){ return this._heap[this.GetParentIndex(child)]; }
        private T LeftChild(int parent) { return this._heap[this.GetLeftChildIndex(parent)]; }
        private T RightChild(int parent) { return this._heap[this.GetRightChildIndex(parent)]; }

        private void Swap(int firstIndex, int secondIndex)
        {
            T temp = this._heap[firstIndex];
            this._heap[firstIndex] = this._heap[secondIndex];
            this._heap[secondIndex] = temp;
        }

        private bool IsBefore(T element1, T element2)
        {
            // If element 1 is before element 2
            int compareResult = element1.CompareTo(element2);
            if (_isMin)
                return compareResult < 0;
            return compareResult > 0;
        }
        public void HeapifyDown()
        {
            int currIndex = 0;
            while (this.GetLeftChildIndex(currIndex) < this._heapSize)
            {
                int smaller = this.GetLeftChildIndex(currIndex);
                if (this.GetRightChildIndex(currIndex) < this._heapSize &&
                    IsBefore(this.RightChild(currIndex), this.LeftChild(currIndex)))
                {
                    smaller += 1; // Right child
                }

                if (this.IsBefore(this._heap[currIndex], this._heap[smaller]))
                    return;

                this.Swap(currIndex, smaller);
                currIndex = smaller;
            }
        }
        public void HeapifyUp()
        {
            int currIndex = this._heapSize - 1;
            while (this.GetParentIndex(currIndex) >= 0 &&
                   this.IsBefore(this._heap[currIndex], this.Parent(currIndex)))
            {
                this.Swap(this.GetParentIndex(currIndex), currIndex);
                currIndex = GetParentIndex(currIndex);
            }
        }
        // -------------------------- Heap Functions ---------------------------

        public T Peek()
        { 
            if(this.IsEmpty) throw new ArgumentOutOfRangeException($"The heap is empty");
            return this._heap[0]; // Peek heap root value
        }

        public T Remove()
        {
            if (this.IsEmpty) throw new ArgumentOutOfRangeException($"The heap is empty");
            T returnValue = this._heap[0];
            this.Swap(0,this._heapSize - 1);
            this._heap.RemoveAt(this._heapSize - 1);
            this._heapSize -= 1;
            this.HeapifyDown();
            return returnValue; // Remove heap root and return it's value
        }

        public bool Remove(T elementToRemove)
        {
            if (!this._heap.Contains(elementToRemove)) return false;
            bool output = this._heap.Remove(elementToRemove);
            this._heapSize -= 1;
            this.HeapifyDown();
            return output;
        }


        public void Insert(T element)
        {
            this._heap.Add(element);
            this._heapSize += 1;
            this.HeapifyUp();
        }

        public bool Contains(T element)
        {
            return Enumerable.Contains(this._heap, element);
        }

        public T GetElement(T element)
        {
            if (!Contains(element)) throw new Exception("Couldn't find the element");
            foreach (var e in this._heap.Where(e => e.Equals(element)))
                return e;
            throw new Exception("Problem with finding element");
        }
    }
}
