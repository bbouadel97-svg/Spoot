using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        chapitre_titre();
        Scène1();

    }
    public static void chapitre_titre()
    {
        //Contenu du chapitre
        String choix;
        String Titre;
        //Votre déroulé d'aventure
        Titre = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\ascii-art.txt");
        Console.WriteLine(Titre);
        //String Titre2;
        Titre = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\ecran_titre.txt");
        Console.WriteLine(Titre);
        Console.ReadLine();
    }
    public static void Scène1()
    {
        //Contenu du chapitre
        String choix;
        String Scene1;
        //Votre déroulé d'aventure
        Scene1 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scène1\texte scène1.txt");
        Console.WriteLine(Scene1);
        Scene1 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scène1\image scène1.txt");
        Console.WriteLine(Scene1);

        Console.ReadLine();
    }

}



