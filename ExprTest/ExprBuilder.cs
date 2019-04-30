using System;
using System.Collections.Generic;

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

        /// <summary>
        ///  Generate a expression tree based on the constraints.
        /// </summary>
        public void Generate()
        {
            Random r = new Random();
            //Random out atomic operands.
            for (var i = 0;i < maxOpnd;i++) 
            {
                double dRand = r.NextDouble();
                if(allowNeg)
                {
                    dRand -= 0.5;
                }
                dRand *= maxValue;
                if(!allowDec)
                {
                    dRand = Math.Truncate(dRand);
                }
                else
                {
                    dRand = Math.Round(dRand, maxPrecision);
                }
                AtomExpr aexp = new AtomExpr(dRand);
                subExprList.Add(aexp);
            }

            Shuffle();

            Expr ecombine = new Expr();
            ExprOprt oprt = ExprOprt.NIL;
            ExprOprt[] oplist = Enum.GetValues(typeof(ExprOprt)) as ExprOprt[];
            ecombine.expr0 = subExprList[0];
            ecombine.expr1 = subExprList[1];
            while (subExprList.Count > 1)
            {
                if (ecombine.expr1.ParseValue() == 0)
                {
                    int ind = r.Next(1, oplist.Length - 1);
                    if (!allowNeg && ecombine.expr0.ParseValue() < 0)
                    {
                        while (oplist[ind]==ExprOprt.SUB)
                        {
                            ind = r.Next(1, oplist.Length - 1);
                        }
                    }
                    if(!allowBrack)
                    {
                        ecombine.oprt = oplist[ind];
                        switch (ecombine.oprt)
                        {
                            case ExprOprt.SUB:

                                break;
                        }
                    }
                }
            }
        }
    }
}
