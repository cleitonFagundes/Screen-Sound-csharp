Banda FooFighters = new Banda("FooFighters");

Album FooFightersAlbum = new Album("Echoes of Resilience");

Musica musica1 = new Musica(FooFighters, "Everlong")
{
    Duracao = 250,
    Disponivel = true,
};

Musica musica2 = new Musica(FooFighters, "The Pretender")
{
    Duracao = 269,
    Disponivel = true,
};

Musica musica3 = new Musica(FooFighters, "My Hero")
{
    Duracao = 250,
    Disponivel = false,
};

Musica musica4 = new Musica(FooFighters, "Learn to Fly")
{
    Duracao = 233,
    Disponivel = true,
};

Musica musica5 = new Musica(FooFighters, "All My Life")
{
    Duracao = 263,
    Disponivel = true,
};

FooFightersAlbum.AdicionarMusica(musica1);
FooFightersAlbum.AdicionarMusica(musica2);
FooFightersAlbum.AdicionarMusica(musica3);
FooFightersAlbum.AdicionarMusica(musica4);
FooFightersAlbum.AdicionarMusica(musica5);
FooFighters.AdicionarAlbum(FooFightersAlbum);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();
musica5.ExibirFichaTecnica();
FooFightersAlbum.ExibirMusicasAlbum();
FooFighters.ExibirDiscografia();