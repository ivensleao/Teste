using System;
using System.Collections.Generic;
using GFolha_Model.IServices;
using GFolha_Model.Model;

namespace GFolha_Model.Services
{
    class PessoaService : IPessoaService
    {
        public bool InserePessoa(PessoaModel pessoa)
        {
            Random random = new Random();
            int result = random.Next(1, 20);
            return result > 10;
        }

        public IList<PessoaModel> ListaPessoas()
        {
            return new List<PessoaModel>();
        }

        public bool DeletaPessoa(PessoaModel pessoa)
        {
            Random random = new Random();
            int result = random.Next(1, 20);
            return result > 10;
        }

        public bool AtualizaPessoa(PessoaModel pessoa)
        {
            Random random = new Random();
            int result = random.Next(1, 20);
            return result > 10;
        }
    }
}
