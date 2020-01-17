using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLainers
{
    class PierAlreadyHaveException : Exception
    {
        public PierAlreadyHaveException() : base("На пирсе уже имеется такое судно")
        { }
    }
}
