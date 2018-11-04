using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public interface IMyLinkedList
    {
        int Count { get; }
        void Populate(int amount);
        void Add(int value);
        void Reverse();
        void Print();
    }
}
