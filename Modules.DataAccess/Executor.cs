using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.DataAccess
{
    /// <summary>
    /// <see cref="Executor"/> used to execute sqlquery's.
    /// </summary>
    public class Executor
    {
        #region Fields
        private readonly string connectionString;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase"/> class.
        /// </summary>
        /// <param name="connectionString">Database connectionstring.</param>
        public Executor(string connectionString)
        {
            this.connectionString = connectionString;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Executes a storedprocedure.
        /// </summary>
        /// <param name="storedProcedureName"></param>
        /// <param name="procedureParameters"></param>
        /// <returns>Returns storedprocedure dataset</returns>
        public DataSet Execute(string storedProcedureName, params string[] procedureParameters)
        {
            return null;
        }

        /// <summary>
        /// Executes a sqlquery.
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns>Return sqlquery dataset</returns>
        public DataSet Execute(string sqlQuery)
        {
            DataSet ds = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(sqlQuery, new SqlConnection(connectionString))))
            {
                adapter.Fill(ds);
            }
            return ds;
        }
        #endregion
    }
}
