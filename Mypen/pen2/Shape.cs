using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace pen2
{
    public enum DrawType
    { 
       Stop=0,Line=1,Rectangle=2,Circle=3,Sketch=4
    }
    public abstract class Shape
    {
        //类字段
        private int _penWidth = 10;//画笔宽度

        public int _PenWidth
        {
            get { return _penWidth; }
            set { _penWidth = value; }
        }
        private Color _penColor = Color.Red;//画笔颜色

        public Color _PenColor
        {
            get { return _penColor; }
            set { _penColor = value; }
        }
        //绘制图元方法。注意：使用DashStyle类时，要添加System.Drawing2D命名空间
        public abstract void Draw(Graphics g,DashStyle ds,double zoomRatio);
        //写入文件方法(抽象方法)（注意：BinaryWriter类需要添加System.IO命名空间）
        public abstract void Write(BinaryWriter bw);
        //读取文件方法(抽象方法)（注意：BinaryWriter类需要添加System.IO命名空间）
        public abstract void Read(BinaryReader br);

    }
    public class Line : Shape
    {
        private Point _p1;

        public Point _P1
        {
            get { return _p1; }
            set { _p1 = value; }
        }
        private Point _p2;

        public Point _P2
        {
            get { return _p2; }
            set { _p2 = value; }
        }
        public Line(Point p1,Point p2)
        {
            _p1 = p1;
            _p2 = p2;
        }
        //绘制图元方法
        public override void Draw(Graphics g, DashStyle ds, double zoomRatio)
        {
            Pen p = new Pen(_PenColor,(int)(_PenWidth*zoomRatio));
            //设置画笔线形
            p.DashStyle = ds;
            //获取缩放后直线的起点终点
            Point p1=new Point((int)(_p1.X*zoomRatio),(int)(_p1.Y*zoomRatio));
            Point p2=new Point((int)(_p2.X*zoomRatio),(int)(_p2.Y*zoomRatio));
            //绘制缩放后的直线
            g.DrawLine(p,p1,p2);
        }
        //写入文件方法
        public override void Write(BinaryWriter bw)
        {
            //写入线宽和颜色
            bw.Write(_PenWidth);
            bw.Write(_PenColor.ToArgb());
            //写入_p1,_p2点的坐标
            bw.Write(_p1.X); bw.Write(_p1.Y);
            bw.Write(_p2.X); bw.Write(_p2.Y);
        }
        //读取文件方法
        public override void Read(BinaryReader br)
        {
            //读出线宽和颜色
            _PenWidth = br.ReadInt32();
            _PenColor = Color.FromArgb(br.ReadInt32());
            //读出_p1,_p2点的坐标
            _p1.X = br.ReadInt32(); _p1.Y = br.ReadInt32();
            _p2.X = br.ReadInt32(); _p2.Y = br.ReadInt32();
        }
    }
    public class Rectangle : Shape
    {
        private Point _p3;

        public Point _P3
        {
            get { return _p3; }
            set { _p3 = value; }
        }
        private Point _p4;

        public Point _P4
        {
            get { return _p4; }
            set { _p4 = value; }
        }
        public Rectangle(Point p3, Point p4)
        {
            _p3 = p3;
            _p4 = p4;
        }
        public override void Draw(Graphics g, DashStyle ds, double zoomRatio)
        {
            Pen p = new Pen(_PenColor, (int)(_PenWidth * zoomRatio));
            //设置画笔线形
            p.DashStyle = ds;
            //获取缩放后矩形对角线点坐标
            Point p3 = new Point((int)(_p3.X * zoomRatio), (int)(_p3.Y * zoomRatio));
            Point p4 = new Point((int)(_p4.X * zoomRatio), (int)(_p4.Y * zoomRatio));
            //绘制缩放后的的矩形左上角的坐标
            Point leftTop = new Point();
            leftTop.X=(p3.X<=p4.X)?p3.X:p4.X;
            leftTop.Y = (_p3.Y <= _p4.Y) ? _p3.Y : _p4.Y;
            g.DrawRectangle(p, leftTop.X, leftTop.Y, Math.Abs(_p4.X - _p3.X), Math.Abs(_p4.Y - _p3.Y));
        }
        //写入文件方法
        public override void Write(BinaryWriter bw)
        {
            //写入线宽和颜色
            bw.Write(_PenWidth);
            bw.Write(_PenColor.ToArgb());
            //写入_p3,_p4点的坐标
            bw.Write(_p3.X); bw.Write(_p3.Y);
            bw.Write(_p4.X); bw.Write(_p4.Y);
        }
        //读取文件方法
        public override void Read(BinaryReader br)
        {
            //读出线宽和颜色
            _PenWidth = br.ReadInt32();
            _PenColor = Color.FromArgb(br.ReadInt32());
            //读出_p3,_p4点的坐标
            _p3.X = br.ReadInt32(); _p3.Y = br.ReadInt32();
            _p4.X = br.ReadInt32(); _p4.Y = br.ReadInt32();
        }
    }
    public class Circle : Shape
    {
        private Point _pCenter;

       public Point _PCenter
      {
         get { return _pCenter; }
         set { _pCenter = value; }
       }

        
        private float _r;

      public float _R
     {
        get { return _r; }
        set { _r = value; }
     }


      public Circle(Point pCenter, float r)
        {
            _pCenter = pCenter;
            _r = r;
        }
      public override void Draw(Graphics g, DashStyle ds, double zoomRatio)
        {
            Pen p = new Pen(_PenColor, (int)(_PenWidth * zoomRatio));
            //设置画笔线形
            p.DashStyle = ds;
            //获取缩放后的圆心点的坐标
            Point pCenter = new Point((int)(_pCenter.X * zoomRatio), (int)(_pCenter.Y * zoomRatio));
            //获取缩放后的圆的半径
            float r = (float)(_r * zoomRatio);
           //绘制缩放后的圆
            g.DrawEllipse(p, pCenter.X-r, pCenter.Y-_r,2*r,2*r);
        }
      //写入文件方法
      public override void Write(BinaryWriter bw)
      {
          //写入线宽和颜色
          bw.Write(_PenWidth);
          bw.Write(_PenColor.ToArgb());
          //写入_pCenter,_r点的坐标
          bw.Write(_pCenter.X); bw.Write(_pCenter.Y);
          bw.Write(_r); 
      }
      //读取文件方法
      public override void Read(BinaryReader br)
      {
          //读出线宽和颜色
          _PenWidth = br.ReadInt32();
          _PenColor = Color.FromArgb(br.ReadInt32());
          //读出_p1,_p2点的坐标
          _pCenter.X = br.ReadInt32(); _pCenter.Y = br.ReadInt32();
          _r = br.ReadSingle();
      }
    }
    
    //Sketch子类
public class Sketch:Shape
{
    //类字段
    private List<Point>_pointList=new List<Point>();


    //类属性
        public List<Point> _PointList
    {
      get { return _pointList; }
      set { _pointList = value; }
    }
    //构造方法
    public Sketch()
    {
    }
    //绘制图元方法
    public override void Draw(Graphics g, DashStyle ds, double zoomRatio)
        {
         //创建画笔对象
            Pen p = new Pen(_PenColor, (int)(_PenWidth * zoomRatio));
            //设置画笔线形
            p.DashStyle = ds;
         //设置画笔的线帽样式为圆头。如果缺少会出现开裂现象
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.Round;
            // 创建用于DrawCurve的点数组
            PointF[] pointsForCurve = new PointF[_pointList.Count];

            // 将_pointList中的Point转换为PointF，并填充到pointsForCurve数组中
            for (int i = 0; i < _pointList.Count; i++)
            {
                pointsForCurve[i] = new PointF(_pointList[i].X * (float)zoomRatio, _pointList[i].Y * (float)zoomRatio);
            }

            // 绘制曲线
            // 注意：此处的索引范围应为[0, pointsForCurve.Length - 1]
            // 因为我们不需要包括最后一个点之后的任何控制点
            g.DrawCurve(p, pointsForCurve, 0, pointsForCurve.Length - 1);
           
        }
      //写入文件方法
      public override void Write(BinaryWriter binaryWriter)
      {
          //写入线宽和颜色
          binaryWriter.Write(_PenWidth);
         binaryWriter.Write(_PenColor.ToArgb());
          //逐一写入Sketch的点坐标
          foreach(Point temPoint in _pointList)
          {
            binaryWriter.Write(temPoint.X);
              binaryWriter.Write(temPoint.Y);
          }
         
      }
      //读取文件方法
      public override void Read(BinaryReader binaryReader)
      {
          //清空_pointList
          _pointList.Clear();
          //读出线宽和颜色
          _PenWidth = binaryReader.ReadInt32();
          _PenColor = Color.FromArgb(binaryReader.ReadInt32());
          //读出Sketch的总点数
          int pointCount=binaryReader.ReadInt32();
          //逐一读出个点的坐标，并添加到_pointList中
          for(int i=0;i<=pointCount-1;i++)
          {
              int x=binaryReader.ReadInt32();
              int y=binaryReader.ReadInt32();
              Point point=new Point(x,y);
              _pointList.Add(point);
          }
      }


}
}
