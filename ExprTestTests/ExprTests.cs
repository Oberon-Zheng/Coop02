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
            //((e.expr0) as Expr).oprt = ExprOprt.ADD;
            //((e.expr0) as Expr).expr0 = new AtomExpr(3.0);
            //((e.expr0) as Expr).expr1 = new AtomExpr(2.0);
            //((e.expr1) as Expr).oprt = ExprOprt.MUL;
            //((e.expr1) as Expr).expr0 = new AtomExpr(36.0);
            //((e.expr1) as Expr).expr1 = new AtomExpr(0.0);
            var i = e.ParseValue();
            Assert.Fail();
        }
    }
}