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
        private string displayedDatabaseSource;
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
                // return DbSource.NONE;
                if (selectedDatabaseSource == "localhost")
                    return DbSource.LOCALHOST;
                else if (selectedDatabaseSource == "devops")
            }
        }

        public string DisplayedDatabaseSource {
            get
            {
                switch (dbSource)
                {
                    case DbSource.DEVOPS:
                        return "devops adatforrás";
                        break;
                    case DbSource.LOCALHOST:
                        return "localhost adatforrás";
                    case DbSource.NONE:
                        return "beépített tesztadatok";
                        break;
                    default:
                        return "";
                        
                }
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
