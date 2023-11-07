namespace ScreenSound.Modelos;
internal class Avaliacao
{
    public Avaliacao(int nota) 
    {
        if(nota < 0)
        {
            nota = 0;
        }else if (nota > 10){
            nota = 10;
        }
          Nota = nota;
 
    }

    public int Nota { get; }

    public static Avaliacao Parse(string Texto) 
    {
        int nota = int.Parse(Texto);
        return new Avaliacao(nota);
    }
}
