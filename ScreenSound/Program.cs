using ScreenSound.Modelos;

Dictionary<string, Artista> bandasRegistradas = new();

Artista Ira = new("Ira!");
Artista Leozin = new("Leozin");

bandasRegistradas.Add("Ira", Ira);
bandasRegistradas.Add("Leozin", Leozin);

void ExibirLogo()
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
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
bool BandaExiste(string banda, Action opcaoDoMenu)
{
    int voltar;

    if (bandasRegistradas.ContainsKey(banda))
    {
        return true;
    }
    else
    {
        Console.WriteLine($"\n!!!A banda {banda} não Existe!!! \n\nPara tentar novamente pressione 1 \n\nPara voltar ao menu principal presione 2");
        voltar = int.Parse(Console.ReadLine()!);
        switch (voltar)
        {
            case 1: opcaoDoMenu(); break;
            case 2: ExibirOpcoesDoMenu(); break;
        }
        return false;
    }
}
void VoltarAoMenu()
{
    Console.WriteLine("\nAperte Qualquer tecla para voltar");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}
void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandasRegistradas();
            break;
        case 4:
            AvaliarUmaBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDoArtista = Console.ReadLine()!;
    Artista artista = new Artista(nomeDoArtista);
    bandasRegistradas.Add(nomeDoArtista, artista);
    Console.WriteLine($"A banda {nomeDoArtista} foi registrada com sucesso!");
    VoltarAoMenu();
}
void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDoArtista = Console.ReadLine()!;
    if(BandaExiste(nomeDoArtista, RegistrarAlbum))
    {

    Artista artista = bandasRegistradas[nomeDoArtista];

    Console.Write("Agora digite o título do álbum: ");
    string tituloAlbum = Console.ReadLine()!;

    Album AlbumNovo = new(tituloAlbum);
    artista.AdicionarAlbum(AlbumNovo);
    
    Console.WriteLine($"O álbum {tituloAlbum} de {nomeDoArtista} foi registrado com sucesso!");

    }

    VoltarAoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    VoltarAoMenu();
}
void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (BandaExiste(nomeDoArtista, AvaliarUmaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDoArtista} merece: ");
        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDoArtista].AdicionarNota(nota);
        Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDoArtista}");
        VoltarAoMenu();   
    }
}
void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string NomeDoArtista = Console.ReadLine()!;
    if (BandaExiste(NomeDoArtista, ExibirDetalhes))
    {
        Artista artista = bandasRegistradas[NomeDoArtista]; 
        Console.WriteLine($"\nA média da banda {artista.Nome} é {artista.Media}.");
        artista.ExibirDiscografia();
        VoltarAoMenu();

    }
}

ExibirOpcoesDoMenu();