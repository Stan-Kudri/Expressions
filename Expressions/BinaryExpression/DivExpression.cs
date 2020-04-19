using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class DivExpression:Expressions
    {
        private Expressions Left, Right;

        public DivExpression(Expressions left, Expressions right)
        {
            Left = left;
            Right = right;
        }

        public override sealed Object Clone()
        {
            return new DivExpression(this.Left,this.Right);
        }

        public override double Eval()
        {
            var lft = Left.Eval();
            var rgt = Right.Eval();
            return lft / rgt;
        }

        public override string ToString()
        {
            return $"({Left}/{Right})";
        }
    }
}
