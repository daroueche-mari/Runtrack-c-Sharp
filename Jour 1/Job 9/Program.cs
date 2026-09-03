using System;
using System.Collections.Generic;

namespace Jour01
{
    class Program
    {
        public static List<string> Sort(string[] args)
        {
            List<string> words = new List<string>(args);
            if (words.Count == 0) return words;

            // Règle 7 : Vérification du mot "trick"
            bool hasTrick = false;
            foreach (var word in words)
            {
                if (word.Contains("trick"))
                {
                    hasTrick = true;
                    break;
                }
            }

            // Règle 5 : Si la liste contient 10 mots d'origine
            bool isTenWords = words.Count == 10;

            // Règle 6 : Nettoyage des mots de longueur 11
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length == 11)
                {
                    string cleaned = "";
                    foreach (char c in words[i])
                    {
                        if (c < '0' || c > '9')
                        {
                            cleaned += c;
                        }
                    }
                    words[i] = cleaned;
                }
            }

            // Tri par comparaison personnalisée
            words.Sort((a, b) => CompareWords(a, b, isTenWords, hasTrick));

            return words;
        }

        private static int CompareWords(string a, string b, bool isTenWords, bool hasTrick)
        {
            int result = BaseCompare(a, b, isTenWords);

            // Si "trick" est présent, on inverse toutes les contraintes de tri
            if (hasTrick)
            {
                result = -result;
            }

            return result;
        }

        private static int BaseCompare(string a, string b, bool isTenWords)
        {
            // Règle 5 : Tri par taille décroissante si la liste contenait 10 mots
            if (isTenWords)
            {
                if (a.Length != b.Length)
                {
                    return b.Length.CompareTo(a.Length);
                }
            }

            // Règle 4 : Détection de symbole au début (Inversion du sens de tri)
            bool aIsSymbol = a.Length > 0 && !char.IsLetterOrDigit(a[0]);
            bool bIsSymbol = b.Length > 0 && !char.IsLetterOrDigit(b[0]);

            if (aIsSymbol || bIsSymbol)
            {
                return string.Compare(b, a, StringComparison.Ordinal);
            }

            // Règle 2 : Priorité aux mots commençant par M-P (ou m-p)
            bool aIsMP = IsBetweenMAndP(a);
            bool bIsMP = IsBetweenMAndP(b);

            if (aIsMP && !bIsMP) return -1;
            if (!aIsMP && bIsMP) return 1;

            // Règle 3 : Mots commençant par des chiffres
            bool aIsDigit = a.Length > 0 && char.IsDigit(a[0]);
            bool bIsDigit = b.Length > 0 && char.IsDigit(b[0]);

            if (aIsDigit && bIsDigit)
            {
                return CompareDigitWords(a, b);
            }

            // Règle 1 : Tri alphabétique ASCII par défaut
            return string.Compare(a, b, StringComparison.Ordinal);
        }

        private static bool IsBetweenMAndP(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;
            char first = char.ToUpper(word[0]);
            return first >= 'M' && first <= 'P';
        }

        private static int CompareDigitWords(string a, string b)
        {
            int sumA = 0, sumB = 0;
            char letterA = '\0', letterB = '\0';

            foreach (char c in a)
            {
                if (char.IsDigit(c)) sumA += (c - '0');
                else { letterA = c; break; }
            }

            foreach (char c in b)
            {
                if (char.IsDigit(c)) sumB += (c - '0');
                else { letterB = c; break; }
            }

            int letterComp = letterA.CompareTo(letterB);
            if (letterComp != 0) return letterComp;

            return sumA.CompareTo(sumB);
        }

        static void Main(string[] args)
        {
            // Si aucun argument n'est fourni, on demande la saisie
            if (args.Length == 0)
            {
                Console.WriteLine("Entrez vos mots séparés par des espaces :");
                string input = Console.ReadLine() ??"";

                // Découpe la chaîne saisie en un tableau de mots
                args = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            List<string> sortedWords = Sort(args);
            Console.WriteLine("\nRésultat du tri :");
            foreach (string word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}