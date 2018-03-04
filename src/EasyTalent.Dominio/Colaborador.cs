using System;
using System.Linq;
using System.Reflection;

namespace EasyTalent.Dominio
{
    public class Colaborador
    {
        public int Codigo { get; private set; }
        public Guid UId { get; private set; }


    }

    public class Identidade
    {
        public NomePessoa NomeCompleto { get; private set; }
        
    }


}
