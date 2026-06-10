using System;
using System.Collections.Generic;
using System.Text;

namespace Doxly.Domain.Entities
{
    /// <summary>
    /// Modelo para el documento
    /// </summary>
    public class Documento
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Id tipo documento
        /// </summary>
        public Guid TipoDocumentoId { get; private set; }

        /// <summary>
        /// Tipo documento
        /// </summary>
        public TipoDocumento TipoDocumento { get; private set; } //Navegacion

        /// <summary>
        /// fecha creacion
        /// </summary>
        public DateTime FechaCreacion { get; private set; }

        /// <summary>
        /// Dicionrio de campos dinamicos
        /// </summary>
        public Dictionary<string, object> ValoresDinamicos { get; private set; } = new();

        /// <summary>
        /// 
        /// </summary>
        protected Documento() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoDocumentoId"></param>
        public Documento(Guid tipoDocumentoId)
        {
            Id = Guid.NewGuid();
            TipoDocumentoId = tipoDocumentoId;
            FechaCreacion = DateTime.UtcNow;
        }

        public void EstablecerValor(string nombreCampo, object valor)
        {
            ValoresDinamicos[nombreCampo] = valor;
        }
    }
}
