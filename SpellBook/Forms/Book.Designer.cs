namespace MysticReference
{
    partial class Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblSearch = new System.Windows.Forms.Label();
            this.listBoxBook = new System.Windows.Forms.ListBox();
            this.contextMenuStripList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abjurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conjurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enchantmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.illusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.necromancyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmutationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSpellBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSpellBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblSearch);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxBook);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBook);
            this.splitContainer1.Size = new System.Drawing.Size(843, 398);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search:";
            // 
            // listBoxBook
            // 
            this.listBoxBook.ContextMenuStrip = this.contextMenuStripList;
            this.listBoxBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxBook.FormattingEnabled = true;
            this.listBoxBook.Location = new System.Drawing.Point(0, 30);
            this.listBoxBook.Name = "listBoxBook";
            this.listBoxBook.Size = new System.Drawing.Size(281, 368);
            this.listBoxBook.TabIndex = 0;
            this.listBoxBook.SelectedIndexChanged += new System.EventHandler(this.ListBoxBookSelectedIndexChanged);
            // 
            // contextMenuStripList
            // 
            this.contextMenuStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abjurationToolStripMenuItem,
            this.conjurationToolStripMenuItem,
            this.divinationToolStripMenuItem,
            this.enchantmentToolStripMenuItem,
            this.evocationToolStripMenuItem,
            this.illusionToolStripMenuItem,
            this.necromancyToolStripMenuItem,
            this.transmutationToolStripMenuItem,
            this.universalToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.contextMenuStripList.Name = "contextMenuStripList";
            this.contextMenuStripList.ShowCheckMargin = true;
            this.contextMenuStripList.ShowImageMargin = false;
            this.contextMenuStripList.Size = new System.Drawing.Size(153, 224);
            this.contextMenuStripList.Text = "Show School:";
            // 
            // abjurationToolStripMenuItem
            // 
            this.abjurationToolStripMenuItem.Name = "abjurationToolStripMenuItem";
            this.abjurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abjurationToolStripMenuItem.Text = "Abjuration";
            this.abjurationToolStripMenuItem.Click += new System.EventHandler(this.AbjurationToolStripMenuItemClick);
            // 
            // conjurationToolStripMenuItem
            // 
            this.conjurationToolStripMenuItem.Name = "conjurationToolStripMenuItem";
            this.conjurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conjurationToolStripMenuItem.Text = "Conjuration";
            this.conjurationToolStripMenuItem.Click += new System.EventHandler(this.ConjurationToolStripMenuItemClick);
            // 
            // divinationToolStripMenuItem
            // 
            this.divinationToolStripMenuItem.Name = "divinationToolStripMenuItem";
            this.divinationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.divinationToolStripMenuItem.Text = "Divination";
            this.divinationToolStripMenuItem.Click += new System.EventHandler(this.DivinationToolStripMenuItemClick);
            // 
            // enchantmentToolStripMenuItem
            // 
            this.enchantmentToolStripMenuItem.Name = "enchantmentToolStripMenuItem";
            this.enchantmentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enchantmentToolStripMenuItem.Text = "Enchantment";
            this.enchantmentToolStripMenuItem.Click += new System.EventHandler(this.EnchantmentToolStripMenuItemClick);
            // 
            // evocationToolStripMenuItem
            // 
            this.evocationToolStripMenuItem.Name = "evocationToolStripMenuItem";
            this.evocationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.evocationToolStripMenuItem.Text = "Evocation";
            this.evocationToolStripMenuItem.Click += new System.EventHandler(this.EvocationToolStripMenuItemClick);
            // 
            // illusionToolStripMenuItem
            // 
            this.illusionToolStripMenuItem.Name = "illusionToolStripMenuItem";
            this.illusionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.illusionToolStripMenuItem.Text = "Illusion";
            this.illusionToolStripMenuItem.Click += new System.EventHandler(this.IllusionToolStripMenuItemClick);
            // 
            // necromancyToolStripMenuItem
            // 
            this.necromancyToolStripMenuItem.Name = "necromancyToolStripMenuItem";
            this.necromancyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.necromancyToolStripMenuItem.Text = "Necromancy";
            this.necromancyToolStripMenuItem.Click += new System.EventHandler(this.NecromancyToolStripMenuItemClick);
            // 
            // transmutationToolStripMenuItem
            // 
            this.transmutationToolStripMenuItem.Name = "transmutationToolStripMenuItem";
            this.transmutationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transmutationToolStripMenuItem.Text = "Transmutation";
            this.transmutationToolStripMenuItem.Click += new System.EventHandler(this.TransmutationToolStripMenuItemClick);
            // 
            // universalToolStripMenuItem
            // 
            this.universalToolStripMenuItem.Name = "universalToolStripMenuItem";
            this.universalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.universalToolStripMenuItem.Text = "Universal";
            this.universalToolStripMenuItem.Click += new System.EventHandler(this.UniversalToolStripMenuItemClick);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.NoneToolStripMenuItemClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(53, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
            // 
            // textBoxBook
            // 
            this.textBoxBook.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBook.Location = new System.Drawing.Point(0, 0);
            this.textBoxBook.Multiline = true;
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.ReadOnly = true;
            this.textBoxBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBook.Size = new System.Drawing.Size(558, 398);
            this.textBoxBook.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSpellBookToolStripMenuItem,
            this.openSpellBookToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSpellBookToolStripMenuItem
            // 
            this.newSpellBookToolStripMenuItem.Name = "newSpellBookToolStripMenuItem";
            this.newSpellBookToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newSpellBookToolStripMenuItem.Text = "New Spell Book";
            this.newSpellBookToolStripMenuItem.Click += new System.EventHandler(this.NewSpellBookToolStripMenuItemClick);
            // 
            // openSpellBookToolStripMenuItem
            // 
            this.openSpellBookToolStripMenuItem.Name = "openSpellBookToolStripMenuItem";
            this.openSpellBookToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openSpellBookToolStripMenuItem.Text = "Open Spell Book";
            this.openSpellBookToolStripMenuItem.Click += new System.EventHandler(this.SelectSpellBookToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 427);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(859, 469);
            this.MinimumSize = new System.Drawing.Size(859, 469);
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Mystic Reference";
            this.Load += new System.EventHandler(this.BookLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripList.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.ListBox listBoxBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSpellBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSpellBookToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripList;
        private System.Windows.Forms.ToolStripMenuItem abjurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conjurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enchantmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem illusionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem necromancyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmutationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
    }
}