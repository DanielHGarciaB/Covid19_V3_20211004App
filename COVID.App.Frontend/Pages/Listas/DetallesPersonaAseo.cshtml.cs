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
    public class DetallesPersonaAseoModel : PageModel
    {
        private static IRepositorioPersonal_Aseo _repoPersonalAseo = new RepositorioPersonal_Aseo(new Persistencia.AppContext());

        public IEnumerable<Personal_Aseo> PersonalAseo { get; set; }

        //codigo para crear el formulario de filtro de busqueda 
        public void OnGet(int idPersonal_Aseo)
        {
            //Filtrobusqueda = filtrobusqueda;
            PersonalAseo = _repoPersonalAseo.GetPersonal_Aseo(idPersonal_Aseo);
        }   
    }
}
