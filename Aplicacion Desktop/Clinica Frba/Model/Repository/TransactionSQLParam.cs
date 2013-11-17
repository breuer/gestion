using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Clinica_Frba.Model.Repository
{
    public class TransactionSQLParam
    {
        private String spName;
        private SqlParameter sqlParameter;

        public TransactionSQLParam() { }


        public String SpName
        {
            get { return spName; }
            set { spName = value; }
        }

        public SqlParameter SQLParameter
        {
            get { return sqlParameter; }
            set { sqlParameter = value; }
        }
    }
}
