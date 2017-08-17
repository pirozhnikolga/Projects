﻿using System;
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
                if(_list == null) _list = new ObservableCollection<string>() {"1 fghj", "2 cvbn"};
                return _list;
            }
            set
            {
                _list = value;
                RaisePropertyChanged("List");
            }
        }

        public ICommand OpenCommand => new ActionCommand(() =>
        {
            var win = new ChildWindow();
            win.ShowDialog();
        });
    }

}