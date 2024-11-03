using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Axes;

namespace OxyPlotDemo
{
    public partial class FormMain : Form
    {
        List<DataPoint> series1Data = new List<DataPoint>();
        List<DataPoint> series2Data = new List<DataPoint>();
        bool bLive = false;

        public FormMain()
        {
            InitializeComponent();

            ProvideData(360);
            /*
            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "X-Axis",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            };

            plotView1.Model.Axes.Add(xAxis);
            */
        }

        void ProvideData(int numData)
        {
            var myModel = new PlotModel { Title = "Simple line chart" };

            plotView1.Model = myModel;

            var lineSeries1 = new LineSeries
            {
                Title = "Sin()",
                Color = OxyColors.SteelBlue,       // Line color
            };

            var lineSeries2 = new LineSeries
            {
                Title = "Cos()",
                Color = OxyColors.Red,       // Line color
            };

            Legend legend = new Legend();
            legend.LegendTitle = "Legend";
            legend.LegendPosition = LegendPosition.TopRight;
            legend.LegendOrientation = LegendOrientation.Vertical;
            legend.LegendPlacement = LegendPlacement.Outside;
            legend.LegendSymbolPlacement = LegendSymbolPlacement.Left;
            plotView1.Model.Legends.Add(legend);


            Task.Run(() =>
            {
                series1Data = Enumerable.Range(0, numData).Select(x => new DataPoint(x, Math.Sin((double)x * Math.PI / 180.0))).ToList<DataPoint>();
                series2Data = Enumerable.Range(0, numData).Select(x => new DataPoint(x, Math.Cos((double)x * Math.PI / 180.0))).ToList<DataPoint>();

                lineSeries1.Points.AddRange(series1Data);
                lineSeries2.Points.AddRange(series2Data);

                myModel.Series.Add(lineSeries1);
                myModel.Series.Add(lineSeries2);

                plotView1.InvalidatePlot(true);
            });
        }

        private DataPoint GetNextPoint(double x)
        {
            DataPoint point = new DataPoint(x, Math.Sin((double)x * Math.PI / 180.0));
            return point;
        }

        private void ProvideLiveData()
        {
            var myModel = new PlotModel { Title = "Simple live data" };
            DataPoint pt;
            double x = 0;

            plotView1.Model = myModel;

            var lineSeries1 = new LineSeries
            {
                Title = "Sin()",
                Color = OxyColors.SteelBlue,       // Line color
            };

            myModel.Series.Add(lineSeries1);
            bLive = true;

            Task.Run(async () =>
            {
                while (bLive)
                {
                    if (x > 1000000.0)
                    {
                        bLive = false;
                        break;
                    }

                    pt = GetNextPoint(x);
                    lineSeries1.Points.Add(pt);
                    plotView1.InvalidatePlot(true);
                    await Task.Delay(20);
                    x += 1;
                }
            });
        }

        private void mnu360Points_Click(object sender, EventArgs e)
        {
            bLive = false;
            ProvideData(360);
        }

        private void mnu3600Points_Click(object sender, EventArgs e)
        {
            bLive = false;
            ProvideData(3600);
        }

        private void mnu36000Points_Click(object sender, EventArgs e)
        {
            bLive = false;
            ProvideData(36000);
        }

        private void mnu360000Points_Click(object sender, EventArgs e)
        {
            bLive = false;
            ProvideData(360000);
        }

        private void mnuLive_Click(object sender, EventArgs e)
        {
            ProvideLiveData();
        }

        private void mnuEnableZoomX_Click(object sender, EventArgs e)
        {
            mnuEnableZoomX.Checked = !mnuEnableZoomX.Checked;
            plotView1.Model.Axes[0].IsZoomEnabled = mnuEnableZoomX.Checked;
        }

        private void mnuEnableZoomY_Click(object sender, EventArgs e)
        {
            mnuEnableZoomY.Checked = !mnuEnableZoomY.Checked;
            plotView1.Model.Axes[1].IsZoomEnabled = mnuEnableZoomY.Checked;
        }

        private void RefreshPlot()
        {
            plotView1.InvalidatePlot(true);
        }

        private void mnuReferesh_Click(object sender, EventArgs e)
        {
            RefreshPlot();
        }

        private void mnuZoomAll_Click(object sender, EventArgs e)
        {
            foreach (var ax in plotView1.Model.Axes)
                ax.Reset();

            RefreshPlot();
        }

        private void mnuEnablePanX_Click(object sender, EventArgs e)
        {
            mnuEnablePanX.Checked = !mnuEnablePanX.Checked;
            plotView1.Model.Axes[0].IsPanEnabled = mnuEnablePanX.Checked;
        }

        private void mnuEnablePanY_Click(object sender, EventArgs e)
        {
            mnuEnablePanY.Checked = !mnuEnablePanY.Checked;
            plotView1.Model.Axes[1].IsPanEnabled = mnuEnablePanY.Checked;
        }

        private void UncheckAllPositions()
        {
            mnuTopLeft.Checked = false;
            mnuTopCenter.Checked = false;
            mnuTopRight.Checked = false;
            mnuBottomLeft.Checked = false;
            mnuBottomCenter.Checked = false;
            mnuBottomRight.Checked = false;
            mnuLeftTop.Checked = false;
            mnuLeftMiddle.Checked = false;
            mnuLeftBottom.Checked = false;
            mnuRightTop.Checked = false;
            mnuRightMiddle.Checked = false;
            mnuRightButtom.Checked = false;
        }

        private void mnuTopLeft_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.TopLeft;
            UncheckAllPositions();
            mnuTopLeft.Checked = true;
            RefreshPlot();
        }

        private void mnuTopCenter_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.TopCenter;
            UncheckAllPositions();
            mnuTopCenter.Checked = true;
            RefreshPlot();
        }

        private void mnuTopRight_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.TopRight;
            UncheckAllPositions();
            mnuTopRight.Checked = true;
            RefreshPlot();
        }

        private void mnuBottomLeft_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.BottomLeft;
            UncheckAllPositions();
            mnuBottomLeft.Checked = true;
            RefreshPlot();
        }

        private void mnuBottomCenter_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.BottomCenter;
            UncheckAllPositions();
            mnuBottomCenter.Checked = true;
            RefreshPlot();
        }

        private void mnuBottomRight_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.BottomRight;
            UncheckAllPositions();
            mnuBottomRight.Checked = true;
            RefreshPlot();
        }

        private void mnuLeftTop_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.LeftTop;
            UncheckAllPositions();
            mnuLeftTop.Checked = true;
            RefreshPlot();
        }

        private void mnuLeftMiddle_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.LeftMiddle;
            UncheckAllPositions();
            mnuLeftMiddle.Checked = true;
            RefreshPlot();
        }

        private void mnuLeftBottom_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.LeftBottom;
            UncheckAllPositions();
            mnuLeftBottom.Checked = true;
            RefreshPlot();
        }

        private void mnuRightTop_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.RightTop;
            UncheckAllPositions();
            mnuRightTop.Checked = true;
            RefreshPlot();
        }

        private void mnuRightMiddle_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.RightMiddle;
            UncheckAllPositions();
            mnuRightMiddle.Checked = true;
            RefreshPlot();
        }

        private void mnuRightButtom_Click(object sender, EventArgs e)
        {
            plotView1.Model.Legends[0].LegendPosition = LegendPosition.RightBottom;
            UncheckAllPositions();
            mnuRightButtom.Checked = true;
            RefreshPlot();
        }

        private void mnuHorizVert_Click(object sender, EventArgs e)
        {
            mnuHorizVert.Checked = !mnuHorizVert.Checked;

            plotView1.Model.Legends[0].LegendOrientation = mnuHorizVert.Checked ? LegendOrientation.Horizontal : LegendOrientation.Vertical;
            RefreshPlot();
        }

        private void mnuOutsideInside_Click(object sender, EventArgs e)
        {
            mnuOutsideInside.Checked = !mnuOutsideInside.Checked;

            plotView1.Model.Legends[0].LegendPlacement = mnuOutsideInside.Checked ? LegendPlacement.Inside : LegendPlacement.Outside;
            RefreshPlot();
        }

        private void mnuLeftRight_Click(object sender, EventArgs e)
        {
            mnuLeftRight.Checked = !mnuLeftRight.Checked;

            plotView1.Model.Legends[0].LegendSymbolPlacement = mnuLeftRight.Checked ? LegendSymbolPlacement.Right : LegendSymbolPlacement.Left;
            RefreshPlot();
        }

        private void mnuHideSeries1_Click(object sender, EventArgs e)
        {
            mnuHideSeries1.Checked = !mnuHideSeries1.Checked;
            plotView1.Model.Series[0].IsVisible = !mnuHideSeries1.Checked;
            RefreshPlot();
        }

        private void mnuHideSeries2_Click(object sender, EventArgs e)
        {
            mnuHideSeries2.Checked = !mnuHideSeries2.Checked;
            plotView1.Model.Series[1].IsVisible = !mnuHideSeries2.Checked;
            RefreshPlot();
        }

        private void mnuHideAxisX_Click(object sender, EventArgs e)
        {
            mnuHideAxisX.Checked = !mnuHideAxisX.Checked;
            plotView1.Model.Axes[0].IsAxisVisible = !mnuHideAxisX.Checked;
            RefreshPlot();
        }

        private void mnuHideAxisY_Click(object sender, EventArgs e)
        {
            mnuHideAxisY.Checked = !mnuHideAxisY.Checked;
            plotView1.Model.Axes[1].IsAxisVisible = !mnuHideAxisY.Checked;
            RefreshPlot();
        }
    }
}
