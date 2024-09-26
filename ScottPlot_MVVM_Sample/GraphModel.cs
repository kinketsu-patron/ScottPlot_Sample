using ScottPlot.WPF;

namespace ScottPlot_MVVM_Sample
{
    public class GraphModel /*: NotifyChanged*/
    {
        #region メンバ変数
        private WpfPlot? m_ScottPlotGraph = null;
        #endregion

        #region プロパティ
        public WpfPlot? ScottPlotGraph
        {
            get { return m_ScottPlotGraph; }
            set
            {
                if( m_ScottPlotGraph != value ) {
                    m_ScottPlotGraph = value;
                    //RaisePropertyChanged( );
                }
            }
        }
        #endregion

        #region コンストラクタ
        public GraphModel( )
        {
            ScottPlotGraph = new WpfPlot( );
            int[] dataX = { 1, 2, 3, 4, 5 };
            int[] dataY = { 1, 4, 9, 16, 25 };
            ScottPlotGraph.Plot.Add.Scatter( dataX, dataY );
            ScottPlotGraph.Plot.Axes.SetLimits( 0, 10, 0, 30 );
            ScottPlotGraph.Plot.Axes.Left.Label.Text = "Y軸";
            ScottPlotGraph.Plot.Axes.Bottom.Label.Text = "X軸";
            ScottPlotGraph.Plot.Axes.Left.Label.FontName = "BIZ UDゴシック";
            ScottPlotGraph.Plot.Axes.Bottom.Label.FontName = "BIZ UDゴシック";
            ScottPlotGraph.Plot.Axes.Left.Label.FontSize = 24;
            ScottPlotGraph.Plot.Axes.Bottom.Label.FontSize = 24;
            ScottPlotGraph.Plot.Axes.Left.TickLabelStyle.FontSize = 24;
            ScottPlotGraph.Plot.Axes.Bottom.TickLabelStyle.FontSize = 24;

            ScottPlot.TickGenerators.NumericAutomatic l_TickGenY = new ScottPlot.TickGenerators.NumericAutomatic();
            l_TickGenY.TargetTickCount = 10;
            ScottPlotGraph.Plot.Axes.Left.TickGenerator = l_TickGenY;
            ScottPlot.TickGenerators.NumericAutomatic l_TickGenX = new ScottPlot.TickGenerators.NumericAutomatic();
            l_TickGenX.TargetTickCount = 10;
            ScottPlotGraph.Plot.Axes.Bottom.TickGenerator = l_TickGenX;

            ScottPlotGraph.Refresh( );
        }
        #endregion
    }
}
