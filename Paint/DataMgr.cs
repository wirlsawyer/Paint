using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;

namespace Paint
{
    public class DataMgr
    {     

        public enum DrawShape {LINE, RECT, ELLIPSE, TEXT, SELECT};
        public DrawShape CurShapMode = DrawShape.LINE;
        public Pen CurPen = new Pen(Color.Black);
        public SolidBrush CurBrush = new SolidBrush(Color.Transparent);
        public ArrayList DataInfosAry = new ArrayList(); 

        private static readonly object Mutex = new object();
        private static volatile DataMgr _instance;
        private DataMgr() 
        {
            this.New();
        }

        public static DataMgr getInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Mutex)
                    {
                        if (_instance == null)
                            _instance = new DataMgr();
                    }
                }
                return _instance;
            }
        }


        public void New()
        {
            DataInfosAry.Clear();
            CurShapMode = DrawShape.LINE;
            SetWidth(1);
            SetPenColor(0);
            SetBrushColor(0);
        }

        public void SetPenColor(int indx)
        {
            switch (indx)
            {
                case 0:
                    CurPen.Color = Color.FromArgb(0, 0, 0);                    
                    break;
                case 1:
                    CurPen.Color = Color.FromArgb(255, 128, 64);                   
                    break;
                case 2:
                    CurPen.Color = Color.FromArgb(255, 0, 0);                    
                    break;
                case 3:
                    CurPen.Color = Color.FromArgb(255, 255, 0);                    
                    break;
                case 4:
                    CurPen.Color = Color.FromArgb(0, 128, 0);                    
                    break;
                case 5:
                    CurPen.Color = Color.FromArgb(0, 255, 255);                    
                    break;
                case 6:
                    CurPen.Color = Color.FromArgb(0, 0, 255);                    
                    break;
                case 7:
                    CurPen.Color = Color.FromArgb(255, 0, 255);                    
                    break;
                default:
                    break;
            }     
        }

        public void SetBrushColor(int indx)
        {
            switch (indx)
            {
                case 0:
                    CurBrush.Color = Color.Transparent;
                    break;
                case 1:
                    CurBrush.Color = Color.FromArgb(0, 0, 0);
                    break;
                case 2:
                    CurBrush.Color = Color.FromArgb(255, 128, 64);
                    break;
                case 3:
                    CurBrush.Color = Color.FromArgb(255, 0, 0);
                    break;
                case 4:
                    CurBrush.Color = Color.FromArgb(255, 255, 0);
                    break;
                case 5:
                    CurBrush.Color = Color.FromArgb(0, 128, 0);
                    break;
                case 6:
                    CurBrush.Color = Color.FromArgb(0, 255, 255);
                    break;
                case 7:
                    CurBrush.Color = Color.FromArgb(0, 0, 255);
                    break;
                case 8:
                    CurBrush.Color = Color.FromArgb(255, 0, 255);
                    break;
                default:
                    break;
            }
        }
         
        public void SetWidth(int width)
        {
            CurPen.Width = width;
        }
    }
}
