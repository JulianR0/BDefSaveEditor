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
                        labelUnique.Text = "Maximum: 2"; toolTipUniques.SetToolTip(linkLabel1, "This weapon has no unique upgrades.");
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
            /*
             * Pistol has 2 unique grades.

                1. Lightning enchantment
                Every 3 bullets that you fire continuously will cast a lightning strike.
                Damage: 20 HP.

                2. Explosive attack
                Activates secondary attack of pistol, it takes 2 bullets per shot and has low attack speed.
                Bullet creates an explosion on impact.
                Damage: 25 HP.
                Radius: 64 units.

             * */
            return "";
        }
    }
}
