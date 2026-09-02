using System;

namespace Job5
{
    public class Program
    {
        public static void Main()
        {
            SealedDoor mytest = new SealedDoor();
            OpenDoor mynewtest = new OpenDoor();
            mytest.Open(0);
            mytest.Open(1);
            mynewtest.Open(0);
            // error CS0239: 'OpenDoor.Open(int)' : impossible de substituer le membre hérité 'SealedDoor.Open(int)', car il est sealed
            // La build a échoué. Corrigez les erreurs de la build et réexécutez-la.
        }
    }
}