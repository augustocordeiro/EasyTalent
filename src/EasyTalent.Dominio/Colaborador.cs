using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EasyTalent.NucleoCompartilhado;

namespace EasyTalent.Dominio
{
    public class Colaborador
    {
        public Id Id { get; private set; }
        public Identidade Identificacao { get; private set; }
        public string Biografia { get; private set; }
        private readonly IList<CompetenciaColaborador> _competencias;
        public IReadOnlyCollection<CompetenciaColaborador> Competencias => _competencias.ToArray();

        public Colaborador(IList<CompetenciaColaborador> competencias, Id id, Identidade identificacao, string biografia)
        {
            _competencias = competencias;
            Id = id;
            Identificacao = identificacao;
            Biografia = biografia;
            _competencias = new List<CompetenciaColaborador>();
        }
    }

    public class CompetenciaColaborador
    {
        public Id Id { get; private set; }
        public Competencia Competencia { get; private set; }
        public DateTime AdicionadaEm { get; private set; }
        public NivelCompetencia Nivel { get; private set; }
        public string Observacoes { get; private set; }
    }


    public class Competencia
    {
        public Id Id { get; private set; }
        public string Descricao { get; private set; }
    }

    public enum NivelCompetencia
    {
        Iniciante = 0,
        Intermediario = 1,
        Avancado = 2,
        Especialista = 3
    }

}

    
