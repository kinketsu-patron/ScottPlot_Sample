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
            WPF_Graph.Refresh( );
        }
    }
}