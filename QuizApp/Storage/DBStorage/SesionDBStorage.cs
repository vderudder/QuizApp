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
        public Dominio.Sesion CreateSesion(string pUsuarioId, double pPuntaje, double pTiempo, DateTime pFecha)
        {
            var sesionContext = ContextoDB.Instancia.ServicioBD.Sesiones.Add(new DB.QuizContext.Sesion() { SesionId = Guid.NewGuid().ToString(), SesionFecha = pFecha, SesionTiempo = pTiempo, SesionPuntaje = pPuntaje, UsuarioId = pUsuarioId });
            ContextoDB.Instancia.ServicioBD.SaveChanges();

            return DB.QuizContext.Sesion.DAOToEntity(sesionContext.Entity);
        }

        /// <summary>
        /// Obtiene las sesiones ordenadas por puntaje de mayor a menor, tomando solo las primeras 20
        /// </summary>
        /// <returns></returns>
        public List<Dominio.Sesion> GetSesionesByPuntaje()
        {
            var sesiones = ContextoDB.Instancia.ServicioBD.Sesiones.Include(s => s.Usuario).OrderByDescending(ses => ses.SesionPuntaje).Take(20).ToList();

            return sesiones.Select(DB.QuizContext.Sesion.DAOToEntity).ToList();
        }

    }


}
