using System;
using System.Collections.Generic;
using GFolha_Model.Exceptions;
using GFolha_Model.IServices;
using GFolha_Model.Model;
using GFolha_Model.Services;
using GFolha_Model.Response;

namespace GFolha_Model.Controller
{
    public static class PessoaController
    {
        static IPessoaService _pessoaService;

        static PessoaController()
        {
            _pessoaService = new PessoaService();
        }

        /// <summary>
        /// Método para inserir novo registro de pessoa no banco de dados
        /// </summary>
        /// <param name="pessoa">Objeto pessoa</param>
        /// <returns>Response{Success=true/false, Message=mensagem}</returns>
        public static ResponsePattern InserePessoa(PessoaModel pessoa)
        {
            try
            {
                if(Utils.Utils.CheckNullObject(pessoa))
                    throw new NullObjException();

                var success = _pessoaService.InserePessoa(pessoa);
                return success
                    ? new ResponsePattern() {Message = Resources.MessageSuccessInsertGeneric, Success = true}
                    : new ResponsePattern() {Message = Resources.MessageErrorInsertGeneric, Success = false};
            }
            catch (NullObjException)
            {
                return new ResponsePattern() {Success = false, Message = Resources.ExceptionNullObj};
            }
            catch (Exception)
            {
                return new ResponsePattern() { Success = false, Message = Resources.ExceptionGenericError };
            }
        }

        /// <summary>
        /// Método para inserir novo registro de pessoa no banco de dados
        /// </summary>
        /// <returns>Lista de pessoas</returns>
        public static IList<PessoaModel> ListaPessoas()
        {
            try
            {
                return _pessoaService.ListaPessoas();
            }
            catch (Exception)
            {
                return new List<PessoaModel>();
            }
        }

        /// <summary>
        /// Método para atualizar registro de pessoa no banco de dados
        /// </summary>
        /// <param name="pessoa">Objeto pessoa</param>
        /// <returns>Response{Success=true/false, Message=mensagem}</returns>
        public static ResponsePattern AtualizaPessoa(PessoaModel pessoa)
        {
            try
            {
                if (Utils.Utils.CheckNullObject(pessoa))
                    throw new NullObjException();

                var success = _pessoaService.AtualizaPessoa(pessoa);
                return success
                    ? new ResponsePattern() { Message = Resources.MessageSuccessUpdateGeneric, Success = true }
                    : new ResponsePattern() { Message = Resources.MessageErrorUpdateGeneric, Success = false };
            }
            catch (NullObjException)
            {
                return new ResponsePattern() { Success = false, Message = Resources.ExceptionNullObj };
            }
            catch (Exception)
            {
                return new ResponsePattern() { Success = false, Message = Resources.ExceptionGenericError };
            }
        }

        /// <summary>
        /// Método para excluir registro de pessoa no banco de dados
        /// </summary>
        /// <param name="pessoa">Objeto pessoa</param>
        /// <returns>Response{Success=true/false, Message=mensagem}</returns>
        public static ResponsePattern DeletaPessoa(PessoaModel pessoa)
        {
            try
            {
                if (Utils.Utils.CheckNullObject(pessoa))
                    throw new NullObjException();

                var success = _pessoaService.DeletaPessoa(pessoa);
                return success
                    ? new ResponsePattern() { Message = Resources.MessageSuccessDeleteGeneric, Success = true }
                    : new ResponsePattern() { Message = Resources.MessageErrorDeleteGeneric, Success = false };
            }
            catch (NullObjException)
            {
                return new ResponsePattern() { Success = false, Message = Resources.ExceptionNullObj };
            }
            catch (Exception)
            {
                return new ResponsePattern() { Success = false, Message = Resources.ExceptionGenericError };
            }
        }
    }
}
