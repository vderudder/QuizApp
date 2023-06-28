using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzify.IO
{
    /// <summary>
    /// Clase base de DTO que implementa Mapster para el mapeo
    /// </summary>
    /// <typeparam name="TDto">Clase DTO</typeparam>
    /// <typeparam name="TEntity">Clase entidad de dominio</typeparam>
    public abstract class BaseDTO<TDto, TEntity> : IRegister
         where TDto : class, new()
         where TEntity : class, new()
    {
        /// <summary>
        /// Mapea DTO a entidad de dominio
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public static TEntity ToEntity(TDto dto)
        {
            return dto.Adapt<TEntity>();
        }

        /// <summary>
        /// Mapea entidad de dominio a DTO
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static TDto ToDto(TEntity entity)
        {
            return entity.Adapt<TDto>();
        }


        private TypeAdapterConfig Config { get; set; }

        /// <summary>
        /// Implementado por las clases DTO que heredan para configurar mapeos especificos
        /// </summary>
        public virtual void AddCustomMappings() { }

        protected TypeAdapterSetter<TDto, TEntity> SetCustomMappings()
            => Config.ForType<TDto, TEntity>();

        protected TypeAdapterSetter<TEntity, TDto> SetCustomMappingsInverse()
            => Config.ForType<TEntity, TDto>();

        public void Register(TypeAdapterConfig config)
        {
            Config = config;
            AddCustomMappings();
        }
    }
}
