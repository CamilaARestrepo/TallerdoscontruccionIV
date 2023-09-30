
Jugador jugador1 = new Jugador("Deiby","BASE", 2);
Jugador jugador2 = new Jugador("Richard","ESCOLTA" ,4);
Jugador jugador3 = new Jugador("Karen","ALERO", 6);
Jugador jugador4 = new Jugador("David","PIVOT" ,8);
Jugador jugador5 = new Jugador("Dylan","ALA-PIVOT" ,10);
Jugador jugador6 = new Jugador("Flor","PIVOT", 1);

List<Jugador> listaJugadores = new List<Jugador>();


Team orange = new Team("orange");
Team green = new Team("green");

listaJugadores.Add(jugador1);
listaJugadores.Add(jugador2);
listaJugadores.Add(jugador3);
listaJugadores.Add(jugador4);
listaJugadores.Add(jugador5);
listaJugadores.Add(jugador6);

Random random = new Random();
int contadorEquipoOrange = 0;
int contadorEquipoGreen = 0;

foreach (Jugador jugador in listaJugadores)
{
    if (contadorEquipoOrange < 3 && contadorEquipoGreen < 3)
    {
        int equipoAleatorio = random.Next(2);

        if (equipoAleatorio == 0 && contadorEquipoOrange < 3)
        {
            orange.agregarJugador(jugador);
            contadorEquipoOrange++;
        }
        else if (equipoAleatorio == 1 && contadorEquipoGreen < 3)
        {
            green.agregarJugador(jugador);
            contadorEquipoGreen++;
        }
    }
    else if (contadorEquipoOrange < 3)
    {
        orange.agregarJugador(jugador);
        contadorEquipoOrange++;
    }
    else if (contadorEquipoGreen < 3)
    {
        green.agregarJugador(jugador);
        contadorEquipoGreen++;
    }
}
        Console.WriteLine("Integrantes del equipo Orange:");
        orange.verJugadores();

        Console.WriteLine("\nItegrantes del equipo Green:");
        green.verJugadores();



int sumaRendimientoOrange = orange.ganadorPorRendimiento();
int sumaRendimientoGreen = green.ganadorPorRendimiento();

string equipoGanador = ""; 

if (sumaRendimientoOrange > sumaRendimientoGreen)
{
    equipoGanador = "Orange";
    Console.WriteLine($"\nEl equipo ganador es: !!!{equipoGanador}!!! que tiene tubo un rendimiento de  {sumaRendimientoOrange}");
}
else if (sumaRendimientoGreen > sumaRendimientoOrange)
{
    equipoGanador = "Green";
    Console.WriteLine($"\nEl equipo ganador es: !!!{equipoGanador}!!! que tiene tubo un rendimiento de  {sumaRendimientoGreen}");
}