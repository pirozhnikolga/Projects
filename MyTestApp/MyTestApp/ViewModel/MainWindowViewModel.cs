using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyTestApp.View;

namespace MyTestApp.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() { }

        private ObservableCollection<string> _list;

        public ObservableCollection<string> List
        {
            get
            {
                if (_list == null) _list = NamesList.Instance;
                return _list;
            }
            set
            {
                _list = value;
                RaisePropertyChanged("List");
            }
        }


        private List<Obj> _objects;
        public List<Obj> Objects
        {
            get
            {
                if (_objects == null) _objects = new List<Obj>() {new Obj("Petrov", 24), new Obj("Ivanov", 54)};
                return _objects;
            }
            set
            {
                _objects = value;
                RaisePropertyChanged("Objects");
            }
        }

        public ICommand OpenCommand => new ActionCommand(() =>
        {
            WindowFactory.CreateChildWindow();
        });
    }

    public class Obj
    {
        public string Name { get; set; }
        public int Some { get; set; }

        public Obj(string name, int some)
        {
            Name = name;
            Some = some;
        }
    }

}
