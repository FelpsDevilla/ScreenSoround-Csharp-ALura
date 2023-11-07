namespace ScreenSound.Modelos;
internal class Avaliacao
{
    public Avaliacao(int nota) 
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string Texto) 
    {
        int nota = int.Parse(Texto);
        return new Avaliacao(nota);
    }
}
