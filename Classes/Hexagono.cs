using System;

public class Hexagono : FiguraGeometrica{

  public override Single CalcularArea(){
   double area = (3 * Math.Sqrt(3) * Math.Pow(Lado, 2)) / 2;
    return (Single) area;
    }
  
}