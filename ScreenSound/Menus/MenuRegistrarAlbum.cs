using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public static void Executar()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite o artista cujo álbum deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (BandaExiste(nomeDoArtista, Executar))
        {

            Artista artista = bandasRegistradas[nomeDoArtista];

            Console.Write("\nAgora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            Album AlbumNovo = new(tituloAlbum);
            artista.AdicionarAlbum(AlbumNovo);

            Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeDoArtista} foi registrado com sucesso!");

        }

        VoltarAoMenu();
    }
}
