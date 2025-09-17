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
        Scène2();
    }

    public static void chapitre_titre()
    {
        //Contenu du chapitre
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
        String Scene1;
        //Votre déroulé d'aventure
        Scene1 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scène1\texte scène1.txt");
        Console.WriteLine(Scene1);
        Scene1 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scène1\image scène1.txt");
        Console.WriteLine(Scene1);

        Console.ReadLine();
    }
    public static void Scène2()
    {
        string choix;
        string Scene2;
        Scene2 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scene2\choix scene2.txt");
        Console.WriteLine(Scene2);
        Console.Write("Choisissez une option : 1 ou 2 ");
        choix = Console.ReadLine().ToLower();

        switch (choix)
        {
            case "1":
                //Chapitre 1
                Scene2 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scene2\image scene2.txt");
                Console.WriteLine(Scene2);
                Console.ReadLine();
                Scène3();
                //bon choix (chambre)
                break;
            case "2":
                string Scene2_1;
                Scene2_1 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\Game over\Game Over.txt");
                Console.WriteLine(Scene2_1);
                Scene2 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scene2\game over .txt");
                Console.WriteLine(Scene2);
                Console.ReadLine();
                //gameover
                //relancer jeu
                chapitre_titre();
                break;
            default:
                Console.WriteLine("Choix invalide, veuillez réessayer.");
                //Relancer le jeu ou le chapitre en cours
                Scène2();
                break;

        }
    }
         public static void Scène3()
    {
        string choix;
        string Scene3;
        Scene3 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scène3\question.txt");
        Console.WriteLine(Scene3);
        Scene3 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scène3\choix sc3.txt");
        Console.WriteLine(Scene3);
        Console.Write("Choisissez une option : 1 ou 2 ");
        choix = Console.ReadLine().ToLower();

        switch (choix)
        {
            case "1":
                string Scene3_1;
                Scene3_1 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\Game over\Game Over.txt");
                Console.WriteLine(Scene3_1);
                Scene3_1 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scène3\mort.txt");
                Console.WriteLine(Scene3_1);
                Console.ReadLine();
                chapitre_titre();
                
                
                break;
            case "2":
            Scene3 = File.ReadAllText(@"C:\Users\xeral\Documents\git\Spoot\ressources\scène3\reussi scene3.txt");
                Console.WriteLine(Scene3);
                Console.ReadLine();
                Scene4();
                break;
            default:
                Console.WriteLine("Choix invalide, veuillez réessayer.");
                //Relancer le jeu ou le chapitre en cours
                Scène3();
                break;
        }
        Console.ReadLine();
    }
}



