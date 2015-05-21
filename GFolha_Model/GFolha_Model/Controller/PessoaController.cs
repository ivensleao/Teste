using System;
using GFolha_Model.Exceptions;
using GFolha_Model.IServices;
using GFolha_Model.Model;
using GFolha_Model.Services;

namespace GFolha_Model.Controller
{
    public static class PessoaController
    {
        static IPessoaService _pessoaService;
        static IContatoService _contatoService;

        static PessoaController()
        {
            _pessoaService = new PessoaService();
            _contatoService = new ContatoService();
        }

        public static void InserePessoa(PessoaModel pessoa)
        {
            try
            {
                if(Utils.Utils.CheckNullObject(pessoa))
                    throw new NullObjException();

                _pessoaService.InserePessoa(pessoa);
            }
            catch (NullObjException)
            {
                throw new NullObjException(Resources.ExceptionNullObj);
            }
            catch (Exception)
            {
                throw new Exception(Resources.ExceptionGenericError);
            }
        }

        public static void InsereContato(ContatoModel contato)
        {
            try
            {
                if (Utils.Utils.CheckNullObject(contato))
                    throw new NullObjException();
                
                _contatoService.InsereContato(contato);
            }
            catch (NullObjException)
            {
                throw new NullObjException(Resources.ExceptionNullObj);
            }
            catch (Exception)
            {
                throw new Exception(Resources.ExceptionGenericError);
            }
        }
    }
}
