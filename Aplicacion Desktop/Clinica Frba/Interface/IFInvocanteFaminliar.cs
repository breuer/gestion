using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model;
using System.Data.SqlClient;

namespace Clinica_Frba.Interface
{
    public interface IFInvocanteFamiliar
    {
        void seleccionarConyuge(List<SqlParameter> conyuge);
        void seleccionarFamiliar(List<SqlParameter> familiar);

    }
}
