using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiSelect.ComponentMultiSelectTore
{
    public enum TOrderByTypes
    {
        /// <summary>
        /// Ordena por la etiqueta o texto que ve el usuario.
        /// </summary>
        Label,
        /// <summary>
        /// Ordena por el valor, no es visto por el usuario.
        /// </summary>
        Value,
        /// <summary>
        /// Muestra los items marcados primero y los no marcados después.
        /// </summary>
        Checked,
        /// <summary>
        /// No ordena, respetando de esta manera el orden natural o predefinido.
        /// </summary>
        Nothing
    }
}
