using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression
{
    public enum Operator
    {
        NIL = 0,
        ADD,
        SUB,
        MUL,
        DIV
    }
    public abstract class ExpressionBase
    {
        public ExpressionBase()
        {

        }
    }
    public class AtomicExpr:ExpressionBase
    {
        public int decdigit;
        private double val;
        public AtomicExpr(double val,int decdig)
        {
            this.val = val;
            decdigit = decdig;
        }
    }
    public class Expression:ExpressionBase
    {
        public ExpressionBase expr0;
        public ExpressionBase expr1;
        public Operator optr;
        public Expression()
        {
            expr0 = null;
            expr1 = null;
            optr = Operator.NIL;
        }
    }
    public class ExprGenerator
    {
        public Expression expr;
        public ExprGenerator()
        {
            expr = new Expression();
        }
        public void Generate(byte enabledOper=0x0f,uint maxOperand=2,bool allowDecimal=false,bool allowNeg=false,int decdig=0,bool allowBrack=false,double maxValue=1.0)
        {
            Random r = new Random();
            AtomicExpr[] arryAexp = new AtomicExpr[maxOperand];
            for(var i = 0;i< arryAexp.Length;i++)
            {
                double d = Math.Round((r.NextDouble()-0.5) * maxValue * 2,decdig);
                d = allowNeg ? d : Math.Abs(d);
                AtomicExpr aexp = new AtomicExpr(d,decdig);
            }
            
        }
       
    }
    public class Expr
    {
        public StringBuilder expstr;

    }
}
