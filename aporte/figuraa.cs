using System;
namespace aporteP;
public class GDfigura{
    public string nombref{get;set;}
    public string colorF{get;set;}

    public GDfigura(string nombref, string colorF){
        this.nombref=nombref;
        this.colorF=colorF;
    }

    public void visualiza()
    {
        Console.WriteLine("la figura es un: "+nombref);
        Console.WriteLine("el color de la figura es :"+colorF);
    }
public virtual void muestra(){

}
}