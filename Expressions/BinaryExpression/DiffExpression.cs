using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class DiffExpression:Expressions
    {
        private Expressions Left, Right;

        public DiffExpression(Expressions left, Expressions right)
        {
            Left = left;
            Right = right;
        }

        public new Expressions Clone()
        {
            return new DiffExpression(Left,Right);
        }

        public override double Eval()
        {
            var lft = Left.Eval();
            var rgt = Right.Eval();
            return lft - rgt;
        }

        public override string ToString()
        {
            return $"({Left}-{Right})";
        }
    }
}
