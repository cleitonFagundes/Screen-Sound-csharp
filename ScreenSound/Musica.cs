class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }


    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }//Operação de leitura(get) e de escrita(set);

    public string DescricaoResumida => $"A música {Nome} é do artista {Artista} com duração de {Duracao} segundos.";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no seu plano.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Adiquira o plano PutzPremium para ouvir {Nome}");
            Console.WriteLine();
        }
    }
}