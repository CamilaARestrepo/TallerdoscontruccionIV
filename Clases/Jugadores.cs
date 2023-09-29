public class Jugador
{
    private string Nombre {get;set;} 
    private string Posicion {get;set;} 

    private int Rendimiento {get;set;} 

    public Jugador(string Nombre, string Posicion, int Rendimiento){
        this.Nombre = Nombre;
        this.Posicion = Posicion;
        this.Rendimiento = Rendimiento;
    }

    public string getNombre()
    {
        return this.Nombre;
    }

    public string getPosicion()
    {
        return this.Posicion;
    }

    public int getRendimiento()
    {
        return this.Rendimiento;
    }

}