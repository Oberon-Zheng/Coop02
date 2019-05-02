using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExpression.Tests
{
    [TestClass()]
    public class ExprBuilderTests
    {
        [TestMethod()]
        public void ExprBuilderTest()
        {
            double d = 3.000048;
            string s = d.ToString("R");
            d = 3.0048;
            s = d.ToString("R");
            Expr e = new Expr
            (ExprOprt.MUL, 
                new Expr
                (
                    ExprOprt.ADD,new AtomExpr(3),new AtomExpr(2)
                ),
                new Expr
                (
                    ExprOprt.MUL,new AtomExpr(6),new Expr
                        (
                            ExprOprt.SUB,new AtomExpr(8), new AtomExpr(5)
                        )
                )
            );
            ExprBuilder ebuild = new ExprBuilder();
            ebuild.maxOpnd = 8;
            ebuild.maxValue = 10;
            ebuild.allowOprt = (byte)ExprOprt.DIV | (byte)ExprOprt.ADD | (byte)ExprOprt.SUB;
            ebuild.allowNeg = true;
            ebuild.allowBrack = true;
            //ebuild.maxOpnd = 0;
            while(true)
            {
                ebuild.BinaryGenerate(ExprOprt.DIV);
            }
            var i = e.ParseValue();
            Assert.Fail();
        }
    }
}