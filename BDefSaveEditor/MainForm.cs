﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace BDefSaveEditor
{
    public partial class Main : Form
    {
        const int ADDRESS_WAVE = 0x00C;
        const int ADDRESS_CLASS = 0x010;
        const int ADDRESS_KILLS = 0x014;
        const int ADDRESS_XP = 0x018;
        const int ADDRESS_LEGERITY = 0x01C;
        const int ADDRESS_PRECISION = 0x020;
        const int ADDRESS_WEAPONS = 0x02C;
        const int ADDRESS_TOUGHNESS = 0x024;
        const int ADDRESS_SORCERY = 0x028;
        const int ADDRESS_MONEY = 0x0B4;
        const int ADDRESS_SALVAGE = 0x0B8;
        const int ADDRESS_SOULS = 0x0BC;
        const int ADDRESS_HPKITS = 0x0C0;
        const int ADDRESS_MPKITS = 0x0C4;
        const int ADDRESS_AP = 0x0C8;
        const int ADDRESS_GAMEMODE = 0x0F8;
        const int ADDRESS_TASK_NUMBER = 0x0DC;
        const int ADDRESS_TASK_TYPE = 0x0E0;
        const int ADDRESS_TASK_REMAIN = 0x0E4;
        const int ADDRESS_TASK_EVENT = 0x0F4;
        const int ADDRESS_LONGJUMP = 0x170;
        const int ADDRESS_HELMET_COLOR = 0x174;
        const int ADDRESS_HELMET_ITEMID = 0x178;
        const int ADDRESS_HELMET_DEFENSE = 0x17C;
        const int ADDRESS_HELMET_ATTRIBUTE = 0x180;
        const int ADDRESS_HELMET_UPGRADES = 0x184;
        const int ADDRESS_ARMOR_COLOR = 0x188;
        const int ADDRESS_ARMOR_ITEMID = 0x18C;
        const int ADDRESS_ARMOR_DEFENSE = 0x190;
        const int ADDRESS_ARMOR_ATTRIBUTE = 0x194;
        const int ADDRESS_ARMOR_UPGRADES = 0x198;
        const int ADDRESS_TRINKET_COLOR = 0x19C;
        const int ADDRESS_TRINKET_ITEMID = 0x1A0;
        const int ADDRESS_TRINKET_ATTRIBUTE = 0x1A8;
        const int ADDRESS_TRINKET_UPGRADES = 0x1AC;
        const int ADDRESS_GEM_COLOR = 0x1B0;
        const int ADDRESS_GEM_ITEMID = 0x1B4;
        const int ADDRESS_ITEM1_COLOR = 0x1C4;
        const int ADDRESS_ITEM1_ITEMID = 0x1C8;
        const int ADDRESS_ITEM1_DEFENSE = 0x1CC;
        const int ADDRESS_ITEM1_ATTRIBUTE = 0x1D0;
        const int ADDRESS_ITEM1_UPGRADES = 0x1D4;
        const int ADDRESS_ITEM2_COLOR = 0x1D8;
        const int ADDRESS_ITEM2_ITEMID = 0x1DC;
        const int ADDRESS_ITEM2_DEFENSE = 0x1E0;
        const int ADDRESS_ITEM2_ATTRIBUTE = 0x1E4;
        const int ADDRESS_ITEM2_UPGRADES = 0x1E8;
        const int ADDRESS_ITEM3_COLOR = 0x1EC;
        const int ADDRESS_ITEM3_ITEMID = 0x1F0;
        const int ADDRESS_ITEM3_DEFENSE = 0x1F4;
        const int ADDRESS_ITEM3_ATTRIBUTE = 0x1F8;
        const int ADDRESS_ITEM3_UPGRADES = 0x1FC;
        const int ADDRESS_ITEM4_COLOR = 0x200;
        const int ADDRESS_ITEM4_ITEMID = 0x204;
        const int ADDRESS_ITEM4_DEFENSE = 0x208;
        const int ADDRESS_ITEM4_ATTRIBUTE = 0x20C;
        const int ADDRESS_ITEM4_UPGRADES = 0x210;
        const int ADDRESS_ITEM5_COLOR = 0x214;
        const int ADDRESS_ITEM5_ITEMID = 0x218;
        const int ADDRESS_ITEM5_DEFENSE = 0x21C;
        const int ADDRESS_ITEM5_ATTRIBUTE = 0x220;
        const int ADDRESS_ITEM5_UPGRADES = 0x224;
        const int ADDRESS_ITEM6_COLOR = 0x228;
        const int ADDRESS_ITEM6_ITEMID = 0x22C;
        const int ADDRESS_ITEM6_DEFENSE = 0x230;
        const int ADDRESS_ITEM6_ATTRIBUTE = 0x234;
        const int ADDRESS_ITEM6_UPGRADES = 0x238;
        const int ADDRESS_ITEM7_COLOR = 0x23C;
        const int ADDRESS_ITEM7_ITEMID = 0x240;
        const int ADDRESS_ITEM7_DEFENSE = 0x244;
        const int ADDRESS_ITEM7_ATTRIBUTE = 0x248;
        const int ADDRESS_ITEM7_UPGRADES = 0x24C;
        const int ADDRESS_ITEM8_COLOR = 0x250;
        const int ADDRESS_ITEM8_ITEMID = 0x254;
        const int ADDRESS_ITEM8_DEFENSE = 0x258;
        const int ADDRESS_ITEM8_ATTRIBUTE = 0x25C;
        const int ADDRESS_ITEM8_UPGRADES = 0x260;
        const int ADDRESS_UPGRADE_MEELE_DAMAGE = 0x29C;
        const int ADDRESS_UPGRADE_MEELE_RATE = 0x2A8;
        const int ADDRESS_UPGRADE_AXE_SLOTS = 0x2CC;
        const int ADDRESS_UPGRADE_AXE_DAMAGE = 0x2D0;
        const int ADDRESS_UPGRADE_AXE_RATE = 0x2DC;
        const int ADDRESS_UPGRADE_PISTOL_SLOTS = 0x300;
        const int ADDRESS_UPGRADE_PISTOL_DAMAGE = 0x304;
        const int ADDRESS_UPGRADE_PISTOL_RATE = 0x310;
        const int ADDRESS_UPGRADE_PISTOL_AMMO = 0x31C;
        const int ADDRESS_UPGRADE_PISTOL_UNIQUE = 0x328;
        const int ADDRESS_UPGRADE_BLASTER_SLOTS = 0x334;
        const int ADDRESS_UPGRADE_BLASTER_DAMAGE = 0x338;
        const int ADDRESS_UPGRADE_BLASTER_RATE = 0x344;
        const int ADDRESS_UPGRADE_PYTHON_SLOTS = 0x368;
        const int ADDRESS_UPGRADE_PYTHON_DAMAGE = 0x36C;
        const int ADDRESS_UPGRADE_PYTHON_RATE = 0x378;
        const int ADDRESS_UPGRADE_PYTHON_AMMO = 0x384;
        const int ADDRESS_UPGRADE_PYTHON_UNIQUE = 0x390;
        const int ADDRESS_UPGRADE_AKIMBO_SLOTS = 0x39C;
        const int ADDRESS_UPGRADE_AKIMBO_DAMAGE = 0x3A0;
        const int ADDRESS_UPGRADE_AKIMBO_RATE = 0x3AC;
        const int ADDRESS_UPGRADE_AKIMBO_AMMO = 0x3B8;
        const int ADDRESS_UPGRADE_AKIMBO_UNIQUE = 0x3C4;
        const int ADDRESS_UPGRADE_SMG_SLOTS = 0x3D0;
        const int ADDRESS_UPGRADE_SMG_DAMAGE = 0x3D4;
        const int ADDRESS_UPGRADE_SMG_RATE = 0x3E0;
        const int ADDRESS_UPGRADE_SMG_AMMO = 0x3EC;
        const int ADDRESS_UPGRADE_SHOTGUN_SLOTS = 0x404;
        const int ADDRESS_UPGRADE_SHOTGUN_DAMAGE = 0x408;
        const int ADDRESS_UPGRADE_SHOTGUN_RATE = 0x414;
        const int ADDRESS_UPGRADE_SHOTGUN_AMMO = 0x420;
        const int ADDRESS_UPGRADE_SHOTGUN_UNIQUE = 0x42C;
        const int ADDRESS_UPGRADE_CROSSBOW_SLOTS = 0x438;
        const int ADDRESS_UPGRADE_CROSSBOW_DAMAGE = 0x43C;
        const int ADDRESS_UPGRADE_CROSSBOW_RATE = 0x448;
        const int ADDRESS_UPGRADE_CROSSBOW_AMMO = 0x454;
        const int ADDRESS_UPGRADE_CROSSBOW_UNIQUE = 0x460;
        const int ADDRESS_UPGRADE_ASSAULT_SLOTS = 0x46C;
        const int ADDRESS_UPGRADE_ASSAULT_DAMAGE = 0x470;
        const int ADDRESS_UPGRADE_ASSAULT_RATE = 0x47C;
        const int ADDRESS_UPGRADE_ASSAULT_AMMO = 0x488;
        const int ADDRESS_UPGRADE_SAW_SLOTS = 0x4A0;
        const int ADDRESS_UPGRADE_SAW_DAMAGE = 0x4A4;
        const int ADDRESS_UPGRADE_SAW_RATE = 0x4B0;
        const int ADDRESS_UPGRADE_SAW_AMMO = 0x4BC;
        const int ADDRESS_UPGRADE_SNIPER_SLOTS = 0x4D4;
        const int ADDRESS_UPGRADE_SNIPER_DAMAGE = 0x4D8;
        const int ADDRESS_UPGRADE_SNIPER_RATE = 0x4E4;
        const int ADDRESS_UPGRADE_SNIPER_AMMO = 0x4F0;
        const int ADDRESS_UPGRADE_RPG_SLOTS = 0x508;
        const int ADDRESS_UPGRADE_RPG_DAMAGE = 0x50C;
        const int ADDRESS_UPGRADE_GAUSS_SLOTS = 0x53C;
        const int ADDRESS_UPGRADE_GAUSS_DAMAGE = 0x540;
        const int ADDRESS_UPGRADE_GAUSS_RATE = 0x54C;
        const int ADDRESS_UPGRADE_SHOCK_RATE = 0x580;
        const int ADDRESS_UPGRADE_GRENADE_SLOTS = 0x5A4;
        const int ADDRESS_UPGRADE_GRENADE_RATE = 0x5B4;
        const int ADDRESS_UPGRADE_GRENADE_AMMO = 0x5C0;
        const int ADDRESS_UPGRADE_MINIGUN_SLOTS = 0x60C;
        const int ADDRESS_UPGRADE_MINIGUN_DAMAGE = 0x610;
        const int ADDRESS_UPGRADE_MINIGUN_RATE = 0x61C;
        const int ADDRESS_AMMO_BUCKSHOT = 0x038;
        const int ADDRESS_AMMO_9MM = 0x03C;
        const int ADDRESS_AMMO_SHOCK = 0x040;
        const int ADDRESS_AMMO_SAW = 0x044;
        const int ADDRESS_AMMO_SNIPER = 0x048;
        const int ADDRESS_AMMO_ARGRENADE = 0x04C;
        const int ADDRESS_AMMO_FLAME = 0x050;
        const int ADDRESS_AMMO_MINIGUN = 0x054;
        const int ADDRESS_AMMO_PYTHON = 0x058;
        const int ADDRESS_AMMO_GAUSS = 0x05C;
        const int ADDRESS_AMMO_RPG = 0x060;
        const int ADDRESS_AMMO_CROSSBOW = 0x064;
        const int ADDRESS_AMMO_TRIPMINE = 0x068;
        const int ADDRESS_AMMO_SATCHEL = 0x06C;
        const int ADDRESS_AMMO_HANDGRENADE = 0x070;
        const int ADDRESS_AMMO_GRENADELAUNCHER = 0x074;
        const int ADDRESS_POWERS_FIRST = 0x0CC;
        const int ADDRESS_POWERS_SECOND = 0x0D0;
        const int ADDRESS_POWERS_THIRD = 0x0D4;
        const int ADDRESS_POWERS_FOURTH = 0x0D8;

        const uint W_MELEE = (1 << 1);
        const uint W_AXE = (1 << 2);
        const uint W_PISTOL = (1 << 3);
        const uint W_BLASTER = (1 << 4);
        const uint W_357 = (1 << 5);
        const uint W_AKIMBO = (1 << 6);
        const uint W_MP5 = (1 << 7);
        const uint W_SHOTGUN = (1 << 8);
        const uint W_CROSSBOW = (1 << 9);
        const uint W_ASSAULT = (1 << 10);
        const uint W_SAW = (1 << 11);
        const uint W_SNIPER = (1 << 12);
        const uint W_RPG = (1 << 13);
        const uint W_GAUSS = (1 << 14);
        const uint W_SHOCK = (1 << 15);
        const uint W_GL = (1 << 16);
        const uint W_FLAME = (1 << 17);
        const uint W_MINIGUN = (1 << 18);
        const uint W_HANDGRENADE = (1 << 19);
        const uint W_TRIPMINE = (1 << 20);
        const uint W_SATCHEL = (1 << 21);
        const uint W_SUIT = 0x80000000; // (1 << 31)

        // It would be better if the XP formula could be reverse engineered
        readonly int[] arrXPLevels =
        {
            0,
            300,
            758,
            1283,
            1884,
            2572,
            3360,
            4263,
            5296,
            6479,
            7834,
            9386,
            11163,
            13197,
            15526,
            18193,
            21247,
            24744,
            28748,
            33333,
            38583,
            44594,
            51477,
            59358,
            68382,
            78714,
            90544,
            104090,
            119600,
            137359,
            157693,
            180975,
            207633,
            238157,
            273107,
            313125,
            358946,
            411411,
            471483,
            540266,
            619022,
            709198,
            812449,
            930672,
            1066037,
            1221030,
            1398498,
            1601698,
            1834363,
            2100764,
            2405793,
            2755051,
            3154952,
            3612839,
            4137119,
            4737420,
            5424765,
            6211775,
            7112901,
            8144691,
            9326090,
            10678792,
            12227636,
            14001062,
            16031635,
            18356641,
            21018773,
            24066914,
            27557036,
            31553225,
            36128862,
            41367966,
            47366740,
            54235337,
            62099880,
            71104782,
            81415394,
            93221045,
            106738515,
            122216018,
            139937759,
            160229152,
            183462797,
            210065320,
            240525209,
            275401781,
            315335455,
            361059511,
            413413555,
            473358934,
            541996392
        };

        public bool b_WPN_Melee;
        public bool b_WPN_Axe;
        public bool b_WPN_Pistol;
        public bool b_WPN_Blaster;
        public bool b_WPN_357;
        public bool b_WPN_Akimbo;
        public bool b_WPN_MP5;
        public bool b_WPN_Shotgun;
        public bool b_WPN_Crossbow;
        public bool b_WPN_Assault;
        public bool b_WPN_SAW;
        public bool b_WPN_Sniper;
        public bool b_WPN_RPG;
        public bool b_WPN_Gauss;
        public bool b_WPN_Shock;
        public bool b_WPN_GL;
        public bool b_WPN_Flame;
        public bool b_WPN_Minigun;
        public bool b_WPN_Suit;

        public int i_TASK_Number;
        public int i_TASK_Type;
        public int i_TASK_Remain;
        public int i_TASK_Event;

        public int i_HELMET_Color;
        public int i_HELMET_ItemID;
        public int i_HELMET_Defense;
        public int i_HELMET_Attribute;
        public int i_HELMET_Upgrades;

        public int i_ARMOR_Color;
        public int i_ARMOR_ItemID;
        public int i_ARMOR_Defense;
        public int i_ARMOR_Attribute;
        public int i_ARMOR_Upgrades;

        public int i_TRINKET_Color;
        public int i_TRINKET_ItemID;
        public int i_TRINKET_Attribute;
        public int i_TRINKET_Upgrades;

        public int i_GEM_Color;
        public int i_GEM_ItemID;

        public int i_ITEM1_Color;
        public int i_ITEM1_ItemID;
        public int i_ITEM1_Defense;
        public int i_ITEM1_Attribute;
        public int i_ITEM1_Upgrades;

        public int i_ITEM2_Color;
        public int i_ITEM2_ItemID;
        public int i_ITEM2_Defense;
        public int i_ITEM2_Attribute;
        public int i_ITEM2_Upgrades;

        public int i_ITEM3_Color;
        public int i_ITEM3_ItemID;
        public int i_ITEM3_Defense;
        public int i_ITEM3_Attribute;
        public int i_ITEM3_Upgrades;

        public int i_ITEM4_Color;
        public int i_ITEM4_ItemID;
        public int i_ITEM4_Defense;
        public int i_ITEM4_Attribute;
        public int i_ITEM4_Upgrades;

        public int i_ITEM5_Color;
        public int i_ITEM5_ItemID;
        public int i_ITEM5_Defense;
        public int i_ITEM5_Attribute;
        public int i_ITEM5_Upgrades;

        public int i_ITEM6_Color;
        public int i_ITEM6_ItemID;
        public int i_ITEM6_Defense;
        public int i_ITEM6_Attribute;
        public int i_ITEM6_Upgrades;

        public int i_ITEM7_Color;
        public int i_ITEM7_ItemID;
        public int i_ITEM7_Defense;
        public int i_ITEM7_Attribute;
        public int i_ITEM7_Upgrades;

        public int i_ITEM8_Color;
        public int i_ITEM8_ItemID;
        public int i_ITEM8_Defense;
        public int i_ITEM8_Attribute;
        public int i_ITEM8_Upgrades;

        public int i_UPGRADE_MEELE_Damage;
        public int i_UPGRADE_MEELE_RateOfFire;

        public int i_UPGRADE_AXE_Slots;
        public int i_UPGRADE_AXE_Damage;
        public int i_UPGRADE_AXE_RateOfFire;

        public int i_UPGRADE_PISTOL_Slots;
        public int i_UPGRADE_PISTOL_Damage;
        public int i_UPGRADE_PISTOL_RateOfFire;
        public int i_UPGRADE_PISTOL_Ammo;
        public int i_UPGRADE_PISTOL_Unique;

        public int i_UPGRADE_BLASTER_Slots;
        public int i_UPGRADE_BLASTER_Damage;
        public int i_UPGRADE_BLASTER_RateOfFire;

        public int i_UPGRADE_PYTHON_Slots;
        public int i_UPGRADE_PYTHON_Damage;
        public int i_UPGRADE_PYTHON_RateOfFire;
        public int i_UPGRADE_PYTHON_Ammo;
        public int i_UPGRADE_PYTHON_Unique;

        public int i_UPGRADE_AKIMBO_Slots;
        public int i_UPGRADE_AKIMBO_Damage;
        public int i_UPGRADE_AKIMBO_RateOfFire;
        public int i_UPGRADE_AKIMBO_Ammo;
        public int i_UPGRADE_AKIMBO_Unique;

        public int i_UPGRADE_SMG_Slots;
        public int i_UPGRADE_SMG_Damage;
        public int i_UPGRADE_SMG_RateOfFire;
        public int i_UPGRADE_SMG_Ammo;

        public int i_UPGRADE_SHOTGUN_Slots;
        public int i_UPGRADE_SHOTGUN_Damage;
        public int i_UPGRADE_SHOTGUN_RateOfFire;
        public int i_UPGRADE_SHOTGUN_Ammo;
        public int i_UPGRADE_SHOTGUN_Unique;

        public int i_UPGRADE_CROSSBOW_Slots;
        public int i_UPGRADE_CROSSBOW_Damage;
        public int i_UPGRADE_CROSSBOW_RateOfFire;
        public int i_UPGRADE_CROSSBOW_Ammo;
        public int i_UPGRADE_CROSSBOW_Unique;

        public int i_UPGRADE_ASSAULT_Slots;
        public int i_UPGRADE_ASSAULT_Damage;
        public int i_UPGRADE_ASSAULT_RateOfFire;
        public int i_UPGRADE_ASSAULT_Ammo;

        public int i_UPGRADE_SAW_Slots;
        public int i_UPGRADE_SAW_Damage;
        public int i_UPGRADE_SAW_RateOfFire;
        public int i_UPGRADE_SAW_Ammo;

        public int i_UPGRADE_SNIPER_Slots;
        public int i_UPGRADE_SNIPER_Damage;
        public int i_UPGRADE_SNIPER_RateOfFire;
        public int i_UPGRADE_SNIPER_Ammo;

        public int i_UPGRADE_RPG_Slots;
        public int i_UPGRADE_RPG_Damage;

        public int i_UPGRADE_GAUSS_Slots;
        public int i_UPGRADE_GAUSS_Damage;
        public int i_UPGRADE_GAUSS_RateOfFire;

        public int i_UPGRADE_SHOCK_RateOfFire;

        public int i_UPGRADE_GRENADE_Slots;
        public int i_UPGRADE_GRENADE_RateOfFire;
        public int i_UPGRADE_GRENADE_Ammo;

        public int i_UPGRADE_MINIGUN_Slots;
        public int i_UPGRADE_MINIGUN_Damage;
        public int i_UPGRADE_MINIGUN_RateOfFire;

        public int i_AMMO_Shotgun;
        public int i_AMMO_9mm;
        public int i_AMMO_Shock;
        public int i_AMMO_SAW;
        public int i_AMMO_Sniper;
        public int i_AMMO_ARGrenade;
        public int i_AMMO_Flame;
        public int i_AMMO_Minigun;
        public int i_AMMO_357;
        public int i_AMMO_Gauss;
        public int i_AMMO_RPG;
        public int i_AMMO_Crossbow;
        public int i_AMMO_Tripmine;
        public int i_AMMO_Satchel;
        public int i_AMMO_Grenade;
        public int i_AMMO_GLauncher;

        public int i_POWER_First;
        public int i_POWER_Second;
        public int i_POWER_Third;
        public int i_POWER_Fourth;

        WeaponsForm weaponForm;
        TasksForm taskForm;
        InventoryForm inventoryForm;
        UpgradesForm upgradesForm;
        PowersForm powersForm;

        public Main()
        {
            InitializeComponent();
            weaponForm = new WeaponsForm(this);
            taskForm = new TasksForm(this);
            inventoryForm = new InventoryForm(this);
            upgradesForm = new UpgradesForm(this);
            powersForm = new PowersForm(this);
        }

        private void ResetWeapons()
        {
            b_WPN_Melee = false;
            b_WPN_Axe = false;
            b_WPN_Pistol = false;
            b_WPN_Blaster = false;
            b_WPN_357 = false;
            b_WPN_Akimbo = false;
            b_WPN_MP5 = false;
            b_WPN_Shotgun = false;
            b_WPN_Crossbow = false;
            b_WPN_Assault = false;
            b_WPN_SAW = false;
            b_WPN_Sniper = false;
            b_WPN_RPG = false;
            b_WPN_Gauss = false;
            b_WPN_Shock = false;
            b_WPN_GL = false;
            b_WPN_Flame = false;
            b_WPN_Minigun = false;
            b_WPN_Suit = false;
        }

        public void UpdateInventoryMenu()
        {
            contextMenuInventory.Items[2].Text = "Equipped Helmet (" + inventoryForm.GetItemName(i_HELMET_ItemID) + ")";
            contextMenuInventory.Items[3].Text = "Equipped Armor (" + inventoryForm.GetItemName(i_ARMOR_ItemID) + ")";
            contextMenuInventory.Items[4].Text = "Equipped Trinket (" + inventoryForm.GetItemName(i_TRINKET_ItemID) + ")";
            contextMenuInventory.Items[5].Text = "Equipped Gem (" + inventoryForm.GetItemName(i_GEM_ItemID) + ")";
            
            ToolStripDropDownItem subItems = (ToolStripDropDownItem)contextMenuInventory.Items[6];
            subItems.DropDownItems[0].Text = "Slot 1 (" + inventoryForm.GetItemName(i_ITEM1_ItemID) + ")";
            subItems.DropDownItems[1].Text = "Slot 2 (" + inventoryForm.GetItemName(i_ITEM2_ItemID) + ")";
            subItems.DropDownItems[2].Text = "Slot 3 (" + inventoryForm.GetItemName(i_ITEM3_ItemID) + ")";
            subItems.DropDownItems[3].Text = "Slot 4 (" + inventoryForm.GetItemName(i_ITEM4_ItemID) + ")";
            subItems.DropDownItems[4].Text = "Slot 5 (" + inventoryForm.GetItemName(i_ITEM5_ItemID) + ")";
            subItems.DropDownItems[5].Text = "Slot 6 (" + inventoryForm.GetItemName(i_ITEM6_ItemID) + ")";
            subItems.DropDownItems[6].Text = "Slot 7 (" + inventoryForm.GetItemName(i_ITEM7_ItemID) + ")";
            subItems.DropDownItems[7].Text = "Slot 8 (" + inventoryForm.GetItemName(i_ITEM8_ItemID) + ")";
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            labelFile.Text = openFileDialog.SafeFileName;

            string szFilePath = openFileDialog.FileName;
            string[] szFileSplit = szFilePath.Split('\\');

            for (int iLength = 0; iLength < szFileSplit.Length; iLength++ )
            {
                if ( szFileSplit[iLength].StartsWith( "pve_" ) )
                {
                    labelMapName.Text = "Map: " + szFileSplit[iLength];
                    break;
                }
            }
            
            try
            {
                using (FileStream fsFile = File.OpenRead(szFilePath))
                {
                    byte[] bData = new byte[4];
                    int iData;
                    uint uiCheck;
                    ResetWeapons();

                    // Header
                    fsFile.Read(bData, 0, bData.Length);
                    if (bData[0] == 0xBE && bData[1] == 0xBA && bData[2] == 0xAD && bData[3] == 0xDE)
                    {
                        // Gamemode
                        comboMode.SelectedIndex = ConvertAndLoad(fsFile, ADDRESS_GAMEMODE) - 1;

                        // Class
                        comboClass.SelectedIndex = ConvertAndLoad(fsFile, ADDRESS_CLASS) - 1;

                        // Wave
                        boxWave.Value = ConvertAndLoad(fsFile, ADDRESS_WAVE);

                        // Legerity
                        boxLegerity.Value = ConvertAndLoad(fsFile, ADDRESS_LEGERITY);

                        // Precision
                        boxPrecision.Value = ConvertAndLoad(fsFile, ADDRESS_PRECISION);

                        // Toughness
                        boxToughness.Value = ConvertAndLoad(fsFile, ADDRESS_TOUGHNESS);

                        // Sorcery
                        boxSorcery.Value = ConvertAndLoad(fsFile, ADDRESS_SORCERY);

                        // Ability Points
                        boxAP.Value = ConvertAndLoad(fsFile, ADDRESS_AP);

                        // Kills
                        boxKills.Value = ConvertAndLoad(fsFile, ADDRESS_KILLS);

                        // Money
                        boxMoney.Value = ConvertAndLoad(fsFile, ADDRESS_MONEY);

                        // Salvage
                        boxSalvage.Value = ConvertAndLoad(fsFile, ADDRESS_SALVAGE);

                        // Souls
                        boxSouls.Value = ConvertAndLoad(fsFile, ADDRESS_SOULS);

                        // Health Kits
                        boxHPKits.Value = ConvertAndLoad(fsFile, ADDRESS_HPKITS);

                        // Mana Kits
                        boxMPKits.Value = ConvertAndLoad(fsFile, ADDRESS_MPKITS);

                        // Total Experience
                        iData = ConvertAndLoad(fsFile, ADDRESS_XP);
                        boxXP.Value = iData;
                        boxLevel.Value = XPToLevel(iData);

                        // Long Jump
                        checkLJ.Checked = Convert.ToBoolean(ConvertAndLoad(fsFile, ADDRESS_LONGJUMP));

                        // Weapons
                        fsFile.Seek(ADDRESS_WEAPONS, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        uint uiData = BitConverter.ToUInt32(bData, 0);
                        /* uint uiData = Convert.ToUInt32(ConvertAndLoad(fsFile, ADDRESS_WEAPONS)); fails */
                        uiCheck = uiData; if ((uiCheck &= W_MELEE) == W_MELEE) b_WPN_Melee = true; // Bad way of doing bitwise check!
                        uiCheck = uiData; if ((uiCheck &= W_AXE) == W_AXE) b_WPN_Axe = true;
                        uiCheck = uiData; if ((uiCheck &= W_PISTOL) == W_PISTOL) b_WPN_Pistol = true;
                        uiCheck = uiData; if ((uiCheck &= W_BLASTER) == W_BLASTER) b_WPN_Blaster = true;
                        uiCheck = uiData; if ((uiCheck &= W_357) == W_357) b_WPN_357 = true;
                        uiCheck = uiData; if ((uiCheck &= W_AKIMBO) == W_AKIMBO) b_WPN_Akimbo = true;
                        uiCheck = uiData; if ((uiCheck &= W_MP5) == W_MP5) b_WPN_MP5 = true;
                        uiCheck = uiData; if ((uiCheck &= W_SHOTGUN) == W_SHOTGUN) b_WPN_Shotgun = true;
                        uiCheck = uiData; if ((uiCheck &= W_CROSSBOW) == W_CROSSBOW) b_WPN_Crossbow = true;
                        uiCheck = uiData; if ((uiCheck &= W_ASSAULT) == W_ASSAULT) b_WPN_Assault = true;
                        uiCheck = uiData; if ((uiCheck &= W_SAW) == W_SAW) b_WPN_SAW = true;
                        uiCheck = uiData; if ((uiCheck &= W_SNIPER) == W_SNIPER) b_WPN_Sniper = true;
                        uiCheck = uiData; if ((uiCheck &= W_RPG) == W_RPG) b_WPN_RPG = true;
                        uiCheck = uiData; if ((uiCheck &= W_GAUSS) == W_GAUSS) b_WPN_Gauss = true;
                        uiCheck = uiData; if ((uiCheck &= W_SHOCK) == W_SHOCK) b_WPN_Shock = true;
                        uiCheck = uiData; if ((uiCheck &= W_GL) == W_GL) b_WPN_GL = true;
                        uiCheck = uiData; if ((uiCheck &= W_FLAME) == W_FLAME) b_WPN_Flame = true;
                        uiCheck = uiData; if ((uiCheck &= W_MINIGUN) == W_MINIGUN) b_WPN_Minigun = true;
                        uiCheck = uiData; if ((uiCheck &= W_SUIT) == W_SUIT) b_WPN_Suit = true;
                        
                        // Tasks
                        i_TASK_Number = ConvertAndLoad(fsFile, ADDRESS_TASK_NUMBER); // Task number
                        i_TASK_Type = ConvertAndLoad(fsFile, ADDRESS_TASK_TYPE) - 1; // Task type
                        i_TASK_Remain = ConvertAndLoad(fsFile, ADDRESS_TASK_REMAIN); // Task remain
                        i_TASK_Event = ConvertAndLoad(fsFile, ADDRESS_TASK_EVENT); // Event task

                        // Inventory
                        i_HELMET_Color = ConvertAndLoad(fsFile, ADDRESS_HELMET_COLOR); // Helmet
                        i_HELMET_ItemID = ConvertAndLoad(fsFile, ADDRESS_HELMET_ITEMID);
                        i_HELMET_Defense = ConvertAndLoad(fsFile, ADDRESS_HELMET_DEFENSE);
                        i_HELMET_Attribute = ConvertAndLoad(fsFile, ADDRESS_HELMET_ATTRIBUTE);
                        i_HELMET_Upgrades = ConvertAndLoad(fsFile, ADDRESS_HELMET_UPGRADES);

                        i_ARMOR_Color = ConvertAndLoad(fsFile, ADDRESS_ARMOR_COLOR); // Armor
                        i_ARMOR_ItemID = ConvertAndLoad(fsFile, ADDRESS_ARMOR_ITEMID);
                        i_ARMOR_Defense = ConvertAndLoad(fsFile, ADDRESS_ARMOR_DEFENSE);
                        i_ARMOR_Attribute = ConvertAndLoad(fsFile, ADDRESS_ARMOR_ATTRIBUTE);
                        i_ARMOR_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ARMOR_UPGRADES);

                        i_TRINKET_Color = ConvertAndLoad(fsFile, ADDRESS_TRINKET_COLOR); // Trinket
                        i_TRINKET_ItemID = ConvertAndLoad(fsFile, ADDRESS_TRINKET_ITEMID);
                        i_TRINKET_Attribute = ConvertAndLoad(fsFile, ADDRESS_TRINKET_ATTRIBUTE);
                        i_TRINKET_Upgrades = ConvertAndLoad(fsFile, ADDRESS_TRINKET_UPGRADES);

                        i_GEM_Color = ConvertAndLoad(fsFile, ADDRESS_GEM_COLOR); // Gem
                        i_GEM_ItemID = ConvertAndLoad(fsFile, ADDRESS_GEM_ITEMID);

                        i_ITEM1_Color = ConvertAndLoad(fsFile, ADDRESS_ITEM1_COLOR); // Bag Slot 1
                        i_ITEM1_ItemID = ConvertAndLoad(fsFile, ADDRESS_ITEM1_ITEMID);
                        i_ITEM1_Defense = ConvertAndLoad(fsFile, ADDRESS_ITEM1_DEFENSE);
                        i_ITEM1_Attribute = ConvertAndLoad(fsFile, ADDRESS_ITEM1_ATTRIBUTE);
                        i_ITEM1_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ITEM1_UPGRADES);

                        i_ITEM2_Color = ConvertAndLoad(fsFile, ADDRESS_ITEM2_COLOR); // Bag Slot 2
                        i_ITEM2_ItemID = ConvertAndLoad(fsFile, ADDRESS_ITEM2_ITEMID);
                        i_ITEM2_Defense = ConvertAndLoad(fsFile, ADDRESS_ITEM2_DEFENSE);
                        i_ITEM2_Attribute = ConvertAndLoad(fsFile, ADDRESS_ITEM2_ATTRIBUTE);
                        i_ITEM2_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ITEM2_UPGRADES);

                        i_ITEM3_Color = ConvertAndLoad(fsFile, ADDRESS_ITEM3_COLOR); // Bag Slot 3
                        i_ITEM3_ItemID = ConvertAndLoad(fsFile, ADDRESS_ITEM3_ITEMID);
                        i_ITEM3_Defense = ConvertAndLoad(fsFile, ADDRESS_ITEM3_DEFENSE);
                        i_ITEM3_Attribute = ConvertAndLoad(fsFile, ADDRESS_ITEM3_ATTRIBUTE);
                        i_ITEM3_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ITEM3_UPGRADES);

                        i_ITEM4_Color = ConvertAndLoad(fsFile, ADDRESS_ITEM4_COLOR); // Bag Slot 4
                        i_ITEM4_ItemID = ConvertAndLoad(fsFile, ADDRESS_ITEM4_ITEMID);
                        i_ITEM4_Defense = ConvertAndLoad(fsFile, ADDRESS_ITEM4_DEFENSE);
                        i_ITEM4_Attribute = ConvertAndLoad(fsFile, ADDRESS_ITEM4_ATTRIBUTE);
                        i_ITEM4_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ITEM4_UPGRADES);

                        i_ITEM5_Color = ConvertAndLoad(fsFile, ADDRESS_ITEM5_COLOR); // Bag Slot 5
                        i_ITEM5_ItemID = ConvertAndLoad(fsFile, ADDRESS_ITEM5_ITEMID);
                        i_ITEM5_Defense = ConvertAndLoad(fsFile, ADDRESS_ITEM5_DEFENSE);
                        i_ITEM5_Attribute = ConvertAndLoad(fsFile, ADDRESS_ITEM5_ATTRIBUTE);
                        i_ITEM5_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ITEM5_UPGRADES);

                        i_ITEM6_Color = ConvertAndLoad(fsFile, ADDRESS_ITEM6_COLOR); // Bag Slot 6
                        i_ITEM6_ItemID = ConvertAndLoad(fsFile, ADDRESS_ITEM6_ITEMID);
                        i_ITEM6_Defense = ConvertAndLoad(fsFile, ADDRESS_ITEM6_DEFENSE);
                        i_ITEM6_Attribute = ConvertAndLoad(fsFile, ADDRESS_ITEM6_ATTRIBUTE);
                        i_ITEM6_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ITEM6_UPGRADES);

                        i_ITEM7_Color = ConvertAndLoad(fsFile, ADDRESS_ITEM7_COLOR); // Bag Slot 7
                        i_ITEM7_ItemID = ConvertAndLoad(fsFile, ADDRESS_ITEM7_ITEMID);
                        i_ITEM7_Defense = ConvertAndLoad(fsFile, ADDRESS_ITEM7_DEFENSE);
                        i_ITEM7_Attribute = ConvertAndLoad(fsFile, ADDRESS_ITEM7_ATTRIBUTE);
                        i_ITEM7_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ITEM7_UPGRADES);

                        i_ITEM8_Color = ConvertAndLoad(fsFile, ADDRESS_ITEM8_COLOR); // Bag Slot 8
                        i_ITEM8_ItemID = ConvertAndLoad(fsFile, ADDRESS_ITEM8_ITEMID);
                        i_ITEM8_Defense = ConvertAndLoad(fsFile, ADDRESS_ITEM8_DEFENSE);
                        i_ITEM8_Attribute = ConvertAndLoad(fsFile, ADDRESS_ITEM8_ATTRIBUTE);
                        i_ITEM8_Upgrades = ConvertAndLoad(fsFile, ADDRESS_ITEM8_UPGRADES);

                        UpdateInventoryMenu();

                        // Weapon Upgrades
                        i_UPGRADE_AXE_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_MEELE_DAMAGE); // Meele
                        i_UPGRADE_AXE_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_MEELE_RATE);

                        i_UPGRADE_AXE_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_AXE_SLOTS); // Ancient Axe
                        i_UPGRADE_AXE_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_AXE_DAMAGE);
                        i_UPGRADE_AXE_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_AXE_RATE);

                        i_UPGRADE_PISTOL_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PISTOL_SLOTS); // Pistol
                        i_UPGRADE_PISTOL_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PISTOL_DAMAGE);
                        i_UPGRADE_PISTOL_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PISTOL_RATE);
                        i_UPGRADE_PISTOL_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PISTOL_AMMO);
                        i_UPGRADE_PISTOL_Unique = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PISTOL_UNIQUE);

                        i_UPGRADE_BLASTER_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_BLASTER_SLOTS); // Blaster
                        i_UPGRADE_BLASTER_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_BLASTER_DAMAGE);
                        i_UPGRADE_BLASTER_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_BLASTER_RATE);

                        i_UPGRADE_PYTHON_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PYTHON_SLOTS); // Python
                        i_UPGRADE_PYTHON_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PYTHON_DAMAGE);
                        i_UPGRADE_PYTHON_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PYTHON_RATE);
                        i_UPGRADE_PYTHON_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PYTHON_AMMO);
                        i_UPGRADE_PYTHON_Unique = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_PYTHON_UNIQUE);

                        i_UPGRADE_AKIMBO_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_AKIMBO_SLOTS); // Akimbo
                        i_UPGRADE_AKIMBO_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_AKIMBO_DAMAGE);
                        i_UPGRADE_AKIMBO_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_AKIMBO_RATE);
                        i_UPGRADE_AKIMBO_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_AKIMBO_AMMO);
                        i_UPGRADE_AKIMBO_Unique = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_AKIMBO_UNIQUE);

                        i_UPGRADE_SMG_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SMG_SLOTS); // Submachine Gun
                        i_UPGRADE_SMG_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SMG_DAMAGE);
                        i_UPGRADE_SMG_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SMG_RATE);
                        i_UPGRADE_SMG_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SMG_AMMO);

                        i_UPGRADE_SHOTGUN_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SHOTGUN_SLOTS); // Shotgun
                        i_UPGRADE_SHOTGUN_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SHOTGUN_DAMAGE);
                        i_UPGRADE_SHOTGUN_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SHOTGUN_RATE);
                        i_UPGRADE_SHOTGUN_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SHOTGUN_AMMO);
                        i_UPGRADE_SHOTGUN_Unique = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SHOTGUN_UNIQUE);

                        i_UPGRADE_CROSSBOW_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_CROSSBOW_SLOTS); // Crossbow
                        i_UPGRADE_CROSSBOW_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_CROSSBOW_DAMAGE);
                        i_UPGRADE_CROSSBOW_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_CROSSBOW_RATE);
                        i_UPGRADE_CROSSBOW_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_CROSSBOW_AMMO);
                        i_UPGRADE_CROSSBOW_Unique = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_CROSSBOW_UNIQUE);

                        i_UPGRADE_ASSAULT_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_ASSAULT_SLOTS); // Assault Rifle
                        i_UPGRADE_ASSAULT_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_ASSAULT_DAMAGE);
                        i_UPGRADE_ASSAULT_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_ASSAULT_RATE);
                        i_UPGRADE_ASSAULT_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_ASSAULT_AMMO);

                        i_UPGRADE_SAW_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SAW_SLOTS); // SAW
                        i_UPGRADE_SAW_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SAW_DAMAGE);
                        i_UPGRADE_SAW_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SAW_RATE);
                        i_UPGRADE_SAW_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SAW_AMMO);

                        i_UPGRADE_SNIPER_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SNIPER_SLOTS); // Sniper Rifle
                        i_UPGRADE_SNIPER_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SNIPER_DAMAGE);
                        i_UPGRADE_SNIPER_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SNIPER_RATE);
                        i_UPGRADE_SNIPER_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SNIPER_AMMO);

                        i_UPGRADE_RPG_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_RPG_SLOTS); // Rocket Launcher
                        i_UPGRADE_RPG_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_RPG_DAMAGE);

                        i_UPGRADE_GAUSS_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_GAUSS_SLOTS); // Gauss
                        i_UPGRADE_GAUSS_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_GAUSS_DAMAGE);
                        i_UPGRADE_GAUSS_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_GAUSS_RATE);

                        i_UPGRADE_SHOCK_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_SHOCK_RATE); // Shock Rifle

                        i_UPGRADE_GRENADE_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_GRENADE_SLOTS); // Grenade Launcher
                        i_UPGRADE_GRENADE_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_GRENADE_RATE);
                        i_UPGRADE_GRENADE_Ammo = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_GRENADE_AMMO);

                        i_UPGRADE_MINIGUN_Slots = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_MINIGUN_SLOTS); // Minigun
                        i_UPGRADE_MINIGUN_Damage = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_MINIGUN_DAMAGE);
                        i_UPGRADE_MINIGUN_RateOfFire = ConvertAndLoad(fsFile, ADDRESS_UPGRADE_MINIGUN_RATE);

                        // Ammo
                        i_AMMO_Shotgun = ConvertAndLoad(fsFile, ADDRESS_AMMO_BUCKSHOT);
                        i_AMMO_9mm = ConvertAndLoad(fsFile, ADDRESS_AMMO_9MM);
                        i_AMMO_Shock = ConvertAndLoad(fsFile, ADDRESS_AMMO_SHOCK); if (i_AMMO_Shock < 1) i_AMMO_Shock = 1;
                        i_AMMO_SAW = ConvertAndLoad(fsFile, ADDRESS_AMMO_SAW);
                        i_AMMO_Sniper = ConvertAndLoad(fsFile, ADDRESS_AMMO_SNIPER);
                        i_AMMO_ARGrenade = ConvertAndLoad(fsFile, ADDRESS_AMMO_ARGRENADE);
                        i_AMMO_Flame = ConvertAndLoad(fsFile, ADDRESS_AMMO_FLAME);
                        i_AMMO_Minigun = ConvertAndLoad(fsFile, ADDRESS_AMMO_MINIGUN);
                        i_AMMO_357 = ConvertAndLoad(fsFile, ADDRESS_AMMO_PYTHON);
                        i_AMMO_Gauss = ConvertAndLoad(fsFile, ADDRESS_AMMO_GAUSS);
                        i_AMMO_RPG = ConvertAndLoad(fsFile, ADDRESS_AMMO_RPG);
                        i_AMMO_Crossbow = ConvertAndLoad(fsFile, ADDRESS_AMMO_CROSSBOW);
                        i_AMMO_Tripmine = ConvertAndLoad(fsFile, ADDRESS_AMMO_TRIPMINE);
                        i_AMMO_Satchel = ConvertAndLoad(fsFile, ADDRESS_AMMO_SATCHEL);
                        i_AMMO_Grenade = ConvertAndLoad(fsFile, ADDRESS_AMMO_HANDGRENADE);
                        i_AMMO_GLauncher = ConvertAndLoad(fsFile, ADDRESS_AMMO_GRENADELAUNCHER);

                        // Powers
                        i_POWER_First = ConvertAndLoad(fsFile, ADDRESS_POWERS_FIRST);
                        i_POWER_Second = ConvertAndLoad(fsFile, ADDRESS_POWERS_SECOND);
                        i_POWER_Third = ConvertAndLoad(fsFile, ADDRESS_POWERS_THIRD);
                        i_POWER_Fourth = ConvertAndLoad(fsFile, ADDRESS_POWERS_FOURTH);

                        // Controls
                        comboMode.Enabled = true;
                        comboClass.Enabled = true;
                        boxWave.Enabled = true;
                        boxLegerity.Enabled = true;
                        boxPrecision.Enabled = true;
                        boxToughness.Enabled = true;
                        boxSorcery.Enabled = true;
                        boxAP.Enabled = true;
                        boxKills.Enabled = true;
                        boxMoney.Enabled = true;
                        boxSalvage.Enabled = true;
                        boxSouls.Enabled = true;
                        boxHPKits.Enabled = true;
                        boxMPKits.Enabled = true;
                        boxXP.Enabled = true;
                        boxLevel.Enabled = true;
                        checkLJ.Enabled = true;
                        buttonWeapons.Enabled = true;
                        buttonTasks.Enabled = true;
                        buttonInventory.Enabled = true;
                        buttonUpgrades.Enabled = true;
                        buttonSkills.Enabled = true;
                        buttonSave.Enabled = true;
                    }
                    else
                    {
                        comboMode.Enabled = false;
                        comboClass.Enabled = false;
                        boxWave.Enabled = false;
                        boxLegerity.Enabled = false;
                        boxPrecision.Enabled = false;
                        boxToughness.Enabled = false;
                        boxSorcery.Enabled = false;
                        boxAP.Enabled = false;
                        boxKills.Enabled = false;
                        boxMoney.Enabled = false;
                        boxSalvage.Enabled = false;
                        boxSouls.Enabled = false;
                        boxHPKits.Enabled = false;
                        boxMPKits.Enabled = false;
                        boxXP.Enabled = false;
                        boxLevel.Enabled = false;
                        checkLJ.Enabled = false;
                        buttonWeapons.Enabled = false;
                        buttonTasks.Enabled = false;
                        buttonInventory.Enabled = false;
                        buttonUpgrades.Enabled = false;
                        buttonSkills.Enabled = false;
                        buttonSave.Enabled = false;

                        labelFile.Text = "No file opened";
                        labelMapName.Text = "Map: ";
                        MessageBox.Show("Invalid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception error)
            {
                comboMode.Enabled = false;
                comboClass.Enabled = false;
                boxWave.Enabled = false;
                boxLegerity.Enabled = false;
                boxPrecision.Enabled = false;
                boxToughness.Enabled = false;
                boxSorcery.Enabled = false;
                boxAP.Enabled = false;
                boxKills.Enabled = false;
                boxMoney.Enabled = false;
                boxSalvage.Enabled = false;
                boxSouls.Enabled = false;
                boxHPKits.Enabled = false;
                boxMPKits.Enabled = false;
                boxXP.Enabled = false;
                boxLevel.Enabled = false;
                checkLJ.Enabled = false;
                buttonWeapons.Enabled = false;
                buttonTasks.Enabled = false;
                buttonInventory.Enabled = false;
                buttonUpgrades.Enabled = false;
                buttonSkills.Enabled = false;
                buttonSave.Enabled = false;

                MessageBox.Show("Unable to load file.\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int XPToLevel(int iXP)
        {
            // Can't use array methods, iterate through the array. Slow!
            int index;
            for (index = 0; index < arrXPLevels.Length; index++)
            {
                if (arrXPLevels[index] >= iXP)
                    break; // This is the player's current level
            }
            return index + 1;
        }

        public void UpdateUpgradesContextItems()
        {
            cmu1_Meele.Enabled = false;
            cmu1_Axe.Enabled = false;
            cmu2_Pistol.Enabled = false;
            cmu2_Blaster.Enabled = false;
            cmu2_Python.Enabled = false;
            cmu2_Akimbo.Enabled = false;
            cmu3_SMG.Enabled = false;
            cmu3_Shotgun.Enabled = false;
            cmu3_Crossbow.Enabled = false;
            cmu3_ARifle.Enabled = false;
            cmu3_SAW.Enabled = false;
            cmu3_Sniper.Enabled = false;
            cmu4_RPGLauncher.Enabled = false;
            cmu4_Gauss.Enabled = false;
            cmu4_SRifle.Enabled = false;
            cmu4_GrenadeLauncher.Enabled = false;
            cmu4_Minigun.Enabled = false;
            
            if (b_WPN_Melee) cmu1_Meele.Enabled = true;
            if (b_WPN_Axe) cmu1_Axe.Enabled = true;
            if (b_WPN_Pistol) cmu2_Pistol.Enabled = true;
            if (b_WPN_Blaster) cmu2_Blaster.Enabled = true;
            if (b_WPN_357) cmu2_Python.Enabled = true;
            if (b_WPN_Akimbo) cmu2_Akimbo.Enabled = true;
            if (b_WPN_MP5) cmu3_SMG.Enabled = true;
            if (b_WPN_Shotgun) cmu3_Shotgun.Enabled = true;
            if (b_WPN_Crossbow) cmu3_Crossbow.Enabled = true;
            if (b_WPN_Assault) cmu3_ARifle.Enabled = true;
            if (b_WPN_SAW) cmu3_SAW.Enabled = true;
            if (b_WPN_Sniper) cmu3_Sniper.Enabled = true;
            if (b_WPN_RPG) cmu4_RPGLauncher.Enabled = true;
            if (b_WPN_Gauss) cmu4_Gauss.Enabled = true;
            if (b_WPN_Shock) cmu4_SRifle.Enabled = true;
            if (b_WPN_GL) cmu4_GrenadeLauncher.Enabled = true;
            if (b_WPN_Minigun) cmu4_Minigun.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (boxXP.Value == boxXP.Maximum)
            {
                DialogResult drWarning;
                drWarning = MessageBox.Show("Total XP value exceeds game's maximum!\nThe game WILL FREEZE as soon as it reads the save file contents.\nSave anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (drWarning == DialogResult.No)
                    return;
            }

            string szFilePath = openFileDialog.FileName;

            try
            {
                using (FileStream fsFile = File.OpenWrite(szFilePath))
                {
                    int iData = 0;
                    uint uiData = 0;

                    // Gamemode
                    ConvertAndSave(fsFile, ADDRESS_GAMEMODE, comboMode.SelectedIndex + 1);

                    // Class
                    ConvertAndSave(fsFile, ADDRESS_CLASS, comboClass.SelectedIndex + 1);

                    // Wave
                    ConvertAndSave(fsFile, ADDRESS_WAVE, (int)boxWave.Value);

                    // Legerity
                    ConvertAndSave(fsFile, ADDRESS_LEGERITY, (int)boxLegerity.Value);

                    // Precision
                    ConvertAndSave(fsFile, ADDRESS_PRECISION, (int)boxPrecision.Value);

                    // Toughness
                    ConvertAndSave(fsFile, ADDRESS_TOUGHNESS, (int)boxToughness.Value);

                    // Sorcery
                    ConvertAndSave(fsFile, ADDRESS_SORCERY, (int)boxSorcery.Value);

                    // Ability Points
                    ConvertAndSave(fsFile, ADDRESS_AP, (int)boxAP.Value);

                    // Kills
                    ConvertAndSave(fsFile, ADDRESS_KILLS, (int)boxKills.Value);

                    // Money
                    ConvertAndSave(fsFile, ADDRESS_MONEY, (int)boxMoney.Value);

                    // Salvage
                    ConvertAndSave(fsFile, ADDRESS_SALVAGE, (int)boxSalvage.Value);

                    // Souls
                    ConvertAndSave(fsFile, ADDRESS_SOULS, (int)boxSouls.Value);

                    // Health Kits
                    ConvertAndSave(fsFile, ADDRESS_HPKITS, (int)boxHPKits.Value);

                    // Mana Kits
                    ConvertAndSave(fsFile, ADDRESS_MPKITS, (int)boxMPKits.Value);

                    // Total Experience
                    ConvertAndSave(fsFile, ADDRESS_XP, (int)boxXP.Value);

                    // Long Jump
                    ConvertAndSave(fsFile, ADDRESS_LONGJUMP, Convert.ToInt32(checkLJ.Checked));

                    // Weapons
                    if (b_WPN_Melee) uiData += W_MELEE;
                    if (b_WPN_Axe) uiData += W_AXE;
                    if (b_WPN_Pistol) uiData += W_PISTOL;
                    if (b_WPN_Blaster) uiData += W_BLASTER;
                    if (b_WPN_357) uiData += W_357;
                    if (b_WPN_Akimbo) uiData += W_AKIMBO;
                    if (b_WPN_MP5) uiData += W_MP5;
                    if (b_WPN_Shotgun) uiData += W_SHOTGUN;
                    if (b_WPN_Crossbow) uiData += W_CROSSBOW;
                    if (b_WPN_Assault) uiData += W_ASSAULT;
                    if (b_WPN_SAW) uiData += W_SAW;
                    if (b_WPN_Sniper) uiData += W_SNIPER;
                    if (b_WPN_RPG) uiData += W_RPG;
                    if (b_WPN_Gauss) uiData += W_GAUSS;
                    if (b_WPN_Shock) uiData += W_SHOCK;
                    if (b_WPN_GL) uiData += W_GL;
                    if (b_WPN_Flame) uiData += W_FLAME;
                    if (b_WPN_Minigun) uiData += W_MINIGUN;
                    if (i_AMMO_Tripmine > 0) uiData += W_TRIPMINE;
                    if (i_AMMO_Satchel > 0) uiData += W_SATCHEL;
                    if (i_AMMO_Grenade > 0) uiData += W_HANDGRENADE;
                    iData = Convert.ToInt32(uiData);
                    iData += (1 << 22); // W_GESTURES
                    if (b_WPN_Suit) iData += (1 << 31); // W_SUIT
                    ConvertAndSave(fsFile, ADDRESS_WEAPONS, iData);

                    // Tasks
                    ConvertAndSave(fsFile, ADDRESS_TASK_NUMBER, i_TASK_Number); // Task number
                    ConvertAndSave(fsFile, ADDRESS_TASK_TYPE, i_TASK_Type + 1); // Task type
                    ConvertAndSave(fsFile, ADDRESS_TASK_REMAIN, i_TASK_Remain); // Task remain
                    ConvertAndSave(fsFile, ADDRESS_TASK_EVENT, i_TASK_Event); // Event task

                    // Inventory
                    ConvertAndSave(fsFile, ADDRESS_HELMET_COLOR, i_HELMET_Color); // Helmet
                    ConvertAndSave(fsFile, ADDRESS_HELMET_ITEMID, i_HELMET_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_HELMET_DEFENSE, i_HELMET_Defense);
                    ConvertAndSave(fsFile, ADDRESS_HELMET_ATTRIBUTE, i_HELMET_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_HELMET_UPGRADES, i_HELMET_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_ARMOR_COLOR, i_ARMOR_Color); // Armor
                    ConvertAndSave(fsFile, ADDRESS_ARMOR_ITEMID, i_ARMOR_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ARMOR_DEFENSE, i_ARMOR_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ARMOR_ATTRIBUTE, i_ARMOR_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ARMOR_UPGRADES, i_ARMOR_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_TRINKET_COLOR, i_TRINKET_Color); // Trinket
                    ConvertAndSave(fsFile, ADDRESS_TRINKET_ITEMID, i_TRINKET_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_TRINKET_ATTRIBUTE, i_TRINKET_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_TRINKET_UPGRADES, i_TRINKET_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_GEM_COLOR, i_GEM_Color); // Gem
                    ConvertAndSave(fsFile, ADDRESS_GEM_ITEMID, i_GEM_ItemID);

                    ConvertAndSave(fsFile, ADDRESS_ITEM1_COLOR, i_ITEM1_Color); // Bag Slot 1
                    ConvertAndSave(fsFile, ADDRESS_ITEM1_ITEMID, i_ITEM1_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ITEM1_DEFENSE, i_ITEM1_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ITEM1_ATTRIBUTE, i_ITEM1_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ITEM1_UPGRADES, i_ITEM1_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_ITEM2_COLOR, i_ITEM2_Color); // Bag Slot 2
                    ConvertAndSave(fsFile, ADDRESS_ITEM2_ITEMID, i_ITEM2_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ITEM2_DEFENSE, i_ITEM2_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ITEM2_ATTRIBUTE, i_ITEM2_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ITEM2_UPGRADES, i_ITEM2_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_ITEM3_COLOR, i_ITEM3_Color); // Bag Slot 3
                    ConvertAndSave(fsFile, ADDRESS_ITEM3_ITEMID, i_ITEM3_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ITEM3_DEFENSE, i_ITEM3_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ITEM3_ATTRIBUTE, i_ITEM3_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ITEM3_UPGRADES, i_ITEM3_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_ITEM4_COLOR, i_ITEM4_Color); // Bag Slot 4
                    ConvertAndSave(fsFile, ADDRESS_ITEM4_ITEMID, i_ITEM4_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ITEM4_DEFENSE, i_ITEM4_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ITEM4_ATTRIBUTE, i_ITEM4_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ITEM4_UPGRADES, i_ITEM4_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_ITEM5_COLOR, i_ITEM5_Color); // Bag Slot 5
                    ConvertAndSave(fsFile, ADDRESS_ITEM5_ITEMID, i_ITEM5_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ITEM5_DEFENSE, i_ITEM5_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ITEM5_ATTRIBUTE, i_ITEM5_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ITEM5_UPGRADES, i_ITEM5_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_ITEM6_COLOR, i_ITEM6_Color); // Bag Slot 6
                    ConvertAndSave(fsFile, ADDRESS_ITEM6_ITEMID, i_ITEM6_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ITEM6_DEFENSE, i_ITEM6_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ITEM6_ATTRIBUTE, i_ITEM6_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ITEM6_UPGRADES, i_ITEM6_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_ITEM7_COLOR, i_ITEM7_Color); // Bag Slot 7
                    ConvertAndSave(fsFile, ADDRESS_ITEM7_ITEMID, i_ITEM7_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ITEM7_DEFENSE, i_ITEM7_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ITEM7_ATTRIBUTE, i_ITEM7_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ITEM7_UPGRADES, i_ITEM7_Upgrades);

                    ConvertAndSave(fsFile, ADDRESS_ITEM8_COLOR, i_ITEM8_Color); // Bag Slot 8
                    ConvertAndSave(fsFile, ADDRESS_ITEM8_ITEMID, i_ITEM8_ItemID);
                    ConvertAndSave(fsFile, ADDRESS_ITEM8_DEFENSE, i_ITEM8_Defense);
                    ConvertAndSave(fsFile, ADDRESS_ITEM8_ATTRIBUTE, i_ITEM8_Attribute);
                    ConvertAndSave(fsFile, ADDRESS_ITEM8_UPGRADES, i_ITEM8_Upgrades);

                    // Weapon Upgrades
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_MEELE_DAMAGE, i_UPGRADE_MEELE_Damage); // Meele
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_MEELE_RATE, i_UPGRADE_MEELE_RateOfFire);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_AXE_SLOTS, i_UPGRADE_AXE_Slots); // Ancient Axe
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_AXE_DAMAGE, i_UPGRADE_AXE_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_AXE_RATE, i_UPGRADE_AXE_RateOfFire);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PISTOL_SLOTS, i_UPGRADE_PISTOL_Slots); // Pistol
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PISTOL_DAMAGE, i_UPGRADE_PISTOL_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PISTOL_RATE, i_UPGRADE_PISTOL_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PISTOL_AMMO, i_UPGRADE_PISTOL_Ammo);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PISTOL_UNIQUE, i_UPGRADE_PISTOL_Unique);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_BLASTER_SLOTS, i_UPGRADE_BLASTER_Slots); // Blaster
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_BLASTER_DAMAGE, i_UPGRADE_BLASTER_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_BLASTER_RATE, i_UPGRADE_BLASTER_RateOfFire);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PYTHON_SLOTS, i_UPGRADE_PYTHON_Slots); // Python
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PYTHON_DAMAGE, i_UPGRADE_PYTHON_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PYTHON_RATE, i_UPGRADE_PYTHON_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PYTHON_AMMO, i_UPGRADE_PYTHON_Ammo);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_PYTHON_UNIQUE, i_UPGRADE_PYTHON_Unique);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_AKIMBO_SLOTS, i_UPGRADE_AKIMBO_Slots); // Akimbo
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_AKIMBO_DAMAGE, i_UPGRADE_AKIMBO_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_AKIMBO_RATE, i_UPGRADE_AKIMBO_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_AKIMBO_AMMO, i_UPGRADE_AKIMBO_Ammo);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_AKIMBO_UNIQUE, i_UPGRADE_AKIMBO_Unique);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SMG_SLOTS, i_UPGRADE_SMG_Slots); // Submachine Gun
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SMG_DAMAGE, i_UPGRADE_SMG_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SMG_RATE, i_UPGRADE_SMG_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SMG_AMMO, i_UPGRADE_SMG_Ammo);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SHOTGUN_SLOTS, i_UPGRADE_SHOTGUN_Slots); // Shotgun
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SHOTGUN_DAMAGE, i_UPGRADE_SHOTGUN_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SHOTGUN_RATE, i_UPGRADE_SHOTGUN_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SHOTGUN_AMMO, i_UPGRADE_SHOTGUN_Ammo);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SHOTGUN_UNIQUE, i_UPGRADE_SHOTGUN_Unique);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_CROSSBOW_SLOTS, i_UPGRADE_CROSSBOW_Slots); // Crossbow
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_CROSSBOW_DAMAGE, i_UPGRADE_CROSSBOW_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_CROSSBOW_RATE, i_UPGRADE_CROSSBOW_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_CROSSBOW_AMMO, i_UPGRADE_CROSSBOW_Ammo);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_CROSSBOW_UNIQUE, i_UPGRADE_CROSSBOW_Unique);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_ASSAULT_SLOTS, i_UPGRADE_ASSAULT_Slots); // Assault Rifle
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_ASSAULT_DAMAGE, i_UPGRADE_ASSAULT_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_ASSAULT_RATE, i_UPGRADE_ASSAULT_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_ASSAULT_AMMO, i_UPGRADE_ASSAULT_Ammo);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SAW_SLOTS, i_UPGRADE_SAW_Slots); // SAW
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SAW_DAMAGE, i_UPGRADE_SAW_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SAW_RATE, i_UPGRADE_SAW_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SAW_AMMO, i_UPGRADE_SAW_Ammo);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SNIPER_SLOTS, i_UPGRADE_SNIPER_Slots); // Sniper Rifle
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SNIPER_DAMAGE, i_UPGRADE_SNIPER_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SNIPER_RATE, i_UPGRADE_SNIPER_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SNIPER_AMMO, i_UPGRADE_SNIPER_Ammo);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_RPG_SLOTS, i_UPGRADE_RPG_Slots); // RPG
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_RPG_DAMAGE, i_UPGRADE_RPG_Damage);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_GAUSS_SLOTS, i_UPGRADE_GAUSS_Slots); // Gauss Rifle
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_GAUSS_DAMAGE, i_UPGRADE_GAUSS_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_GAUSS_RATE, i_UPGRADE_GAUSS_RateOfFire);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_SHOCK_RATE, i_UPGRADE_SHOCK_RateOfFire); // Shock Rifle

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_GRENADE_SLOTS, i_UPGRADE_GRENADE_Slots); // Grenade Launcher
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_GRENADE_RATE, i_UPGRADE_GRENADE_RateOfFire);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_GRENADE_AMMO, i_UPGRADE_GRENADE_Ammo);

                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_MINIGUN_SLOTS, i_UPGRADE_MINIGUN_Slots); // Minigun
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_MINIGUN_DAMAGE, i_UPGRADE_MINIGUN_Damage);
                    ConvertAndSave(fsFile, ADDRESS_UPGRADE_MINIGUN_RATE, i_UPGRADE_MINIGUN_RateOfFire);

                    // Ammo
                    ConvertAndSave(fsFile, ADDRESS_AMMO_BUCKSHOT, i_AMMO_Shotgun);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_9MM, i_AMMO_9mm);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_SHOCK, i_AMMO_Shock);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_SAW, i_AMMO_SAW);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_SNIPER, i_AMMO_Sniper);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_ARGRENADE, i_AMMO_ARGrenade);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_FLAME, i_AMMO_Flame);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_MINIGUN, i_AMMO_Minigun);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_PYTHON, i_AMMO_357);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_GAUSS, i_AMMO_Gauss);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_RPG, i_AMMO_RPG);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_CROSSBOW, i_AMMO_Crossbow);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_TRIPMINE, i_AMMO_Tripmine);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_SATCHEL, i_AMMO_Satchel);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_HANDGRENADE, i_AMMO_Grenade);
                    ConvertAndSave(fsFile, ADDRESS_AMMO_GRENADELAUNCHER, i_AMMO_GLauncher);

                    // Powers
                    ConvertAndSave(fsFile, ADDRESS_POWERS_FIRST, i_POWER_First);
                    ConvertAndSave(fsFile, ADDRESS_POWERS_SECOND, i_POWER_Second);
                    ConvertAndSave(fsFile, ADDRESS_POWERS_THIRD, i_POWER_Third);
                    ConvertAndSave(fsFile, ADDRESS_POWERS_FOURTH, i_POWER_Fourth);

                    // End
                    MessageBox.Show("Save file updated.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Unable to save file.\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Let us not repeat these lines everywhere eh?
        private int ConvertAndLoad(FileStream fsFile, int iAddress)
        {
            byte[] bData = new byte[4];
            fsFile.Seek(iAddress, SeekOrigin.Begin);
            fsFile.Read(bData, 0, bData.Length);
            return BitConverter.ToInt32(bData, 0);
        }
        private void ConvertAndSave(FileStream fsFile, int iAddress, int iData)
        {
            fsFile.Seek(iAddress, SeekOrigin.Begin);
            fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
            fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
            fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
            fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
        }

        private void buttonWeapons_Click(object sender, EventArgs e)
        {
            weaponForm.ShowDialog();
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            taskForm.ShowDialog();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            contextMenuInventory.Show(MousePosition);
        }

        private void tsmHelmet_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Equipped Helmet";
            inventoryForm.InitHelmetMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmArmor_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Equipped Armor";
            inventoryForm.InitArmorMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmTrinket_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Equipped Trinket";
            inventoryForm.InitTrinketMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmGem_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Socketed Gem";
            inventoryForm.InitGemMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmSlot1_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Bag: Slot 1";
            inventoryForm.InitItemMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmSlot2_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Bag: Slot 2";
            inventoryForm.InitItemMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmSlot3_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Bag: Slot 3";
            inventoryForm.InitItemMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmSlot4_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Bag: Slot 4";
            inventoryForm.InitItemMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmSlot5_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Bag: Slot 5";
            inventoryForm.InitItemMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmSlot6_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Bag: Slot 6";
            inventoryForm.InitItemMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmSlot7_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Bag: Slot 7";
            inventoryForm.InitItemMenu();
            inventoryForm.ShowDialog();
        }

        private void tsmSlot8_Click(object sender, EventArgs e)
        {
            inventoryForm.Text = "Bag: Slot 8";
            inventoryForm.InitItemMenu();
            inventoryForm.ShowDialog();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void boxLevel_Leave(object sender, EventArgs e)
        {
            boxXP.Value = arrXPLevels[Convert.ToInt32(boxLevel.Value) - 1];
        }

        private void boxXP_Leave(object sender, EventArgs e)
        {
            boxLevel.Value = XPToLevel(Convert.ToInt32(boxXP.Value));
        }

        private void buttonUpgrades_Click(object sender, EventArgs e)
        {
            contextMenuUpgrades.Show(MousePosition);
        }

        private void cmu1_Meele_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Meele";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.MEELE);
            upgradesForm.ShowDialog();
        }

        private void cmu1_Axe_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Ancient Axe";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.AXE);
            upgradesForm.ShowDialog();
        }

        private void cmu2_Pistol_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Pistol";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.PISTOL);
            upgradesForm.ShowDialog();
        }

        private void cmu2_Blaster_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Blaster";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.BLASTER);
            upgradesForm.ShowDialog();
        }

        private void cmu2_Python_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Python";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.PYTHON);
            upgradesForm.ShowDialog();
        }

        private void cmu2_Akimbo_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Akimbo";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.AKIMBO);
            upgradesForm.ShowDialog();
        }

        private void cmu3_SMG_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Submachine Gun";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.SMG);
            upgradesForm.ShowDialog();
        }

        private void cmu3_Shotgun_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Shotgun";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.SHOTGUN);
            upgradesForm.ShowDialog();
        }

        private void cmu3_Crossbow_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Crossbow";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.CROSSBOW);
            upgradesForm.ShowDialog();
        }

        private void cmu3_ARifle_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Assault Rifle";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.ASSAULT);
            upgradesForm.ShowDialog();
        }

        private void cmu3_SAW_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Squad Automatic Weapon";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.SAW);
            upgradesForm.ShowDialog();
        }

        private void cmu3_Sniper_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Sniper Rifle";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.SNIPER);
            upgradesForm.ShowDialog();
        }

        private void cmu4_RPGLauncher_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Rocket-Propelled Grenade";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.ROCKET);
            upgradesForm.ShowDialog();
        }

        private void cmu4_Gauss_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Gauss Rifle";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.GAUSS);
            upgradesForm.ShowDialog();
        }

        private void cmu4_SRifle_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Shock Rifle";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.SHOCK);
            upgradesForm.ShowDialog();
        }

        private void cmu4_GrenadeLauncher_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Grenade Launcher";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.GRENADE);
            upgradesForm.ShowDialog();
        }

        private void cmu4_Minigun_Click(object sender, EventArgs e)
        {
            upgradesForm.Text = "Minigun";
            upgradesForm.InitUpgradeMenu(UpgradesForm.e_Selector.MINIGUN);
            upgradesForm.ShowDialog();
        }

        private void buttonSkills_Click(object sender, EventArgs e)
        {
            powersForm.ShowDialog();
        }
    }
}
