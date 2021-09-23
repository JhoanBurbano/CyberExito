using ExitoLogGames.App.Persistencia;
using System.Collections.Generic;
using System.Linq;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Comandos
{
    public class CRUDempleado : CRUDEmploy
    {
        private readonly Connection conexion;
        public CRUDempleado(Connection conexion){
            this.conexion = conexion;
        }

        Employ CRUDEmploy.AddEmploy(Employ employ){
            var empleado = conexion.empleados.Add(employ);
            conexion.SaveChanges();
            return empleado.Entity;
        }

        void CRUDEmploy.DeleteEmploy(int IdEmploy){
            var empleado = conexion.empleados.FirstOrDefault(e => e.EmployId==IdEmploy);
            if(empleado == null)
                return;
            conexion.empleados.Remove(empleado);
            conexion.SaveChanges();
        }

        IEnumerable<Employ> CRUDEmploy.GetAllEmploys(){
            return conexion.empleados;
        }

        Employ CRUDEmploy.GetEmploy(int IdEmploy){
            return conexion.empleados.FirstOrDefault(e => e.EmployId == IdEmploy);
        }
        Employ CRUDEmploy.UpdateEmploy(Employ employ){
            var empleado = conexion.empleados.FirstOrDefault(e => e.Cedula == employ.Cedula);
            if(empleado!= null){
                empleado.Nombre=employ.Nombre;
                empleado.Apellido=employ.Apellido;
                empleado.Cedula=employ.Cedula;
                empleado.Sucursal=employ.Sucursal;
                empleado.Usuario=employ.Usuario;
                empleado.Password=employ.Password;
                conexion.SaveChanges();
                
            }
            return empleado;
        }



    }
}