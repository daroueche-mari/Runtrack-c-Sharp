using System;

namespace SingleJob
{
    public class Equipe
    {
        private Meloap mymeloap = new Meloap();
        private Sameth mysameth = new Sameth();
        private EgideDeTartaros myegide = new EgideDeTartaros();


        public int sante { get; set; }

        public Equipe(int mys)
        {
            sante = mys;
        }

        public void MessageError()
        {
            if (mymeloap.mylist is null)
            {
                throw new CombatException("Erreur la liste est vide");
            }
            else if (mysameth.mydic is null)
            {
                throw new CombatException("Erreur le dictionnaire est vide");
            }
            else if (myegide.mynewdic is null)
            {
                throw new CombatException("Erreur le dictionnaire d'egide est vide");
            }
        }




    }
}