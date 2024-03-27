namespace Hierarchy
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Tipo { get; protected set; }
        public DateTime DataDeInclusao { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public new string Tipo { get => "PF"; }
    }
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public new string Tipo { get => "PJ"; }
    }


}
