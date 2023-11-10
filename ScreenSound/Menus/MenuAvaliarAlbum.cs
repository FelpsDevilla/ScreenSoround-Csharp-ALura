using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public static void Executar()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar um Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (BandaExiste(nomeDoArtista, Executar))
        {
            Artista artista = bandasRegistradas[nomeDoArtista];
            Console.Write("\nDigite o nome do album que deseja avaliar: ");
            string nomeDoAlbum = Console.ReadLine()!;
            if (artista.Albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
            {
                Album album = artista.Albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                Console.Write($"\nQual a nota que o album {album.Nome} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {nomeDoAlbum}");
                VoltarAoMenu();
            }
            else
            {
                Console.WriteLine("\n!!!Album Não encontrado!!!");
                TentarNovamenteVoltar(Executar);
            }

            
        }
    }
}