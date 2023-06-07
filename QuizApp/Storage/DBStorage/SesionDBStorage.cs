using QuizApp.UI;
using Quizzify.IO;
using Microsoft.EntityFrameworkCore;

namespace Quizzify.Storage.DBStorage
{
    /// <summary>
    /// Corresponde al Storage de sesiones usando DB relacional
    /// </summary>
    internal class SesionDBStorage : ISesionStorage
    {
        /// <summary>
        /// Crea una nueva sesion de juego
        /// </summary>
        /// <param name="pUsuarioId">El id de usuario</param>
        /// <param name="pPuntaje">El puntaje de la sesion</param>
        /// <param name="pTiempo">El tiempo insumido de la sesion</param>
        /// <param name="pFecha">La fecha que se realizo la sesion</param>
        /// <returns></returns>
        public SesionDTO CreateSesion(string pUsuarioId, double pPuntaje, double pTiempo, DateTime pFecha)
        {
            Contexto.iServicioBD.Sesiones.Add(new DB.QuizContext.Sesion() { SesionId = Guid.NewGuid().ToString(), SesionFecha = pFecha, SesionTiempo = pTiempo, SesionPuntaje = pPuntaje, UsuarioId = pUsuarioId });
            Contexto.iServicioBD.SaveChanges();

            return new SesionDTO { iPuntaje = pPuntaje, iTiempo = pTiempo, iFecha = pFecha };

        }

        /// <summary>
        /// Obtiene las sesiones ordenadas por puntaje de mayor a menor, tomando solo las primeras 20
        /// </summary>
        /// <returns></returns>
        public List<SesionDTO> GetSesionesByPuntaje()
        {

            var sesiones = Contexto.iServicioBD.Sesiones.Include(s => s.Usuario).OrderByDescending(ses => ses.SesionPuntaje).Take(20).ToList();

            List<SesionDTO> sesionesDTO = new List<SesionDTO>();

            foreach (var item in sesiones)
            {
                var sesionDTO = new SesionDTO { iId = item.SesionId, iUsuarioId = item.UsuarioId, iUsuarioNombre = item.Usuario.UsuarioNombre, iPuntaje = item.SesionPuntaje, iTiempo = item.SesionTiempo, iFecha = item.SesionFecha };
                sesionesDTO.Add(sesionDTO);
            };

            return sesionesDTO;
        }

    }


}
