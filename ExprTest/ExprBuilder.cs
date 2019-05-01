﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

namespace MyExpression
{
    /// <summary>
    /// This class builds a complete formula with variety of operations under the spercific constraint
    /// </summary>
    public class ExprBuilder
    {
        private List<ExprBase> subExprList;
        public bool allowDec;
        public bool allowNeg;
        public double maxValue;
        public int maxPrecision;
        public bool allowBrack;
        public bool allowCplxExpr;
        public int maxOpnd;
        public byte allowOprt;
        public ExprBuilder()
        {
            subExprList = new List<ExprBase>();
            allowOprt = 0x00;
            allowDec = false;
            allowNeg = false;
            maxValue = 100.0;
            maxPrecision = 2;
            maxOpnd = 3;
            allowBrack = false;
            allowCplxExpr = false;
        }

        public bool IsAllowed(ExprOprt oprt)
        {
            return (allowOprt & (byte)oprt) != 0;
        }
        public void Allow(ExprOprt oprt)
        {
            allowOprt |= (byte)oprt;
        }
        public void Disallow(ExprOprt oprt)
        {
            allowOprt = (byte)(allowOprt & ~(int)oprt);
        }

        /// <summary>
        /// Fisher-Yates Shuffle:Shuffle the list of subexpressions to combine.
        /// </summary>
        private void Shuffle()
        {
            Random rng = new Random();
            int n = subExprList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                ExprBase value = subExprList[k];
                subExprList[k] = subExprList[n];
                subExprList[n] = value;
            }
        }

        private ExprOprt ChooseOprt(params ExprOprt[] oprts)
        {
            Random r = new Random();
            return oprts[r.Next(oprts.Length)];
        }
        private ExprOprt ChooseOprt(HashSet<ExprOprt> oprtSet)
        {
            var oprts = new List<ExprOprt>(oprtSet);
            Random r = new Random();
            return oprts[r.Next(oprts.Count)];
        }

        private bool AssociativityEnabled(HashSet<ExprOprt> oprtSet)
        {
            return oprtSet.Contains(ExprOprt.ADD) || oprtSet.Contains(ExprOprt.MUL);
        }

        /// <summary>
        ///  Generate a expression tree based on the constraints.
        /// </summary>
        public Expr Generate()
        {
            HashSet<ExprOprt> hsetOprt = new HashSet<ExprOprt>(Enum.GetValues(typeof(ExprOprt)) as IEnumerable<ExprOprt>);
            hsetOprt.Remove(ExprOprt.NIL);
            if (allowCplxExpr)
            {
                subExprList.Clear();
                Random r = new Random();
                #region Random out atomic operands.
                for (var i = 0; i < maxOpnd; i++)
                {
                    double dRand = r.NextDouble();
                    if (allowNeg)
                    {
                        dRand -= 0.5;
                        dRand *= 2;
                    }
                    dRand *= maxValue;
                    if (!allowDec)
                    {
                        dRand = Math.Truncate(dRand);
                    }
                    else
                    {
                        dRand = Math.Round(dRand, maxPrecision);
                    }
                    if (allowOprt == (byte)ExprOprt.DIV && Math.Abs(dRand) < double.Epsilon)
                    {
                        i--;
                        continue;
                    }
                    AtomExpr aexp = new AtomExpr(dRand);
                    subExprList.Add(aexp);
                }
                if (subExprList == null || subExprList.Count <= 0)
                {
                    throw new NoExprFoundException();
                }
                #endregion
                Shuffle();
                #region Operator set is culled by allowOprt. 
                if (!IsAllowed(ExprOprt.ADD))
                {
                    hsetOprt.Remove(ExprOprt.ADD);
                }
                if (!IsAllowed(ExprOprt.SUB))
                {
                    hsetOprt.Remove(ExprOprt.SUB);
                }
                if (!IsAllowed(ExprOprt.MUL))
                {
                    hsetOprt.Remove(ExprOprt.MUL);
                }
                if (!IsAllowed(ExprOprt.DIV))
                {
                    hsetOprt.Remove(ExprOprt.DIV);
                }
                #endregion

                if (hsetOprt.Count == 0)
                {
                    throw new NoOprtFoundException();
                }

                var origOprtSet = new HashSet<ExprOprt>(hsetOprt);
                #region Generating Expression
                while (subExprList.Count > 1)
                {
                    Expr ecombine = new Expr();
                    ExprBase expr0 = subExprList[0];
                    ExprBase expr1 = subExprList[1];
                    hsetOprt = new HashSet<ExprOprt>(origOprtSet);
                    if (Math.Abs(expr1.ParseValue()) < double.Epsilon)
                    {
                        hsetOprt.Remove(ExprOprt.DIV);
                    }

                    if (!allowBrack)
                    {
                        if (!allowNeg && (expr0.ParseValue() < expr1.ParseValue()))
                        {
                            //不允许负数出现，若左<右则不允许减法为合并运算
                            hsetOprt.Remove(ExprOprt.SUB);
                        }
                        if (AssociativityEnabled(hsetOprt))
                        {
                            if (expr1 is Expr)
                            {
                                if (expr1.Priority == 1 || (expr1 as Expr).oprt == ExprOprt.SUB)
                                {
                                    hsetOprt.Remove(ExprOprt.SUB);
                                }
                                if (!expr1.Associative)
                                {
                                    //(expr1 as Expr).InvertOprt();
                                    hsetOprt.Remove(ExprOprt.DIV);
                                }
                                if (expr0.Priority == 0 || expr1.Priority == 0)
                                {
                                    hsetOprt.Remove(ExprOprt.MUL);
                                    hsetOprt.Remove(ExprOprt.DIV);
                                }
                            }
                            else
                            {
                                if (expr0.Priority == 0)
                                {
                                    hsetOprt.Remove(ExprOprt.MUL);
                                    hsetOprt.Remove(ExprOprt.DIV);
                                }
                            }
                        }
                        else
                        {
                            if (expr0 is Expr)
                            {
                                if (expr0.Priority == 0)
                                {
                                    hsetOprt.Remove(ExprOprt.DIV);
                                }
                            }
                        }
                    }
                    if (hsetOprt.Count == 0)
                    {
                        throw new NoOprtFoundException();
                    }
                    ecombine.expr0 = expr0;
                    ecombine.expr1 = expr1;
                    ecombine.oprt = ChooseOprt(hsetOprt);
                    if (!allowBrack && !ecombine.IsNaturalOrder)
                    {
                        return null;
                    }
                    if (AssociativityEnabled(hsetOprt))
                    {
                        subExprList.Remove(expr0);
                        subExprList.Remove(expr1);
                        subExprList.Add(ecombine);
                        Shuffle();
                    }
                    else
                    {
                        subExprList[0] = ecombine;
                        subExprList.Remove(expr1);
                    }
                }
                return subExprList[0] as Expr;
                #endregion
            }
            else
            {
                Random r = new Random();
                #region Random out atomic operands.
                
                    double dRand = r.NextDouble();
                    if (allowNeg)
                    {
                        dRand -= 0.5;
                        dRand *= 2;
                    }
                    dRand *= maxValue;
                    if (!allowDec)
                    {
                        dRand = Math.Truncate(dRand);
                    }
                    else
                    {
                        dRand = Math.Round(dRand, maxPrecision);
                    }
                    AtomExpr aexp0 = new AtomExpr(dRand);
                    dRand = r.NextDouble();
                    if (allowNeg)
                    {
                        dRand -= 0.5;
                        dRand *= 2;
                    }
                    dRand *= maxValue;
                    if (!allowDec)
                    {
                        dRand = Math.Truncate(dRand);
                    }
                    else
                    {
                        dRand = Math.Round(dRand, maxPrecision);
                    }
                    AtomExpr aexp1 = new AtomExpr(dRand);
                Expr ecombine = new Expr();
                if(!allowNeg)
                {
                    if (aexp0.ParseValue()<aexp1.ParseValue())
                    {
                        hsetOprt.Remove(ExprOprt.SUB);
                    }

                }
                if(aexp1.ParseValue()==0)
                {
                    hsetOprt.Remove(ExprOprt.DIV);
                }
                ecombine.oprt = ChooseOprt(hsetOprt);
                ecombine.expr0 = aexp0;
                ecombine.expr1 = aexp1;
                return ecombine;
            }
        }
    }

    public class NoExprFoundException : Exception
    {
        public NoExprFoundException() : base("\nNo available expressions!\n(Possibly maxOpnd is 0)\n")
        {
        }
    }
    public class NoOprtFoundException : Exception
    {
        public NoOprtFoundException():base("\nNo available operators!\n(Possibly hsetOprt is empty)\n")
        {
        }
    }
}
