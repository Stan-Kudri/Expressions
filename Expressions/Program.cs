using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        public static void Print(Expressions expressions)
        {
            Console.WriteLine($"{expressions.ToString()} = {expressions.Eval()}");
        }

        static void Main(string[] args)
        {
            var variableLht = new ConstantExpression(12);
            var variableRgt = new ConstantExpression(4);

            var add = new AddExpression(variableLht, variableRgt);

            var div = new DivExpression(add, variableRgt);

            var axa = (Expressions) div.Clone();

            Print(axa);

            Console.Read();
        }
    }
}
