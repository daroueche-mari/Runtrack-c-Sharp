using System;

namespace Job1
{
    public class Msg
    {
         public void CharacterSheet()
        {
            string nom = "Bob";          // Type 1: string
            int age = 25;                // Type 2: int
            int niveau = 5;
            string classe = "Guerrier";
            double piecesDOr = 150.50;   // Type 3: double
            bool estNouveau = true;      // Type 4: bool

            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"Âge : {age} ans");
            Console.WriteLine($"Niveau : {niveau}");
            Console.WriteLine($"Classe : {classe}");
            Console.WriteLine($"Bourse : {piecesDOr} pièces d'or");
            Console.WriteLine($"Nouveau : {estNouveau}");
        } 
        public string Communicate(string message)
        {
            return message;
        }
    }
}