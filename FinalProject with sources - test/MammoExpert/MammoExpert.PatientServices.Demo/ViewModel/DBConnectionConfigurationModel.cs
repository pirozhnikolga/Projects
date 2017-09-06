using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MammoExpert.PatientServices.Demo.Properties;
using MammoExpert.PatientServices.PresenterCore;
using MammoExpert.PatientServices.Sources;

namespace MammoExpert.PatientServices.Demo.ViewModel
{
    public class DBConnectionConfigurationModel : ViewModelBase
    {
        #region Fields

        private DBSource _source;

        #endregion // Fields

        #region Constructor

        public DBConnectionConfigurationModel(Source source)
        {
            base.DisplayName = Resources.DBConnectionConfigurationModel_DisplayName;
            Source = new DBSource()
            {
                ConectionString = source.ConnectionString,
                Description = source.Description,
                Driver = source.Parameters["Driver"],
                Id = source.Id,
                Ip = source.Parameters["Ip"],
                Name = source.Name,
                Password = source.Parameters["Password"],
                Port = source.Parameters["Port"],
                Type = source.Type,
                UserName = source.Parameters["UserName"]
            };
        }

        #endregion // Constructor

        #region Properties

        public DBSource Source
        {
            get { return _source; }
            set
            {
                if (_source != value)
                {
                    _source = value;
                    RaisePropertyChanged("Source");
                }
            }
        }

        #endregion // Properties

        #region Commands

        public ICommand CreateCommand => new ActionCommand(Create);

        #endregion // Commands

        #region Private Methods

        private void Create()
        {
            MessageBox.Show(
                "Типа создали что-то",
                "Подтверждение",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            CloseAction();
        }

        #endregion // Private Methods
    }
}
