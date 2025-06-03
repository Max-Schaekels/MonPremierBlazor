using Microsoft.AspNetCore.Components;

namespace MonPremierBlazor.Components.shared
{
    public partial class DisplayComponent
    {
        
        private List<string> questions;

        
        private int index;

        [Parameter]
        public EventCallback<List<string>> OnQuizFinished { get; set; }

        [Parameter]
        public string Prenom { get; set; }

        protected int num => index + 1;
        protected string question => questions[index];
        protected string? reponseActuelle;
        protected bool quizzTermine;

        
        private List<string> reponses;

        
        protected void Choisir(string reponse)
        {
            if (index < questions.Count)
            {
                reponses.Add(reponse);
                reponseActuelle = reponse;
                index++;
                
            }
            if (index == questions.Count)
            {
                quizzTermine = true;
                OnQuizFinished.InvokeAsync(reponses);
            }

        }

        
        protected override void OnInitialized()
        {
            questions = new List<string>
            {
                "Aimez-vous le chocolat ?",
                "Avez-vous déjà voyagé à l'étranger ?",
                "Savez-vous nager ?"
            };

            index = 0;
            reponses = new List<string>();
            quizzTermine = false;
        }
    }
}
