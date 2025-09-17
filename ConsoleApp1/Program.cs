using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        String choix;
        String texte;
        //Votre déroulé d'aventure
        texte = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\txt.txt");
Console.WriteLine(texte);
    }
}


