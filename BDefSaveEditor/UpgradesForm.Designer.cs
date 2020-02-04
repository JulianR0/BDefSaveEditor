namespace BDefSaveEditor
{
    partial class UpgradesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericSlots = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericDamage = new System.Windows.Forms.NumericUpDown();
            this.numericRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericAmmo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUnique = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelNoUpgrade = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelUnique = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTipUniques = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnique)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slots:";
            // 
            // numericSlots
            // 
            this.numericSlots.Location = new System.Drawing.Point(15, 25);
            this.numericSlots.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericSlots.Name = "numericSlots";
            this.numericSlots.Size = new System.Drawing.Size(65, 20);
            this.numericSlots.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Damage:";
            // 
            // numericDamage
            // 
            this.numericDamage.Location = new System.Drawing.Point(15, 73);
            this.numericDamage.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericDamage.Name = "numericDamage";
            this.numericDamage.Size = new System.Drawing.Size(65, 20);
            this.numericDamage.TabIndex = 3;
            // 
            // numericRate
            // 
            this.numericRate.Location = new System.Drawing.Point(15, 121);
            this.numericRate.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericRate.Name = "numericRate";
            this.numericRate.Size = new System.Drawing.Size(65, 20);
            this.numericRate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rate of Fire:";
            // 
            // numericAmmo
            // 
            this.numericAmmo.Location = new System.Drawing.Point(15, 169);
            this.numericAmmo.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericAmmo.Name = "numericAmmo";
            this.numericAmmo.Size = new System.Drawing.Size(65, 20);
            this.numericAmmo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ammo:";
            // 
            // numericUnique
            // 
            this.numericUnique.Location = new System.Drawing.Point(15, 217);
            this.numericUnique.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUnique.Name = "numericUnique";
            this.numericUnique.Size = new System.Drawing.Size(65, 20);
            this.numericUnique.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unique:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 39);
            this.label6.TabIndex = 10;
            this.label6.Text = "NOTE:\r\nGoing over the default maximum upgrades may\r\ncause the weapon to behave er" +
    "ratically.";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(164, 301);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelNoUpgrade
            // 
            this.labelNoUpgrade.AutoSize = true;
            this.labelNoUpgrade.Location = new System.Drawing.Point(86, 27);
            this.labelNoUpgrade.Name = "labelNoUpgrade";
            this.labelNoUpgrade.Size = new System.Drawing.Size(147, 13);
            this.labelNoUpgrade.TabIndex = 12;
            this.labelNoUpgrade.Text = "Cannot be upgraded in-game.";
            this.labelNoUpgrade.Visible = false;
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Location = new System.Drawing.Point(86, 75);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(69, 13);
            this.labelDamage.TabIndex = 13;
            this.labelDamage.Text = "labelDamage";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(86, 123);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(52, 13);
            this.labelRate.TabIndex = 14;
            this.labelRate.Text = "labelRate";
            // 
            // labelAmmo
            // 
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.Location = new System.Drawing.Point(86, 171);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(58, 13);
            this.labelAmmo.TabIndex = 15;
            this.labelAmmo.Text = "labelAmmo";
            // 
            // labelUnique
            // 
            this.labelUnique.AutoSize = true;
            this.labelUnique.Location = new System.Drawing.Point(86, 219);
            this.labelUnique.Name = "labelUnique";
            this.labelUnique.Size = new System.Drawing.Size(63, 13);
            this.labelUnique.TabIndex = 16;
            this.labelUnique.Text = "Placeholder";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(155, 219);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(19, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(?)";
            this.toolTipUniques.SetToolTip(this.linkLabel1, "AAATRIGGER");
            // 
            // UpgradesForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 336);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelUnique);
            this.Controls.Add(this.labelAmmo);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelDamage);
            this.Controls.Add(this.labelNoUpgrade);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUnique);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericAmmo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericDamage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericSlots);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpgradesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Upgrades";
            ((System.ComponentModel.ISupportInitialize)(this.numericSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSlots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDamage;
        private System.Windows.Forms.NumericUpDown numericRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericAmmo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUnique;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelNoUpgrade;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelAmmo;
        private System.Windows.Forms.Label labelUnique;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTipUniques;
    }
}