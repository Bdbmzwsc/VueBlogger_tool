using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HandyControl.Properties.Langs;
using HandyControl;
using VueBlogger_tool;
using HandyControl.Tools.Extension;



namespace VueBlogger_tool_hub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lang_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void changecolor_Click(object sender, RoutedEventArgs e)
        {
            



            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("pack://application:,,,/HandyControl;component/Themes/SkinDark.xaml");
            Application.Current.Resources.MergedDictionaries[0]=resourceDictionary;
        }

        private void MessageBox_dialog_Click(object sender, RoutedEventArgs e)
        {
           


            HandyControl.Controls.MessageBox.Show("test", "test");


            MessageBox.Show("test","test", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // HandyControl.Controls.Dialog.Show(new VueBlogger_tool.TextDialog().DialogInfo=new VueBlogger_tool.ViewModel.DialogInfo { text="a temp"});
        }
    }
}
