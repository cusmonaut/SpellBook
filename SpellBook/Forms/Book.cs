using MysticReference.DAL;
using MysticReference.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MysticReference
{
    public partial class Book : Form
    {
        private readonly FileHandler _handler = FileHandler.Instance;
        public static SpellBook MasterSpellBook = new SpellBook();
        public static SpellBook PlayerSpellBook = new SpellBook();
        private PlayerBook _player = new PlayerBook();
        private readonly List<Schools> _filters = new List<Schools>();

        public Book()
        {
            _handler.updateSpellList();
            InitializeComponent();
            listBoxBook.DisplayMember = "Name";
        }

        private void BookLoad(object sender, EventArgs e)
        {
            LoadAllSpells();
            PopulateList();
        }

        /// <summary>
        /// fills the list box with spell names
        /// </summary>
        private void PopulateList()
        {
            var text = txtSearch.Text.ToUpper().Trim();
            //reduces spaces between words to one
            text = Regex.Replace(text, @"\s+", " ");

            //sorts the displayed spells based on the search text
            var sorted = MasterSpellBook.spells.Where(x => x.name.ToUpper().Contains(text));
            if (_filters.Count > 0)
            {
                //sorts the displayed spells based on the filters selected. Can sort with multiple filters.
                sorted = sorted.Where(s => _filters.Any(f => f.ToString().ToLower() == s.school.ToLower()));
            }

            foreach (var spell in sorted)
            {
                listBoxBook.Items.Add(spell);
            }
        }

        //loads all spells from master spell book into memory
        private void LoadAllSpells()
        {
            _handler.ReadFromCsvFile(ref MasterSpellBook);
        }

        //about menu item handler
        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName + " " + Application.ProductVersion, "About");
        }

        //exit menu item hander
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Updates the displayed spell info when a new spell is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxBookSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSpell = (Spell)listBoxBook.SelectedItem;

            textBoxBook.Text = selectedSpell.ToString();
        }

        /// <summary>
        /// Creates a new spell book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewSpellBookToolStripMenuItemClick(object sender, EventArgs e)
        {
            var name = Microsoft.VisualBasic.Interaction.InputBox("Spell Book Name: ", "Create New Spell Book", "CustomSpellBook");

            if (!string.IsNullOrEmpty(name))
            {
                PlayerSpellBook = new SpellBook { BookName = name };

                _player = new PlayerBook();
                PlayerBook.PlayerSpellBook = PlayerSpellBook;
                PreparePlayerForm();
                _player.Show();
            }
        }

        /// <summary>
        /// selects a spell book to load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSpellBookToolStripMenuItemClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Title = "Open Spell Book", Filter = "SpellBook Files | *.sb" };
            try
            {
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PlayerSpellBook = new SpellBook();
                    _player = new PlayerBook();
                    PlayerSpellBook.BookName = ofd.SafeFileName;
                    _handler.ReadBinaryFile(PlayerSpellBook.BookName, ref PlayerSpellBook);
                    PlayerBook.PlayerSpellBook = PlayerSpellBook;
                    PreparePlayerForm();
                    _player.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.ToString());
            }
        }

        /// <summary>
        /// loads the proper info into the player spell book
        /// </summary>
        private void PreparePlayerForm()
        {
            _player = new PlayerBook();
            PlayerBook.PlayerSpellBook = PlayerSpellBook;
        }

        /// <summary>
        /// refreshes the spell list
        /// </summary>
        private void RefreshList()
        {
            listBoxBook.Items.Clear();
            PopulateList();
        }

        private void TxtSearchTextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void UpdateFilterList(Schools selected, ToolStripMenuItem menu)
        {
            if (_filters.Contains(selected))
            {
                _filters.Remove(selected);
            }
            else
            {
                _filters.Add(selected);
            }

            updateMenuItem(menu);

            RefreshList();
        }

        private void updateMenuItem(ToolStripMenuItem menu)
        {
            menu.Checked = !(menu.Checked);
        }

        private void AbjurationToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Abjuration, (ToolStripMenuItem)sender);
        }

        private void ConjurationToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Conjuration, (ToolStripMenuItem)sender);
        }

        private void DivinationToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Divination, (ToolStripMenuItem)sender);
        }

        private void EnchantmentToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Enchantment, (ToolStripMenuItem)sender);
        }

        private void EvocationToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Evocation, (ToolStripMenuItem)sender);
        }

        private void IllusionToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Illusion, (ToolStripMenuItem)sender);
        }

        private void NecromancyToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Necromancy, (ToolStripMenuItem)sender);
        }

        private void TransmutationToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Transmutation, (ToolStripMenuItem)sender);
        }

        private void UniversalToolStripMenuItemClick(object sender, EventArgs e)
        {
            UpdateFilterList(Schools.Universal, (ToolStripMenuItem)sender);
        }

        private void NoneToolStripMenuItemClick(object sender, EventArgs e)
        {
            _filters.Clear();
            RefreshList();
            RestMenuItems();
        }

        private void RestMenuItems()
        {
            foreach (ToolStripMenuItem item in contextMenuStripList.Items)
            {
                item.Checked = false;
            }
        }
    }
}