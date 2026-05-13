public class Receta{
    public string Nombre {get;set;}
    public DateTime FechaNacimiento {get;set;}
    public string TipoComida {get;set;}
    public double PresupuestoDisp {get;set;}
    public int CantPersonas {get;set;}

    public Receta (string nombre, DateTime fecha, string tipo, double presu, int cant)
    {
        this.Nombre = nombre;
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

    public string determinarPlato(){
        string platoSugerido;
        if(TipoComida == "Caliente"){
            if(PresupuestoDisp < 3000){
                platoSugerido = "Fideos Con Manteca";
            }
            else if(3000 <= PresupuestoDisp <= 7000){
                platoSugerido = "Arroz con verduras salteadas";
            }
            else{
                platoSugerido = "Pollo al horno con guarnición";
            }
             }
        else if(TipoComida == "Fría"){
            if(PresupuestoDisp < 3000){
                platoSugerido = "Ensalada simple";
            }
            else if(3000 <= PresupuestoDisp <= 7000){
                platoSugerido = "Ensalada completa con proteína";
            }
            else{
                platoSugerido = "Tabla de fiambres y quesos";
            }
        }
        return platoSugerido;
       
    }

    public int calcularTiempo(){
        int minutosEst;
        if(TipoComida == "Caliente"){
            if (CantPersonas == 1 || CantPersonas == 2 || CantPersonas == 3){
                minutosEst = 20;
            }
            else if(4 <= CantPersonas <= 7){
                minutosEst = 40;
            }
            else{
                minutosEst = 80;
            }
             }
        else if(TipoComida == "Fría"){
             if (CantPersonas == 1 || CantPersonas == 2 || CantPersonas == 3){
                minutosEst = 10;
            }
            else if(4 <= CantPersonas <= 7){
                minutosEst = 20;
            }
            else{
                minutosEst = 40;
            }
        }
        return minutosEst;
    }

    public string determinarDificultad(){
        string dificultad;

        if(PresupuestoDisp < 3000){
            if (CantPersonas == 1 || CantPersonas == 2 || CantPersonas == 3){
                dificultad = "Principiante";
            }
            else if(4 <= CantPersonas <= 7){
                dificultad = "Intermedio";
            }
        }
        else if(3000 <= PresupuestoDisp <= 7000){
             if (CantPersonas == 1 || CantPersonas == 2 || CantPersonas == 3){
                dificultad = "Intermedio";
            }
            else if(4 <= CantPersonas){
               dificultad = "Intermedio";
            }
        }
        else{
            if(1 <= CantPersonas <= 7){
                dificultad = "Intermedio";
            }
            else{
                dificultad = "Avanzado";
            }
        }
        return dificultad;
    }


}