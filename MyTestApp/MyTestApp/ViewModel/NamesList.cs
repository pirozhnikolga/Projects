using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApp.ViewModel
{
    public class NamesList: ViewModelBase
    {
        private static readonly Lazy<ObservableCollection<string>> ModelCreator = new Lazy<ObservableCollection<string>>(() => new ObservableCollection<string>());
        public static ObservableCollection<string> Instance => ModelCreator.Value;
        private NamesList() {}
    }
}
