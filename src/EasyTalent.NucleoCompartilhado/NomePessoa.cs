namespace EasyTalent.NucleoCompartilhado
{
    public class NomePessoa
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }

        public string NomeCompleto => ObterNomeCompleto();

        public NomePessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string ObterNomeCompleto()
        {

            if (Sobrenome.Length > 0)
            {
                return $"{Nome} {Sobrenome}".ToUpper();
            }
            return Nome;
        }
        public string Iniciais => ObterIniciais();
        private string ObterIniciais()
        {
            string[] nomes = NomeCompleto.Split(' ');
            if (nomes.Length > 1)
            {
                return nomes.Length > 2 ? $"{nomes[0][0]}{nomes[nomes.Length - 1][0]}".ToUpper() : $"{nomes[0][0]}{nomes[1][0]}".ToUpper();
            }

            return NomeCompleto[0].ToString().ToUpper();
        }
    }
}