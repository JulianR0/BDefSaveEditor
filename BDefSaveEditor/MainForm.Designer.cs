namespace BDefSaveEditor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelMapName = new System.Windows.Forms.Label();
            this.labelWave = new System.Windows.Forms.Label();
            this.boxWave = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.boxLevel = new System.Windows.Forms.NumericUpDown();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelAbilities = new System.Windows.Forms.Label();
            this.labelLegerity = new System.Windows.Forms.Label();
            this.boxLegerity = new System.Windows.Forms.NumericUpDown();
            this.boxPrecision = new System.Windows.Forms.NumericUpDown();
            this.boxToughness = new System.Windows.Forms.NumericUpDown();
            this.boxSorcery = new System.Windows.Forms.NumericUpDown();
            this.labelPrecision = new System.Windows.Forms.Label();
            this.labelToughness = new System.Windows.Forms.Label();
            this.labelSorcery = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.boxHPKits = new System.Windows.Forms.NumericUpDown();
            this.boxMPKits = new System.Windows.Forms.NumericUpDown();
            this.checkLJ = new System.Windows.Forms.CheckBox();
            this.boxAP = new System.Windows.Forms.NumericUpDown();
            this.labelAP = new System.Windows.Forms.Label();
            this.labelKills = new System.Windows.Forms.Label();
            this.boxKills = new System.Windows.Forms.NumericUpDown();
            this.labelMoney = new System.Windows.Forms.Label();
            this.boxMoney = new System.Windows.Forms.NumericUpDown();
            this.labelSalvage = new System.Windows.Forms.Label();
            this.boxSalvage = new System.Windows.Forms.NumericUpDown();
            this.labelSouls = new System.Windows.Forms.Label();
            this.boxSouls = new System.Windows.Forms.NumericUpDown();
            this.labelHPKits = new System.Windows.Forms.Label();
            this.labelMPKits = new System.Windows.Forms.Label();
            this.labelXP = new System.Windows.Forms.Label();
            this.boxXP = new System.Windows.Forms.NumericUpDown();
            this.buttonWeapons = new System.Windows.Forms.Button();
            this.buttonTasks = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonUpgrades = new System.Windows.Forms.Button();
            this.contextMenuInventory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmHelmet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmArmor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrinket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlot1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlot2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlot3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlot4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlot5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlot6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlot7 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSlot8 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAmmo = new System.Windows.Forms.Button();
            this.buttonSkills = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLegerity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxToughness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSorcery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHPKits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMPKits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxKills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSalvage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSouls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxXP)).BeginInit();
            this.contextMenuInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(0, 0);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 99;
            this.buttonOpen.TabStop = false;
            this.buttonOpen.Text = "Open File";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(81, 5);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(76, 13);
            this.labelFile.TabIndex = 97;
            this.labelFile.Text = "No file opened";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "sav";
            this.openFileDialog.Filter = "BDef Save File|*.sav|All files|*.*";
            this.openFileDialog.InitialDirectory = "c:\\Program Files (x86)\\Steam\\steamapps\\common\\Base Defense\\bdef\\save\\";
            this.openFileDialog.Title = "Select Save File";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // labelMapName
            // 
            this.labelMapName.AutoSize = true;
            this.labelMapName.Location = new System.Drawing.Point(81, 31);
            this.labelMapName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.labelMapName.Name = "labelMapName";
            this.labelMapName.Size = new System.Drawing.Size(34, 13);
            this.labelMapName.TabIndex = 96;
            this.labelMapName.Text = "Map: ";
            // 
            // labelWave
            // 
            this.labelWave.AutoSize = true;
            this.labelWave.Location = new System.Drawing.Point(270, 60);
            this.labelWave.Name = "labelWave";
            this.labelWave.Size = new System.Drawing.Size(39, 13);
            this.labelWave.TabIndex = 91;
            this.labelWave.Text = "Wave:";
            // 
            // boxWave
            // 
            this.boxWave.Enabled = false;
            this.boxWave.Location = new System.Drawing.Point(273, 76);
            this.boxWave.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.boxWave.Name = "boxWave";
            this.boxWave.Size = new System.Drawing.Size(80, 20);
            this.boxWave.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(0, 26);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 98;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Save File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(12, 60);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(64, 13);
            this.labelMode.TabIndex = 95;
            this.labelMode.Text = "Gamemode:";
            // 
            // comboMode
            // 
            this.comboMode.Enabled = false;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "Softcore",
            "Hardcore",
            "Underworld"});
            this.comboMode.Location = new System.Drawing.Point(15, 76);
            this.comboMode.MaxDropDownItems = 3;
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(80, 21);
            this.comboMode.TabIndex = 0;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(98, 60);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(35, 13);
            this.labelClass.TabIndex = 94;
            this.labelClass.Text = "Class:";
            // 
            // comboClass
            // 
            this.comboClass.Enabled = false;
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "Rushing",
            "Religious",
            "Provident"});
            this.comboClass.Location = new System.Drawing.Point(101, 76);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(80, 21);
            this.comboClass.TabIndex = 1;
            // 
            // boxLevel
            // 
            this.boxLevel.Enabled = false;
            this.boxLevel.Location = new System.Drawing.Point(187, 76);
            this.boxLevel.Name = "boxLevel";
            this.boxLevel.Size = new System.Drawing.Size(80, 20);
            this.boxLevel.TabIndex = 2;
            this.boxLevel.TabStop = false;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(184, 60);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(36, 13);
            this.labelLevel.TabIndex = 101;
            this.labelLevel.Text = "Level:";
            // 
            // labelAbilities
            // 
            this.labelAbilities.AutoSize = true;
            this.labelAbilities.Location = new System.Drawing.Point(12, 109);
            this.labelAbilities.Name = "labelAbilities";
            this.labelAbilities.Size = new System.Drawing.Size(45, 13);
            this.labelAbilities.TabIndex = 102;
            this.labelAbilities.Text = "Abilities:";
            // 
            // labelLegerity
            // 
            this.labelLegerity.AutoSize = true;
            this.labelLegerity.Location = new System.Drawing.Point(101, 127);
            this.labelLegerity.Name = "labelLegerity";
            this.labelLegerity.Size = new System.Drawing.Size(44, 13);
            this.labelLegerity.TabIndex = 103;
            this.labelLegerity.Text = "Legerity";
            // 
            // boxLegerity
            // 
            this.boxLegerity.Enabled = false;
            this.boxLegerity.Location = new System.Drawing.Point(15, 125);
            this.boxLegerity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxLegerity.Name = "boxLegerity";
            this.boxLegerity.Size = new System.Drawing.Size(80, 20);
            this.boxLegerity.TabIndex = 4;
            this.toolTip.SetToolTip(this.boxLegerity, "run speed\r\ngravity reduction\r\nmaximum ammo multiplier");
            // 
            // boxPrecision
            // 
            this.boxPrecision.Enabled = false;
            this.boxPrecision.Location = new System.Drawing.Point(15, 151);
            this.boxPrecision.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxPrecision.Name = "boxPrecision";
            this.boxPrecision.Size = new System.Drawing.Size(80, 20);
            this.boxPrecision.TabIndex = 5;
            this.toolTip.SetToolTip(this.boxPrecision, "shooting accuracy\r\ncritical hit chance\r\ndamage factor");
            // 
            // boxToughness
            // 
            this.boxToughness.Enabled = false;
            this.boxToughness.Location = new System.Drawing.Point(15, 177);
            this.boxToughness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxToughness.Name = "boxToughness";
            this.boxToughness.Size = new System.Drawing.Size(80, 20);
            this.boxToughness.TabIndex = 6;
            this.toolTip.SetToolTip(this.boxToughness, "maximum hit points\r\nnatural defense\r\nhealth regeneration speed");
            // 
            // boxSorcery
            // 
            this.boxSorcery.Enabled = false;
            this.boxSorcery.Location = new System.Drawing.Point(15, 203);
            this.boxSorcery.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxSorcery.Name = "boxSorcery";
            this.boxSorcery.Size = new System.Drawing.Size(80, 20);
            this.boxSorcery.TabIndex = 7;
            this.toolTip.SetToolTip(this.boxSorcery, "maximum mana points\r\npower of most skills/spells\r\nmana regeneration speed");
            // 
            // labelPrecision
            // 
            this.labelPrecision.AutoSize = true;
            this.labelPrecision.Location = new System.Drawing.Point(101, 153);
            this.labelPrecision.Name = "labelPrecision";
            this.labelPrecision.Size = new System.Drawing.Size(50, 13);
            this.labelPrecision.TabIndex = 104;
            this.labelPrecision.Text = "Precision";
            // 
            // labelToughness
            // 
            this.labelToughness.AutoSize = true;
            this.labelToughness.Location = new System.Drawing.Point(101, 179);
            this.labelToughness.Name = "labelToughness";
            this.labelToughness.Size = new System.Drawing.Size(60, 13);
            this.labelToughness.TabIndex = 105;
            this.labelToughness.Text = "Toughness";
            // 
            // labelSorcery
            // 
            this.labelSorcery.AutoSize = true;
            this.labelSorcery.Location = new System.Drawing.Point(101, 205);
            this.labelSorcery.Name = "labelSorcery";
            this.labelSorcery.Size = new System.Drawing.Size(43, 13);
            this.labelSorcery.TabIndex = 106;
            this.labelSorcery.Text = "Sorcery";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // boxHPKits
            // 
            this.boxHPKits.Enabled = false;
            this.boxHPKits.Location = new System.Drawing.Point(187, 203);
            this.boxHPKits.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxHPKits.Name = "boxHPKits";
            this.boxHPKits.Size = new System.Drawing.Size(80, 20);
            this.boxHPKits.TabIndex = 13;
            this.toolTip.SetToolTip(this.boxHPKits, "WARNING: Going over \"Belt capacity\" will clamp this value to it\'s max.");
            // 
            // boxMPKits
            // 
            this.boxMPKits.Enabled = false;
            this.boxMPKits.Location = new System.Drawing.Point(273, 203);
            this.boxMPKits.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxMPKits.Name = "boxMPKits";
            this.boxMPKits.Size = new System.Drawing.Size(80, 20);
            this.boxMPKits.TabIndex = 14;
            this.toolTip.SetToolTip(this.boxMPKits, "WARNING: Going over \"Belt capacity\" will clamp this value to it\'s max.");
            // 
            // checkLJ
            // 
            this.checkLJ.AutoSize = true;
            this.checkLJ.Enabled = false;
            this.checkLJ.Location = new System.Drawing.Point(273, 243);
            this.checkLJ.Name = "checkLJ";
            this.checkLJ.Size = new System.Drawing.Size(97, 17);
            this.checkLJ.TabIndex = 16;
            this.checkLJ.Text = "Has LongJump";
            this.toolTip.SetToolTip(this.checkLJ, "Also known as \"Unusual shoes\".");
            this.checkLJ.UseVisualStyleBackColor = true;
            // 
            // boxAP
            // 
            this.boxAP.Enabled = false;
            this.boxAP.Location = new System.Drawing.Point(15, 229);
            this.boxAP.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxAP.Name = "boxAP";
            this.boxAP.Size = new System.Drawing.Size(80, 20);
            this.boxAP.TabIndex = 8;
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Location = new System.Drawing.Point(101, 231);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(66, 13);
            this.labelAP.TabIndex = 107;
            this.labelAP.Text = "Ability Points";
            // 
            // labelKills
            // 
            this.labelKills.AutoSize = true;
            this.labelKills.Location = new System.Drawing.Point(184, 109);
            this.labelKills.Name = "labelKills";
            this.labelKills.Size = new System.Drawing.Size(28, 13);
            this.labelKills.TabIndex = 108;
            this.labelKills.Text = "Kills:";
            // 
            // boxKills
            // 
            this.boxKills.Enabled = false;
            this.boxKills.Location = new System.Drawing.Point(187, 125);
            this.boxKills.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.boxKills.Name = "boxKills";
            this.boxKills.Size = new System.Drawing.Size(80, 20);
            this.boxKills.TabIndex = 9;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(270, 109);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(42, 13);
            this.labelMoney.TabIndex = 109;
            this.labelMoney.Text = "Money:";
            // 
            // boxMoney
            // 
            this.boxMoney.Enabled = false;
            this.boxMoney.Location = new System.Drawing.Point(273, 125);
            this.boxMoney.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.boxMoney.Name = "boxMoney";
            this.boxMoney.Size = new System.Drawing.Size(80, 20);
            this.boxMoney.TabIndex = 10;
            // 
            // labelSalvage
            // 
            this.labelSalvage.AutoSize = true;
            this.labelSalvage.Location = new System.Drawing.Point(184, 148);
            this.labelSalvage.Name = "labelSalvage";
            this.labelSalvage.Size = new System.Drawing.Size(49, 13);
            this.labelSalvage.TabIndex = 110;
            this.labelSalvage.Text = "Salvage:";
            // 
            // boxSalvage
            // 
            this.boxSalvage.Enabled = false;
            this.boxSalvage.Location = new System.Drawing.Point(187, 164);
            this.boxSalvage.Maximum = new decimal(new int[] {
            16777215,
            0,
            0,
            0});
            this.boxSalvage.Name = "boxSalvage";
            this.boxSalvage.Size = new System.Drawing.Size(80, 20);
            this.boxSalvage.TabIndex = 11;
            // 
            // labelSouls
            // 
            this.labelSouls.AutoSize = true;
            this.labelSouls.Location = new System.Drawing.Point(270, 148);
            this.labelSouls.Name = "labelSouls";
            this.labelSouls.Size = new System.Drawing.Size(36, 13);
            this.labelSouls.TabIndex = 111;
            this.labelSouls.Text = "Souls:";
            // 
            // boxSouls
            // 
            this.boxSouls.Enabled = false;
            this.boxSouls.Location = new System.Drawing.Point(273, 164);
            this.boxSouls.Maximum = new decimal(new int[] {
            16777215,
            0,
            0,
            0});
            this.boxSouls.Name = "boxSouls";
            this.boxSouls.Size = new System.Drawing.Size(80, 20);
            this.boxSouls.TabIndex = 12;
            // 
            // labelHPKits
            // 
            this.labelHPKits.AutoSize = true;
            this.labelHPKits.Location = new System.Drawing.Point(184, 187);
            this.labelHPKits.Name = "labelHPKits";
            this.labelHPKits.Size = new System.Drawing.Size(61, 13);
            this.labelHPKits.TabIndex = 113;
            this.labelHPKits.Text = "Health Kits:";
            // 
            // labelMPKits
            // 
            this.labelMPKits.AutoSize = true;
            this.labelMPKits.Location = new System.Drawing.Point(270, 187);
            this.labelMPKits.Name = "labelMPKits";
            this.labelMPKits.Size = new System.Drawing.Size(57, 13);
            this.labelMPKits.TabIndex = 114;
            this.labelMPKits.Text = "Mana Kits:";
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.Location = new System.Drawing.Point(184, 226);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(51, 13);
            this.labelXP.TabIndex = 115;
            this.labelXP.Text = "Total XP:";
            // 
            // boxXP
            // 
            this.boxXP.Enabled = false;
            this.boxXP.Location = new System.Drawing.Point(186, 242);
            this.boxXP.Maximum = new decimal(new int[] {
            541996392,
            0,
            0,
            0});
            this.boxXP.Name = "boxXP";
            this.boxXP.Size = new System.Drawing.Size(81, 20);
            this.boxXP.TabIndex = 15;
            // 
            // buttonWeapons
            // 
            this.buttonWeapons.Enabled = false;
            this.buttonWeapons.Location = new System.Drawing.Point(10, 271);
            this.buttonWeapons.Margin = new System.Windows.Forms.Padding(1);
            this.buttonWeapons.Name = "buttonWeapons";
            this.buttonWeapons.Size = new System.Drawing.Size(85, 23);
            this.buttonWeapons.TabIndex = 116;
            this.buttonWeapons.Text = "Edit Weapons";
            this.buttonWeapons.UseVisualStyleBackColor = true;
            this.buttonWeapons.Click += new System.EventHandler(this.buttonWeapons_Click);
            // 
            // buttonTasks
            // 
            this.buttonTasks.Enabled = false;
            this.buttonTasks.Location = new System.Drawing.Point(98, 271);
            this.buttonTasks.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTasks.Name = "buttonTasks";
            this.buttonTasks.Size = new System.Drawing.Size(85, 23);
            this.buttonTasks.TabIndex = 117;
            this.buttonTasks.Text = "Edit Tasks";
            this.buttonTasks.UseVisualStyleBackColor = true;
            this.buttonTasks.Click += new System.EventHandler(this.buttonTasks_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Enabled = false;
            this.buttonInventory.Location = new System.Drawing.Point(185, 271);
            this.buttonInventory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(85, 23);
            this.buttonInventory.TabIndex = 118;
            this.buttonInventory.Text = "Edit Inventory";
            this.buttonInventory.UseVisualStyleBackColor = true;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonUpgrades
            // 
            this.buttonUpgrades.Enabled = false;
            this.buttonUpgrades.Location = new System.Drawing.Point(273, 271);
            this.buttonUpgrades.Margin = new System.Windows.Forms.Padding(1);
            this.buttonUpgrades.Name = "buttonUpgrades";
            this.buttonUpgrades.Size = new System.Drawing.Size(85, 23);
            this.buttonUpgrades.TabIndex = 119;
            this.buttonUpgrades.Text = "Edit Upgrades";
            this.buttonUpgrades.UseVisualStyleBackColor = true;
            // 
            // contextMenuInventory
            // 
            this.contextMenuInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTitle,
            this.toolStripSeparator1,
            this.tsmHelmet,
            this.tsmArmor,
            this.tsmTrinket,
            this.tsmGem,
            this.tsmBag});
            this.contextMenuInventory.Name = "contextMenuInventory";
            this.contextMenuInventory.Size = new System.Drawing.Size(167, 164);
            // 
            // tsmTitle
            // 
            this.tsmTitle.Enabled = false;
            this.tsmTitle.Name = "tsmTitle";
            this.tsmTitle.Size = new System.Drawing.Size(166, 22);
            this.tsmTitle.Text = "Edit Inventory";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmHelmet
            // 
            this.tsmHelmet.Name = "tsmHelmet";
            this.tsmHelmet.Size = new System.Drawing.Size(166, 22);
            this.tsmHelmet.Text = "Equipped Helmet";
            this.tsmHelmet.Click += new System.EventHandler(this.tsmHelmet_Click);
            // 
            // tsmArmor
            // 
            this.tsmArmor.Name = "tsmArmor";
            this.tsmArmor.Size = new System.Drawing.Size(166, 22);
            this.tsmArmor.Text = "Equipped Armor";
            this.tsmArmor.Click += new System.EventHandler(this.tsmArmor_Click);
            // 
            // tsmTrinket
            // 
            this.tsmTrinket.Name = "tsmTrinket";
            this.tsmTrinket.Size = new System.Drawing.Size(166, 22);
            this.tsmTrinket.Text = "Equipped Trinket";
            this.tsmTrinket.Click += new System.EventHandler(this.tsmTrinket_Click);
            // 
            // tsmGem
            // 
            this.tsmGem.Name = "tsmGem";
            this.tsmGem.Size = new System.Drawing.Size(166, 22);
            this.tsmGem.Text = "Socketed Gem";
            this.tsmGem.Click += new System.EventHandler(this.tsmGem_Click);
            // 
            // tsmBag
            // 
            this.tsmBag.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSlot1,
            this.tsmSlot2,
            this.tsmSlot3,
            this.tsmSlot4,
            this.tsmSlot5,
            this.tsmSlot6,
            this.tsmSlot7,
            this.tsmSlot8});
            this.tsmBag.Name = "tsmBag";
            this.tsmBag.Size = new System.Drawing.Size(166, 22);
            this.tsmBag.Text = "Bag";
            // 
            // tsmSlot1
            // 
            this.tsmSlot1.Name = "tsmSlot1";
            this.tsmSlot1.Size = new System.Drawing.Size(152, 22);
            this.tsmSlot1.Text = "Slot 1";
            this.tsmSlot1.Click += new System.EventHandler(this.tsmSlot1_Click);
            // 
            // tsmSlot2
            // 
            this.tsmSlot2.Name = "tsmSlot2";
            this.tsmSlot2.Size = new System.Drawing.Size(152, 22);
            this.tsmSlot2.Text = "Slot 2";
            this.tsmSlot2.Click += new System.EventHandler(this.tsmSlot2_Click);
            // 
            // tsmSlot3
            // 
            this.tsmSlot3.Name = "tsmSlot3";
            this.tsmSlot3.Size = new System.Drawing.Size(152, 22);
            this.tsmSlot3.Text = "Slot 3";
            this.tsmSlot3.Click += new System.EventHandler(this.tsmSlot3_Click);
            // 
            // tsmSlot4
            // 
            this.tsmSlot4.Name = "tsmSlot4";
            this.tsmSlot4.Size = new System.Drawing.Size(152, 22);
            this.tsmSlot4.Text = "Slot 4";
            this.tsmSlot4.Click += new System.EventHandler(this.tsmSlot4_Click);
            // 
            // tsmSlot5
            // 
            this.tsmSlot5.Name = "tsmSlot5";
            this.tsmSlot5.Size = new System.Drawing.Size(152, 22);
            this.tsmSlot5.Text = "Slot 5";
            this.tsmSlot5.Click += new System.EventHandler(this.tsmSlot5_Click);
            // 
            // tsmSlot6
            // 
            this.tsmSlot6.Name = "tsmSlot6";
            this.tsmSlot6.Size = new System.Drawing.Size(152, 22);
            this.tsmSlot6.Text = "Slot 6";
            this.tsmSlot6.Click += new System.EventHandler(this.tsmSlot6_Click);
            // 
            // tsmSlot7
            // 
            this.tsmSlot7.Name = "tsmSlot7";
            this.tsmSlot7.Size = new System.Drawing.Size(152, 22);
            this.tsmSlot7.Text = "Slot 7";
            this.tsmSlot7.Click += new System.EventHandler(this.tsmSlot7_Click);
            // 
            // tsmSlot8
            // 
            this.tsmSlot8.Name = "tsmSlot8";
            this.tsmSlot8.Size = new System.Drawing.Size(152, 22);
            this.tsmSlot8.Text = "Slot 8";
            this.tsmSlot8.Click += new System.EventHandler(this.tsmSlot8_Click);
            // 
            // buttonAmmo
            // 
            this.buttonAmmo.Enabled = false;
            this.buttonAmmo.Location = new System.Drawing.Point(10, 298);
            this.buttonAmmo.Name = "buttonAmmo";
            this.buttonAmmo.Size = new System.Drawing.Size(85, 23);
            this.buttonAmmo.TabIndex = 120;
            this.buttonAmmo.Text = "Edit Ammo";
            this.buttonAmmo.UseVisualStyleBackColor = true;
            // 
            // buttonSkills
            // 
            this.buttonSkills.Enabled = false;
            this.buttonSkills.Location = new System.Drawing.Point(98, 298);
            this.buttonSkills.Name = "buttonSkills";
            this.buttonSkills.Size = new System.Drawing.Size(85, 23);
            this.buttonSkills.TabIndex = 121;
            this.buttonSkills.Text = "Edit Skills";
            this.buttonSkills.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(273, 298);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(85, 23);
            this.buttonAbout.TabIndex = 93;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 326);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonSkills);
            this.Controls.Add(this.buttonAmmo);
            this.Controls.Add(this.buttonUpgrades);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.buttonTasks);
            this.Controls.Add(this.buttonWeapons);
            this.Controls.Add(this.checkLJ);
            this.Controls.Add(this.boxXP);
            this.Controls.Add(this.labelXP);
            this.Controls.Add(this.boxMPKits);
            this.Controls.Add(this.labelMPKits);
            this.Controls.Add(this.boxHPKits);
            this.Controls.Add(this.labelHPKits);
            this.Controls.Add(this.boxSouls);
            this.Controls.Add(this.labelSouls);
            this.Controls.Add(this.boxSalvage);
            this.Controls.Add(this.labelSalvage);
            this.Controls.Add(this.boxMoney);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.boxKills);
            this.Controls.Add(this.labelKills);
            this.Controls.Add(this.labelAP);
            this.Controls.Add(this.boxAP);
            this.Controls.Add(this.labelSorcery);
            this.Controls.Add(this.labelToughness);
            this.Controls.Add(this.labelPrecision);
            this.Controls.Add(this.boxSorcery);
            this.Controls.Add(this.boxToughness);
            this.Controls.Add(this.boxPrecision);
            this.Controls.Add(this.boxLegerity);
            this.Controls.Add(this.labelLegerity);
            this.Controls.Add(this.labelAbilities);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.boxLevel);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.comboMode);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.boxWave);
            this.Controls.Add(this.labelWave);
            this.Controls.Add(this.labelMapName);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Defense Save Editor";
            ((System.ComponentModel.ISupportInitialize)(this.boxWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLegerity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxToughness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSorcery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxHPKits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMPKits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxKills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSalvage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSouls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxXP)).EndInit();
            this.contextMenuInventory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelMapName;
        private System.Windows.Forms.Label labelWave;
        private System.Windows.Forms.NumericUpDown boxWave;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.NumericUpDown boxLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelAbilities;
        private System.Windows.Forms.Label labelLegerity;
        private System.Windows.Forms.NumericUpDown boxLegerity;
        private System.Windows.Forms.NumericUpDown boxPrecision;
        private System.Windows.Forms.NumericUpDown boxToughness;
        private System.Windows.Forms.NumericUpDown boxSorcery;
        private System.Windows.Forms.Label labelPrecision;
        private System.Windows.Forms.Label labelToughness;
        private System.Windows.Forms.Label labelSorcery;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown boxAP;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.Label labelKills;
        private System.Windows.Forms.NumericUpDown boxKills;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.NumericUpDown boxMoney;
        private System.Windows.Forms.Label labelSalvage;
        private System.Windows.Forms.NumericUpDown boxSalvage;
        private System.Windows.Forms.Label labelSouls;
        private System.Windows.Forms.NumericUpDown boxSouls;
        private System.Windows.Forms.Label labelHPKits;
        private System.Windows.Forms.NumericUpDown boxHPKits;
        private System.Windows.Forms.Label labelMPKits;
        private System.Windows.Forms.NumericUpDown boxMPKits;
        private System.Windows.Forms.Label labelXP;
        private System.Windows.Forms.NumericUpDown boxXP;
        private System.Windows.Forms.CheckBox checkLJ;
        private System.Windows.Forms.Button buttonWeapons;
        private System.Windows.Forms.Button buttonTasks;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonUpgrades;
        private System.Windows.Forms.ContextMenuStrip contextMenuInventory;
        private System.Windows.Forms.ToolStripMenuItem tsmTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmArmor;
        private System.Windows.Forms.ToolStripMenuItem tsmTrinket;
        private System.Windows.Forms.ToolStripMenuItem tsmGem;
        private System.Windows.Forms.ToolStripMenuItem tsmBag;
        private System.Windows.Forms.ToolStripMenuItem tsmSlot1;
        private System.Windows.Forms.ToolStripMenuItem tsmSlot2;
        private System.Windows.Forms.ToolStripMenuItem tsmSlot3;
        private System.Windows.Forms.ToolStripMenuItem tsmSlot4;
        private System.Windows.Forms.ToolStripMenuItem tsmSlot5;
        private System.Windows.Forms.ToolStripMenuItem tsmSlot6;
        private System.Windows.Forms.ToolStripMenuItem tsmSlot7;
        private System.Windows.Forms.ToolStripMenuItem tsmSlot8;
        private System.Windows.Forms.ToolStripMenuItem tsmHelmet;
        private System.Windows.Forms.Button buttonAmmo;
        private System.Windows.Forms.Button buttonSkills;
        private System.Windows.Forms.Button buttonAbout;

    }
}

