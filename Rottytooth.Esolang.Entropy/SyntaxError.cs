﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rottytooth.Esolang.Entropy
{
    public class SyntaxError : Exception
    {
        public SyntaxError(string errorMessage)
            : base(errorMessage)
        {
        }
    }
}
