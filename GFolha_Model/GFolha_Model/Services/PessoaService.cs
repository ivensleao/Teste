using System.Collections.Generic;
using GFolha_Model.IServices;
using GFolha_Model.Model;

namespace GFolha_Model.Services
{
    public class PessoaService : IPessoaService
    {
        public bool InserePessoa(PessoaModel pessoa)
        {
            return true;
        }

        public IList<PessoaModel> ListaPessoas()
        {
            return new List<PessoaModel>();
        }

        public bool DeletaPessoa(PessoaModel pessoa)
        {
            return true;
        }

        public bool AtualizaPessoa(PessoaModel pessoa)
        {
            return true;
        }
    }
}
