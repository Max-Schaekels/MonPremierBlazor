using Microsoft.AspNetCore.Components;

namespace MonPremierBlazor.Components.Pages
{
    public partial class Manger
    {
        [Parameter]
        public string? mode { get; set; }

        protected string message = "";

        protected override void OnInitialized()
        {
            if (string.Equals(mode, "BurgerTime", StringComparison.OrdinalIgnoreCase))
            {
                message = "Bon appétit, c'est l'heure !";
            }
            else
            {
                DateTime maintenant = DateTime.Now;
                
                DateTime prochainRepas = new DateTime(maintenant.Year, maintenant.Month, maintenant.Day, 12, 30, 0);



                int minutes = (int)(prochainRepas - maintenant).TotalMinutes;
                message = $"Vous êtes à {minutes} minutes du repas";
            }
        }


    }
}
