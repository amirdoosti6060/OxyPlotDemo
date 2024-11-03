namespace OxyPlotDemo
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            menuStrip1 = new MenuStrip();
            mnuInteraction = new ToolStripMenuItem();
            mnuEnableZoomX = new ToolStripMenuItem();
            mnuEnableZoomY = new ToolStripMenuItem();
            mnuEnablePanX = new ToolStripMenuItem();
            mnuEnablePanY = new ToolStripMenuItem();
            mnuZoomAll = new ToolStripMenuItem();
            mnuReferesh = new ToolStripMenuItem();
            mnuLegend = new ToolStripMenuItem();
            mnuTopLeft = new ToolStripMenuItem();
            mnuTopCenter = new ToolStripMenuItem();
            mnuTopRight = new ToolStripMenuItem();
            mnuBottomLeft = new ToolStripMenuItem();
            mnuBottomCenter = new ToolStripMenuItem();
            mnuBottomRight = new ToolStripMenuItem();
            mnuLeftTop = new ToolStripMenuItem();
            mnuLeftMiddle = new ToolStripMenuItem();
            mnuLeftBottom = new ToolStripMenuItem();
            mnuRightTop = new ToolStripMenuItem();
            mnuRightMiddle = new ToolStripMenuItem();
            mnuRightButtom = new ToolStripMenuItem();
            mnuHorizVert = new ToolStripMenuItem();
            mnuOutsideInside = new ToolStripMenuItem();
            mnuLeftRight = new ToolStripMenuItem();
            mnuAxes = new ToolStripMenuItem();
            mnuData = new ToolStripMenuItem();
            mnu360Points = new ToolStripMenuItem();
            mnu3600Points = new ToolStripMenuItem();
            mnu36000Points = new ToolStripMenuItem();
            mnu360000Points = new ToolStripMenuItem();
            mnuLive = new ToolStripMenuItem();
            mnuHideSeries1 = new ToolStripMenuItem();
            mnuHideSeries2 = new ToolStripMenuItem();
            mnuHideAxisX = new ToolStripMenuItem();
            mnuHideAxisY = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // plotView1
            // 
            plotView1.Dock = DockStyle.Fill;
            plotView1.Location = new Point(0, 24);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(800, 426);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuInteraction, mnuLegend, mnuAxes, mnuData });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuInteraction
            // 
            mnuInteraction.DropDownItems.AddRange(new ToolStripItem[] { mnuEnableZoomX, mnuEnableZoomY, mnuEnablePanX, mnuEnablePanY, mnuZoomAll, mnuReferesh });
            mnuInteraction.Name = "mnuInteraction";
            mnuInteraction.Size = new Size(76, 20);
            mnuInteraction.Text = "Interaction";
            // 
            // mnuEnableZoomX
            // 
            mnuEnableZoomX.Checked = true;
            mnuEnableZoomX.CheckState = CheckState.Checked;
            mnuEnableZoomX.Name = "mnuEnableZoomX";
            mnuEnableZoomX.Size = new Size(154, 22);
            mnuEnableZoomX.Text = "Enable Zoom X";
            mnuEnableZoomX.Click += mnuEnableZoomX_Click;
            // 
            // mnuEnableZoomY
            // 
            mnuEnableZoomY.Checked = true;
            mnuEnableZoomY.CheckState = CheckState.Checked;
            mnuEnableZoomY.Name = "mnuEnableZoomY";
            mnuEnableZoomY.Size = new Size(154, 22);
            mnuEnableZoomY.Text = "Enable Zoom Y";
            mnuEnableZoomY.Click += mnuEnableZoomY_Click;
            // 
            // mnuEnablePanX
            // 
            mnuEnablePanX.Checked = true;
            mnuEnablePanX.CheckState = CheckState.Checked;
            mnuEnablePanX.Name = "mnuEnablePanX";
            mnuEnablePanX.Size = new Size(154, 22);
            mnuEnablePanX.Text = "Enable Pan X";
            mnuEnablePanX.Click += mnuEnablePanX_Click;
            // 
            // mnuEnablePanY
            // 
            mnuEnablePanY.Checked = true;
            mnuEnablePanY.CheckState = CheckState.Checked;
            mnuEnablePanY.Name = "mnuEnablePanY";
            mnuEnablePanY.Size = new Size(154, 22);
            mnuEnablePanY.Text = "Enable Pan Y";
            mnuEnablePanY.Click += mnuEnablePanY_Click;
            // 
            // mnuZoomAll
            // 
            mnuZoomAll.Name = "mnuZoomAll";
            mnuZoomAll.Size = new Size(154, 22);
            mnuZoomAll.Text = "Zoom All";
            mnuZoomAll.Click += mnuZoomAll_Click;
            // 
            // mnuReferesh
            // 
            mnuReferesh.Name = "mnuReferesh";
            mnuReferesh.Size = new Size(154, 22);
            mnuReferesh.Text = "Refresh";
            mnuReferesh.Click += mnuReferesh_Click;
            // 
            // mnuLegend
            // 
            mnuLegend.DropDownItems.AddRange(new ToolStripItem[] { mnuTopLeft, mnuTopCenter, mnuTopRight, mnuBottomLeft, mnuBottomCenter, mnuBottomRight, mnuLeftTop, mnuLeftMiddle, mnuLeftBottom, mnuRightTop, mnuRightMiddle, mnuRightButtom, mnuHorizVert, mnuOutsideInside, mnuLeftRight, mnuHideSeries1, mnuHideSeries2 });
            mnuLegend.Name = "mnuLegend";
            mnuLegend.Size = new Size(58, 20);
            mnuLegend.Text = "Legend";
            // 
            // mnuTopLeft
            // 
            mnuTopLeft.Name = "mnuTopLeft";
            mnuTopLeft.Size = new Size(180, 22);
            mnuTopLeft.Text = "TopLeft";
            mnuTopLeft.Click += mnuTopLeft_Click;
            // 
            // mnuTopCenter
            // 
            mnuTopCenter.Name = "mnuTopCenter";
            mnuTopCenter.Size = new Size(180, 22);
            mnuTopCenter.Text = "TopCenter";
            mnuTopCenter.Click += mnuTopCenter_Click;
            // 
            // mnuTopRight
            // 
            mnuTopRight.Checked = true;
            mnuTopRight.CheckState = CheckState.Checked;
            mnuTopRight.Name = "mnuTopRight";
            mnuTopRight.Size = new Size(180, 22);
            mnuTopRight.Text = "TopRight";
            mnuTopRight.Click += mnuTopRight_Click;
            // 
            // mnuBottomLeft
            // 
            mnuBottomLeft.Name = "mnuBottomLeft";
            mnuBottomLeft.Size = new Size(180, 22);
            mnuBottomLeft.Text = "BottomLeft";
            mnuBottomLeft.Click += mnuBottomLeft_Click;
            // 
            // mnuBottomCenter
            // 
            mnuBottomCenter.Name = "mnuBottomCenter";
            mnuBottomCenter.Size = new Size(180, 22);
            mnuBottomCenter.Text = "BottomCenter";
            mnuBottomCenter.Click += mnuBottomCenter_Click;
            // 
            // mnuBottomRight
            // 
            mnuBottomRight.Name = "mnuBottomRight";
            mnuBottomRight.Size = new Size(180, 22);
            mnuBottomRight.Text = "BottomRight";
            mnuBottomRight.Click += mnuBottomRight_Click;
            // 
            // mnuLeftTop
            // 
            mnuLeftTop.Name = "mnuLeftTop";
            mnuLeftTop.Size = new Size(180, 22);
            mnuLeftTop.Text = "LeftTop";
            mnuLeftTop.Click += mnuLeftTop_Click;
            // 
            // mnuLeftMiddle
            // 
            mnuLeftMiddle.Name = "mnuLeftMiddle";
            mnuLeftMiddle.Size = new Size(180, 22);
            mnuLeftMiddle.Text = "LeftMiddle";
            mnuLeftMiddle.Click += mnuLeftMiddle_Click;
            // 
            // mnuLeftBottom
            // 
            mnuLeftBottom.Name = "mnuLeftBottom";
            mnuLeftBottom.Size = new Size(180, 22);
            mnuLeftBottom.Text = "LeftBottom";
            mnuLeftBottom.Click += mnuLeftBottom_Click;
            // 
            // mnuRightTop
            // 
            mnuRightTop.Name = "mnuRightTop";
            mnuRightTop.Size = new Size(180, 22);
            mnuRightTop.Text = "RightTop";
            mnuRightTop.Click += mnuRightTop_Click;
            // 
            // mnuRightMiddle
            // 
            mnuRightMiddle.Name = "mnuRightMiddle";
            mnuRightMiddle.Size = new Size(180, 22);
            mnuRightMiddle.Text = "RightMiddle";
            mnuRightMiddle.Click += mnuRightMiddle_Click;
            // 
            // mnuRightButtom
            // 
            mnuRightButtom.Name = "mnuRightButtom";
            mnuRightButtom.Size = new Size(180, 22);
            mnuRightButtom.Text = "RightBottom";
            mnuRightButtom.Click += mnuRightButtom_Click;
            // 
            // mnuHorizVert
            // 
            mnuHorizVert.Name = "mnuHorizVert";
            mnuHorizVert.Size = new Size(180, 22);
            mnuHorizVert.Text = "Horizontal / Vertical";
            mnuHorizVert.Click += mnuHorizVert_Click;
            // 
            // mnuOutsideInside
            // 
            mnuOutsideInside.Name = "mnuOutsideInside";
            mnuOutsideInside.Size = new Size(180, 22);
            mnuOutsideInside.Text = "Outside / Inside";
            mnuOutsideInside.Click += mnuOutsideInside_Click;
            // 
            // mnuLeftRight
            // 
            mnuLeftRight.Name = "mnuLeftRight";
            mnuLeftRight.Size = new Size(180, 22);
            mnuLeftRight.Text = "Symbol Left / Right";
            mnuLeftRight.Click += mnuLeftRight_Click;
            // 
            // mnuAxes
            // 
            mnuAxes.DropDownItems.AddRange(new ToolStripItem[] { mnuHideAxisX, mnuHideAxisY });
            mnuAxes.Name = "mnuAxes";
            mnuAxes.Size = new Size(44, 20);
            mnuAxes.Text = "Axes";
            // 
            // mnuData
            // 
            mnuData.DropDownItems.AddRange(new ToolStripItem[] { mnu360Points, mnu3600Points, mnu36000Points, mnu360000Points, mnuLive });
            mnuData.Name = "mnuData";
            mnuData.Size = new Size(43, 20);
            mnuData.Text = "Data";
            // 
            // mnu360Points
            // 
            mnu360Points.Name = "mnu360Points";
            mnu360Points.Size = new Size(146, 22);
            mnu360Points.Text = "360 points";
            mnu360Points.Click += mnu360Points_Click;
            // 
            // mnu3600Points
            // 
            mnu3600Points.Name = "mnu3600Points";
            mnu3600Points.Size = new Size(146, 22);
            mnu3600Points.Text = "3600 points";
            mnu3600Points.Click += mnu3600Points_Click;
            // 
            // mnu36000Points
            // 
            mnu36000Points.Name = "mnu36000Points";
            mnu36000Points.Size = new Size(146, 22);
            mnu36000Points.Text = "36000 points";
            mnu36000Points.Click += mnu36000Points_Click;
            // 
            // mnu360000Points
            // 
            mnu360000Points.Name = "mnu360000Points";
            mnu360000Points.Size = new Size(146, 22);
            mnu360000Points.Text = "360000 points";
            mnu360000Points.Click += mnu360000Points_Click;
            // 
            // mnuLive
            // 
            mnuLive.Name = "mnuLive";
            mnuLive.Size = new Size(146, 22);
            mnuLive.Text = "Live";
            mnuLive.Click += mnuLive_Click;
            // 
            // mnuHideSeries1
            // 
            mnuHideSeries1.Name = "mnuHideSeries1";
            mnuHideSeries1.Size = new Size(180, 22);
            mnuHideSeries1.Text = "Hide Series 1";
            mnuHideSeries1.Click += mnuHideSeries1_Click;
            // 
            // mnuHideSeries2
            // 
            mnuHideSeries2.Name = "mnuHideSeries2";
            mnuHideSeries2.Size = new Size(180, 22);
            mnuHideSeries2.Text = "Hide Series 2";
            mnuHideSeries2.Click += mnuHideSeries2_Click;
            // 
            // mnuHideAxisX
            // 
            mnuHideAxisX.Name = "mnuHideAxisX";
            mnuHideAxisX.Size = new Size(180, 22);
            mnuHideAxisX.Text = "Hide Axis X ";
            mnuHideAxisX.Click += mnuHideAxisX_Click;
            // 
            // mnuHideAxisY
            // 
            mnuHideAxisY.Name = "mnuHideAxisY";
            mnuHideAxisY.Size = new Size(180, 22);
            mnuHideAxisY.Text = "Hide Axis Y";
            mnuHideAxisY.Click += mnuHideAxisY_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(plotView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "OxyPlot Demo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuInteraction;
        private ToolStripMenuItem mnuLegend;
        private ToolStripMenuItem mnuAxes;
        private ToolStripMenuItem mnuData;
        private ToolStripMenuItem mnu360Points;
        private ToolStripMenuItem mnu3600Points;
        private ToolStripMenuItem mnu36000Points;
        private ToolStripMenuItem mnu360000Points;
        private ToolStripMenuItem mnuLive;
        private ToolStripMenuItem mnuZoomAll;
        private ToolStripMenuItem mnuEnableZoomX;
        private ToolStripMenuItem mnuEnableZoomY;
        private ToolStripMenuItem mnuReferesh;
        private ToolStripMenuItem mnuEnablePanX;
        private ToolStripMenuItem mnuEnablePanY;
        private ToolStripMenuItem mnuTopLeft;
        private ToolStripMenuItem mnuTopCenter;
        private ToolStripMenuItem mnuTopRight;
        private ToolStripMenuItem mnuBottomLeft;
        private ToolStripMenuItem mnuBottomCenter;
        private ToolStripMenuItem mnuBottomRight;
        private ToolStripMenuItem mnuLeftTop;
        private ToolStripMenuItem mnuLeftMiddle;
        private ToolStripMenuItem mnuLeftBottom;
        private ToolStripMenuItem mnuRightTop;
        private ToolStripMenuItem mnuRightMiddle;
        private ToolStripMenuItem mnuRightButtom;
        private ToolStripMenuItem mnuHorizVert;
        private ToolStripMenuItem mnuOutsideInside;
        private ToolStripMenuItem mnuLeftRight;
        private ToolStripMenuItem mnuHideSeries1;
        private ToolStripMenuItem mnuHideSeries2;
        private ToolStripMenuItem mnuHideAxisX;
        private ToolStripMenuItem mnuHideAxisY;
    }
}
