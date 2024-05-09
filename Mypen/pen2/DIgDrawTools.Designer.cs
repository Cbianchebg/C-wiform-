namespace pen2
{
    partial class DIgDrawTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIgDrawTools));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonWidth = new System.Windows.Forms.Button();
            this.buttonSketch = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(2, 383);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(71, 47);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "退出";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonUndo.Image = global::pen2.Properties.Resources.undo;
            this.buttonUndo.Location = new System.Drawing.Point(2, 330);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(71, 47);
            this.buttonUndo.TabIndex = 14;
            this.buttonUndo.Text = "撤销";
            this.buttonUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonUndo.UseVisualStyleBackColor = false;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonColor.Image = global::pen2.Properties.Resources.color;
            this.buttonColor.Location = new System.Drawing.Point(2, 224);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(71, 47);
            this.buttonColor.TabIndex = 13;
            this.buttonColor.Text = "颜色";
            this.buttonColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonWidth
            // 
            this.buttonWidth.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonWidth.Image = global::pen2.Properties.Resources.width;
            this.buttonWidth.Location = new System.Drawing.Point(2, 277);
            this.buttonWidth.Name = "buttonWidth";
            this.buttonWidth.Size = new System.Drawing.Size(71, 47);
            this.buttonWidth.TabIndex = 12;
            this.buttonWidth.Text = "线宽";
            this.buttonWidth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonWidth.UseVisualStyleBackColor = false;
            this.buttonWidth.Click += new System.EventHandler(this.buttonWidth_Click);
            // 
            // buttonSketch
            // 
            this.buttonSketch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSketch.Image = global::pen2.Properties.Resources.sketch;
            this.buttonSketch.Location = new System.Drawing.Point(2, 171);
            this.buttonSketch.Name = "buttonSketch";
            this.buttonSketch.Size = new System.Drawing.Size(71, 47);
            this.buttonSketch.TabIndex = 11;
            this.buttonSketch.Text = "徒手画";
            this.buttonSketch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSketch.UseVisualStyleBackColor = false;
            this.buttonSketch.Click += new System.EventHandler(this.buttonSketch_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCircle.Image = global::pen2.Properties.Resources.circle;
            this.buttonCircle.Location = new System.Drawing.Point(2, 118);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(71, 47);
            this.buttonCircle.TabIndex = 10;
            this.buttonCircle.Text = "圆";
            this.buttonCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonRectangle.Image = global::pen2.Properties.Resources.rectangle;
            this.buttonRectangle.Location = new System.Drawing.Point(2, 65);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(71, 47);
            this.buttonRectangle.TabIndex = 9;
            this.buttonRectangle.Text = "矩形";
            this.buttonRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLine.Image = global::pen2.Properties.Resources.line;
            this.buttonLine.Location = new System.Drawing.Point(2, 12);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(71, 47);
            this.buttonLine.TabIndex = 8;
            this.buttonLine.Text = "直线";
            this.buttonLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonStart.Location = new System.Drawing.Point(2, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 47);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // DIgDrawTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 435);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonWidth);
            this.Controls.Add(this.buttonSketch);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DIgDrawTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "绘图工具箱";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.DIgDrawTools_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DIgDrawTools_FormClosed);
            this.LocationChanged += new System.EventHandler(this.DIgDrawTools_LocationChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonWidth;
        private System.Windows.Forms.Button buttonSketch;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonStart;
    }
}