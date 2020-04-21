using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    sealed class AddExpression : Expressions
    {
        private Expressions Left, Right;

        public AddExpression(Expressions left, Expressions right)
        {
            Left = left;
            Right = right;
        }

        public override Expressions Clone()
        {
            var left = this.Left.Clone();
            var right = this.Right.Clone();
            return new AddExpression(left,right);
        }
        
        public override double Eval()
        {
            var lft = Left.Eval();
            var rgt = Right.Eval();
            return lft + rgt;
        }

        public override string ToString()
        {
            return $"({Left}+{Right})";
        }
    }
}
