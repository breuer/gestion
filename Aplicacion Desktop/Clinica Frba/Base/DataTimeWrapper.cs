using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Base
{
    public class DataTimeWrapper
    {
        private DateTime _dataTime;

        public DataTimeWrapper(DateTime dataTime) {
            _dataTime = dataTime;
        }

        public string Time
        {
            get { 
                StringBuilder st = new StringBuilder();
                st.Append(_dataTime.Hour + ":" + _dataTime.Minute);
                return st.ToString();
            }
        }

        public DateTime Date
        {
            get { return _dataTime; }
        }
    }
}
