using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarUmaBanda : Menu
{
    public static void Executar()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (BandaExiste(nomeDoArtista, Executar))
        {
            Console.Write($"Qual a nota que a banda {nomeDoArtista} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDoArtista].AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDoArtista}");
            VoltarAoMenu();
        }
    }
}
