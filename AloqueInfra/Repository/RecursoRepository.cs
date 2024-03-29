﻿using AloqueInfra.Models;
using SiteContatos.Data;

namespace AloqueInfra.Repository
{
    public class RecursoRepository : FuncoesGerais<RecursoModelo>
    {
        private readonly DatabaseContext _DatabaseContext;
        public RecursoRepository(DatabaseContext contextoDoBanco)
        {
            _DatabaseContext = contextoDoBanco;
        }

        public RecursoModelo Adicionar(RecursoModelo funcionario)
        {
            _DatabaseContext.Funcionario.Add(funcionario);
            _DatabaseContext.SaveChanges();
            return funcionario;
        }

        public RecursoModelo BuscarPorID(int ID)
        {
            return _DatabaseContext.Funcionario.FirstOrDefault(funcionario => funcionario.Id == ID);
        }

        public List<RecursoModelo> BuscarTodos()
        {
            return _DatabaseContext.Funcionario.ToList();
        }

        public bool Apagar(int ID)
        {
            RecursoModelo funcionario = BuscarPorID(ID);

            if (funcionario == null) throw new Exception("Houve algum erro ao procurar o cliente.");

            _DatabaseContext.Funcionario.Remove(funcionario);
            _DatabaseContext.SaveChanges();

            return true;
        }

        public RecursoModelo Editar(RecursoModelo funcionario)
        {
            RecursoModelo dadosOriginais = BuscarPorID(funcionario.Id);

            if (dadosOriginais == null) throw new Exception("Ocorreu algum erro ao tentar encontrar o contato.");

            dadosOriginais.funcNome = funcionario.funcNome;
            dadosOriginais.funcCPF = funcionario.funcCPF;
            dadosOriginais.funcRG = funcionario.funcRG;
            dadosOriginais.funcEmail = funcionario.funcEmail;
            dadosOriginais.funcValorDiario = funcionario.funcValorDiario;

            _DatabaseContext.Funcionario.Update(dadosOriginais);
            _DatabaseContext.SaveChanges();

            return dadosOriginais;
        }
    }
}