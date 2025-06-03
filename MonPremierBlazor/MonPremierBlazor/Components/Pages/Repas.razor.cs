using Microsoft.AspNetCore.Components;
using Microsoft.VisualBasic;

namespace MonPremierBlazor.Components.Pages
{
    public partial class Repas
    {
        [Parameter]
        public string Info { get; set; }
        public void fnGo()
        {
            Info = "Tu as clické sur GO";
        }
    }
}
