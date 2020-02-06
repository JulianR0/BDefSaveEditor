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
                case e_Selector.BLASTER:
                    {
                        mainForm.i_UPGRADE_BLASTER_Slots = (int)numericSlots.Value;
                        mainForm.i_UPGRADE_BLASTER_Damage = (int)numericDamage.Value;
                        mainForm.i_UPGRADE_BLASTER_RateOfFire = (int)numericRate.Value;
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
            szUniques += "Damage: 20 HP.";
            szUniques += "Radius: 128 units.";

            return szUniques;
        }
    }
}
