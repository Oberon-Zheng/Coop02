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
        //private ExprBuilder eBuilder;
        private List<Expr> questions = new List<Expr>();//存储生成题目列表
        private class QuizConfig
        {
            public ExprBuilder eBuilder;
            public int qcount;
            //public bool CplxFlag;
            public int addcount, subcount, mulcount, divcount;
            public int Count
            {
                get
                {
                    if (eBuilder.allowCplxExpr)
                        return qcount;
                    else
                        return addcount + subcount + mulcount + divcount;
                }
            }
            public QuizConfig(int addcount, int subcount, int mulcount, int divcount)
            {
                eBuilder = new ExprBuilder();
                this.addcount = addcount;
                this.subcount = subcount;
                this.mulcount = mulcount;
                this.divcount = divcount;
            }
        }
        QuizConfig qConfig;
        public FrmQuizGen()
        {
            qConfig = new QuizConfig(0, 0, 0, 0);
            InitializeComponent();
        }

        private void stpQSub_ValueChanged(object sender, EventArgs e)
        {
            qConfig.subcount = decimal.ToInt32((sender as NumericUpDown).Value);
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
            BindingSource bs =  new BindingSource();
            bs.DataSource = questions;
            lBoxQuizDisp.DataSource = bs;
            lBoxQuizDisp.DisplayMember = "";
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
            qConfig.eBuilder.maxOpnd = decimal.ToInt32(stpMaxOptr.Value);
        }

        private void cBoxAllowCplx_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCplxSettings();
            UpdateStepper();
            qConfig.eBuilder.allowCplxExpr = (sender as CheckBox).Checked;
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
            qConfig.qcount = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void cBoxCQuizAdd_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                qConfig.eBuilder.Allow(ExprOprt.ADD);
            }
            else
            {
                qConfig.eBuilder.Disallow(ExprOprt.ADD);
            }
        }

        private void cBoxCQuizSub_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                qConfig.eBuilder.Allow(ExprOprt.SUB);
            }
            else
            {
                qConfig.eBuilder.Disallow(ExprOprt.SUB);
            }
        }

        private void cBoxCQuizMul_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                qConfig.eBuilder.Allow(ExprOprt.MUL);
            }
            else
            {
                qConfig.eBuilder.Disallow(ExprOprt.MUL);
            }
        }

        private void cBoxCQuizDiv_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                qConfig.eBuilder.Allow(ExprOprt.DIV);
            }
            else
            {
                qConfig.eBuilder.Disallow(ExprOprt.DIV);
            }
        }

        private void cBoxCQuizAllowBrack_CheckedChanged(object sender, EventArgs e)
        {
            qConfig.eBuilder.allowBrack = (sender as CheckBox).Checked;
        }

        private void stpMaxPrecision_ValueChanged(object sender, EventArgs e)
        {
            qConfig.eBuilder.maxPrecision = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void stpQAdd_ValueChanged(object sender, EventArgs e)
        {
            qConfig.addcount = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void stpQMul_ValueChanged(object sender, EventArgs e)
        {
            qConfig.mulcount = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void stpQDiv_ValueChanged(object sender, EventArgs e)
        {
            qConfig.divcount = decimal.ToInt32((sender as NumericUpDown).Value);
        }

        private void lBoxQuizDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            try
            {
                GenerateQuestions(r);
            }
            catch (Exception)
            {
                MessageBox.Show("未选定合适的运算符！");
            }
            return;
        }

        private void GenerateQuestions(Random r)
        {
            if(qConfig.eBuilder.allowOprt == (byte)ExprOprt.NIL)
            {
                throw new NoOprtFoundException();
            }
            for (var i = 0; i < qConfig.Count; i++)
            {
                try
                {
                    Expr egen = qConfig.eBuilder.Generate(r);
                    if (egen == null)
                    {
                        i--;
                        continue;
                    }
                    questions.Add(egen);
                    if (qConfig.eBuilder.allowCplxExpr)
                    {
                        switch (egen.oprt)
                        {
                            case ExprOprt.ADD:
                                qConfig.addcount++;
                                break;
                            case ExprOprt.SUB:
                                qConfig.subcount++;
                                break;
                            case ExprOprt.MUL:
                                qConfig.mulcount++;
                                break;
                            case ExprOprt.DIV:
                                qConfig.divcount++;
                                break;
                            default:
                                throw new InvalidExprOprtParseException(egen.oprt);
                        }
                    }
                }
                catch (Exception)
                {
                    i--;
                    continue;
                }
                //questions.Add(egen);
            }
        }
    }
}
