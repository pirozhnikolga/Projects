using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.ViewModel
{
    public class CommonViewModel
    {
        public MainWindowViewModel MainVM { get; set; }
        public ChildWindowViewModel ChildVM { get; set; }
        public CommonViewModel()
        {
            MainVM = new MainWindowViewModel();
            ChildVM = new ChildWindowViewModel();
        }
    }
}
