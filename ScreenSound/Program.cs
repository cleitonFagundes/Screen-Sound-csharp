Album FooFightersAlbum = new Album();
FooFightersAlbum.Nome = "Echoes of Resilience";

Musica musica1 = new Musica();
musica1.Nome = "Everlong";
musica1.Duracao = 250;

Musica musica2 = new Musica();
musica2.Nome = "The Pretender";
musica2.Duracao = 269;

Musica musica3 = new Musica();
musica3.Nome = "My Hero";
musica3.Duracao = 250;

Musica musica4 = new Musica();
musica4.Nome = "Learn to Fly";
musica4.Duracao = 233;

Musica musica5 = new Musica();
musica5.Nome = "All My Life";
musica5.Duracao = 263;

FooFightersAlbum.AdicionarMusica(musica1);
FooFightersAlbum.AdicionarMusica(musica2);
FooFightersAlbum.AdicionarMusica(musica3);
FooFightersAlbum.AdicionarMusica(musica4);
FooFightersAlbum.AdicionarMusica(musica5);

Banda FooFighters = new Banda();
FooFighters.Nome = "FooFighters";
FooFighters.AdicionarAlbum(FooFightersAlbum);
FooFighters.ExibirDiscografia();