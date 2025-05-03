namespace PokemonProjectv2
{
    partial class BattleScreen
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
            this.Move1 = new System.Windows.Forms.Button();
            this.Move2 = new System.Windows.Forms.Button();
            this.Move3 = new System.Windows.Forms.Button();
            this.Move4 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Switch = new System.Windows.Forms.Button();
            this.UseItem = new System.Windows.Forms.Button();
            this.pokebacksprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokebacksprite)).BeginInit();
            this.SuspendLayout();
            // 
            // Move1
            // 
            this.Move1.Location = new System.Drawing.Point(39, 405);
            this.Move1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Move1.Name = "Move1";
            this.Move1.Size = new System.Drawing.Size(405, 117);
            this.Move1.TabIndex = 0;
            this.Move1.Text = "Move1";
            this.Move1.UseVisualStyleBackColor = true;
            // 
            // Move2
            // 
            this.Move2.Location = new System.Drawing.Point(482, 405);
            this.Move2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Move2.Name = "Move2";
            this.Move2.Size = new System.Drawing.Size(405, 117);
            this.Move2.TabIndex = 1;
            this.Move2.Text = "Move2";
            this.Move2.UseVisualStyleBackColor = true;
            // 
            // Move3
            // 
            this.Move3.Location = new System.Drawing.Point(39, 557);
            this.Move3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Move3.Name = "Move3";
            this.Move3.Size = new System.Drawing.Size(405, 117);
            this.Move3.TabIndex = 2;
            this.Move3.Text = "Move3";
            this.Move3.UseVisualStyleBackColor = true;
            // 
            // Move4
            // 
            this.Move4.Location = new System.Drawing.Point(482, 557);
            this.Move4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Move4.Name = "Move4";
            this.Move4.Size = new System.Drawing.Size(405, 117);
            this.Move4.TabIndex = 3;
            this.Move4.Text = "Move4";
            this.Move4.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(964, 580);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(184, 78);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Switch
            // 
            this.Switch.Location = new System.Drawing.Point(964, 492);
            this.Switch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(184, 78);
            this.Switch.TabIndex = 5;
            this.Switch.Text = "SwitchPokemon";
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // UseItem
            // 
            this.UseItem.Location = new System.Drawing.Point(964, 405);
            this.UseItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseItem.Name = "UseItem";
            this.UseItem.Size = new System.Drawing.Size(184, 78);
            this.UseItem.TabIndex = 6;
            this.UseItem.Text = "UseItem";
            this.UseItem.UseVisualStyleBackColor = true;
            // 
            // pokebacksprite
            // 
            this.pokebacksprite.Location = new System.Drawing.Point(102, 154);
            this.pokebacksprite.Name = "pokebacksprite";
            this.pokebacksprite.Size = new System.Drawing.Size(285, 208);
            this.pokebacksprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pokebacksprite.TabIndex = 7;
            this.pokebacksprite.TabStop = false;
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pokebacksprite);
            this.Controls.Add(this.UseItem);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Move4);
            this.Controls.Add(this.Move3);
            this.Controls.Add(this.Move2);
            this.Controls.Add(this.Move1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BattleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pokebacksprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Move1;
        private System.Windows.Forms.Button Move2;
        private System.Windows.Forms.Button Move3;
        private System.Windows.Forms.Button Move4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Switch;
        private System.Windows.Forms.Button UseItem;
        private System.Windows.Forms.PictureBox pokebacksprite;
    }
}