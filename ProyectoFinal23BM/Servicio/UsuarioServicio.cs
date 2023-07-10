using ProyectoFinal23BM.Context;
using ProyectoFinal23BM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal23BM.Servicio
{
    public class UsuarioServicio
    {
        public void AgregarUsuario(Usuario request)
        {
            try
            {
                if(request == null) 
                { 
                    using (var _contex = new ApplicationDbContext())
                    {
                        Usuario res = new Usuario();
                        res. Nombre = request.Nombre;
                        res.UserName = request.UserName;
                        res.Password = request.Password;
                        //res.FkRol=request.FkRol;

                        _contex.Usuarios.Add(res);
                        _contex.SaveChanges();
                    }
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("Sucedio un error" +  ex.Message);
            
            }
        }

        public List<Usuario> GetUsuarios() 
        {
            try
            {
                using (var _contex = new ApplicationDbContext())
                {
                    List<Usuario>usuarios=_contex.Usuarios.ToList();
                    if(usuarios.Count > 0)//verificar listas vacias
                    {
                        return usuarios;
                    }
                    return usuarios;
                }

            }
            catch (Exception ex) 
            
            {
                throw new Exception("error" + ex.Message);
            }
        
        }
    }
}
