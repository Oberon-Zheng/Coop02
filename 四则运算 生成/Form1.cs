using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyExpression;

namespace 四则运算_生成
{
    public partial class FrmQuizGen : Form
    {
        private ExprBuilder eBuilder;
        private List<Expr> questions;//存储生成题目列表
        private class QuizNumber
        {
            private int qcount;
            public bool CplxFlag;
            public int addcount, subcount, mulcount, divcount;
            public int Count
            {
                get
                {
                    if (CplxFlag)
                        return qcount;
                    else
                        return addcount + subcount + mulcount + divcount;
                }
            }
            public QuizNumber(int addcount, int subcount, int mulcount, int divcount)
            {
                this.addcount = addcount;
                this.subcount = subcount;
                this.mulcount = mulcount;
                this.divcount = divcount;
            }
        }
        QuizNumber qnum;
        public FrmQuizGen()
        {
            eBuilder = new ExprBuilder();
            qnum = new QuizNumber(0,0,0,0);
            InitializeComponent();
        }

        private void stpQSub_ValueChanged(object sender, EventArgs e)
        {
            qnum.subcount = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lBoxQuizDisp.Items.Clear();
        }

        private void FrmQuizGen_Activated(object sender, EventArgs e)
        {
            UpdateCplxSettings();
            UpdateStepper();
            stpMaxPrecision.Enabled = cBoxAllowFrac.Checked;
        }

        private void cBoxQTypeAdd_CheckedChanged(object sender, EventArgs e)
        {
            stpQAdd.Enabled = cBoxQTypeAdd.Checked && cBoxQTypeAdd.Enabled;
        }

        private void cBoxQTypeSub_CheckedChanged(object sender, EventArgs e)
        {
            stpQSub.Enabled = cBoxQTypeSub.Checked && cBoxQTypeSub.Enabled;
        }

        private void cBoxQTypeMul_CheckedChanged(object sender, EventArgs e)
        {
            stpQMul.Enabled = cBoxQTypeMul.Checked && cBoxQTypeMul.Enabled;
        }

        private void cBoxQTypeDiv_CheckedChanged(object sender, EventArgs e)
        {
            stpQDiv.Enabled = cBoxQTypeDiv.Checked && cBoxQTypeDiv.Enabled;
        }

        private void stpMaxOptr_ValueChanged(object sender, EventArgs e)
        {
            eBuilder.maxOpnd = decimal.ToInt32(stpMaxOptr.Value);
        }

        private void cBoxAllowCplx_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCplxSettings();
            UpdateStepper();
        }

        private void UpdateCplxSettings()
        {
            cBoxQTypeAdd.Enabled = !cBoxAllowCplx.Checked;
            cBoxQTypeSub.Enabled = !cBoxAllowCplx.Checked;
            cBoxQTypeMul.Enabled = !cBoxAllowCplx.Checked;
            cBoxQTypeDiv.Enabled = !cBoxAllowCplx.Checked;
            labPromptCQuizNum.Enabled = cBoxAllowCplx.Checked;
            labPromptMaxOptr.Enabled = cBoxAllowCplx.Checked;
            labPromptAllowType.Enabled = cBoxAllowCplx.Checked;
            cBoxCQuizAdd.Enabled = cBoxAllowCplx.Checked;
            cBoxCQuizSub.Enabled = cBoxAllowCplx.Checked;
            cBoxCQuizMul.Enabled = cBoxAllowCplx.Checked;
            cBoxCQuizDiv.Enabled = cBoxAllowCplx.Checked;
            cBoxCQuizAllowBrack.Enabled = cBoxAllowCplx.Checked;
            stpCQuizNum.Enabled = cBoxAllowCplx.Checked;
            stpMaxOptr.Enabled = cBoxAllowCplx.Checked;
        }

        private void UpdateStepper()
        {
            stpQAdd.Enabled = cBoxQTypeAdd.Checked && cBoxQTypeAdd.Enabled;
            stpQSub.Enabled = cBoxQTypeSub.Checked && cBoxQTypeSub.Enabled;
            stpQMul.Enabled = cBoxQTypeMul.Checked && cBoxQTypeMul.Enabled;
            stpQDiv.Enabled = cBoxQTypeDiv.Checked && cBoxQTypeDiv.Enabled;
        }

        private void cBoxAllowFrac_CheckedChanged(object sender, EventArgs e)
        {
            stpMaxPrecision.Enabled = cBoxAllowFrac.Checked;
        }

        private void stpCQuizNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cBoxCQuizAdd_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                eBuilder.Allow(ExprOprt.ADD);
            }
            else
            {
                eBuilder.Disallow(ExprOprt.ADD);
            }
        }

        private void cBoxCQuizSub_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                eBuilder.Allow(ExprOprt.SUB);
            }
            else
            {
                eBuilder.Disallow(ExprOprt.SUB);
            }
        }

        private void cBoxCQuizMul_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                eBuilder.Allow(ExprOprt.MUL);
            }
            else
            {
                eBuilder.Disallow(ExprOprt.MUL);
            }
        }

        private void cBoxCQuizDiv_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                eBuilder.Allow(ExprOprt.DIV);
            }
            else
            {
                eBuilder.Disallow(ExprOprt.DIV);
            }
        }

        private void cBoxCQuizAllowBrack_CheckedChanged(object sender, EventArgs e)
        {
            eBuilder.allowBrack = (sender as CheckBox).Checked;
        }

        private void stpMaxPrecision_ValueChanged(object sender, EventArgs e)
        {
            eBuilder.maxPrecision = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void stpQAdd_ValueChanged(object sender, EventArgs e)
        {
            qnum.addcount = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void stpQMul_ValueChanged(object sender, EventArgs e)
        {
            qnum.mulcount = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void stpQDiv_ValueChanged(object sender, EventArgs e)
        {
            qnum.divcount = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void lBoxQuizDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            {
                for(var i=0;i<qnum.Count;i++)
                {
                    try
                    {
                        Expr gen = eBuilder.Generate();
                        if(gen==null)
                        {
                            i--;
                            continue;
                        }
                        questions.Add(gen);
                        if (eBuilder.allowCplxExpr)
                        {
                            /*switch (gen.oprt)
                            {
                                case ExprOprt.ADD:
                                    qnum.addcount++;
                                    break;
                                default:
                            }
                            {
                                
                            }*/
                        }
                    }
                    catch (Exception)
                    {
                        i--;
                        continue;
                    }
                }
            }
        }
    }
}
