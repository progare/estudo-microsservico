using AwesomeGym.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeGym.Core.DTOs
{
    public class AdicionarAlunoErpDTO
    {
        public AdicionarAlunoErpDTO(Aluno aluno, Unidade unidade)
        {
            Aluno = aluno;
            Unidade = unidade;
        }

        public Aluno Aluno { get; private set; }
        public Unidade Unidade { get; private set; }
    }
}
