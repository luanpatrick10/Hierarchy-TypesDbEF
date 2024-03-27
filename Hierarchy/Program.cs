using Hierarchy;


CriarDados();
List<PessoaFisica> pessoasFisicas = ObterPessoasFisicas();
List<PessoaJuridica> pessoasJuridicas = ObterPessoasJuridicas();

Console.WriteLine("Imprimindo Pessoas Físicas\n");
foreach (PessoaFisica pessoaFisica in pessoasFisicas)
    Console.WriteLine($"Pessoa Física CPF: {pessoaFisica.CPF}; Data de inclusão: {pessoaFisica.DataDeInclusao}");

Console.WriteLine("\n\n\n");

Console.WriteLine("Imprimindo Pessoas Jurídicas\n");
foreach (PessoaJuridica pessoaJuridica in pessoasJuridicas)
    Console.WriteLine($"Pessoa Jurídica CNPJ: {pessoaJuridica.CNPJ}; Data de inclusão: {pessoaJuridica.DataDeInclusao}");


static void CriarDados()
{
    ApplicationContext applicationContext = new ApplicationContext();

    PessoaFisica pessoaFisica = new PessoaFisica();
    pessoaFisica.DataDeInclusao = DateTime.Now;
    pessoaFisica.CPF = "11111111111";

    PessoaJuridica pessoaJuridica = new PessoaJuridica();
    pessoaJuridica.DataDeInclusao = DateTime.Now;
    pessoaJuridica.CNPJ = "00000000000000";

    applicationContext.PessoasFisicas.Add(pessoaFisica);
    applicationContext.PessoasJuridicas.Add(@pessoaJuridica);
    applicationContext.SaveChanges();
}

static List<PessoaFisica> ObterPessoasFisicas()
{
    return new ApplicationContext().PessoasFisicas.ToList();
}

static List<PessoaJuridica> ObterPessoasJuridicas()
{
    return new ApplicationContext().PessoasJuridicas.ToList();
}

