using MysticReference.DAL;
using MysticReference.Domain;
using System;
using System.Windows.Forms;

namespace MysticReference.Forms
{
    public partial class AddSpells : Form
    {
        private SpellBook newSpells = new SpellBook();
        private readonly FileHandler _handler = FileHandler.Instance;
        private const string DisplayMember = "Name";

        public AddSpells()
        {
            InitializeComponent();
            listBoxPlayer.DisplayMember = DisplayMember;
            listBoxMaster.DisplayMember = DisplayMember;
            PopulateList();
            PopulatePlayerList();
            newSpells.BookName = Book.PlayerSpellBook.BookName;
        }

        private void PopulatePlayerList()
        {
            foreach (var spell in PlayerBook.PlayerSpellBook.spells)
            {
                listBoxPlayer.Items.Add(spell);
            }
        }

        /// <summary>
        /// fills the master spell list box with spell names
        /// </summary>
        private void PopulateList()
        {
            foreach (var spell in Book.MasterSpellBook.spells)
            {
                listBoxMaster.Items.Add(spell);
            }
        }

        /// <summary>
        /// Adds a spell to the selected spell book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            var selectedSpell = (Spell)listBoxMaster.SelectedItem;
            bool isSpellInList = false;
            foreach (Spell spell in listBoxPlayer.Items)
            {
                isSpellInList = spell.name == selectedSpell.name;
            }
            if (!isSpellInList)
                listBoxPlayer.Items.Add(selectedSpell);
        }

        /// <summary>
        /// Adds a spell to the selected spells to the player spell book, closes the add spell dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDoneClick(object sender, EventArgs e)
        {
            foreach (Spell item in listBoxPlayer.Items)
            {
                var selectedSpell = item;
                var current = new Spell();

                foreach (Spell spell in Book.MasterSpellBook.spells)
                {
                    if (spell.name == selectedSpell.name)
                        current = spell;
                }

                newSpells.spells.Add(current);
            }

            PlayerBook.PlayerSpellBook = newSpells;

            _handler.WriteBinaryFile(Book.PlayerSpellBook.BookName, Book.PlayerSpellBook);

            Dispose();
        }

        private void BtnRemoveClick(object sender, EventArgs e)
        {
            listBoxPlayer.Items.Remove(listBoxPlayer.SelectedItem);
        }
    }
}