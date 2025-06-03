using Microsoft.AspNetCore.Components;

namespace MonPremierBlazor.Components.Pages
{
    public partial class Quizz
    {
        public List<string> reponsesQuizz { get; set; } = new List<string>();
        public string Prenom { get; set; }

        public void RecevoirReponse(List<string> reponses)
        {
            foreach (string rep in reponses)
            {
                reponsesQuizz.Add(rep);
            }
        }

        public void AjouterReponse(string reponse)
        {
            reponsesQuizz.Add(reponse);
        }
    }
}
