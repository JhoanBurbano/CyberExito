using System.Collections.Generic;

namespace ExitoLogGames.App.Dominio
{
    public class Rol
    {
        public int IdRol{get;set;}
        public int IdAdmin{get;set;}
        public int IdEmploy{get;set;}
        
        public List<Employ> Employs = new List<Employ>();
        public List<Sales> EmploySales = new List<Sales>();
        
    }
}