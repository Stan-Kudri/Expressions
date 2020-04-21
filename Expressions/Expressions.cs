using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    abstract class Expressions
    {
        public abstract double Eval();

        public virtual Expressions Clone()
        {
            return this;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
