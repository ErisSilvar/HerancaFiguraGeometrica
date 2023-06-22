using System;

public class Circulo : FiguraGeometrica{
  public Single Raio { get; set; }

  public override Single CalcularArea(){
    return (Single ) (Math.PI * Math.Pow(Raio, 2));
  }
  
}