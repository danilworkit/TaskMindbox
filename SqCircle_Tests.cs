using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Tests
{
    [TestClass()]
    public class SqCircle_Tests
    {
        [TestMethod()]
        public void CalcSquareC_Test()
        {
            double r = 10;
            double exp = 314;
            SqCircle sc = new SqCircle();
            double res = sc.CalcSquareC(r);
            Assert.AreEqual(exp, res);
        }
        [TestMethod()]
        public void CalcSquareT_Test()
        {
            double a = 5;
            double b = 3;
            double c = 4;
            double exp = 6;
            SqTraingle st = new SqTraingle();
            double res = st.CalcSquareT(a, b, c);
            Assert.AreEqual(exp, res);

        }
    }
}