using Doxly.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Doxly.Domain.Entities
{
    /// <summary>
    /// modelo para la definicion de campo
    /// </summary>
    public class DefinicionCampo
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Tipo dato
        /// </summary>
        public TipoDatoCampo TipoDato { get; set; }

        /// <summary>
        /// Propiedades
        /// </summary>
        public PropiedadesCampo Propiedades { get; set; } = new PropiedadesCampo();
    }

    /// <summary>
    /// Modelo para propiedades de los campos
    /// </summary>
    public class PropiedadesCampo
    {
        /// <summary>
        /// Obligatorio
        /// </summary>
        public bool EsObligatorio { get; set; }

        /// <summary>
        /// Repetitivo
        /// </summary>
        public bool EsRepetitivo { get; set; }

        /// <summary>
        /// Unico
        /// </summary>
        public bool EsUnico { get; set; }

        /// <summary>
        /// Tiene seguridad
        /// </summary>
        public bool TieneSeguridad { get; set; }

        /// <summary>
        /// Longitud
        /// </summary>
        public int? Longitud { get; set; }

        /// <summary>
        /// Decimales
        /// </summary>
        public int? Decimales { get; set; }

        /// <summary>
        /// Origen tabla
        /// </summary>
        public string OrigenTabla { get; set; } = string.Empty;
    }
}
