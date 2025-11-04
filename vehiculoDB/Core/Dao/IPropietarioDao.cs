using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehiculoDB.Core.Clases;

namespace vehiculoDB.Core.Dao
{
    internal interface IPropietarioDao
    {
        int Insert(Propietario PaaPropietario);
        bool Update(Propietario paPropietario);
        bool Delete(int idPropietario);
        Propietario GetById(int idPropietario);
        List<Propietario> GetAll(string filtro = "");
    }
}
