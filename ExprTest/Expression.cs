using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

namespace MyExpression
{
    public enum ExprOprt:byte
    {
        NIL = 0,
        ADD,
        SUB,
        MUL,
        DIV
    }

    public static class ExprUtil
    {
        public static int GetOprtPriority(ExprOprt oprt)
        {
            switch (oprt)
            {
                case ExprOprt.ADD:
                case ExprOprt.SUB:
                    return 0;
                case ExprOprt.MUL:
                case ExprOprt.DIV:
                    return 1;
                default:
                    throw new InvalidExprOprtParseException(oprt);
            }
        }
        public static char GetOprtChar(ExprOprt oprt)
        {
            switch(oprt)
            {
                case ExprOprt.ADD:
                    return '+';
                case ExprOprt.SUB:
                    return '-';
                case ExprOprt.MUL:
                    return '*';
                case ExprOprt.DIV:
                    return '/';
                case ExprOprt.NIL:
                    return char.MinValue;
                default:
                    throw new InvalidExprOprtParseException(oprt);
            }
        }
    }

    public abstract class ExprBase
    {
        /// <summary>
        /// The abstract method of all expressions used for parsing its own value;
        /// </summary>
        /// <returns>Parsed result of expression</returns>
        public abstract double ParseValue();
        /// <summary>
        /// Returns if this expression needs no brackets (calculated as a natural order)
        /// </summary>
        public abstract bool IsNaturalOrder
        {
            get;
        }
        public abstract int Priority
        {
            get;
        }
        public abstract bool Associative
        {
            get;
        }

    }

    public class AtomExpr : ExprBase
    {
        public double val;

        public override int Priority
        {
            get
            {
                return int.MaxValue;
            }
        }
        public override bool IsNaturalOrder
        {
            get
            {
                return true;
            }
        }
        public override bool Associative
        {
            get
            {
                return true;
            }
        }

        public AtomExpr(double val)
        {
            this.val = val;
        }
        public sbyte Sign
        {
            get
            {
                if(val > 0)
                {
                    return 1;
                }
                else if(val < 0)
                {
                    return -1;
                }
                else if(val == 0)
                {
                    return 0;
                }
                else
                {
                    return -2;
                }
            }
        }
        public override double ParseValue()
        {
            return val;
        }
        public override string ToString()
        {
            if(val < 0)
            {
                return string.Format("({0})", val.ToString());
            }
            else
            {
                return val.ToString();
            }
        }
    }

    public class Expr : ExprBase
    {
        public ExprBase expr0;
        public ExprBase expr1;
        public ExprOprt oprt;

        public override int Priority
        {
            get
            {
                switch(oprt)
                {
                    case ExprOprt.ADD:
                    case ExprOprt.SUB:
                        return 0;
                    case ExprOprt.MUL:
                    case ExprOprt.DIV:
                        return 1;
                    default:
                        throw new InvalidExprOprtParseException(oprt);
                }
            }
        }
        public override bool Associative
        {
            get
            {
                switch (oprt)
                {
                    case ExprOprt.ADD:
                    case ExprOprt.MUL:
                        return true;
                    case ExprOprt.SUB:
                    case ExprOprt.DIV:
                        return false;
                    default:
                        throw new InvalidExprOprtParseException(oprt);
                }
            }
        }


        public override bool IsNaturalOrder
        {
            get
            {
                if (expr0.IsNaturalOrder && expr1.IsNaturalOrder)
                {
                    if(expr0.Priority >= Priority && expr1.Priority > Priority)
                    {
                        return true;
                    }
                    else if(expr0.Priority == Priority && expr1.Priority == Priority && expr1.Associative)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
        }

        public Expr()
        {
            expr0 = null;
            expr1 = null;
            oprt = ExprOprt.NIL;
        }
        public Expr(ExprOprt op,ExprBase ex0,ExprBase ex1)
        {
            expr0 = ex0;
            expr1 = ex1;
            oprt = op;
        }
        public override double ParseValue()
        {
            if (expr0 == null || expr1 == null)
            {
                throw new NullReferenceException();
            }
            decimal d0 = new Decimal(expr0.ParseValue());
            decimal d1 = new Decimal(expr1.ParseValue());
            switch (oprt)
            {
                case ExprOprt.NIL:
                    throw new IncompleteExprParseException();
                case ExprOprt.ADD:
                    return decimal.ToDouble(d0 + d1);
                case ExprOprt.SUB:
                    return decimal.ToDouble(d0 - d1);
                case ExprOprt.MUL:
                    return decimal.ToDouble(d0 * d1);
                case ExprOprt.DIV:
                    if(d1 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return decimal.ToDouble(d0 / d1);
                default:
                    throw new InvalidExprOprtParseException(oprt);
            }
        }
        public override string ToString()
        {
            if(oprt == ExprOprt.NIL)
            {
                throw new IncompleteExprParseException();
            }
            else
            {
                if(IsNaturalOrder)
                {
                    return string.Format("{0}{1}{2}", expr0.ToString(), ExprUtil.GetOprtChar(oprt), expr1.ToString());
                }
                else
                {
                    StringBuilder strbExpr = new StringBuilder(null);
                    if(expr0.Priority < Priority)
                    {
                        strbExpr.AppendFormat("({0})", expr0.ToString());
                    }
                    else
                    {
                        strbExpr.AppendFormat("{0}", expr0.ToString());
                    }
                    strbExpr.AppendFormat("{0}", ExprUtil.GetOprtChar(oprt));
                    if(expr1.Priority < Priority || (expr1.Priority == Priority && !Associative))
                    {
                        strbExpr.AppendFormat("({0})", expr1.ToString());
                    }
                    else
                    {
                        strbExpr.AppendFormat("{0}", expr1.ToString());
                    }
                    return strbExpr.ToString();
                }
            }
            //throw new NotImplementedException();
        }

        /* Obsoleted Expr(string exprstr)
        public Expr(string exprstr)
        {
            Regex rgxp = new Regex("^$");
            bool ismatch = rgxp.IsMatch(exprstr);
            if (ismatch)
            {
                this.expr0 = null;
                this.expr1 = null;
                this.oprt = ExprOprt.NIL;
            }
            else
            {

            }
        }*/



    }
        
    public class IncompleteExprParseException : Exception
    {
        public IncompleteExprParseException():base("Attempting to parse an incomplete expression (possibly missing operator)")
        {
        }
    }
    public class InvalidExprOprtParseException : Exception
    {
        public InvalidExprOprtParseException(ExprOprt optr) : base(string.Format("Unknown operator {0}", optr))
        {
        }
    }
}
