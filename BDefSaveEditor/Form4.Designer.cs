namespace BDefSaveEditor
{
    partial class Form4
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
            this.labelItem = new System.Windows.Forms.Label();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.labelDefense = new System.Windows.Forms.Label();
            this.boxDefense = new System.Windows.Forms.NumericUpDown();
            this.labelAttribute = new System.Windows.Forms.Label();
            this.boxAttribute = new System.Windows.Forms.NumericUpDown();
            this.labelUpgrades = new System.Windows.Forms.Label();
            this.boxUpgrades = new System.Windows.Forms.NumericUpDown();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemDescription = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAttribute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxUpgrades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(12, 9);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(30, 13);
            this.labelItem.TabIndex = 0;
            this.labelItem.Text = "Item:";
            // 
            // comboItem
            // 
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(15, 25);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(130, 21);
            this.comboItem.TabIndex = 1;
            this.comboItem.SelectedIndexChanged += new System.EventHandler(this.comboItem_SelectedIndexChanged);
            // 
            // labelDefense
            // 
            this.labelDefense.AutoSize = true;
            this.labelDefense.Location = new System.Drawing.Point(160, 9);
            this.labelDefense.Name = "labelDefense";
            this.labelDefense.Size = new System.Drawing.Size(50, 13);
            this.labelDefense.TabIndex = 2;
            this.labelDefense.Text = "Defense:";
            // 
            // boxDefense
            // 
            this.boxDefense.Location = new System.Drawing.Point(163, 25);
            this.boxDefense.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.boxDefense.Name = "boxDefense";
            this.boxDefense.Size = new System.Drawing.Size(65, 20);
            this.boxDefense.TabIndex = 3;
            // 
            // labelAttribute
            // 
            this.labelAttribute.AutoSize = true;
            this.labelAttribute.Location = new System.Drawing.Point(243, 9);
            this.labelAttribute.Name = "labelAttribute";
            this.labelAttribute.Size = new System.Drawing.Size(49, 13);
            this.labelAttribute.TabIndex = 4;
            this.labelAttribute.Text = "Attribute:";
            // 
            // boxAttribute
            // 
            this.boxAttribute.Location = new System.Drawing.Point(246, 25);
            this.boxAttribute.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.boxAttribute.Name = "boxAttribute";
            this.boxAttribute.Size = new System.Drawing.Size(65, 20);
            this.boxAttribute.TabIndex = 5;
            this.boxAttribute.ValueChanged += new System.EventHandler(this.boxAttribute_ValueChanged);
            // 
            // labelUpgrades
            // 
            this.labelUpgrades.AutoSize = true;
            this.labelUpgrades.Location = new System.Drawing.Point(326, 9);
            this.labelUpgrades.Name = "labelUpgrades";
            this.labelUpgrades.Size = new System.Drawing.Size(56, 13);
            this.labelUpgrades.TabIndex = 6;
            this.labelUpgrades.Text = "Upgrades:";
            // 
            // boxUpgrades
            // 
            this.boxUpgrades.Location = new System.Drawing.Point(329, 25);
            this.boxUpgrades.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.boxUpgrades.Name = "boxUpgrades";
            this.boxUpgrades.Size = new System.Drawing.Size(65, 20);
            this.boxUpgrades.TabIndex = 7;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(12, 58);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(56, 13);
            this.labelItemName.TabIndex = 8;
            this.labelItemName.Text = "Item name";
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.AutoSize = true;
            this.labelItemDescription.Location = new System.Drawing.Point(12, 80);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(81, 13);
            this.labelItemDescription.TabIndex = 9;
            this.labelItemDescription.Text = "Item description";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(319, 113);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form4
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 148);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelItemDescription);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.boxUpgrades);
            this.Controls.Add(this.labelUpgrades);
            this.Controls.Add(this.boxAttribute);
            this.Controls.Add(this.labelAttribute);
            this.Controls.Add(this.boxDefense);
            this.Controls.Add(this.labelDefense);
            this.Controls.Add(this.comboItem);
            this.Controls.Add(this.labelItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Inventory";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAttribute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxUpgrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ComboBox comboItem;
        private System.Windows.Forms.Label labelDefense;
        private System.Windows.Forms.NumericUpDown boxDefense;
        private System.Windows.Forms.Label labelAttribute;
        private System.Windows.Forms.NumericUpDown boxAttribute;
        private System.Windows.Forms.Label labelUpgrades;
        private System.Windows.Forms.NumericUpDown boxUpgrades;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelItemDescription;
        private System.Windows.Forms.Button buttonOK;
    }
}