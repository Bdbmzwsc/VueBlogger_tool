using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

using VueBlogger_tool.ViewModel;
*/
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.ComponentModel;





namespace VueBlogger_tool.ViewModel
{
    public class DialogInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DialogInfo()
        {
            text = "";
        }

        string Text;
        public string text
        {
            get => Text;
            set { Text = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("text")); }
        }
    }
}
