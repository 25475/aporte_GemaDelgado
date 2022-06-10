using System;
namespace aporteP;
public class GDcirculo:GDfigura,IGemaD
{
    public double pi=Math.PI;
    public double r2{get;set;}

    public GDcirculo(double pi,double r2,string nombre, string color):base(nombre,color)
    {
        this.pi=Math.PI;
        this.r2=r2;

    }
    
    public override void muestra(){
        double area;
        area=pi*r2*r2;
        Console.WriteLine("el area del circulo es: "+area);
    }
}