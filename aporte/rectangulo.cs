using System;
namespace aporteP;
public class GDrectangulo:GDfigura, IGemaD
{
    public int bas{get;set;}
    public int altura{get;set;}

    public GDrectangulo(int bas,int altura,string nombre, string color):base(nombre,color)
    {
        this.bas=bas;
        this.altura=altura;
    }

public override void muestra(){
int b;
b=bas*altura;
Console.WriteLine("el area del rectangulo es: "+b);
}

}