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
        String Titre;
        //Votre déroulé d'aventure
        Titre = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\ascii-art.txt");
        Console.WriteLine(Titre);
        String Titre2;
        Titre2 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\ecran_titre.txt");
        Console.WriteLine(Titre2);
        Console.ReadLine();

    }
}


