namespace GFolha_Model.Model
{
    public class PessoaModel
    {
        public int IdPessoa { get; set; }

        public string Nome { get; set; }

        public int Sexo { get; set; }

        public ContatoModel Contato { get; set; }
    }
}
