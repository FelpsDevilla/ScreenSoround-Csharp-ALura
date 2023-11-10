using ScreenSound.Modelos;
using ScreenSound.Menus;
using ScreenSound;

internal class Program
{
    public static Dictionary<string, Artista> bandasRegistradas = new();

    public static Dictionary<int, Action> Menus = new Dictionary<int, Action>
{
    { 1, MenuRegistrarBandaArtistas.Executar },
    { 2, MenuRegistrarAlbum.Executar },
    { 3, MenuExibirBandasRegistradas.Executar },
    { 4, MenuAvaliarUmaBanda.Executar },
    { 5, MenuAvaliarAlbum.Executar },
    { 6, MenuExibirDetalhes.Executar },
    { -1, MenuRegistrarBandaArtistas.Executar }
};
    private static void EscolheOpcao()
    {
        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        if (Menus.ContainsKey(opcaoEscolhidaNumerica)) 
        {
            Action menuAserExecutado = Menus[opcaoEscolhidaNumerica];
            menuAserExecutado();
           
           
        }else
            {
                Console.WriteLine("Opção inválida, tente novamente");
                EscolheOpcao();
            }
        
    }
    public static void ExibirOpcoesDoMenu()
    {
        Console.Clear();
        Menu.ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
        Console.WriteLine("Digite 3 para mostrar todas as bandas");
        Console.WriteLine("Digite 4 para avaliar uma banda");
        Console.WriteLine("Digite 5 para avaliar um album");
        Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
        Console.WriteLine("Digite -1 para sair");

        EscolheOpcao();

        
    }

    private static async Task Main(string[] args)
    {


        //ExibirOpcoesDoMenu();
        string resumo = await ChatGPT.GerarResumoArtistaAsync("Leozin");

        Console.WriteLine($"{resumo}");
    }
} 