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
using System.Windows.Shapes;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.ComponentModel;

namespace VueBlogger_tool
{
    /// <summary>
    /// TextDialog.xaml 的交互逻辑
    /// </summary>
    public partial class TextDialog
    {
    

      // public VueBlogger_tool.ViewModel.DialogInfo DialogInfo=new ViewModel.DialogInfo();

        public TextDialog()
        {
            DataContext = this;
            InitializeComponent();
        }


    }
}
