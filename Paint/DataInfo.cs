using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Paint
{
    class DataInfo
    {
        private DataMgr.DrawShape mShapMode;
        private Pen mPen = new Pen(Color.Black);
        private SolidBrush mBrush = new SolidBrush(Color.Transparent);
        private Point mDownPos;
        private Point mUpPos;

        public DataInfo(DataMgr.DrawShape shapMode, Pen pen, SolidBrush brush, Point down, Point up)
        {
            this.mShapMode = shapMode;
            this.mPen = (Pen)pen.Clone();
            this.mBrush = (SolidBrush)brush.Clone();
            this.mDownPos = down;
            this.mUpPos = up;
        }

        public void Execute(Graphics g)
        {
            int x = Math.Min(mDownPos.X, mUpPos.X);
            int y = Math.Min(mDownPos.Y, mUpPos.Y);
            int w = Math.Abs(mDownPos.X - mUpPos.X);
            int h = Math.Abs(mDownPos.Y - mUpPos.Y);
                   

            switch (this.mShapMode)
            {
                case DataMgr.DrawShape.LINE:
                    g.DrawLine(this.mPen, this.mDownPos, this.mUpPos);
                    break;
                case DataMgr.DrawShape.RECT:
                    g.FillRectangle(this.mBrush, x, y, w, h);
                    g.DrawRectangle(this.mPen, x, y, w, h);
                    break;
                case DataMgr.DrawShape.ELLIPSE:
                    g.FillEllipse(this.mBrush, x, y, w, h);
                    g.DrawEllipse(this.mPen, x, y, w, h);
                    break;
                case DataMgr.DrawShape.TEXT:
                    break;
                case DataMgr.DrawShape.SELECT:
                    break;
            }
        }
    }
}
