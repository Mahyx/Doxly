using System;
using System.Collections.Generic;
using System.Text;

namespace Doxly.Domain.Entities
{
    /// <summary>
    /// Modelo para tipo documento
    /// </summary>
    public class TipoDocumento
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre { get; private set; } = string.Empty;

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion { get; private set; } = string.Empty;

        /// <summary>
        /// Dias de vigencia
        /// </summary>
        public int VigenciaDias {  get; private set; }

        /// <summary>
        /// Ruta de destino
        /// </summary>
        public string RutaDestino { get; private set; } = string.Empty;
        
        /// <summary>
        /// Ruta copia de seguridad
        /// </summary>
        public string RutaCopiaSeguridad { get; private set; } = string.Empty;

        /// <summary>
        /// Adjunta documentos
        /// </summary>
        public bool PermiteAdjunto { get; private set; }

        /// <summary>
        /// Definicion de campos para el tipo documento
        /// </summary>
        public List<DefinicionCampo> Campos { get; private set; } = new();

        /// <summary>
        /// // Constructor vacío para EF Core
        /// </summary>
        protected TipoDocumento() { }

        public TipoDocumento(string nombre,
                             string descripcion,
                             int vigenciaDias,
                             string rutaDestino,
                             string rutaCopiaSeguridad,
                             bool permiteAdjunto)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
            VigenciaDias = vigenciaDias;
            RutaDestino = rutaDestino;
            RutaCopiaSeguridad = rutaCopiaSeguridad;
            PermiteAdjunto = permiteAdjunto;
        }

        public void AgregarCampo(DefinicionCampo campo)
        {
            Campos.Add(campo);
        }
    }
}
