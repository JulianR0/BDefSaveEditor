using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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
        const uint W_SUIT = 0x80000000; // (1 << 31)

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

        Form2 weaponForm;
        Form3 taskForm;
        Form4 inventoryForm;

        public Main()
        {
            InitializeComponent();
            weaponForm = new Form2(this);
            taskForm = new Form3(this);
            inventoryForm = new Form4(this);
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
                        fsFile.Seek(ADDRESS_GAMEMODE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        comboMode.SelectedIndex = iData - 1;

                        // Class
                        fsFile.Seek(ADDRESS_CLASS, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        comboClass.SelectedIndex = iData - 1;

                        // Wave
                        fsFile.Seek(ADDRESS_WAVE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxWave.Value = iData;

                        // Legerity
                        fsFile.Seek(ADDRESS_LEGERITY, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxLegerity.Value = iData;

                        // Precision
                        fsFile.Seek(ADDRESS_PRECISION, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxPrecision.Value = iData;

                        // Toughness
                        fsFile.Seek(ADDRESS_TOUGHNESS, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxToughness.Value = iData;

                        // Sorcery
                        fsFile.Seek(ADDRESS_SORCERY, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxSorcery.Value = iData;

                        // Ability Points
                        fsFile.Seek(ADDRESS_AP, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxAP.Value = iData;

                        // Kills
                        fsFile.Seek(ADDRESS_KILLS, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxKills.Value = iData;

                        // Money
                        fsFile.Seek(ADDRESS_MONEY, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxMoney.Value = iData;

                        // Salvage
                        fsFile.Seek(ADDRESS_SALVAGE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxSalvage.Value = iData;

                        // Souls
                        fsFile.Seek(ADDRESS_SOULS, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxSouls.Value = iData;

                        // Health Kits
                        fsFile.Seek(ADDRESS_HPKITS, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxHPKits.Value = iData;

                        // Mana Kits
                        fsFile.Seek(ADDRESS_MPKITS, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxMPKits.Value = iData;

                        // Total Experience
                        fsFile.Seek(ADDRESS_XP, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        boxXP.Value = iData;

                        // Long Jump
                        fsFile.Seek(ADDRESS_LONGJUMP, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        checkLJ.Checked = Convert.ToBoolean(iData);

                        // Weapons
                        fsFile.Seek(ADDRESS_WEAPONS, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        uint uiData = BitConverter.ToUInt32(bData, 0);
                        uiCheck = uiData; if ((uiCheck &= W_MELEE) == W_MELEE) b_WPN_Melee = true;
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
                        fsFile.Seek(ADDRESS_TASK_NUMBER, SeekOrigin.Begin); // Task number
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_TASK_Number = iData;
                        fsFile.Seek(ADDRESS_TASK_TYPE, SeekOrigin.Begin); // Task type
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_TASK_Type = iData - 1;
                        fsFile.Seek(ADDRESS_TASK_REMAIN, SeekOrigin.Begin); // Task remain
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_TASK_Remain = iData;
                        fsFile.Seek(ADDRESS_TASK_EVENT, SeekOrigin.Begin); // Event task
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_TASK_Event = iData;

                        // Inventory
                        fsFile.Seek(ADDRESS_HELMET_COLOR, SeekOrigin.Begin); // Helmet
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_HELMET_Color = iData;
                        fsFile.Seek(ADDRESS_HELMET_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_HELMET_ItemID = iData;
                        fsFile.Seek(ADDRESS_HELMET_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_HELMET_Defense = iData;
                        fsFile.Seek(ADDRESS_HELMET_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_HELMET_Attribute = iData;
                        fsFile.Seek(ADDRESS_HELMET_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_HELMET_Upgrades = iData;
                        fsFile.Seek(ADDRESS_ARMOR_COLOR, SeekOrigin.Begin); // Armor
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ARMOR_Color = iData;
                        fsFile.Seek(ADDRESS_ARMOR_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ARMOR_ItemID = iData;
                        fsFile.Seek(ADDRESS_ARMOR_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ARMOR_Defense = iData;
                        fsFile.Seek(ADDRESS_ARMOR_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ARMOR_Attribute = iData;
                        fsFile.Seek(ADDRESS_ARMOR_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ARMOR_Upgrades = iData;
                        fsFile.Seek(ADDRESS_TRINKET_COLOR, SeekOrigin.Begin); // Trinket
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_TRINKET_Color = iData;
                        fsFile.Seek(ADDRESS_TRINKET_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_TRINKET_ItemID = iData;
                        fsFile.Seek(ADDRESS_TRINKET_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_TRINKET_Attribute = iData;
                        fsFile.Seek(ADDRESS_TRINKET_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_TRINKET_Upgrades = iData;
                        fsFile.Seek(ADDRESS_GEM_COLOR, SeekOrigin.Begin); // Gem
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_GEM_Color = iData;
                        fsFile.Seek(ADDRESS_GEM_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_GEM_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM1_COLOR, SeekOrigin.Begin); // Bag Slot 1
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM1_Color = iData;
                        fsFile.Seek(ADDRESS_ITEM1_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM1_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM1_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM1_Defense = iData;
                        fsFile.Seek(ADDRESS_ITEM1_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM1_Attribute = iData;
                        fsFile.Seek(ADDRESS_ITEM1_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM1_Upgrades = iData;
                        fsFile.Seek(ADDRESS_ITEM2_COLOR, SeekOrigin.Begin); // Bag Slot 2
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM2_Color = iData;
                        fsFile.Seek(ADDRESS_ITEM2_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM2_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM2_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM2_Defense = iData;
                        fsFile.Seek(ADDRESS_ITEM2_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM2_Attribute = iData;
                        fsFile.Seek(ADDRESS_ITEM2_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM2_Upgrades = iData;
                        fsFile.Seek(ADDRESS_ITEM3_COLOR, SeekOrigin.Begin); // Bag Slot 3
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM3_Color = iData;
                        fsFile.Seek(ADDRESS_ITEM3_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM3_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM3_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM3_Defense = iData;
                        fsFile.Seek(ADDRESS_ITEM3_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM3_Attribute = iData;
                        fsFile.Seek(ADDRESS_ITEM3_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM3_Upgrades = iData;
                        fsFile.Seek(ADDRESS_ITEM4_COLOR, SeekOrigin.Begin); // Bag Slot 4
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM4_Color = iData;
                        fsFile.Seek(ADDRESS_ITEM4_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM4_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM4_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM4_Defense = iData;
                        fsFile.Seek(ADDRESS_ITEM4_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM4_Attribute = iData;
                        fsFile.Seek(ADDRESS_ITEM4_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM4_Upgrades = iData;
                        fsFile.Seek(ADDRESS_ITEM5_COLOR, SeekOrigin.Begin); // Bag Slot 5
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM5_Color = iData;
                        fsFile.Seek(ADDRESS_ITEM5_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM5_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM5_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM5_Defense = iData;
                        fsFile.Seek(ADDRESS_ITEM5_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM5_Attribute = iData;
                        fsFile.Seek(ADDRESS_ITEM5_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM5_Upgrades = iData;
                        fsFile.Seek(ADDRESS_ITEM6_COLOR, SeekOrigin.Begin); // Bag Slot 6
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM6_Color = iData;
                        fsFile.Seek(ADDRESS_ITEM6_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM6_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM6_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM6_Defense = iData;
                        fsFile.Seek(ADDRESS_ITEM6_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM6_Attribute = iData;
                        fsFile.Seek(ADDRESS_ITEM6_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM6_Upgrades = iData;
                        fsFile.Seek(ADDRESS_ITEM7_COLOR, SeekOrigin.Begin); // Bag Slot 7
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM7_Color = iData;
                        fsFile.Seek(ADDRESS_ITEM7_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM7_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM7_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM7_Defense = iData;
                        fsFile.Seek(ADDRESS_ITEM7_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM7_Attribute = iData;
                        fsFile.Seek(ADDRESS_ITEM7_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM7_Upgrades = iData;
                        fsFile.Seek(ADDRESS_ITEM8_COLOR, SeekOrigin.Begin); // Bag Slot 8
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM8_Color = iData;
                        fsFile.Seek(ADDRESS_ITEM8_ITEMID, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM8_ItemID = iData;
                        fsFile.Seek(ADDRESS_ITEM8_DEFENSE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM8_Defense = iData;
                        fsFile.Seek(ADDRESS_ITEM8_ATTRIBUTE, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM8_Attribute = iData;
                        fsFile.Seek(ADDRESS_ITEM8_UPGRADES, SeekOrigin.Begin);
                        fsFile.Read(bData, 0, bData.Length);
                        iData = BitConverter.ToInt32(bData, 0);
                        i_ITEM8_Upgrades = iData;
                        UpdateInventoryMenu();

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
                        checkLJ.Enabled = true;
                        buttonWeapons.Enabled = true;
                        buttonTasks.Enabled = true;
                        buttonInventory.Enabled = true;
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
                        checkLJ.Enabled = false;
                        buttonWeapons.Enabled = false;
                        buttonTasks.Enabled = false;
                        buttonInventory.Enabled = false;
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
                checkLJ.Enabled = false;
                buttonWeapons.Enabled = false;
                buttonTasks.Enabled = false;
                buttonInventory.Enabled = false;
                buttonSave.Enabled = false;

                MessageBox.Show("Unable to load file.\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (boxXP.Value == boxXP.Maximum)
            {
                DialogResult drWarning;
                drWarning = MessageBox.Show("Total XP value exceeds game's maximum!\nThe game WILL FREEZE as soon as the map reads the save file contents.\nSave anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                    fsFile.Seek(ADDRESS_GAMEMODE, SeekOrigin.Begin);
                    iData = comboMode.SelectedIndex + 1;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Class
                    fsFile.Seek(ADDRESS_CLASS, SeekOrigin.Begin);
                    iData = comboClass.SelectedIndex + 1;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Wave
                    fsFile.Seek(ADDRESS_WAVE, SeekOrigin.Begin);
                    iData = (int)boxWave.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Legerity
                    fsFile.Seek(ADDRESS_LEGERITY, SeekOrigin.Begin);
                    iData = (int)boxLegerity.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Precision
                    fsFile.Seek(ADDRESS_PRECISION, SeekOrigin.Begin);
                    iData = (int)boxPrecision.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Toughness
                    fsFile.Seek(ADDRESS_TOUGHNESS, SeekOrigin.Begin);
                    iData = (int)boxToughness.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Sorcery
                    fsFile.Seek(ADDRESS_SORCERY, SeekOrigin.Begin);
                    iData = (int)boxSorcery.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Ability Points
                    fsFile.Seek(ADDRESS_AP, SeekOrigin.Begin);
                    iData = (int)boxAP.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Kills
                    fsFile.Seek(ADDRESS_KILLS, SeekOrigin.Begin);
                    iData = (int)boxKills.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Money
                    fsFile.Seek(ADDRESS_MONEY, SeekOrigin.Begin);
                    iData = (int)boxMoney.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Salvage
                    fsFile.Seek(ADDRESS_SALVAGE, SeekOrigin.Begin);
                    iData = (int)boxSalvage.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Souls
                    fsFile.Seek(ADDRESS_SOULS, SeekOrigin.Begin);
                    iData = (int)boxSouls.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Health Kits
                    fsFile.Seek(ADDRESS_HPKITS, SeekOrigin.Begin);
                    iData = (int)boxHPKits.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Mana Kits
                    fsFile.Seek(ADDRESS_MPKITS, SeekOrigin.Begin);
                    iData = (int)boxMPKits.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Total Experience
                    fsFile.Seek(ADDRESS_XP, SeekOrigin.Begin);
                    iData = (int)boxXP.Value;
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Long Jump
                    fsFile.Seek(ADDRESS_LONGJUMP, SeekOrigin.Begin);
                    iData = Convert.ToInt32(checkLJ.Checked);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Weapons
                    fsFile.Seek(ADDRESS_WEAPONS, SeekOrigin.Begin);
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
                    iData = Convert.ToInt32(uiData);
                    iData += (1 << 22); // W_GESTURES
                    if (b_WPN_Suit) iData += (1 << 31); // W_SUIT
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Tasks
                    fsFile.Seek(ADDRESS_TASK_NUMBER, SeekOrigin.Begin); // Task number
                    iData = i_TASK_Number;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_TASK_TYPE, SeekOrigin.Begin); // Task type
                    iData = i_TASK_Type + 1;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_TASK_REMAIN, SeekOrigin.Begin); // Task remain
                    iData = i_TASK_Remain;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_TASK_EVENT, SeekOrigin.Begin); // Event task
                    iData = i_TASK_Event;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // Inventory
                    fsFile.Seek(ADDRESS_HELMET_COLOR, SeekOrigin.Begin); // Helmet
                    iData = i_HELMET_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_HELMET_ITEMID, SeekOrigin.Begin);
                    iData = i_HELMET_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_HELMET_DEFENSE, SeekOrigin.Begin);
                    iData = i_HELMET_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_HELMET_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_HELMET_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_HELMET_UPGRADES, SeekOrigin.Begin);
                    iData = i_HELMET_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ARMOR_COLOR, SeekOrigin.Begin); // Armor
                    iData = i_ARMOR_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ARMOR_ITEMID, SeekOrigin.Begin);
                    iData = i_ARMOR_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ARMOR_DEFENSE, SeekOrigin.Begin);
                    iData = i_ARMOR_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ARMOR_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ARMOR_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ARMOR_UPGRADES, SeekOrigin.Begin);
                    iData = i_ARMOR_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_TRINKET_COLOR, SeekOrigin.Begin); // Trinket
                    iData = i_TRINKET_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_TRINKET_ITEMID, SeekOrigin.Begin);
                    iData = i_TRINKET_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_TRINKET_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_TRINKET_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_TRINKET_UPGRADES, SeekOrigin.Begin);
                    iData = i_TRINKET_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_GEM_COLOR, SeekOrigin.Begin); // Gem
                    iData = i_GEM_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_GEM_ITEMID, SeekOrigin.Begin);
                    iData = i_GEM_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM1_COLOR, SeekOrigin.Begin); // Bag Slot 1
                    iData = i_ITEM1_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM1_ITEMID, SeekOrigin.Begin);
                    iData = i_ITEM1_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM1_DEFENSE, SeekOrigin.Begin);
                    iData = i_ITEM1_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM1_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ITEM1_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM1_UPGRADES, SeekOrigin.Begin);
                    iData = i_ITEM1_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM2_COLOR, SeekOrigin.Begin); // Bag Slot 2
                    iData = i_ITEM2_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM2_ITEMID, SeekOrigin.Begin);
                    iData = i_ITEM2_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM2_DEFENSE, SeekOrigin.Begin);
                    iData = i_ITEM2_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM2_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ITEM2_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM2_UPGRADES, SeekOrigin.Begin);
                    iData = i_ITEM2_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM3_COLOR, SeekOrigin.Begin); // Bag Slot 3
                    iData = i_ITEM3_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM3_ITEMID, SeekOrigin.Begin);
                    iData = i_ITEM3_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM3_DEFENSE, SeekOrigin.Begin);
                    iData = i_ITEM3_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM3_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ITEM3_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM3_UPGRADES, SeekOrigin.Begin);
                    iData = i_ITEM3_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM4_COLOR, SeekOrigin.Begin); // Bag Slot 4
                    iData = i_ITEM4_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM4_ITEMID, SeekOrigin.Begin);
                    iData = i_ITEM4_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM4_DEFENSE, SeekOrigin.Begin);
                    iData = i_ITEM4_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM4_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ITEM4_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM4_UPGRADES, SeekOrigin.Begin);
                    iData = i_ITEM4_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM5_COLOR, SeekOrigin.Begin); // Bag Slot 5
                    iData = i_ITEM5_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM5_ITEMID, SeekOrigin.Begin);
                    iData = i_ITEM5_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM5_DEFENSE, SeekOrigin.Begin);
                    iData = i_ITEM5_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM5_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ITEM5_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM5_UPGRADES, SeekOrigin.Begin);
                    iData = i_ITEM5_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM6_COLOR, SeekOrigin.Begin); // Bag Slot 6
                    iData = i_ITEM6_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM6_ITEMID, SeekOrigin.Begin);
                    iData = i_ITEM6_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM6_DEFENSE, SeekOrigin.Begin);
                    iData = i_ITEM6_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM6_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ITEM6_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM6_UPGRADES, SeekOrigin.Begin);
                    iData = i_ITEM6_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM7_COLOR, SeekOrigin.Begin); // Bag Slot 7
                    iData = i_ITEM7_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM7_ITEMID, SeekOrigin.Begin);
                    iData = i_ITEM7_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM7_DEFENSE, SeekOrigin.Begin);
                    iData = i_ITEM7_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM7_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ITEM7_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM7_UPGRADES, SeekOrigin.Begin);
                    iData = i_ITEM7_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM8_COLOR, SeekOrigin.Begin); // Bag Slot 8
                    iData = i_ITEM8_Color;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM8_ITEMID, SeekOrigin.Begin);
                    iData = i_ITEM8_ItemID;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM8_DEFENSE, SeekOrigin.Begin);
                    iData = i_ITEM8_Defense;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM8_ATTRIBUTE, SeekOrigin.Begin);
                    iData = i_ITEM8_Attribute;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);
                    fsFile.Seek(ADDRESS_ITEM8_UPGRADES, SeekOrigin.Begin);
                    iData = i_ITEM8_Upgrades;
                    iData = Convert.ToInt32(iData);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[0]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[1]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[2]);
                    fsFile.WriteByte(BitConverter.GetBytes(iData)[3]);

                    // End
                    MessageBox.Show("Save file updated.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Unable to save file.\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Form aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }
    }
}
