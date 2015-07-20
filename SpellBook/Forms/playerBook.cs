using MysticReference.DAL;
using MysticReference.Domain;
using System;
using System.Windows.Forms;

namespace MysticReference
{
    public partial class PlayerBook : Form
    {
        /// <summary>
        /// custom spell book used by the player. Can be added to and deleted from.
        /// </summary>
        public static SpellBook PlayerSpellBook = new SpellBook();

        /// <summary>
        /// Constructor
        /// </summary>
        public PlayerBook()
        {
            InitializeComponent();
            listBoxBook.DisplayMember = "Name";
        }

        /// <summary>
        /// loads the form. Loads all spells into the list and sets the form name to the name of the spell book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerBookLoad(object sender, EventArgs e)
        {
            PopulateList();
            Text = PlayerSpellBook.BookName;
        }

        /// <summary>
        /// Loads all spells from playerspellbook in to the listbox
        /// </summary>
        private void PopulateList()
        {
            listBoxBook.Items.Clear();
            foreach (Spell spell in PlayerSpellBook.spells)
            {
                listBoxBook.Items.Add(spell);
            }
        }

        /// <summary>
        /// Event handler! When a new item is selected in the listbox the displayed text is changed in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxBookSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSpell = (Spell)listBoxBook.SelectedItem;

            textBoxBook.Text = selectedSpell.ToString();
        }

        private void BtnModifyClick(object sender, EventArgs e)
        {
            Form modSpell = new Forms.AddSpells();

            modSpell.ShowDialog();

            FileHandler.Instance.WriteBinaryFile(PlayerSpellBook.BookName, PlayerSpellBook);

            PopulateList();

            textBoxBook.Text = string.Empty;
        }
    }
}