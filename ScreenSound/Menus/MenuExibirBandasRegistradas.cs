namespace ScreenSound.Menus;

internal class MenuExibirBandasRegistradas : Menu
{
    public static void Executar()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        VoltarAoMenu();
    }
}
