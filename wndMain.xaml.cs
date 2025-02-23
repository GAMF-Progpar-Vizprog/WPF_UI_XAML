using System.Windows;

namespace WPF_UI_XAML
{
	
	public partial class wndMain : Window
  {
    public wndMain()
    {
      InitializeComponent();
    }

    private void btExit_Click(object sender, RoutedEventArgs e)
    {
     
      Application.Current.Shutdown();
    }

    private void btMessage_Click(object sender, RoutedEventArgs e)
    {
      
      MessageBox.Show("Message");
    }
  }

}
