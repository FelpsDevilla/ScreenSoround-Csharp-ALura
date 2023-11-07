﻿namespace ScreenSound.Modelos;
internal class Album
{
    private List<Musica> musicas = new List<Musica>();
    private static int contador = 0;
    public Album(string nome)
    {
        Nome = nome;
        Ordem = contador;
        contador++;
    }

    public string Nome { get; }
    public int Ordem { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}