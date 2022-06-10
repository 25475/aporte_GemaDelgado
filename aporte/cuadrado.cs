using System;
namespace aporteP;
public class GDcuadrado:GDfigura, IGemaD
{
    public int lado{get;set;}

    public GDcuadrado(int lado,string nombre, string color):base(nombre,color)
    {
        this.lado=lado;

    }
    
    public override void muestra(){
        int tot;
        tot=lado*lado;
        Console.WriteLine("el area del cuadrado es : "+tot);
    }
}