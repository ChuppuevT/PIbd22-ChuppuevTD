﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLainers
{
    class PierNotFoundException : Exception
    {
        public PierNotFoundException(int i) : base("Не найден корабль по месту "+ i)
        { }
    }
}
