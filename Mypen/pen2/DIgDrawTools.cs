using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pen2
{
    //绘图工具箱窗口类
    public partial class DIgDrawTools : Form
    {
        //类属性：保存FormMain主窗口对象
        public FormMain _formMain;
        
        private void DIgDrawTools_Load(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            buttonLine.Visible = false;
            buttonRectangle.Visible = false;
            buttonCircle.Visible = false;
            buttonSketch.Visible = false;
            buttonWidth.Visible = false;
            buttonColor.Visible = false;
            buttonUndo.Visible = false;
            buttonExit.Visible = false;
            Size = new Size(80,100);
        }
        //构造方法
        public DIgDrawTools()
        {
            InitializeComponent();
           
        }
        //徒手画按钮的响应事件
        private void buttonSketch_Click(object sender, EventArgs e)
        {
            _formMain.MenuItemSketch_Click(null,null);
        }
        //画直线按钮的响应事件
        private void buttonLine_Click(object sender, EventArgs e)
        {
            _formMain.MenuItemLine_Click(null, null);
        }
        //画矩形按钮的响应事件
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            _formMain.MenuItemRectangle_Click(null, null);
        }
        //画圆按钮的响应事件
        private void buttonCircle_Click(object sender, EventArgs e)
        {
            _formMain.MenuItemCircle_Click(null, null);
        }
        //线宽按钮的响应事件
        private void buttonWidth_Click(object sender, EventArgs e)
        {
            _formMain.MenuItemWidth_Click(null, null);
        }
        //颜色按钮的响应事件
        private void buttonColor_Click(object sender, EventArgs e)
        {
            _formMain.MenuItemColor_Click(null, null);
        }
        //撤销按钮的响应事件
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            _formMain.MenuItemUndo_Click(null, null);
        }
        //退出按钮的事件响应方法
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //显示窗口所有界面
            _formMain.menuStrip1.Visible = true;
            _formMain.toolStrip1.Visible = true;
            _formMain.statusStrip1.Visible = true;
            _formMain.FormBorderStyle = FormBorderStyle.Sizable;
            //主窗口最大化
            _formMain.WindowState = FormWindowState.Maximized;
            //关闭绘图工具箱
            this.Close();


        }
        //开始按钮的响应事件
        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            buttonLine.Visible = true;
            buttonRectangle.Visible = true;
            buttonCircle.Visible = true;
            buttonSketch.Visible = true;
            buttonWidth.Visible = true;
            buttonColor.Visible = true;
            buttonUndo.Visible = true;
            buttonExit.Visible = true;
            Size = new Size(80,500);
        }
        //FormClosed事件响应方法
        private void DIgDrawTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            //显示窗口所有界面
            _formMain.menuStrip1.Visible = true;
            _formMain.toolStrip1.Visible = true;
            _formMain.statusStrip1.Visible = true;
            _formMain.FormBorderStyle = FormBorderStyle.Sizable;
            //主窗口最大化
            _formMain.WindowState = FormWindowState.Maximized;
        }

        private void DIgDrawTools_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X <= this.Size.Width*2)
            {
                this.Location = new Point(10, this.Location.Y);
            }
            else if (this.Location.X >= Screen.PrimaryScreen.Bounds.Width - this.Size.Width*2)
            {
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width - 10, this.Location.Y);
            }
            else if (this.Location.Y <=20)
            {
                this.Location = new Point(this.Location.X, 10);
            }
            else if (this.Location.Y >= Screen.PrimaryScreen.Bounds.Height - this.Size.Height - 20)
            {
                this.Location = new Point(this.Location.X, Screen.PrimaryScreen.Bounds.Height - this.Size.Height - 10);
            }
            else if (this.Location.X <= this.Size.Width * 2 && this.Location.Y <= 20)
            {
                this.Location = new Point(10,10);
            }
            else if (this.Location.X <= this.Size.Width * 2 && this.Location.Y >= Screen.PrimaryScreen.Bounds.Height - this.Size.Height - 20)
            {
                this.Location = new Point(10, Screen.PrimaryScreen.Bounds.Height - this.Size.Height - 10);
            }
            else if (this.Location.X>=Screen.PrimaryScreen.Bounds.Width - this.Size.Width * 2 && this.Location.Y <= 20)
            {
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width - 10, 10);
            }
            else if (this.Location.X>=Screen.PrimaryScreen.Bounds.Width - this.Size.Width * 2 && this.Location.Y >= Screen.PrimaryScreen.Bounds.Height - this.Size.Height - 20)
            {
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width - 10, Screen.PrimaryScreen.Bounds.Height - this.Size.Height - 10);
            }
        }
  
        
    }
}
