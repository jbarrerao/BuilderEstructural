﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderEstructural
{
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
