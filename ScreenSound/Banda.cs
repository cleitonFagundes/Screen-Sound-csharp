﻿class Banda
{
    private LinkedList<Album> albuns = new LinkedList<Album>();
    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.AddFirst(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotalFormatada:F2} minutos totais do álbum)");
        }
    }
}