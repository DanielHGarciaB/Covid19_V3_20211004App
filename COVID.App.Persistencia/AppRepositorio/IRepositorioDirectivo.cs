using System.Collections.Generic;
using COVID.App.Dominio;
using System.Linq;

namespace COVID.App.Persistencia 
{
    public interface  IRepositorioDirectivo
    {
         //GetAllDirectivo
        
        IEnumerable<Directivo> GetAllDirectivos();
        //AddDirectivo
        Directivo AddDirectivo(Directivo directivo);
        //UpdateDirectivo
        Directivo UpdateDirectivo(Directivo directivo);
        //DeleteDirectivo
        void DeleteDirectivo(int idDirectivo);
        //GetDirectivo
         IQueryable<Directivo> GetDirectivo(int idDirectivo);
    }
}