using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlodores
{
    public class controladorLogin
    {
        public Boolean GetList(string usuario, string password)
        {
            using (Modelos.EF.test1Entities3 db = new Modelos.EF.test1Entities3())
            {
                if(db.Usuarios.Find(usuario) != null && db.Usuarios.Find(usuario).Contraseña == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
    }
}
