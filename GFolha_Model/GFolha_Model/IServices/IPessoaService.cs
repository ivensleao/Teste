
using System.Collections.Generic;
using GFolha_Model.Model;

namespace GFolha_Model.IServices
{
    public interface IPessoaService
    {
        bool InserePessoa(PessoaModel pessoa);

        IList<PessoaModel> ListaPessoas();

        bool DeletaPessoa(PessoaModel pessoa);

        bool AtualizaPessoa(PessoaModel pessoa);
    }
}
