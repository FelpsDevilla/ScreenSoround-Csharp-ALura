using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public static void Executar()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string NomeDoArtista = Console.ReadLine()!;
        if (BandaExiste(NomeDoArtista, Executar))
        {
            Artista artista = bandasRegistradas[NomeDoArtista];
            Console.WriteLine($"\nA média da banda {artista.Nome} é {artista.Media}.");
            artista.ExibirDiscografia();
            VoltarAoMenu();

        }
    }
}
