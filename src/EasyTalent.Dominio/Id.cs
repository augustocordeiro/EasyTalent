using System;

namespace EasyTalent.Dominio
{
    public class Id
    {
        public int Codigo { get; private set; }
        public Guid UId { get; private set; }

        public Id()
        {
            UId = Guid.NewGuid();
            Codigo = 0;
        }

        public void DefinirCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public void DefinirUId(Guid uId)
        {
            UId = uId;
        }
    }
}