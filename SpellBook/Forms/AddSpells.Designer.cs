namespace MysticReference.Forms
{
    partial class AddSpells
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
            this.listBoxMaster = new System.Windows.Forms.ListBox();
            this.listBoxPlayer = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblAllSpells = new System.Windows.Forms.Label();
            this.lblPlayerSpells = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMaster
            // 
            this.listBoxMaster.FormattingEnabled = true;
            this.listBoxMaster.Location = new System.Drawing.Point(15, 25);
            this.listBoxMaster.Name = "listBoxMaster";
            this.listBoxMaster.Size = new System.Drawing.Size(219, 316);
            this.listBoxMaster.TabIndex = 0;
            // 
            // listBoxPlayer
            // 
            this.listBoxPlayer.FormattingEnabled = true;
            this.listBoxPlayer.Location = new System.Drawing.Point(321, 25);
            this.listBoxPlayer.Name = "listBoxPlayer";
            this.listBoxPlayer.Size = new System.Drawing.Size(219, 316);
            this.listBoxPlayer.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(240, 71);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemoveClick);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(240, 318);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDoneClick);
            // 
            // lblAllSpells
            // 
            this.lblAllSpells.AutoSize = true;
            this.lblAllSpells.Location = new System.Drawing.Point(12, 9);
            this.lblAllSpells.Name = "lblAllSpells";
            this.lblAllSpells.Size = new System.Drawing.Size(52, 13);
            this.lblAllSpells.TabIndex = 5;
            this.lblAllSpells.Text = "All Spells:";
            // 
            // lblPlayerSpells
            // 
            this.lblPlayerSpells.AutoSize = true;
            this.lblPlayerSpells.Location = new System.Drawing.Point(318, 9);
            this.lblPlayerSpells.Name = "lblPlayerSpells";
            this.lblPlayerSpells.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerSpells.TabIndex = 6;
            this.lblPlayerSpells.Text = "Player Spells:";
            // 
            // AddSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.lblPlayerSpells);
            this.Controls.Add(this.lblAllSpells);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxPlayer);
            this.Controls.Add(this.listBoxMaster);
            this.Name = "AddSpells";
            this.Text = "AddSpells";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMaster;
        private System.Windows.Forms.ListBox listBoxPlayer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblAllSpells;
        private System.Windows.Forms.Label lblPlayerSpells;
    }
}