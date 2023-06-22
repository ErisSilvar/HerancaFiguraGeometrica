using System;

public class Octagono : FiguraGeometrica{
  public override Single CalcularArea(){
  double area = 2 * Lado * Lado * (1 + Math.Sqrt(2));
    return (Single) area;
    }
  
}