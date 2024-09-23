using ScottPlot.WPF;

namespace ScottPlot_MVVM_Sample
{
        public class GraphModel : NotifyChanged
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
                                if ( m_ScottPlotGraph != value ) {
                                        m_ScottPlotGraph = value;
                                        RaisePropertyChanged( );
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
                        ScottPlotGraph.Refresh( );
                }
                #endregion
        }
}
