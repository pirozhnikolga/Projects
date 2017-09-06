using MammoExpert.PatientServices.PresenterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MammoExpert.PatientServices.Sources;

namespace MammoExpert.PatientServices.Demo.ViewModel
{
    public class ConfigurationWindowViewModel : ViewModelBase
    {
        #region Fields and Properties

        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                RaisePropertyChanged("CurrentViewModel");
            }
        }

        //private S _source;

        //public S Source
        //{
        //    get { return _source; }
        //    set
        //    {
        //        if (_source == value) return;
        //        _source = value;
        //        RaisePropertyChanged("Source");
        //    }
        //}

        //private DBSource _dbSource;

        //public DBSource DBSource
        //{
        //    get { return _dbSource; }
        //    set
        //    {
        //        if (_dbSource == value) return;
        //        _dbSource = value;
        //        RaisePropertyChanged("DBSource");
        //    }
        //}

        //private WLSource _wlSource;

        //public WLSource WLSource
        //{
        //    get { return _wlSource; }
        //    set
        //    {
        //        if (_wlSource == value) return;
        //        _wlSource = value;
        //        RaisePropertyChanged("WLSource");
        //    }
        //}

        #endregion // Fields and Properties

        #region Constructor

        // конструктор при загрузке окна для редактирования выбранного источника
        public ConfigurationWindowViewModel(Source source)
        {
            base.DisplayName = Properties.Resources.ConfigurationWindowViewModel_DisplayName;
            SetCurrentViewModel(source);

            //if (source.Type == SourceType.DataBase)
            //{
            //    Source = new DBSource()
            //    {
            //        ConectionString = source.ConnectionString,
            //        Name = source.Name,
            //        Id = source.Id,
            //        Description = source.Description,
            //        Driver = source.Parameters["Driver"],
            //        Ip = source.Parameters["Ip"],
            //        Port = source.Parameters["Port"],
            //        UserName = source.Parameters["UserName"],
            //        Password = source.Parameters["Password"]
            //    };
            //}
            //if (source.Type == SourceType.Worklist)
            //{
            //    Source = new WLSource()
            //    {
            //        ConectionString = source.ConnectionString,
            //        Name = source.Name,
            //        Id = source.Id,
            //        Description = source.Description,
            //        Header = source.Parameters["Header"],
            //        Ip = source.Parameters["Ip"],
            //        Port = source.Parameters["Port"],
            //        Timeout = source.Parameters["Timeout"]
            //};
            //}
        }

        #endregion // Constructor

        #region Private Methods

        // устанавливает значение для текущей модели представления в зависимости от переданного источника
        private void SetCurrentViewModel(Source source)
        {
            switch (source.Type)
            {
                case SourceType.DataBase:
                    _currentViewModel = new DBConnectionConfigurationModel(source);
                    break;
                case SourceType.Worklist:
                    _currentViewModel = new WorklistConnectionConfigurationModel(source);
                    break;
                default: throw new ArgumentNullException("source");
            }
        }

        #endregion // Private Methods

        #region Commands

        //public ICommand CreateCommand => new ActionCommand(Create);

        //#endregion // Commands

        //#region Private Methods

        //private void Create()
        //{
        //   // MainWindowViewModel.SourceRepository.Add(Source);
        //    CloseAction();
        //}

        #endregion // Private Methods
    }
}
