using System.Windows;

namespace ScottPlot_Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow( )
        {
            InitializeComponent( );
            Loaded += LoadEvent;
        }

        private void LoadEvent( object sender, RoutedEventArgs e )
        {
            int[] dataX = { 1, 2, 3, 4, 5 };
            int[] dataY = { 1, 4, 9, 16, 25 };
            WPF_Graph.Plot.Add.Scatter( dataX, dataY );
            WPF_Graph.Plot.Axes.SetLimits( 0, 10, 0, 30 );
            WPF_Graph.Plot.Axes.Left.Label.Text = "Y軸";
            WPF_Graph.Plot.Axes.Bottom.Label.Text = "X軸";
            WPF_Graph.Plot.Axes.Left.Label.FontName = "BIZ UDゴシック";
            WPF_Graph.Plot.Axes.Bottom.Label.FontName = "BIZ UDゴシック";
            WPF_Graph.Plot.Axes.Left.Label.FontSize = 24;
            WPF_Graph.Plot.Axes.Bottom.Label.FontSize = 24;
            WPF_Graph.Plot.Axes.Left.TickLabelStyle.FontSize = 24;
            WPF_Graph.Plot.Axes.Bottom.TickLabelStyle.FontSize = 24;

            ScottPlot.TickGenerators.NumericAutomatic l_TickGenY = new ScottPlot.TickGenerators.NumericAutomatic();
            l_TickGenY.TargetTickCount = 10;
            WPF_Graph.Plot.Axes.Left.TickGenerator = l_TickGenY;
            ScottPlot.TickGenerators.NumericAutomatic l_TickGenX = new ScottPlot.TickGenerators.NumericAutomatic();
            l_TickGenX.TargetTickCount = 10;
            WPF_Graph.Plot.Axes.Bottom.TickGenerator = l_TickGenX;
            WPF_Graph.Refresh( );
        }
    }
}