using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using COVID.App.Persistencia;
using COVID.App.Dominio;

namespace COVID.App.Frontend.Pages
{
    public class DirectivosModel : PageModel
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        public IEnumerable<Directivo> Directivos {get;set;}
        public void OnGet()
        {
            Directivos = _repoDirectivo.GetAllDirectivos();
        }
    }
}

