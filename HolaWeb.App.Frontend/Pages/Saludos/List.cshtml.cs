using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWep.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private string[] saudos = {"Buenos dias","Buenas tardes","Buenas noches","Hasta mañana"};

        public List<string> ListaSaludos{get;set;}
        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(saudos);
        }
    }
}
