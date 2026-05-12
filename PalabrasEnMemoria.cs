namespace Ahorcado;

public class PalabrasEnMemoria
{
    private readonly List<string> _palabras = new()
    {
        "arquitectura", "interfaz", "polimorfismo", "encapsulamiento", "herencia"
    };

    public string ObtenerPlabraAleatoria()
    {
        var random = new Random();
        return _palabras[random.Next(_palabras.Count)];
    }
}