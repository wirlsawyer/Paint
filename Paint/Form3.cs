using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Paint
{
    public partial class Form3 : Form
    {
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]        
        public static extern bool GetCursorPos(ref Point lpPoint);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref RECT rectangle);

       
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }


        private Point mCurDown;
        private Point mCurUp;
        public Form3()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // 防止閃爍
            this.BackColor = Color.White;       
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            mCurDown.X = -1;
            mCurDown.Y = -1;
            mCurUp.X = -1;
            mCurUp.Y = -1;
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (DataInfo item in DataMgr.getInstance.DataInfosAry)
            {
                item.Execute(g);
            }

            if (mCurDown.X == -1 && mCurDown.Y == -1)
            {
                // nothing
            }else{                         
                DataInfo newInfo = new DataInfo(DataMgr.getInstance.CurShapMode, DataMgr.getInstance.CurPen, DataMgr.getInstance.CurBrush, mCurDown, mCurUp);
                newInfo.Execute(g);
            }
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            mCurDown.X = e.X;
            mCurDown.Y = e.Y;
            mCurUp.X = e.X;
            mCurUp.Y = e.Y;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            mCurUp.X = e.X;
            mCurUp.Y = e.Y;
            checkBoard();

            this.Invalidate();
            this.Update();
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            mCurUp.X = e.X;
            mCurUp.Y = e.Y;
         
            DataInfo newInfo = new DataInfo(DataMgr.getInstance.CurShapMode, DataMgr.getInstance.CurPen, DataMgr.getInstance.CurBrush, mCurDown, mCurUp);
            DataMgr.getInstance.DataInfosAry.Add(newInfo);

            mCurDown.X = -1;
            mCurDown.Y = -1;
            mCurUp.X = -1;
            mCurUp.Y = -1;

            this.Invalidate();
            this.Update();
        }

        private void checkBoard()
        {
            RECT r = new RECT();
            GetWindowRect(this.Parent.Handle, ref r);

            Point defPnt = new Point();
            GetCursorPos(ref defPnt);

            int x = this.Parent.Left - defPnt.X;
            int y = this.Parent.Top - defPnt.Y;


            if (defPnt.X < r.Left)
            {
                System.Diagnostics.Debug.Print("小於左邊");
            }
            else if (defPnt.X > r.Right)
            {
                System.Diagnostics.Debug.Print("大於右邊");

            }

            if (defPnt.Y < r.Top)
            {
                System.Diagnostics.Debug.Print("小於上邊");
            }
            else if (defPnt.Y > r.Bottom)
            {
                System.Diagnostics.Debug.Print("大於下邊=" + this.VerticalScroll.Value);               

            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {            
            this.Invalidate();
            this.Update();
        }

        private void Form3_MouseCaptureChanged(object sender, EventArgs e)
        {
            

        }
     
    }
}