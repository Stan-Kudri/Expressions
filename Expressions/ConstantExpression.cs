using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class ConstantExpression:Expressions
    {
        private double Value { get; set; }

        public ConstantExpression(double value)
        {
            Value = value;
        }

        public override object Clone()
        {
            return new ConstantExpression(this.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override double Eval() => Value;
    }
}
