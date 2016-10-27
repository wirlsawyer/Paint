using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);  
        
        private Form2 toolWin = new Form2();
        private Form3 paintWin = new Form3();

        public Form1()
        {
            InitializeComponent();

            paintWin.Left = 0;
            paintWin.Top = 0;
            paintWin.Width = 1000;
            paintWin.Height = 1000;            
            paintWin.FormBorderStyle = FormBorderStyle.None;
            paintWin.MdiParent = this;
            paintWin.Show();

            toolWin.MdiParent = this;
            toolWin.Show();           
        }


        private void Form1_Load(object sender, EventArgs e)
        {            
           
        }

   
        private void setMenuFuncEnable(int index, bool bEnable)
        {
            switch (index)
            {
                case 0:
                    ((ToolStripMenuItem)lineToolStripMenuItem).Checked = bEnable;
                    break;
                case 1:
                    ((ToolStripMenuItem)rectToolStripMenuItem).Checked = bEnable;
                    break;
                case 2:
                    ((ToolStripMenuItem)ellipseToolStripMenuItem).Checked = bEnable;
                    break;
                case 3:
                    ((ToolStripMenuItem)TextToolStripMenuItem).Checked = bEnable;
                    break;
                case 4:
                    ((ToolStripMenuItem)selectToolStripMenuItem).Checked = bEnable;
                    break;
            }
        }

        public void setGroupMenuFuncEnable(int index)
        {             
            for (int i=0; i<5; i++)
            {
                if (i == index)
                {
                    setMenuFuncEnable(i, true);
                }else{
                    setMenuFuncEnable(i, false);
                }
            }
        }

        private void setMenuColorEnable(int index, bool bEnable)
        {
            switch (index)
            {
                case 0:
                    ((ToolStripMenuItem)colorMenuItem1).Checked = bEnable;
                    break;
                case 1:
                    ((ToolStripMenuItem)colorMenuItem2).Checked = bEnable;
                    break;
                case 2:
                    ((ToolStripMenuItem)colorMenuItem3).Checked = bEnable;
                    break;
                case 3:
                    ((ToolStripMenuItem)colorMenuItem4).Checked = bEnable;
                    break;
                case 4:
                    ((ToolStripMenuItem)colorMenuItem5).Checked = bEnable;
                    break;
                case 5:
                    ((ToolStripMenuItem)colorMenuItem6).Checked = bEnable;
                    break;
                case 6:
                    ((ToolStripMenuItem)colorMenuItem7).Checked = bEnable;
                    break;
                case 7:
                    ((ToolStripMenuItem)colorMenuItem8).Checked = bEnable;
                    break;               
            }
        }

        public void setGroupMenuColorEnable(int index)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i == index)
                {
                    setMenuColorEnable(i, true);
                    DataMgr.getInstance.SetPenColor(i);
                }
                else
                {
                    setMenuColorEnable(i, false);
                }
            }
        }

        private void setMenuWidthEnable(int index, bool bEnable)
        {
            switch (index)
            {
                case 0:
                    ((ToolStripMenuItem)widthMenuItem1).Checked = bEnable;
                    break;
                case 1:
                    ((ToolStripMenuItem)widthMenuItem2).Checked = bEnable;
                    break;
                case 2:
                    ((ToolStripMenuItem)widthMenuItem3).Checked = bEnable;
                    break;
                case 3:
                    ((ToolStripMenuItem)widthMenuItem4).Checked = bEnable;
                    break;
                case 4:
                    ((ToolStripMenuItem)widthMenuItem5).Checked = bEnable;
                    break;               
            }
        }

        public void setGroupMenuWidthEnable(int index)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == index)
                {
                    setMenuWidthEnable(i, true);
                }
                else
                {
                    setMenuWidthEnable(i, false);
                }
            }
        }

        private void setMenuBackgroundEnable(int index, bool bEnable)
        {
            switch (index)
            {
                case 0:
                    ((ToolStripMenuItem)backgroundMenuItem1).Checked = bEnable;
                    break;
                case 1:
                    ((ToolStripMenuItem)backgroundMenuItem2).Checked = bEnable;
                    break;
                case 2:
                    ((ToolStripMenuItem)backgroundMenuItem3).Checked = bEnable;
                    break;
                case 3:
                    ((ToolStripMenuItem)backgroundMenuItem4).Checked = bEnable;
                    break;
                case 4:
                    ((ToolStripMenuItem)backgroundMenuItem5).Checked = bEnable;
                    break;
                case 5:
                    ((ToolStripMenuItem)backgroundMenuItem6).Checked = bEnable;
                    break;
                case 6:
                    ((ToolStripMenuItem)backgroundMenuItem7).Checked = bEnable;
                    break;
                case 7:
                    ((ToolStripMenuItem)backgroundMenuItem8).Checked = bEnable;
                    break;
                case 8:
                    ((ToolStripMenuItem)backgroundMenuItem9).Checked = bEnable;
                    break;
            }
        }

        public void setGroupMenuBackgroundEnable(int index)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i == index)
                {
                    setMenuBackgroundEnable(i, true);
                    DataMgr.getInstance.SetBrushColor(i);
                }
                else
                {
                    setMenuBackgroundEnable(i, false);
                }
            }
        }

                     

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setGroupMenuFuncEnable(0);
            toolWin.setGroupBtnDown(0);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.LINE;
        }

        private void rectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setGroupMenuFuncEnable(1);
            toolWin.setGroupBtnDown(1);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.RECT;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setGroupMenuFuncEnable(2);
            toolWin.setGroupBtnDown(2);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.ELLIPSE;
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setGroupMenuFuncEnable(3);
            toolWin.setGroupBtnDown(3);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.TEXT;
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setGroupMenuFuncEnable(4);
            toolWin.setGroupBtnDown(4);
            DataMgr.getInstance.CurShapMode = DataMgr.DrawShape.SELECT;
        }

        private void colorMenuItem1_Click(object sender, EventArgs e)
        {
            setGroupMenuColorEnable(0);            
        }

        private void colorMenuItem2_Click(object sender, EventArgs e)
        {
            setGroupMenuColorEnable(1);
        }

        private void colorMenuItem3_Click(object sender, EventArgs e)
        {
            setGroupMenuColorEnable(2);
        }

        private void colorMenuItem4_Click(object sender, EventArgs e)
        {
            setGroupMenuColorEnable(3);
        }

        private void colorMenuItem5_Click(object sender, EventArgs e)
        {
            setGroupMenuColorEnable(4);
        }

        private void colorMenuItem6_Click(object sender, EventArgs e)
        {
            setGroupMenuColorEnable(5);
        }

        private void colorMenuItem7_Click(object sender, EventArgs e)
        {
            setGroupMenuColorEnable(6);
        }

        private void colorMenuItem8_Click(object sender, EventArgs e)
        {
            setGroupMenuColorEnable(7);
        }

        private void widthMenuItem1_Click(object sender, EventArgs e)
        {
            setGroupMenuWidthEnable(0);
            DataMgr.getInstance.SetWidth(1);
        }

        private void widthMenuItem2_Click(object sender, EventArgs e)
        {
            setGroupMenuWidthEnable(1);
            DataMgr.getInstance.SetWidth(3);
        }

        private void widthMenuItem3_Click(object sender, EventArgs e)
        {
            setGroupMenuWidthEnable(2);
            DataMgr.getInstance.SetWidth(5);
        }

        private void widthMenuItem4_Click(object sender, EventArgs e)
        {
            setGroupMenuWidthEnable(3);
            DataMgr.getInstance.SetWidth(7);
        }

        private void widthMenuItem5_Click(object sender, EventArgs e)
        {
            setGroupMenuWidthEnable(4);
            DataMgr.getInstance.SetWidth(9);
        }

        private void backgroundMenuItem1_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(0);            
        }

        private void backgroundMenuItem2_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(1);            
        }

        private void backgroundMenuItem3_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(2);            
        }

        private void backgroundMenuItem4_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(3);            
        }

        private void backgroundMenuItem5_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(4);
        }

        private void backgroundMenuItem6_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(5);
        }

        private void backgroundMenuItem7_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(6);
        }

        private void backgroundMenuItem8_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(7);
        }

        private void backgroundMenuItem9_Click(object sender, EventArgs e)
        {
            setGroupMenuBackgroundEnable(8);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolWin.BringToFront();                       
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setGroupMenuFuncEnable(0);
            toolWin.setGroupBtnDown(0);
            setGroupMenuWidthEnable(0);
            setGroupMenuColorEnable(0);
            setGroupMenuBackgroundEnable(0);    
            DataMgr.getInstance.New();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
     
    }
}