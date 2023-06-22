using System;

class Program {
  public static void Main (string[] args) {
    FiguraGeometrica fg = new FiguraGeometrica() {Lado = 1000};
    Console.WriteLine("Área da figuraGeometrica: " + fg.CalcularArea());

    Circulo c = new Circulo(){ Lado = 30, Raio = 40};
    Console.WriteLine("\nÀrea do circulo: " + c.CalcularArea());

    Quadrado q = new Quadrado() { Lado = 10 };
    Console.WriteLine("\nÁrea do quadrado: " + q.CalcularArea());

    Pentagono p = new Pentagono() { Lado = 3 };
    Console.WriteLine("\nÁrea do pentagono: " + p.CalcularArea());

    Hexagono h = new Hexagono() { Lado = 4 };
    Console.WriteLine("\nÁrea do haxagono: " + h.CalcularArea());
    
    Heptagono hp = new Heptagono() {Lado = 4};
    Console.WriteLine("\nÁrea do Heptagono: " + hp.CalcularArea());

    Octagono oc = new Octagono() { Lado = 6};
    Console.WriteLine("\nÁrea do octagono: " + oc.CalcularArea());
  }
  
}