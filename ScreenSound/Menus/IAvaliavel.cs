using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);
        double Media {  get; }
    }
}
