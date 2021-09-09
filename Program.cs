using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Square;

namespace TaskMindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            SqCircle sc = new SqCircle();
            sc.CalcSquareC(5);
            SqTraingle st = new SqTraingle();
            st.CalcSquareT(4,5,3);
            Console.ReadKey();
        }
    }
}
