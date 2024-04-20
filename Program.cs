class Program
{
    static void Main(string[] args)
    {
        VideoJuego.Saludo();

        // Crear instancia de VideoJuego para The Legend of Zelda: Breath of the Wild
        VideoJuego zelda = new VideoJuego
        {
            Titulo = "The Legend of Zelda: Breath of the Wild",
            Desarrolladora = "Nintendo",
            Calificacion = 10,
            AnioLanzamiento = 2017
        };

        // Agregar el juego Zelda a la lista de juegos
        GestorDeVideojuegos.AgregarJuego(zelda);

        // Crear instancias de clases derivadas
        JuegoAccion juegoAccion = new JuegoAccion("Gears of War", "Epic Games", 9.5, 2006, 5);
        JuegoAventura juegoAventura = new JuegoAventura("Final Fantasy 7 Remake", "Square Enix", 10, 2015, 70);
        JuegoDeportes juegoDeportes = new JuegoDeportes("FIFA 22", "EA Sports", 8.7, 2021, "Fútbol");

        // Agregar juegos a la lista
        GestorDeVideojuegos.AgregarJuego(juegoAccion);
        GestorDeVideojuegos.AgregarJuego(juegoAventura);
        GestorDeVideojuegos.AgregarJuego(juegoDeportes);

        // Mostrar información de los juegos
        foreach (VideoJuego juego in GestorDeVideojuegos.ObtenerListaDeJuegos())
        {
            juego.MostrarInformacion();

            // Llamar al método específico de la clase derivada (polimorfismo)
            if (juego is JuegoAccion juegoAccion1)
            {
                juegoAccion1.MostrarMensajeDificultad();
            }
            else if (juego is JuegoAventura juegoAventura1)
            {
                juegoAventura1.MostrarDuracion();
            }
            else if (juego is JuegoDeportes juegoDeportes1)
            {
                juegoDeportes1.MostrarDeporte();
            }

            Console.WriteLine();
        }

        // Ejemplo de sobrecarga de operadores
        JuegoAccion juegoAccion2 = new JuegoAccion("Doom Eternal", "id Software", 8.9, 2020, 4);
        JuegoAccion juegoAccion3 = juegoAccion2 + 1; // Sobrecarga del operador +
        juegoAccion3.MostrarMensajeDificultad();

        Console.ReadLine();
    }
}

