using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizsgaremekProjekt.Repositories;

namespace VizsgaremekProjekt.ViewModels
{
    class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displaydDatabaseSources;
        private string selectedDatabaseSource;
        DatabaseSources repoDatabaseSources;

        public ObservableCollection<string> DisplaydDatabaseSources 
        { 
            get => displaydDatabaseSources; 
        }
        public string SelectedDatabaseSource 
        { 
            get => selectedDatabaseSource; 
            set => selectedDatabaseSource = value; 
        }
        internal DatabaseSources RepoDatabaseSources { 
            get => repoDatabaseSources;
            set => repoDatabaseSources = value; 
        }

        public DatabaseSourceViewModel()
        {
            repoDatabaseSources = new DatabaseSources();
            displaydDatabaseSources = new ObservableCollection<string>
                (repoDatabaseSources.GetAllDatabaseSources());
        }
    }
}
