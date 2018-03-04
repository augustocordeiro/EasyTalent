using System;
using System.Linq;
using System.Reflection;
using EasyTalent.NucleoCompartilhado;

namespace EasyTalent.Dominio
{
    public class Colaborador
    {
        public int Codigo { get; private set; }
        public Guid UId { get; private set; }
        public Identidade Identificacao { get; private set; }
    }
}

    
