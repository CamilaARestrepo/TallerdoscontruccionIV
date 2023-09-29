public class Team
{
    private string Nombre {get;set;}
    private List<Jugador> jugadores = new List<Jugador>();

    public Team(string Nombre)
    {
        this.Nombre = Nombre;
    }
    public void agregarJugador(Jugador jugador)
    {
        jugadores.Add(jugador);
    }
    public void verJugadores()
    {
        foreach (Jugador jugador in jugadores)
        {
            Console.WriteLine($"Datos del jugador:\nNombre: {jugador.getNombre()}, Posición: {jugador.getPosicion()}, Rendimiento: {jugador.getRendimiento()}\n");
        }
    }
        public int ganadorPorRendimiento()
    {
        int sumaRendimiento = 0;
        foreach (Jugador jugador in jugadores)
        {
            sumaRendimiento += jugador.getRendimiento();
        }
        return sumaRendimiento;
    }
}