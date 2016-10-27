using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            this.ControlBox = false;
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;            
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
        }

        private void setBtnEnable(int index, bool bEnable)
        {            
            switch (index)
            {
                case 0:
                    button1.Enabled = bEnable;
                    break;
                case 1:
                    button2.Enabled = bEnable;
                    break;
                case 2:
                    button3.Enabled = bEnable;
                    break;
                case 3:
                    button4.Enabled = bEnable;
                    break;
                case 4:
                    button5.Enabled = bEnable;
                    break;
            }
        }

        public void setGroupBtnDown(int index)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i==index)
                {
                    setBtnEnable(i, false);
                }else{
                    setBtnEnable(i, true);
                }                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setGroupBtnDown(0);
            Form1 frm1 = (Form1)this.MdiParent;
            frm1.setGroupMenuFuncEnable(0);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.LINE;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setGroupBtnDown(1);
            Form1 frm1 = (Form1)this.MdiParent;
            frm1.setGroupMenuFuncEnable(1);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.RECT;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setGroupBtnDown(2);
            Form1 frm1 = (Form1)this.MdiParent;
            frm1.setGroupMenuFuncEnable(2);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.ELLIPSE;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setGroupBtnDown(3);
            Form1 frm1 = (Form1)this.MdiParent;
            frm1.setGroupMenuFuncEnable(3);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.TEXT;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setGroupBtnDown(4);
            Form1 frm1 = (Form1)this.MdiParent;
            frm1.setGroupMenuFuncEnable(4);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.SELECT;
        }

       
    }
}