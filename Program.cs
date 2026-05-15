Console.WriteLine("¿Qué juego quieres jugar?");
Console.WriteLine("  1 — Ahorcado");
Console.WriteLine("  2 — Viborita");
Console.Write("Opción: ");
var opcion = Console.ReadLine();
 
if (opcion == "1")
{
    // --- LÓGICA DEL AHORCADO ---
    var repositorio = new Ahorcado.PalabrasEnMemoria();
    
    Console.WriteLine("=== AHORCADO ===");
    // Menú principal
    Console.WriteLine("Seleccione la Temática.");
    Console.WriteLine("  1 — Arquitectura");
    Console.WriteLine("  2 — POO");
    Console.WriteLine("  3 — .NET");

    // Corrección en la condición: < 1 || > 3
    if (!int.TryParse(Console.ReadLine(), out int eleccion) || eleccion < 1 || eleccion > 3)
    {
        Console.WriteLine("Opción no válida.");
        return;
    }
    
    // Primero asignamos el tema
    repositorio.setTemaPalabraSecreta(eleccion);

    // AHORA SÍ inicializamos el motor, porque ya sabe qué tema usar
    var motor = new Ahorcado.MotorAhorcado(repositorio);
    var ui = new Ahorcado.ConsoleUI(motor);

    while (!motor.Ganado() && !motor.Perdido())
    {
        ui.MostrarTablero();
        char letra = ui.PedirLetra();
 
        if (motor.LetraYaUsada(letra))
        {
            ui.MostrarMensaje("Ya usaste esa letra.");
            continue;
        }
        motor.RegistrarLetra(letra);
    }
 
    ui.MostrarTablero();
 
    if (motor.Ganado())
        ui.MostrarMensaje($"\n¡Ganaste! La palabra era: {motor.PalabraSecreta}");
    else
        ui.MostrarMensaje($"\nPerdiste. La palabra era: {motor.PalabraSecreta}");
 
    if (ui.PreguntarOtraVez())
    {
        var nuevoMotor = new Ahorcado.MotorAhorcado(repositorio);
        var nuevaUI = new Ahorcado.ConsoleUI(nuevoMotor);
    }
}
else if (opcion == "2")
{
    // --- LÓGICA DE LA VIBORITA ---
    var motor = new Ahorcado.MotorViborita();
    var ui = new Ahorcado.ConsolaUIViborita(motor);
 
    Console.CursorVisible = false;
 
    while (!motor.Ganado() && !motor.Perdido())
    {
        ui.MostrarTablero();
        var tecla = ui.LeerTecla();
 
        if (tecla == ConsoleKey.Q) break;
 
        if (tecla != ConsoleKey.NoName)
            motor.CambiarDireccion(tecla);
 
        motor.Avanzar();
        Thread.Sleep(150); // velocidad del juego
    }
 
    ui.MostrarTablero();
    ui.MostrarMensaje(motor.Ganado()
        ? "\n¡Ganaste! Llegaste a 10 puntos."
        : "\nGame over.");
 
    Console.CursorVisible = true;
}
else
{
    Console.WriteLine("Opción no válida.");
}