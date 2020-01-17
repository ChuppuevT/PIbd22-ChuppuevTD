using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLainers
{
    class PierOverflowException : Exception
    {
        public PierOverflowException() : base("Причал не имеет свободных мест")
        { }
    }
}
