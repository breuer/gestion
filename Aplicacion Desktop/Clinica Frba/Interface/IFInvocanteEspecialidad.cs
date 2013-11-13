using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.Model;

namespace Clinica_Frba.Interface
{
    public interface IFInvocanteEspecialidad
    {
        Boolean seleccionarEspecialidad(EspecialidaMedica selected);
    }
}
