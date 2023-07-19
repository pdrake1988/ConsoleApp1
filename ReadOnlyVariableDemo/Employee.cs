using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyVariableDemo
{
    public class Employee
    {
        public const int testConstantVariable = 100;
        public double testDouble = 67.90;
        public static float max = 45;
        public readonly int testReadOnlyVariable;
    }
}
