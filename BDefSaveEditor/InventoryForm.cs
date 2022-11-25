using System;
using System.Windows.Forms;

namespace BDefSaveEditor
{
    public partial class InventoryForm : Form
    {
        Main mainForm;

        int[] HELMET_IDs =
        {
            0x00,
            0x01,
            0x02,
            0x03,
            0x0A,
            0x0B,
            0x0C,
            0x0D,
            0x0E,
            0x14,
            0x15,
            0x16,
            0x1E,
            0x1F,
            0x20,
            0x21,
            0x22,
            0x23
        };

        int[] HELMET_Colors =
        {
            0, // No item
            0, // White
            0,
            0,
            1, // Blue
            1,
            1,
            1,
            1,
            2, // Green
            2,
            2,
            3, // Brown
            3,
            3,
            3,
            3,
            3
        };

        int[] ARMOR_IDs =
        {
            0x00,
            0x28,
            0x29,
            0x2A,
            0x32,
            0x33,
            0x34,
            0x35,
            0x36,
            0x3C,
            0x3D,
            0x3E,
            0x46,
            0x47,
            0x48,
            0x49,
            0x4A,
            0x4B
        };

        int[] ARMOR_Colors =
        {
            0,
            0,
            0,
            0,
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            3,
            3,
            3,
            3,
            3,
            3
        };

        int[] TRINKET_IDs =
        {
            0x00,
            0x5A,
            0x5B,
            0x5C,
            0x5D,
            0x5E,
            0x64,
            0x65,
            0x66,
            0x6E,
            0x6F,
            0x70,
            0x71,
            0x72,
            0x73,
            0x74
        };

        int[] TRINKET_Colors =
        {
            0,
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            3,
            3,
            3,
            3,
            3,
            3,
            3
        };

        int[] GEM_IDs =
        {
            0x00,
            0x78,
            0x79,
            0x7A,
            0x7B,
            0x7C,
            0x7D
        };

        int[] GEM_Colors =
        {
            0,
            3,
            3,
            3,
            3,
            3,
            3
        };

        int[] ITEM_IDs =
        {
            0x00, // uhh...
            0x01, // Helmets
            0x02,
            0x03,
            0x0A,
            0x0B,
            0x0C,
            0x0D,
            0x0E,
            0x14,
            0x15,
            0x16,
            0x1E,
            0x1F,
            0x20,
            0x21,
            0x22,
            0x23,
            0x28, // Armors
            0x29,
            0x2A,
            0x32,
            0x33,
            0x34,
            0x35,
            0x36,
            0x3C,
            0x3D,
            0x3E,
            0x46,
            0x47,
            0x48,
            0x49,
            0x4A,
            0x4B,
            0x5A, // Trinkets
            0x5B,
            0x5C,
            0x5D,
            0x5E,
            0x64,
            0x65,
            0x66,
            0x6E,
            0x6F,
            0x70,
            0x71,
            0x72,
            0x73,
            0x74,
            0x78, // Gems
            0x79,
            0x7A,
            0x7B,
            0x7C,
            0x7D,
            0x82, // Upgrade Kits
            0x83,
            0x84,
            0x85,
            0x86,
            0x8C, // Charms
            0x8D,
            0x96, // Potions
            0x97,
            0x98,
            0x99,
            0x9A,
            0x9B,
            0x9C
        };

        int[] ITEM_Colors =
        {
            0,
            0,
            0,
            0,
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            3,
            3,
            3,
            3,
            3,
            3,
            0,
            0,
            0,
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            3,
            3,
            3,
            3,
            3,
            3,
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            3,
            0,
            0,
            0,
            0,
            0,
            0
        };

        public InventoryForm(Main link)
        {
            InitializeComponent();
            mainForm = link;
        }

        public void InitHelmetMenu()
        {
            object[] HELMET_Names =
            {
                "None",
                "Metal Helmet",
                "Mithril Cap",
                "Shako",
                "Gold Helmet",
                "Helmet of Knowledge",
                "Helmet of Thrift",
                "Saver's Casque",
                "Medic's Hat",
                "Rainbow Helmet",
                "Sunny Tiara",
                "Defenders Helmet",
                "Gargantua's Delight",
                "Thief Diadem",
                "Demonic Eye",
                "Crown of Throns",
                "Hood of Alucard",
                "Fool's Crest"
            };

            comboItem.Items.Clear();
            comboItem.Items.AddRange(HELMET_Names);
        }

        public void InitArmorMenu()
        {
            object[] ARMOR_Names =
            {
                "None",
                "Leather Armor",
                "Mail Vest",
                "Hardened Armor",
                "Bat Armor",
                "Young Mage Robe",
                "Light Plate",
                "Porcupine Vest",
                "Timberman's Jacket",
                "Rainbow Armor",
                "Sunny Robe",
                "Defenders Hauberk",
                "Vampire Shell",
                "Cuirass of Elder Mage",
                "Alchemist Shroud",
                "Hypochondriac",
                "Juggernaut",
                "Trickster"
            };

            comboItem.Items.Clear();
            comboItem.Items.AddRange(ARMOR_Names);
        }

        public void InitTrinketMenu()
        {
            object[] TRINKET_Names =
            {
                "None",
                "Mage Ring",
                "Bear Amulet",
                "Soldier Ring",
                "Lynx Amulet",
                "Lead Ring",
                "Rainbow Amulet",
                "Sunny Amulet",
                "Defenders Amulet",
                "Knowledge of Wizard",
                "New Chance",
                "Golden Tag",
                "Speed Bracelet",
                "Holy Relic",
                "Blood Drop",
                "Energy Seed"
            };

            comboItem.Items.Clear();
            comboItem.Items.AddRange(TRINKET_Names);
        }

        public void InitGemMenu()
        {
            object[] GEM_Names =
            {
                "None",
                "Ruby",
                "Emerald",
                "Sapphire",
                "Topaz",
                "Amber",
                "Aquamarine"
            };

            comboItem.Items.Clear();
            comboItem.Items.AddRange(GEM_Names);
        }

        public void InitItemMenu()
        {
            object[] ALLITEMS_Names =
            {
                "None",
                "Metal Helmet",
                "Mithril Cap",
                "Shako",
                "Gold Helmet",
                "Helmet of Knowledge",
                "Helmet of Thrift",
                "Saver's Casque",
                "Medic's Hat",
                "Rainbow Helmet",
                "Sunny Tiara",
                "Defenders Helmet",
                "Gargantua's Delight",
                "Thief Diadem",
                "Demonic Eye",
                "Crown of Thorns",
                "Hood of Alucard",
                "Fool's Crest",
                "Leather Armor",
                "Mail Vest",
                "Hardened Armor",
                "Bat Armor",
                "Young Mage Robe",
                "Light Plate",
                "Porcupine Vest",
                "Timberman's Jacket",
                "Rainbow Armor",
                "Sunny Robe",
                "Defenders Hauberk",
                "Vampire Shell",
                "Cuirass of Elder Mage",
                "Alchemist Shroud",
                "Hypochondriac",
                "Juggernaut",
                "Trickster",
                "Mage Ring",
                "Bear Amulet",
                "Soldier Ring",
                "Lynx Amulet",
                "Lead Ring",
                "Rainbow Amulet",
                "Sunny Amulet",
                "Defenders Amulet",
                "Knowledge of Wizard",
                "New Chance",
                "Golden Tag",
                "Speed Bracelet",
                "Holy Relic",
                "Blood Drop",
                "Energy Seed",
                "Ruby",
                "Emerald",
                "Sapphire",
                "Topaz",
                "Amber",
                "Aquamarine",
                "Helmet Patch Pack",
                "Armor Plate Pack",
                "Helmet Attribute Scroll",
                "Armor Attribute Scroll",
                "Trinket Attribute Scroll",
                "Christmas Joy",
                "Corrupted Lantern",
                "Green Potion",
                "Magenta Potion",
                "Yellow Potion",
                "Blue Potion",
                "Grey Potion",
                "Pink Potion",
                "Cyan Potion"
            };

            comboItem.Items.Clear();
            comboItem.Items.AddRange(ALLITEMS_Names);
        }

        public string GetItemName(int ItemID)
        {
            string szItemName = "";
            
            switch(ItemID)
            {
                case 0x00: szItemName = "None"; break;
                case 0x01: szItemName = "Metal Helmet"; break; // Helmets
                case 0x02: szItemName = "Mithril Cap"; break;
                case 0x03: szItemName = "Shako"; break;
                case 0x0A: szItemName = "Gold Helmet"; break;
                case 0x0B: szItemName = "Helmet of Knowledge"; break;
                case 0x0C: szItemName = "Helmet of Thrift"; break;
                case 0x0D: szItemName = "Saver's Casque"; break;
                case 0x0E: szItemName = "Medic's Hat"; break;
                case 0x14: szItemName = "Rainbow Helmet"; break;
                case 0x15: szItemName = "Sunny Tiara"; break;
                case 0x16: szItemName = "Defenders Helmet"; break;
                case 0x1E: szItemName = "Gargantuas Delight"; break;
                case 0x1F: szItemName = "Thief Diadem"; break;
                case 0x20: szItemName = "Demonic Eye"; break;
                case 0x21: szItemName = "Crown of Thorns"; break;
                case 0x22: szItemName = "Hood of Alucard"; break;
                case 0x23: szItemName = "Fool's Crest"; break;
                case 0x28: szItemName = "Leather Armor"; break; // Armors
                case 0x29: szItemName = "Mail Vest"; break;
                case 0x2A: szItemName = "Hardened Armor"; break;
                case 0x32: szItemName = "Bat Armor"; break;
                case 0x33: szItemName = "Young Mage Robe"; break;
                case 0x34: szItemName = "Light Plate"; break;
                case 0x35: szItemName = "Porcupine Vest"; break;
                case 0x36: szItemName = "Timberman's Jacket"; break;
                case 0x3C: szItemName = "Rainbow Armor"; break;
                case 0x3D: szItemName = "Sunny Robe"; break;
                case 0x3E: szItemName = "Defenders Hauberk"; break;
                case 0x46: szItemName = "Vampire Shell"; break;
                case 0x47: szItemName = "Cuirass of Elder Mage"; break;
                case 0x48: szItemName = "Alchemist Shroud"; break;
                case 0x49: szItemName = "Hypochondriac"; break;
                case 0x4A: szItemName = "Juggernaut"; break;
                case 0x4B: szItemName = "Trickster"; break;
                case 0x5A: szItemName = "Mage Ring"; break; // Trinkets
                case 0x5B: szItemName = "Bear Amulet"; break;
                case 0x5C: szItemName = "Soldier Ring"; break;
                case 0x5D: szItemName = "Lynx Amulet"; break;
                case 0x5E: szItemName = "Lead Ring"; break;
                case 0x64: szItemName = "Rainbow Amulet"; break;
                case 0x65: szItemName = "Sunny Amulet"; break;
                case 0x66: szItemName = "Defenders Amulet"; break;
                case 0x6E: szItemName = "Knowledge of Wizard"; break;
                case 0x6F: szItemName = "New Chance"; break;
                case 0x70: szItemName = "Golden Tag"; break;
                case 0x71: szItemName = "Speed Bracelet"; break;
                case 0x72: szItemName = "Holy Relic"; break;
                case 0x73: szItemName = "Blood Drop"; break;
                case 0x74: szItemName = "Energy Seed"; break;
                case 0x78: szItemName = "Ruby"; break; // Gems
                case 0x79: szItemName = "Emerald"; break;
                case 0x7A: szItemName = "Sapphire"; break;
                case 0x7B: szItemName = "Topaz"; break;
                case 0x7C: szItemName = "Amber"; break;
                case 0x7D: szItemName = "Aquamarine"; break;
                case 0x82: szItemName = "Helmet Patch Pack"; break; // Upgrade Kits
                case 0x83: szItemName = "Armor Plate Pack"; break;
                case 0x84: szItemName = "Helmet Attribute Scroll"; break;
                case 0x85: szItemName = "Armor Attribute Scroll"; break;
                case 0x86: szItemName = "Trinket Attribute Scroll"; break;
                case 0x8C: szItemName = "Christmas Joy"; break; // Charms
                case 0x8D: szItemName = "Corrupted Lantern"; break;
                case 0x96: szItemName = "Green Potion"; break; // Potions
                case 0x97: szItemName = "Magenta Potion"; break; // Potions
                case 0x98: szItemName = "Yellow Potion"; break; // Potions
                case 0x99: szItemName = "Blue Potion"; break; // Potions
                case 0x9A: szItemName = "Grey Potion"; break; // Potions
                case 0x9B: szItemName = "Pink Potion"; break; // Potions
                case 0x9C: szItemName = "Cyan Potion"; break; // Potions
                default: szItemName = "BAD ITEM"; break;
            }

            return szItemName;
        }

        private string GetItemDescription(int ItemID)
        {
            string szItemDescription = "";

            switch (ItemID)
            {
                case 0x00: szItemDescription = "No item"; break;
                case 0x01: szItemDescription = "No magic attributes"; break; // Helmets
                case 0x02: szItemDescription = "No magic attributes"; break;
                case 0x03: szItemDescription = "No magic attributes"; break;
                case 0x0A: szItemDescription = "10% chance to steal ${0} on kill"; break;
                case 0x0B: szItemDescription = "10% chance to gain ({0} * level) XP on kill"; break;
                case 0x0C: szItemDescription = "Items sell price increased by {0}%"; break;
                case 0x0D: szItemDescription = "Wall shop prices are lower by {0}%"; break;
                case 0x0E: szItemDescription = "Medical kits heal +{0} HP more"; break;
                case 0x14: szItemDescription = "+{0} HP"; break;
                case 0x15: szItemDescription = "+{0} MP"; break;
                case 0x16: szItemDescription = "Enhanced defense"; break;
                case 0x1E: szItemDescription = "10% chance to stomp when struck"; break;
                case 0x1F: szItemDescription = "20% chance to steal ${0} on kill"; break;
                case 0x20: szItemDescription = "+{0}% to critical hit damage"; break;
                case 0x21: szItemDescription = "+{0}% to Thorns"; break;
                case 0x22: szItemDescription = "+{0}% to melee lifesteal"; break;
                case 0x23: szItemDescription = "10% chance to heal {0} HP when struck"; break;
                case 0x28: szItemDescription = "No magic attributes"; break; // Armors
                case 0x29: szItemDescription = "No magic attributes"; break;
                case 0x2A: szItemDescription = "No magic attributes"; break;
                case 0x32: szItemDescription = "10% chance to steal {0} HP on striking"; break;
                case 0x33: szItemDescription = "10% chance to steal {0} MP on striking"; break;
                case 0x34: szItemDescription = "+{0} to run speed"; break;
                case 0x35: szItemDescription = "+{0} to Thorns"; break;
                case 0x36: szItemDescription = "25% chance to deal +{0} melee damage"; break;
                case 0x3C: szItemDescription = "+{0} HP"; break;
                case 0x3D: szItemDescription = "+{0} HP"; break;
                case 0x3E: szItemDescription = "Enhanced defense"; break;
                case 0x46: szItemDescription = "20% chance to steal {0} HP on striking"; break;
                case 0x47: szItemDescription = "20% chance to steal {0} MP on striking"; break;
                case 0x48: szItemDescription = "+{0} increased potion duration"; break;
                case 0x49: szItemDescription = "+{0} belt capacity"; break;
                case 0x4A: szItemDescription = "-{0}% move speed"; break;
                case 0x4B: szItemDescription = "{0}% chance to negate damage"; break;
                case 0x5A: szItemDescription = "+{0} to Sorcery"; break; // Trinkets
                case 0x5B: szItemDescription = "+{0} to Toughness"; break;
                case 0x5C: szItemDescription = "+{0} to Precision"; break;
                case 0x5D: szItemDescription = "+{0} to Legerity"; break;
                case 0x5E: szItemDescription = "-{0} HP"; break;
                case 0x64: szItemDescription = "+{0} HP"; break;
                case 0x65: szItemDescription = "+{0} MP"; break;
                case 0x66: szItemDescription = "+{0} to Toughness"; break;
                case 0x6E: szItemDescription = "+{0} to Sorcery"; break;
                case 0x6F: szItemDescription = "+{0} to Toughness"; break;
                case 0x70: szItemDescription = "+{0} to Precision"; break;
                case 0x71: szItemDescription = "+{0} to Legerity"; break;
                case 0x72: szItemDescription = "Highest MP regeneration rate"; break;
                case 0x73: szItemDescription = "+{0} HP regeneration"; break;
                case 0x74: szItemDescription = "Absorbs damage by draining MP"; break;
                case 0x78: szItemDescription = "Grants you Obscurity spell"; break; // Gems
                case 0x79: szItemDescription = "Grants you Generosity spell"; break;
                case 0x7A: szItemDescription = "Grants you Sacrifice spell"; break;
                case 0x7B: szItemDescription = "Grants you Electronova spell"; break;
                case 0x7C: szItemDescription = "Grants you Pulverize spell"; break;
                case 0x7D: szItemDescription = "Grants you Salvation spell"; break;
                case 0x82: szItemDescription = "Increases defense of equipped helmet by {0}"; break; // Upgrade Kits
                case 0x83: szItemDescription = "Increases defense of equipped armor by {0}"; break;
                case 0x84: szItemDescription = "Increases magic attribute of equipped helmet by {0}"; break;
                case 0x85: szItemDescription = "Increases magic attribute of equipped armor by {0}"; break;
                case 0x86: szItemDescription = "Increases magic attribute of equipped trinket by {0}"; break;
                case 0x8C: szItemDescription = "Grants you colorful visual effect"; break; // Charms
                case 0x8D: szItemDescription = "Grants you dark animated trail"; break;
                case 0x96: szItemDescription = "Increases your run speed"; break; // Potions
                case 0x97: szItemDescription = "Doubles your damage"; break;
                case 0x98: szItemDescription = "Increases your Thorns"; break;
                case 0x99: szItemDescription = "Boosts your mana regeneration"; break;
                case 0x9A: szItemDescription = "Gives you Invulnerability perk"; break;
                case 0x9B: szItemDescription = "Gives you Enchantement perk"; break;
                case 0x9C: szItemDescription = "Gives you Instagib perk"; break;
                default: szItemDescription = "Invalid item index!"; break;
            }

            return szItemDescription;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (this.Text == "Equipped Helmet")
            {
                comboItem.SelectedIndex = Array.IndexOf(HELMET_IDs, mainForm.i_HELMET_ItemID);
                boxDefense.Value = mainForm.i_HELMET_Defense;
                boxAttribute.Value = mainForm.i_HELMET_Attribute;
                boxUpgrades.Value = mainForm.i_HELMET_Upgrades;
            }
            else if (this.Text == "Equipped Armor")
            {
                comboItem.SelectedIndex = Array.IndexOf(ARMOR_IDs, mainForm.i_ARMOR_ItemID);
                boxDefense.Value = mainForm.i_ARMOR_Defense;
                boxAttribute.Value = mainForm.i_ARMOR_Attribute;
                boxUpgrades.Value = mainForm.i_ARMOR_Upgrades;
            }
            else if (this.Text == "Equipped Trinket")
            {
                comboItem.SelectedIndex = Array.IndexOf(TRINKET_IDs, mainForm.i_TRINKET_ItemID);
                boxAttribute.Value = mainForm.i_TRINKET_Attribute;
                boxUpgrades.Value = mainForm.i_TRINKET_Upgrades;
            }
            else if (this.Text == "Socketed Gem")
            {
                comboItem.SelectedIndex = Array.IndexOf(GEM_IDs, mainForm.i_GEM_ItemID);
            }
            else if (this.Text == "Bag: Slot 1")
            {
                comboItem.SelectedIndex = Array.IndexOf(ITEM_IDs, mainForm.i_ITEM1_ItemID);
                boxDefense.Value = mainForm.i_ITEM1_Defense;
                boxAttribute.Value = mainForm.i_ITEM1_Attribute;
                boxUpgrades.Value = mainForm.i_ITEM1_Upgrades;
            }
            else if (this.Text == "Bag: Slot 2")
            {
                comboItem.SelectedIndex = Array.IndexOf(ITEM_IDs, mainForm.i_ITEM2_ItemID);
                boxDefense.Value = mainForm.i_ITEM2_Defense;
                boxAttribute.Value = mainForm.i_ITEM2_Attribute;
                boxUpgrades.Value = mainForm.i_ITEM2_Upgrades;
            }
            else if (this.Text == "Bag: Slot 3")
            {
                comboItem.SelectedIndex = Array.IndexOf(ITEM_IDs, mainForm.i_ITEM3_ItemID);
                boxDefense.Value = mainForm.i_ITEM3_Defense;
                boxAttribute.Value = mainForm.i_ITEM3_Attribute;
                boxUpgrades.Value = mainForm.i_ITEM3_Upgrades;
            }
            else if (this.Text == "Bag: Slot 4")
            {
                comboItem.SelectedIndex = Array.IndexOf(ITEM_IDs, mainForm.i_ITEM4_ItemID);
                boxDefense.Value = mainForm.i_ITEM4_Defense;
                boxAttribute.Value = mainForm.i_ITEM4_Attribute;
                boxUpgrades.Value = mainForm.i_ITEM4_Upgrades;
            }
            else if (this.Text == "Bag: Slot 5")
            {
                comboItem.SelectedIndex = Array.IndexOf(ITEM_IDs, mainForm.i_ITEM5_ItemID);
                boxDefense.Value = mainForm.i_ITEM5_Defense;
                boxAttribute.Value = mainForm.i_ITEM5_Attribute;
                boxUpgrades.Value = mainForm.i_ITEM5_Upgrades;
            }
            else if (this.Text == "Bag: Slot 6")
            {
                comboItem.SelectedIndex = Array.IndexOf(ITEM_IDs, mainForm.i_ITEM6_ItemID);
                boxDefense.Value = mainForm.i_ITEM6_Defense;
                boxAttribute.Value = mainForm.i_ITEM6_Attribute;
                boxUpgrades.Value = mainForm.i_ITEM6_Upgrades;
            }
            else if (this.Text == "Bag: Slot 7")
            {
                comboItem.SelectedIndex = Array.IndexOf(ITEM_IDs, mainForm.i_ITEM7_ItemID);
                boxDefense.Value = mainForm.i_ITEM7_Defense;
                boxAttribute.Value = mainForm.i_ITEM7_Attribute;
                boxUpgrades.Value = mainForm.i_ITEM7_Upgrades;
            }
            else if (this.Text == "Bag: Slot 8")
            {
                comboItem.SelectedIndex = Array.IndexOf(ITEM_IDs, mainForm.i_ITEM8_ItemID);
                boxDefense.Value = mainForm.i_ITEM8_Defense;
                boxAttribute.Value = mainForm.i_ITEM8_Attribute;
                boxUpgrades.Value = mainForm.i_ITEM8_Upgrades;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.Text == "Equipped Helmet")
            {
                mainForm.i_HELMET_Color = HELMET_Colors[comboItem.SelectedIndex];
                mainForm.i_HELMET_ItemID = HELMET_IDs[comboItem.SelectedIndex];
                mainForm.i_HELMET_Defense = (int)boxDefense.Value;
                mainForm.i_HELMET_Attribute = (int)boxAttribute.Value;
                mainForm.i_HELMET_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Equipped Armor")
            {
                mainForm.i_ARMOR_Color = ARMOR_Colors[comboItem.SelectedIndex];
                mainForm.i_ARMOR_ItemID = ARMOR_IDs[comboItem.SelectedIndex];
                mainForm.i_ARMOR_Defense = (int)boxDefense.Value;
                mainForm.i_ARMOR_Attribute = (int)boxAttribute.Value;
                mainForm.i_ARMOR_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Equipped Trinket")
            {
                mainForm.i_TRINKET_Color = TRINKET_Colors[comboItem.SelectedIndex];
                mainForm.i_TRINKET_ItemID = TRINKET_IDs[comboItem.SelectedIndex];
                mainForm.i_TRINKET_Attribute = (int)boxAttribute.Value;
                mainForm.i_TRINKET_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Socketed Gem")
            {
                mainForm.i_GEM_Color = GEM_Colors[comboItem.SelectedIndex];
                mainForm.i_GEM_ItemID = GEM_IDs[comboItem.SelectedIndex];
            }
            else if (this.Text == "Bag: Slot 1")
            {
                mainForm.i_ITEM1_Color = ITEM_Colors[comboItem.SelectedIndex];
                mainForm.i_ITEM1_ItemID = ITEM_IDs[comboItem.SelectedIndex];
                mainForm.i_ITEM1_Defense = (int)boxDefense.Value;
                mainForm.i_ITEM1_Attribute = (int)boxAttribute.Value;
                mainForm.i_ITEM1_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Bag: Slot 2")
            {
                mainForm.i_ITEM2_Color = ITEM_Colors[comboItem.SelectedIndex];
                mainForm.i_ITEM2_ItemID = ITEM_IDs[comboItem.SelectedIndex];
                mainForm.i_ITEM2_Defense = (int)boxDefense.Value;
                mainForm.i_ITEM2_Attribute = (int)boxAttribute.Value;
                mainForm.i_ITEM2_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Bag: Slot 3")
            {
                mainForm.i_ITEM3_Color = ITEM_Colors[comboItem.SelectedIndex];
                mainForm.i_ITEM3_ItemID = ITEM_IDs[comboItem.SelectedIndex];
                mainForm.i_ITEM3_Defense = (int)boxDefense.Value;
                mainForm.i_ITEM3_Attribute = (int)boxAttribute.Value;
                mainForm.i_ITEM3_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Bag: Slot 4")
            {
                mainForm.i_ITEM4_Color = ITEM_Colors[comboItem.SelectedIndex];
                mainForm.i_ITEM4_ItemID = ITEM_IDs[comboItem.SelectedIndex];
                mainForm.i_ITEM4_Defense = (int)boxDefense.Value;
                mainForm.i_ITEM4_Attribute = (int)boxAttribute.Value;
                mainForm.i_ITEM4_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Bag: Slot 5")
            {
                mainForm.i_ITEM5_Color = ITEM_Colors[comboItem.SelectedIndex];
                mainForm.i_ITEM5_ItemID = ITEM_IDs[comboItem.SelectedIndex];
                mainForm.i_ITEM5_Defense = (int)boxDefense.Value;
                mainForm.i_ITEM5_Attribute = (int)boxAttribute.Value;
                mainForm.i_ITEM5_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Bag: Slot 6")
            {
                mainForm.i_ITEM6_Color = ITEM_Colors[comboItem.SelectedIndex];
                mainForm.i_ITEM6_ItemID = ITEM_IDs[comboItem.SelectedIndex];
                mainForm.i_ITEM6_Defense = (int)boxDefense.Value;
                mainForm.i_ITEM6_Attribute = (int)boxAttribute.Value;
                mainForm.i_ITEM6_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Bag: Slot 7")
            {
                mainForm.i_ITEM7_Color = ITEM_Colors[comboItem.SelectedIndex];
                mainForm.i_ITEM7_ItemID = ITEM_IDs[comboItem.SelectedIndex];
                mainForm.i_ITEM7_Defense = (int)boxDefense.Value;
                mainForm.i_ITEM7_Attribute = (int)boxAttribute.Value;
                mainForm.i_ITEM7_Upgrades = (int)boxUpgrades.Value;
            }
            else if (this.Text == "Bag: Slot 8")
            {
                mainForm.i_ITEM8_Color = ITEM_Colors[comboItem.SelectedIndex];
                mainForm.i_ITEM8_ItemID = ITEM_IDs[comboItem.SelectedIndex];
                mainForm.i_ITEM8_Defense = (int)boxDefense.Value;
                mainForm.i_ITEM8_Attribute = (int)boxAttribute.Value;
                mainForm.i_ITEM8_Upgrades = (int)boxUpgrades.Value;
            }

            mainForm.UpdateInventoryMenu();
            this.Close();
        }

        private void comboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Text == "Equipped Helmet")
            {
                int comboItemIndex = comboItem.SelectedIndex;

                labelItemName.Text = GetItemName(HELMET_IDs[comboItemIndex]);
                labelItemDescription.Text = String.Format(GetItemDescription(HELMET_IDs[comboItemIndex]), boxAttribute.Value);

                boxDefense.Enabled = true;
                boxAttribute.Enabled = true;
                boxUpgrades.Enabled = true;

                if (HELMET_IDs[comboItemIndex] == 0x00) // No item
                {
                    boxDefense.Value = 0;
                    boxDefense.Enabled = false;
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }
                else if (HELMET_Colors[comboItemIndex] == 0) // "White" items
                {
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                }
                else if (HELMET_Colors[comboItemIndex] == 2) // "Green" items
                {
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }

                // Attribute disabled items
                if (HELMET_IDs[comboItemIndex] == 0x16 || HELMET_IDs[comboItemIndex] == 0x1E)
                {
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                }
            }
            else if (this.Text == "Equipped Armor")
            {
                int comboItemIndex = comboItem.SelectedIndex;

                labelItemName.Text = GetItemName(ARMOR_IDs[comboItemIndex]);
                labelItemDescription.Text = String.Format(GetItemDescription(ARMOR_IDs[comboItemIndex]), boxAttribute.Value);

                boxDefense.Enabled = true;
                boxAttribute.Enabled = true;
                boxUpgrades.Enabled = true;

                if (ARMOR_IDs[comboItemIndex] == 0x00) // No item
                {
                    boxDefense.Value = 0;
                    boxDefense.Enabled = false;
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }
                else if (ARMOR_Colors[comboItemIndex] == 0) // "White" items
                {
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                }
                else if (ARMOR_Colors[comboItemIndex] == 2) // "Green" items
                {
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }

                // Attribute disabled items
                if (ARMOR_IDs[comboItemIndex] == 0x3E)
                {
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                }
            }
            else if (this.Text == "Equipped Trinket")
            {
                int comboItemIndex = comboItem.SelectedIndex;

                labelItemName.Text = GetItemName(TRINKET_IDs[comboItemIndex]);
                labelItemDescription.Text = String.Format(GetItemDescription(TRINKET_IDs[comboItemIndex]), boxAttribute.Value);

                boxDefense.Enabled = false;
                boxDefense.Value = 0;
                boxAttribute.Enabled = true;
                boxUpgrades.Enabled = true;

                if (TRINKET_IDs[comboItemIndex] == 0x00) // No item
                {
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }
                else if (TRINKET_Colors[comboItemIndex] == 2) // "Green" items
                {
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }

                // Attribute disabled items
                if (TRINKET_IDs[comboItemIndex] == 0x72 || TRINKET_IDs[comboItemIndex] == 0x74)
                {
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }
            }
            else if (this.Text == "Socketed Gem")
            {
                int comboItemIndex = comboItem.SelectedIndex;

                labelItemName.Text = GetItemName(GEM_IDs[comboItemIndex]);
                labelItemDescription.Text = String.Format(GetItemDescription(GEM_IDs[comboItemIndex]), boxAttribute.Value);

                boxDefense.Enabled = false;
                boxDefense.Value = 0;
                boxAttribute.Enabled = false;
                boxAttribute.Value = 0;
                boxUpgrades.Enabled = false;
                boxUpgrades.Value = 0;
            }
            else
            {
                int comboItemIndex = comboItem.SelectedIndex;

                labelItemName.Text = GetItemName(ITEM_IDs[comboItemIndex]);
                labelItemDescription.Text = String.Format(GetItemDescription(ITEM_IDs[comboItemIndex]), boxAttribute.Value);

                boxDefense.Enabled = true;
                boxAttribute.Enabled = true;
                boxUpgrades.Enabled = true;
                labelAttribute.Text = "Attribute";
                labelDurationNote.Visible = false;

                if (ITEM_IDs[comboItemIndex] == 0x00) // No item
                {
                    boxDefense.Value = 0;
                    boxDefense.Enabled = false;
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }
                else if (ITEM_Colors[comboItemIndex] == 0) // "White" items
                {
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                }
                else if (ITEM_Colors[comboItemIndex] == 2) // "Green" items
                {
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }

                // Defense disabled items
                if (ITEM_IDs[comboItemIndex] >= 0x5A && ITEM_IDs[comboItemIndex] <= 0x9C)
                {
                    boxDefense.Value = 0;
                    boxDefense.Enabled = false;
                }

                // Attribute disabled items
                if (ITEM_IDs[comboItemIndex] == 0x16 || 
                    ITEM_IDs[comboItemIndex] == 0x1E || 
                    ITEM_IDs[comboItemIndex] == 0x3E || 
                    ITEM_IDs[comboItemIndex] == 0x72 || 
                    ITEM_IDs[comboItemIndex] == 0x74 ||
                    ITEM_IDs[comboItemIndex] >= 0x78 && ITEM_IDs[comboItemIndex] <= 0x7D || 
                    ITEM_IDs[comboItemIndex] == 0x8C || 
                    ITEM_IDs[comboItemIndex] == 0x8D)
                {
                    boxAttribute.Enabled = false;
                    boxAttribute.Value = 0;
                }

                // Upgrade disabled items
                if (ITEM_IDs[comboItemIndex] == 0x72 || ITEM_IDs[comboItemIndex] == 0x74 || ITEM_IDs[comboItemIndex] >= 0x78 && ITEM_IDs[comboItemIndex] <= 0x9C)
                {
                    boxUpgrades.Enabled = false;
                    boxUpgrades.Value = 0;
                }

                // Attribute renaming for potions
                if (ITEM_IDs[comboItemIndex] >= 0x96 && ITEM_IDs[comboItemIndex] <= 0x9C)
                {
                    labelAttribute.Text = "Duration";
                    labelDurationNote.Visible = true;
                }
            }
        }

        private void boxAttribute_ValueChanged(object sender, EventArgs e)
        {
            comboItem_SelectedIndexChanged(sender, e);
        }
    }
}
