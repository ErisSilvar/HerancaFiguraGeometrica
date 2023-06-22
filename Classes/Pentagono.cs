using System;

public class Pentagono : FiguraGeometrica {

    public override Single CalcularArea(){
    double apotema = (Lado / 2) / Math.Tan(Math.PI / 5);
    double area = (5 * Lado * apotema) / 2;
    return (Single)area;
    }
  
}