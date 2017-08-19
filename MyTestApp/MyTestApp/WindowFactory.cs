using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MyTestApp.View;
using MyTestApp.ViewModel;

namespace MyTestApp
{
    public class WindowFactory
    {
        public WindowFactory() { }

        public static void CreateChildWindow()
        {
            var view = new ChildWindow();
            var viewModel = CommonViewModel.Instance;
            view.DataContext = viewModel;
            view.ShowDialog();
        }

        public static void CreateMainWindow()
        {
            var view = new MainWindow();
            var viewModel = CommonViewModel.Instance;
            view.DataContext = viewModel;
            view.Show();
        }
    }
}
