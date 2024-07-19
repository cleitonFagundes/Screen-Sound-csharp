using System;
using System.Collections.Generic;
using System.Linq;

class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    // Propriedade para obter a duração total no formato minutos:segundos
    public string DuracaoTotalFormatada
    {
        get
        {
            // Calcula a duração total em segundos
            int duracaoTotalSegundos = DuracaoTotal;

            // Calcula minutos e segundos
            int minutos = duracaoTotalSegundos / 60;
            int segundos = duracaoTotalSegundos % 60;

            // Retorna a string formatada
            return $"{minutos}:{segundos:D2}";
        }
    }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome} da Banda FooFighters:\n ");
        foreach (var musica in musicas)
        {
        Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir esse Álbum inteiro você precisa de aproximadamente {DuracaoTotal} ou o equivalente á {DuracaoTotalFormatada:F2} minutos.");
    }
}