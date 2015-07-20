namespace MysticReference
{
    partial class PlayerBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerBook));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxBook = new System.Windows.Forms.ListBox();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxBook);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBook);
            this.splitContainer1.Size = new System.Drawing.Size(849, 390);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 3;
            // 
            // listBoxBook
            // 
            this.listBoxBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBook.FormattingEnabled = true;
            this.listBoxBook.Location = new System.Drawing.Point(0, 0);
            this.listBoxBook.Name = "listBoxBook";
            this.listBoxBook.Size = new System.Drawing.Size(284, 390);
            this.listBoxBook.TabIndex = 0;
            this.listBoxBook.SelectedIndexChanged += new System.EventHandler(this.ListBoxBookSelectedIndexChanged);
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
            this.textBoxBook.Size = new System.Drawing.Size(561, 390);
            this.textBoxBook.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 396);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify Spells";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModifyClick);
            // 
            // playerBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 437);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(859, 469);
            this.MinimumSize = new System.Drawing.Size(859, 469);
            this.Name = "PlayerBook";
            this.Text = "playerBook";
            this.Load += new System.EventHandler(this.PlayerBookLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxBook;
        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.Button btnModify;
    }
}