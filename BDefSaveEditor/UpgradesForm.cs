using System;
using System.Windows.Forms;

namespace BDefSaveEditor
{
    public partial class UpgradesForm : Form
    {
        Main mainForm;

        public enum e_Selector
        {
            MEELE,
            AXE,
            PISTOL,
            BLASTER,
            PYTHON,
            AKIMBO,
            SMG,
            SHOTGUN,
            CROSSBOW,
            ASSAULT,
            SAW,
            SNIPER,
            ROCKET,
            GAUSS,
            SHOCK,
            GRENADE,
            MINIGUN
        }

        int iSavedWeapon;

        public UpgradesForm(Main link)
        {
            InitializeComponent();
            mainForm = link;
        }

        public void InitUpgradeMenu(e_Selector iWeapon)
        {
            iSavedWeapon = (int)iWeapon;
            switch (iWeapon)
            {
                case e_Selector.MEELE:
                    {
                        numericSlots.Value = 0;
                        numericDamage.Value = mainForm.i_UPGRADE_MEELE_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_MEELE_RateOfFire;
                        numericAmmo.Value = 0;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = false; labelNoUpgrade.Visible = true;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = false;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 0";
                        labelRate.Text = "Maximum: 0";
                        labelAmmo.Text = "No effect";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.AXE:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_AXE_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_AXE_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_AXE_RateOfFire;
                        numericAmmo.Value = 0;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = false;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 0";
                        labelAmmo.Text = "No effect";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.PISTOL:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_PISTOL_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_PISTOL_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_PISTOL_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_PISTOL_Ammo;
                        numericUnique.Value = mainForm.i_UPGRADE_PISTOL_Unique;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = true;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "Maximum: 2";
                        labelUnique.Text = "Maximum: 2"; toolTipUniques.SetToolTip(linkLabel1, PistolUpgrades());
                        break;
                    }
                case e_Selector.BLASTER:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_BLASTER_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_BLASTER_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_BLASTER_RateOfFire;
                        numericAmmo.Value = 0;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = false;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 4";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "No effect";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.PYTHON:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_PYTHON_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_PYTHON_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_PYTHON_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_PYTHON_Ammo;
                        numericUnique.Value = mainForm.i_UPGRADE_PYTHON_Unique;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = true;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "Maximum: 0";
                        labelUnique.Text = "Maximum: 2"; toolTipUniques.SetToolTip(linkLabel1, PythonUpgrades());
                        break;
                    }
                case e_Selector.AKIMBO:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_AKIMBO_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_AKIMBO_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_AKIMBO_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_AKIMBO_Ammo;
                        numericUnique.Value = mainForm.i_UPGRADE_AKIMBO_Unique;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = true;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "Maximum: 5";
                        labelUnique.Text = "Maximum: 1"; toolTipUniques.SetToolTip(linkLabel1, AkimboUpgrades());
                        break;
                    }
                case e_Selector.SMG:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_SMG_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_SMG_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_SMG_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_SMG_Ammo;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "Maximum: 5";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.SHOTGUN:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_SHOTGUN_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_SHOTGUN_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_SHOTGUN_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_SHOTGUN_Ammo;
                        numericUnique.Value = mainForm.i_UPGRADE_SHOTGUN_Unique;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = true;
                        labelDamage.Text = "Maximum: 4";
                        labelRate.Text = "Maximum: 4";
                        labelAmmo.Text = "Maximum: 4";
                        labelUnique.Text = "Maximum: 1"; toolTipUniques.SetToolTip(linkLabel1, ShotgunUpgrades());
                        break;
                    }
                case e_Selector.CROSSBOW:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_CROSSBOW_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_CROSSBOW_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_CROSSBOW_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_CROSSBOW_Ammo;
                        numericUnique.Value = mainForm.i_UPGRADE_CROSSBOW_Unique;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = true;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "Maximum: 3";
                        labelUnique.Text = "Maximum: 2"; toolTipUniques.SetToolTip(linkLabel1, CrossbowUpgrades());
                        break;
                    }
                case e_Selector.ASSAULT:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_ASSAULT_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_ASSAULT_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_ASSAULT_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_ASSAULT_Ammo;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 4";
                        labelAmmo.Text = "Maximum: 5";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.SAW:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_SAW_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_SAW_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_SAW_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_SAW_Ammo;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "Maximum: 5";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.SNIPER:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_SNIPER_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_SNIPER_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_SNIPER_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_SNIPER_Ammo;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 2";
                        labelAmmo.Text = "Maximum: 5";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.ROCKET:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_RPG_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_RPG_Damage;
                        numericRate.Value = 0;
                        numericAmmo.Value = 0;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = false;
                        numericAmmo.Enabled = false;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "No effect";
                        labelAmmo.Text = "No effect";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.GAUSS:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_GAUSS_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_GAUSS_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_GAUSS_RateOfFire;
                        numericAmmo.Value = 0;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = false;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 5";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "No effect";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.SHOCK:
                    {
                        numericSlots.Value = 0;
                        numericDamage.Value = 0;
                        numericRate.Value = mainForm.i_UPGRADE_SHOCK_RateOfFire;
                        numericAmmo.Value = 0;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = false; labelNoUpgrade.Visible = true;
                        numericDamage.Enabled = false;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = false;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "No effect";
                        labelRate.Text = "Maximum: 0";
                        labelAmmo.Text = "No effect";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.GRENADE:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_GRENADE_Slots;
                        numericDamage.Value = 0;
                        numericRate.Value = mainForm.i_UPGRADE_GRENADE_RateOfFire;
                        numericAmmo.Value = mainForm.i_UPGRADE_GRENADE_Ammo;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = false;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = true;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "No effect";
                        labelRate.Text = "Maximum: 5";
                        labelAmmo.Text = "Maximum: 3";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
                case e_Selector.MINIGUN:
                    {
                        numericSlots.Value = mainForm.i_UPGRADE_MINIGUN_Slots;
                        numericDamage.Value = mainForm.i_UPGRADE_MINIGUN_Damage;
                        numericRate.Value = mainForm.i_UPGRADE_MINIGUN_RateOfFire;
                        numericAmmo.Value = 0;
                        numericUnique.Value = 0;
                        numericSlots.Enabled = true; labelNoUpgrade.Visible = false;
                        numericDamage.Enabled = true;
                        numericRate.Enabled = true;
                        numericAmmo.Enabled = false;
                        numericUnique.Enabled = false;
                        labelDamage.Text = "Maximum: 2";
                        labelRate.Text = "Maximum: 4";
                        labelAmmo.Text = "No effect";
                        labelUnique.Text = "No uniques"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
                        break;
                    }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            e_Selector iWeapon = (e_Selector)iSavedWeapon;
            switch(iWeapon)
            {
                case e_Selector.MEELE:
                    {
                        mainForm.i_UPGRADE_MEELE_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_MEELE_RateOfFire = (int)numericRate.Value;
                        break;
                    }
                case e_Selector.AXE:
                    {
                        mainForm.i_UPGRADE_AXE_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_AXE_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_AXE_RateOfFire = (int)numericRate.Value;
                        break;
                    }
                case e_Selector.PISTOL:
                    {
                        mainForm.i_UPGRADE_PISTOL_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_PISTOL_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_PISTOL_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_PISTOL_Ammo = (int)numericAmmo.Value;
                        mainForm.i_UPGRADE_PISTOL_Unique = (int)numericUnique.Value;
                        break;
                    }
                case e_Selector.BLASTER:
                    {
                        mainForm.i_UPGRADE_BLASTER_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_BLASTER_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_BLASTER_RateOfFire = (int)numericRate.Value;
                        break;
                    }
                case e_Selector.PYTHON:
                    {
                        mainForm.i_UPGRADE_PYTHON_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_PYTHON_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_PYTHON_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_PYTHON_Ammo = (int)numericAmmo.Value;
                        mainForm.i_UPGRADE_PYTHON_Unique = (int)numericUnique.Value;
                        break;
                    }
                case e_Selector.AKIMBO:
                    {
                        mainForm.i_UPGRADE_AKIMBO_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_AKIMBO_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_AKIMBO_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_AKIMBO_Ammo = (int)numericAmmo.Value;
                        mainForm.i_UPGRADE_AKIMBO_Unique = (int)numericUnique.Value;
                        break;
                    }
                case e_Selector.SMG:
                    {
                        mainForm.i_UPGRADE_SMG_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_SMG_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_SMG_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_SMG_Ammo = (int)numericAmmo.Value;
                        break;
                    }
                case e_Selector.SHOTGUN:
                    {
                        mainForm.i_UPGRADE_SHOTGUN_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_SHOTGUN_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_SHOTGUN_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_SHOTGUN_Ammo = (int)numericAmmo.Value;
                        mainForm.i_UPGRADE_SHOTGUN_Unique = (int)numericUnique.Value;
                        break;
                    }
                case e_Selector.CROSSBOW:
                    {
                        mainForm.i_UPGRADE_CROSSBOW_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_CROSSBOW_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_CROSSBOW_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_CROSSBOW_Ammo = (int)numericAmmo.Value;
                        mainForm.i_UPGRADE_CROSSBOW_Unique = (int)numericUnique.Value;
                        break;
                    }
                case e_Selector.ASSAULT:
                    {
                        mainForm.i_UPGRADE_ASSAULT_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_ASSAULT_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_ASSAULT_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_ASSAULT_Ammo = (int)numericAmmo.Value;
                        break;
                    }
                case e_Selector.SAW:
                    {
                        mainForm.i_UPGRADE_SAW_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_SAW_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_SAW_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_SAW_Ammo = (int)numericAmmo.Value;
                        break;
                    }
                case e_Selector.SNIPER:
                    {
                        mainForm.i_UPGRADE_SNIPER_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_SNIPER_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_SNIPER_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_SNIPER_Ammo = (int)numericAmmo.Value;
                        break;
                    }
                case e_Selector.ROCKET:
                    {
                        mainForm.i_UPGRADE_RPG_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_RPG_Damage = (int)numericDamage.Value;
                        break;
                    }
                case e_Selector.GAUSS:
                    {
                        mainForm.i_UPGRADE_GAUSS_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_GAUSS_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_GAUSS_RateOfFire = (int)numericRate.Value;
                        break;
                    }
                case e_Selector.SHOCK:
                    {
                        mainForm.i_UPGRADE_SHOCK_RateOfFire = (int)numericRate.Value;
                        break;
                    }
                case e_Selector.GRENADE:
                    {
                        mainForm.i_UPGRADE_GRENADE_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_GRENADE_RateOfFire = (int)numericRate.Value;
                        mainForm.i_UPGRADE_GRENADE_Ammo = (int)numericAmmo.Value;
                        break;
                    }
                case e_Selector.MINIGUN:
                    {
                        mainForm.i_UPGRADE_MINIGUN_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_MINIGUN_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_MINIGUN_RateOfFire = (int)numericRate.Value;
                        break;
                    }
            }
        }

        private string PistolUpgrades()
        {
            string szUniques = "Pistol has 2 unique grades.\n\n";
            
            szUniques += "1. Lightning enchantment\n";
            szUniques += "Every 3 bullets that you fire continuously will cast a lightning strike.\n";
            szUniques += "Damage: 20 HP.\n\n";
            
            szUniques += "2. Explosive attack\n";
            szUniques += "Activates secondary attack of pistol, it takes 2 bullets per shot and has low attack speed.\n";
            szUniques += "Bullet creates an explosion on impact.\n";
            szUniques += "Damage: 25 HP.\n";
            szUniques += "Radius: 64 units.";

            return szUniques;
        }

        private string PythonUpgrades()
        {
            string szUniques = "Python has 2 unique grades.\n\n";

            szUniques += "1. Scope attachment\n";
            szUniques += "Places a scope on the top of the gun and activates its secondary attack - zooming.\n\n";

            szUniques += "2. Freezing attack\n";
            szUniques += "Enemies become slow every time you hit them. Duration doesn't stack.\n";
            szUniques += "Slow ratio: 25% slower.\n";
            szUniques += "Duration: 2 seconds.";

            return szUniques;
        }

        private string AkimboUpgrades()
        {
            string szUniques = "Akimbo has 1 unique grade.\n\n";

            szUniques += "1. Radiation\n";
            szUniques += "When you hold this weapon it will damage enemies around you every 3 seconds.\n";
            szUniques += "Damage: 5% of usual enemies max HP and 1% for bosses.\n";
            szUniques += "Radius: 512 units.";

            return szUniques;
        }

        private string ShotgunUpgrades()
        {
            string szUniques = "Shotgun has 1 unique grade.\n\n";

            szUniques += "1. Fast reloading\n";
            szUniques += "This upgrade allows to load 2 shells at the same time, so you will reload your shotgun as twice as fast.\n";

            return szUniques;
        }

        private string CrossbowUpgrades()
        {
            string szUniques = "Crossbow has 2 unique grades.\n\n";

            szUniques += "1. Igniting bolts\n";
            szUniques += "Bolts are enchanted with fiery power, they will ignite enemies on impact. Duration stacks.\n";
            szUniques += "Enchantment doesn't work when aiming with scope.\n";
            szUniques += "Damage: 3% enemies max HP per second.\n";
            szUniques += "Duration: 3 seconds.\n\n";

            szUniques += "2. Explosive bolts\n";
            szUniques += "Bolts are enchanted with hellish explosive power, they will explode on impact.\n";
            szUniques += "Enchantment doesn't work when aiming with scope.\n";
            szUniques += "Damage: 20 HP.\n";
            szUniques += "Radius: 128 units.";

            return szUniques;
        }
    }
}
