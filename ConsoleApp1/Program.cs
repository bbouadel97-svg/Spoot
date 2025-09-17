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
        String Titre2;
        Titre2 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\ecran_titre.txt");
        Console.WriteLine(Titre2);
        Console.ReadLine();
    }
    public static void Scène1()
    {
        //Contenu du chapitre
         String choix;
        String Scene1_1;
        //Votre déroulé d'aventure
        Scene1_1 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\ascii-art.txt");
        Console.WriteLine(Scene1_1);
        
        Console.ReadLine();

}



