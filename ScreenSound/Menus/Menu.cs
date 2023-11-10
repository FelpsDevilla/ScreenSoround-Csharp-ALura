using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menu 
{

    //Cria um apelido para todos os filhos de Menu acessar o Dicionario.
    public static Dictionary<string, Artista> bandasRegistradas = Program.bandasRegistradas;

    public static void TentarNovamenteVoltar(Action opcaoDoMenu)
    {
        Console.WriteLine(" \n\nPara tentar novamente pressione 1 \n\nPara voltar ao menu principal presione 2");
        int voltar = int.Parse(Console.ReadLine()!);
        switch (voltar)
        {
            case 1: opcaoDoMenu(); break;
            case 2: Program.ExibirOpcoesDoMenu(); break;
        }
    }
    public static bool BandaExiste(string banda, Action opcaoDoMenu)
    { 
        if (bandasRegistradas.ContainsKey(banda))
        {
            return true;
        }
        else
        {
            Console.WriteLine($"\n!!!A banda {banda} não Existe!!!");
            TentarNovamenteVoltar(opcaoDoMenu);
            return false;
        }
    }
    public static void ExibirLogo()
    {
        Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
        Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
    }
    public static void VoltarAoMenu()
    {
        Console.WriteLine("\nAperte Qualquer tecla para voltar");
        Console.ReadKey();
        Program.ExibirOpcoesDoMenu();
    }
    public static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
   
}


