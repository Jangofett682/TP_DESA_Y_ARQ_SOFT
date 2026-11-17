using DAL.Models;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JuegoDAO
    {
        //Método para listar
        public List<JuegoEntity> getAll()
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var listaDB = db.Juego
                    //Join
                        .ToList();
                    return JuegoMapper.Map(listaDB);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
