using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree_Traversal_Iterator_Composite.Iterators;

namespace Tree_Traversal_Iterator_Composite.Models
{
    public interface IProjectIterator
    {
        bool MoveNext();
        ProjectComponent Current { get; }
        void Reset();
    }
}
