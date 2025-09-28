// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;

public class Quadrato
{
  
    private float lato;

    public float Lato
    {
        get { return lato; }
        set
        {
            if (value > 0) { lato = value; }

            else { throw new Exception("il lato deve essere > 0"); }
              
        }
    }
    public float area()
    {
        return lato * lato;
    }
public static Quadrato Grande(Quadrato[] quadrati ) {

        Quadrato max = quadrati[0];
        
        for(int i = 1; i < quadrati.Length; i++)
        {

            if(max.area() < quadrati[i].area())
            {
                max = quadrati[i];


            }
        }
        return max;

    }

}
class Program
{
    static void Main()
    {
        Quadrato[] quadrati = new Quadrato[10];
        float la;
        for(int i=0; i<quadrati.Length; i++)
        {
            Console.WriteLine("inserisci ");
            while(!float.TryParse(Console.ReadLine(),out la) || la<=0){
                Console.WriteLine("Erroe");
            }
            quadrati[i] = new Quadrato();  
            quadrati[i].Lato = la;        

        }
        for(int i = 0; i < quadrati.Length; i++)
        {
            Console.WriteLine($"l'area del quadrato{i} è : {quadrati[i].area()} ");        
    
  }
        Quadrato max = Quadrato.Grande(quadrati);
        Console.WriteLine($"il quadrato più grande è {max.area()} ");

    }
}

