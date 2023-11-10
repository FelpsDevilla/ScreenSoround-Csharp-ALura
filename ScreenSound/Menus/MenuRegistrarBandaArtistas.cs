using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarBandaArtistas : Menu
{
    public static void Executar()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das Bandas e Artistas");
        Console.Write("Digite o nome da banda ou Artista que deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        Artista artista = new(nomeDoArtista);
        bandasRegistradas.Add(nomeDoArtista, artista);
        Console.WriteLine($"\n{nomeDoArtista} foi registrado com sucesso!");
        VoltarAoMenu();
    }
}
