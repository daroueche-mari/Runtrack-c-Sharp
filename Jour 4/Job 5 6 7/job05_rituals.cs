using System;

namespace TartarosRitual
{
    // Données transmises par l'événement
    public class RitualEventArgs : EventArgs
    {
        public string StepName { get; }
        public int Progress { get; }
        public int FluxStability { get; }

        public RitualEventArgs(string stepName, int progress, int fluxStability)
        {
            StepName = stepName;
            Progress = progress;
            FluxStability = fluxStability;
        }
    }

    // Classe gérant le rituel
    public class TeleportRitual
    {
        public event EventHandler<RitualEventArgs>? ProgressUpdated;

        private int _progress = 0;
        private int _fluxStability = 100;

        protected virtual void OnProgressUpdated(string stepName)
        {
            ProgressUpdated?.Invoke(this, new RitualEventArgs(stepName, _progress, _fluxStability));
        }

        public void AlignRunes()
        {
            _progress += 33;
            _fluxStability -= 15;
            OnProgressUpdated("Alignement des runes");
        }

        public void PurifyMiasmaStream()
        {
            _progress += 34;
            _fluxStability -= 40; // Baisse importante
            OnProgressUpdated("Purification du flux de miasme");
        }

        public void StabilizeRift()
        {
            _progress = 100;
            _fluxStability += 25;
            OnProgressUpdated("Stabilisation de la brèche");
        }

        // Méthode pour exécuter la simulation du Job 05
        public static void Run()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("     JOB 05 : LE RITUEL D'ASCENSION");
            Console.WriteLine("==================================================\n");

            TeleportRitual ritual = new TeleportRitual();

            // Gestionnaire 1 : Journal de canalisation
            ritual.ProgressUpdated += (sender, e) =>
            {
                Console.WriteLine($"[JOURNAL] Étape : {e.StepName} | Avancement : {e.Progress}% | Stabilité : {e.FluxStability}%");
            };

            // Gestionnaire 2 : Surveillance de la stabilité
            ritual.ProgressUpdated += (sender, e) =>
            {
                if (e.FluxStability < 60)
                {
                    Console.WriteLine($"⚠️ [ALERTE STABILITÉ] Chute critique détectée ! Stabilité actuelle : {e.FluxStability}%\n");
                }
            };

            ritual.AlignRunes();
            ritual.PurifyMiasmaStream();
            ritual.StabilizeRift();
        }
    }
}