using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioControles
    {
        IEnumerable<Control> GetAllControles();
        Control AddControl(Control control);
        Control UpdateControl(int IdControl, Control control);
        void DeleteControl(int IdControl);
        Control GetControl(int IdControl);   
    }
}