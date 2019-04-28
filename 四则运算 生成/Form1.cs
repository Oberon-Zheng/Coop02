using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 四则运算_生成
{
    public partial class FrmQuizGen : Form
    {
        public FrmQuizGen()
        {
            InitializeComponent();
        }

        private void stpQAddSub_ValueChanged(object sender, EventArgs e)
        {

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
            stpQAdd.Enabled = cBoxQTypeAdd.Checked && cBoxQTypeAdd.Enabled;
            stpQSub.Enabled = cBoxQTypeSub.Checked && cBoxQTypeSub.Enabled;
            stpQMul.Enabled = cBoxQTypeMul.Checked && cBoxQTypeMul.Enabled;
            stpQDiv.Enabled = cBoxQTypeDiv.Checked && cBoxQTypeDiv.Enabled;
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

        }
    }
}
