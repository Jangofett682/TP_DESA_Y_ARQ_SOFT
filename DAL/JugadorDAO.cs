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
    public class JugadorDAO
    {
        public List<JugadorEntity> getAll()
        {
            try
            {
                using (var db = new CloudGamingContext())
                {
                    var listaDB = db.Jugador
                        .ToList();
                    return JugadorMapper.Map(listaDB);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
