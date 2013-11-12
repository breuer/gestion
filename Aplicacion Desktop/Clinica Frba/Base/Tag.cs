using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinica_Frba.Base
{
    public class Tag
    {
        private String name;
        private String paramName;
        private Object value;
        private SqlDbType sqlDbType;

        private SqlParameter sqlparameter = null;

        public Tag() { }

        public Tag(String name, String paramName, SqlDbType sqlDbType)
        { 
            this.Name = name;
            this.ParamName = paramName;
            this.SQLDbType = sqlDbType;
        }

        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public String ParamName
        {
            set { paramName = value; }
            get { return paramName; }
        }

        public Object Value
        {
            set { this.value = value; }
            get { return this.value; }
        }
        public SqlDbType SQLDbType
        {
            set { sqlDbType = value; }
            get { return sqlDbType; }
        }

        public SqlParameter SQLParemeter
        {
            get {
                if (sqlparameter == null)
                {
                    sqlparameter = new SqlParameter(ParamName, SQLDbType);
                    sqlparameter.Value = Value;
                }
                return sqlparameter; 
            }
        }
    }
}
