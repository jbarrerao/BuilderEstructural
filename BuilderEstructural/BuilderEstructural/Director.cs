using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderEstructural
{
    class Director
    {
        // Builder uses a complex series of steps
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
