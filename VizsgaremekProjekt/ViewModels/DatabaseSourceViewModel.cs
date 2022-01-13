using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizsgaremekProjekt.Repositories;
using VizsgaremekProjekt.Models;

namespace VizsgaremekProjekt.ViewModels
{
    public class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displaydDatabaseSources;
        private string selectedDatabaseSource;
        private DbSource dbSource;

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

        public DbSource DbSource
        {
            get
            {
                // TDD fejlesztés
                return DbSource.NONE;
            }
        }

        public DatabaseSourceViewModel()
        {
            repoDatabaseSources = new DatabaseSources();
            displaydDatabaseSources = new ObservableCollection<string>
                (repoDatabaseSources.GetAllDatabaseSources());
        }
    }
}
