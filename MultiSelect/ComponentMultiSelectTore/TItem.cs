using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiSelect.ComponentMultiSelectTore
{
    /// <summary>
    /// Representa un ítem de la lista seleccionable.
    /// </summary>
    public class TItem
    {
        /// <summary>
        /// Indica si el ítem está o no seleccionado (chequeado).
        /// </summary>
        public bool Checked { set; get; }

        /// <summary>
        /// Establece el valor que identifica inequívocamente a un ítem.
        /// </summary>
        public string Value { set; get; }

        /// <summary>
        /// Texto que se muestra al usuario, junto al checkbox.
        /// </summary>
        public string Label { set; get; }
    }
}
