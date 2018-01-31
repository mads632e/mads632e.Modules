using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Modules.DataAccess
{
    /// <summary>
    /// <see cref="RepositoryBase"/> used to call DataAccess <see cref="Executor"/>.
    /// </summary>
    public class RepositoryBase
    {
        #region Fields
        private Executor executor;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase"/> class.
        /// </summary>
        public RepositoryBase(string databaseName)
        {
            executor = new Executor(GetConnectionString(databaseName));
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets connectionstring from config file.
        /// </summary>
        /// <param name="databaseName">Name for config file connectionstring to get.</param>
        /// <returns>Return database connectionstring.</returns>
        private string GetConnectionString(string databaseName)
        {
            var connection = ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
            return connection;
        }

        /// <summary>
        /// Method used for testing.
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns>Return dataset from sqlquery</returns>
        public DataSet GetTestData(string sqlQuery)
        {
            return executor.Execute(sqlQuery);
        }
        #endregion
    }
}
