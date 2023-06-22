using System;

public class Heptagono : FiguraGeometrica{
  
  public override Single CalcularArea(){
     double apotema = (Single)Lado / (2 * Math.Tan(Math.PI / 7));
        double area = (Single)(7 * Lado * apotema) / 2;
        return (Single)area;
  }
  
}