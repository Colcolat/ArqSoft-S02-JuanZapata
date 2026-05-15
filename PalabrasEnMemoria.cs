namespace Ahorcado;

public class PalabrasEnMemoria : IRepositorioPalabras
{
    private int tema;
    
    public void setTemaPalabraSecreta(int eleccionUsuario) {
        this.tema = eleccionUsuario;
    }   
    
    private readonly List<string> _palabrasPOO = new()
    
    {
        "arquitectura", "interfaz", "polimorfismo", "encapsulamiento", "herencia"
    };

    private readonly List<string> _palabrasArquitectura = new()
    {
        "arquitectura", "interfaz", "polimorfismo", "encapsulamiento", "herencia"
    };
    
    private readonly List<string> _palabrasNET = new()
    {
        "arquitectura", "interfaz", "polimorfismo", "encapsulamiento", "herencia"
    };


    public string ObtenerPalabraSecreta()
    {
        var random = new Random();
        {
            switch (tema)
            {
                case 1: return _palabrasArquitectura[random.Next(_palabrasArquitectura.Count)];
                case 2: return _palabrasPOO[random.Next(_palabrasPOO.Count)];
                case 3: return _palabrasNET[random.Next(_palabrasNET.Count)];
                default: throw new FormatException("ERROR: La entrada no coincide con las opciones");
            } 

        }
        
    } 

}