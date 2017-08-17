using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace MyTestApp.ViewModel
{
    public class ChildWindowViewModel : MainWindowViewModel
    {
        public ChildWindowViewModel() { }

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                RaisePropertyChanged("Text");
            }
        }
        public ICommand SaveCommand => new ActionCommand(() =>
        {
           List.Add(Text);
        });
    }
}
