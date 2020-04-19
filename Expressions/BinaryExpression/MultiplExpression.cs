using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class MultiplExpression:Expressions
    {
        private Expressions Left, Right;

        public MultiplExpression(Expressions left, Expressions right)
        {
            Left = left;
            Right = right;
        }

        public override sealed Object Clone()
        {
            return new MultiplExpression(this.Left,this.Right);
        }

        public override double Eval()
        {
            var lft = Left.Eval();
            var rgt = Right.Eval();
            return lft * rgt;
        }

        public override string ToString()
        {
            return $"({Left}*{Right})";
        }
    }
}
