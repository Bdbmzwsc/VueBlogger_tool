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
using System.ComponentModel;
using System.Windows.Interop;
using System.Runtime.InteropServices;

namespace VueBlogger_tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region WindowAPI
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);
        public const int WM_SYSCOM = 0x0112;
        public const int WM_BUUP = 0x0202;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Window Execute

        #region MoveWindow
        private void StackPanel_MouseMove(object sender, MouseEventArgs e)//Move
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                SendMessage(new WindowInteropHelper(this).Handle, WM_SYSCOM, (IntPtr)61458, IntPtr.Zero);
            }
        }
        #endregion

        private void Close_window_Click(object sender, RoutedEventArgs e)
        {
            Window w = Window.GetWindow(this);
            w.Close();
        }

        private void Min_Window_Click(object sender, RoutedEventArgs e)
        {
            Window w = Window.GetWindow(this);
            w.WindowState = WindowState.Minimized;
        }
        #endregion

        #region Interface
        public void PushPage(UserControl userControl)
        {
            UserCon = userControl;
        }
        UserControl cont;
        public UserControl UserCon
        {
            get { return cont; }
            set
            {
                cont = value;
                OnPropertyChanged("UserCon");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
        #endregion
    }
}
