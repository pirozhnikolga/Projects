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

        public ICommand SaveCommand => new ActionCommand<string>(Add);

        private void Add(string text)
        {
            List.Add(text);
        }
    }
}
