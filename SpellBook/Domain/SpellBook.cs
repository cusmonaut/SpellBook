using System;
using System.Collections.Generic;

namespace MysticReference.Domain
{
    [Serializable]
    public class SpellBook
    {
        /// <summary>
        /// Name of spell book. File name with extension.
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// List of spells, contains all spells in spell book.
        /// </summary>
        public IList<Spell> spells = new List<Spell>();
    }
}