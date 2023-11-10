using OpenAI_API;

namespace ScreenSound;

internal class ChatGPT
{
    public static async Task<string> GerarResumoArtistaAsync(string NomeDoArtista)
    {
        var client = new OpenAIAPI("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");
        var chat = client.Chat.CreateConversation();
        string mensagem = $"Gere um resumo sobre a banda ou artista {NomeDoArtista}";
        chat.AppendSystemMessage(mensagem);
        string resumo = await chat.GetResponseFromChatbotAsync();
        Console.WriteLine(resumo);

        return resumo;
    }
}
    