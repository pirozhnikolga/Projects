using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.ViewModel
{
    public class CommonViewModel: ViewModelBase
    {
        private static readonly Lazy<CommonViewModel> ModelCreator = new Lazy<CommonViewModel>(() => new CommonViewModel());

        public static CommonViewModel Instance => ModelCreator.Value;

        public MainWindowViewModel MainVM { get; set; }
        public ChildWindowViewModel ChildVM { get; set; }
        private CommonViewModel()
        {
            MainVM = new MainWindowViewModel();
            ChildVM = new ChildWindowViewModel()
            {
                List = MainVM.List
            };
        }
    }
}
