using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizsgaremekProjekt.Models
{
    public enum DbSource { NONE, LOCALHOST, DEVOPS}
    public class DataBaseSource { 

            DbSource dbSource;

            public DbSource DbSource { get => dbSource; set => dbSource = value; }

            public DataBaseSource()
            {
                this.DbSource = DbSource.LOCALHOST;
            }

        }
    }
