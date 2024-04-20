internal class VideoJuego
{
    public string titulo;
    public string desarrolladora;
    public double calificacion;
    public int anioLanzamiento;
    public bool jugando;

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Desarrolladora
    {
        get { return desarrolladora; }
        set { desarrolladora = value; }
    }

    public double Calificacion
    {
        get { return calificacion; }
        set
        {
            // La calificación debe estar entre 0 y 10
            if (value >= 0 && value <= 10)
            {
                calificacion = value;
            }
            else
            {
                Console.WriteLine("La calificación debe estar entre 0 y 10");
            }
        }
    }

    public int AnioLanzamiento
    {
        get { return anioLanzamiento; }
        set
        {
            // El año de lanzamiento debe ser mayor o igual a 1950 y menor o igual al año actual
            if (value >= 1950 && value <= 2024)
            {
                anioLanzamiento = value;
            }
            else
            {
                Console.WriteLine("El año de lanzamiento debe ser mayor o igual a 1950 y menor o igual al año actual.");
            }
        }
    }

    // Constructores
    public VideoJuego() { }

    public VideoJuego(string titulo, string desarrolladora, double calificacion, int anioLanzamiento)
    {
        Titulo = titulo;
        Desarrolladora = desarrolladora;
        Calificacion = calificacion;
        AnioLanzamiento = anioLanzamiento;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Desarrolladora: " + Desarrolladora);
        Console.WriteLine("Calificación: " + Calificacion);
        Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
    }

    public static void Saludo()
    {
        Console.WriteLine("Hi Gamer:");
    }

    public void IniciarPartida()
    {
        jugando = true;
        Console.WriteLine("¡Partida iniciada!");
    }

    public void DetenerPartida()
    {
        jugando = false; // Establecer jugando a false
        Console.WriteLine("Partida detenida.");
    }

    public void TerminarJuego()
    {
        if (!jugando) // Cambiar la condición
        {
            Console.WriteLine("No hay partida en curso.");
        }
        else
        {
            Console.WriteLine("Juego terminado.");
            jugando = false; // Establecer jugando a false
        }
    }
}

// Clase estática GestorDeVideojuegos
internal static class GestorDeVideojuegos
{
    private static List<VideoJuego> listaDeJuegos = new List<VideoJuego>();

    public static List<VideoJuego> ObtenerListaDeJuegos()
    {
        return listaDeJuegos;
    }

    public static void AgregarJuego(VideoJuego juego)
    {
        listaDeJuegos.Add(juego);
    }
}

// Clases derivadas de VideoJuego
internal class JuegoAccion : VideoJuego
{
    public int NivelDificultad { get; set; }

    public JuegoAccion(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, int nivelDificultad)
        : base(titulo, desarrolladora, calificacion, anioLanzamiento)
    {
        NivelDificultad = nivelDificultad;
    }

    public void MostrarMensajeDificultad()
    {
        Console.WriteLine($"Nivel de dificultad: {NivelDificultad}");
    }

    // Sobrecarga de operadores
    public static JuegoAccion operator +(JuegoAccion juego, int incremento)
    {
        JuegoAccion nuevoJuego = new JuegoAccion(juego.Titulo, juego.Desarrolladora, juego.Calificacion, juego.AnioLanzamiento, juego.NivelDificultad + incremento);
        return nuevoJuego;
    }
}
internal class JuegoAventura : VideoJuego
{
    public int horasEstimadas;

    public JuegoAventura(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, int horasEstimadas)
        : base(titulo, desarrolladora, calificacion, anioLanzamiento)
    {
        this.horasEstimadas = horasEstimadas;
    }

    public void MostrarDuracion()
    {
        Console.WriteLine($"Duración estimada: {horasEstimadas} horas");
    }
}

internal class JuegoDeportes : VideoJuego
{
    public string deporte;

    public JuegoDeportes(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, string deporte)
        : base(titulo, desarrolladora, calificacion, anioLanzamiento)
    {
        this.deporte = deporte;
    }

    public void MostrarDeporte()
    {
        Console.WriteLine($"Deporte: {deporte}");
    }
}