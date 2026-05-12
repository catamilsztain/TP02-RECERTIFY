public class Receta{
    public string NombreCocinero {get;set;}
    public DateTime FechaNacimiento {get;set;}
    public string TipoComida {get;set;}
    public double PresupuestoDisp {get;set;}
    public int CantPersonas {get;set;}

    public Receta (string nombre, DateTime fecha, string tipo, double presu, int cant)
    {
        this.NombreCocinero = nombre;
        this.FechaNacimiento = fecha;
        this.TipoComida = tipo;
        this.PresupuestoDisp = presu;
        this.CantPersonas = cant;
    }

    public int CalcularEdad (){
        int edad = DateTime.Today.Year - FechaNacimiento.Year;

        if(DateTime.Today.Month < FechaNacimiento.Month && DateTime.Today.Day < FechaNacimiento.Day)
        {
            edad -= 1;
        }
        return edad;
    }


}