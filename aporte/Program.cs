using System;
namespace aporteP;
class program{
    static void Main(string [] args){
        GDfigura cuadrado=new GDcuadrado(4,"cuadrado","rojo");
        cuadrado.visualiza();
        cuadrado.muestra();
    

        GDfigura circulo=new GDcirculo(3.14,12, "circulo","verde");
        circulo.visualiza();
        circulo.muestra();

        GDfigura rectangulo=new GDrectangulo(10,7,"rectangulo","morado");
        rectangulo.visualiza();
        rectangulo.muestra();

        
        }
    }

