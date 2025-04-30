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
            this.SuspendLayout();
            // 
            // Move1
            // 
            this.Move1.Location = new System.Drawing.Point(26, 263);
            this.Move1.Name = "Move1";
            this.Move1.Size = new System.Drawing.Size(270, 76);
            this.Move1.TabIndex = 0;
            this.Move1.Text = "Move1";
            this.Move1.UseVisualStyleBackColor = true;
            // 
            // Move2
            // 
            this.Move2.Location = new System.Drawing.Point(321, 263);
            this.Move2.Name = "Move2";
            this.Move2.Size = new System.Drawing.Size(270, 76);
            this.Move2.TabIndex = 1;
            this.Move2.Text = "Move2";
            this.Move2.UseVisualStyleBackColor = true;
            // 
            // Move3
            // 
            this.Move3.Location = new System.Drawing.Point(26, 362);
            this.Move3.Name = "Move3";
            this.Move3.Size = new System.Drawing.Size(270, 76);
            this.Move3.TabIndex = 2;
            this.Move3.Text = "Move3";
            this.Move3.UseVisualStyleBackColor = true;
            // 
            // Move4
            // 
            this.Move4.Location = new System.Drawing.Point(321, 362);
            this.Move4.Name = "Move4";
            this.Move4.Size = new System.Drawing.Size(270, 76);
            this.Move4.TabIndex = 3;
            this.Move4.Text = "Move4";
            this.Move4.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(643, 377);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(123, 51);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Switch
            // 
            this.Switch.Location = new System.Drawing.Point(643, 320);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(123, 51);
            this.Switch.TabIndex = 5;
            this.Switch.Text = "SwitchPokemon";
            this.Switch.UseVisualStyleBackColor = true;
            // 
            // UseItem
            // 
            this.UseItem.Location = new System.Drawing.Point(643, 263);
            this.UseItem.Name = "UseItem";
            this.UseItem.Size = new System.Drawing.Size(123, 51);
            this.UseItem.TabIndex = 6;
            this.UseItem.Text = "UseItem";
            this.UseItem.UseVisualStyleBackColor = true;
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UseItem);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Move4);
            this.Controls.Add(this.Move3);
            this.Controls.Add(this.Move2);
            this.Controls.Add(this.Move1);
            this.Name = "BattleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleScreen";
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
    }
}