using System;

public class FiguraGeometrica{
  public Single Lado { get; set; }

  public virtual Single CalcularArea(){
    return 0f;
  }
  
}