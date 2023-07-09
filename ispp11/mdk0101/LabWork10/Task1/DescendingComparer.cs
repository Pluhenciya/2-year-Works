using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class DescendingComparer : IComparer<Student>
    {

        public int Compare(Student? x, Student? y)
        {
            return -x.CompareTo(y);
        }
    }
}
