using ScottPlot.WPF;

namespace ScottPlot_MVVM_Sample
{
    public class MainViewModel : NotifyChanged
    {
        #region メンバ変数
        private GraphModel m_GraphModel;
        #endregion

        #region プロパティ
        public WpfPlot? ScottPlotGraph
        {
            get { return m_GraphModel.ScottPlotGraph; }
            set { m_GraphModel.ScottPlotGraph = value; }
        }
        #endregion

        #region コンストラクタ
        public MainViewModel( )
        {
            m_GraphModel = new GraphModel( );
            m_GraphModel.PropertyChanged += ( sender, e ) => RaisePropertyChanged( );
        }
        #endregion
    }
}
