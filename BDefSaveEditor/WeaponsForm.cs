using System;
using System.Windows.Forms;

namespace BDefSaveEditor
{
    public partial class WeaponsForm : Form
    {
        Main mainForm;

        public WeaponsForm(Main link)
        {
            InitializeComponent();
            mainForm = link;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Weapons
            mainForm.b_WPN_Melee = checkMelee.Checked;
            mainForm.b_WPN_Axe = checkAxe.Checked;
            mainForm.b_WPN_Pistol = checkPistol.Checked;
            mainForm.b_WPN_Blaster = checkBlaster.Checked;
            mainForm.b_WPN_357 = check357.Checked;
            mainForm.b_WPN_Akimbo = checkAkimbo.Checked;
            mainForm.b_WPN_MP5 = checkMP5.Checked;
            mainForm.b_WPN_Shotgun = checkShotgun.Checked;
            mainForm.b_WPN_Crossbow = checkCrossbow.Checked;
            mainForm.b_WPN_Assault = checkAssault.Checked;
            mainForm.b_WPN_SAW = checkSAW.Checked;
            mainForm.b_WPN_Sniper = checkSniper.Checked;
            mainForm.b_WPN_RPG = checkRPG.Checked;
            mainForm.b_WPN_Gauss = checkGauss.Checked;
            mainForm.b_WPN_Shock = checkShock.Checked;
            mainForm.b_WPN_GL = checkGL.Checked;
            mainForm.b_WPN_Flame = checkFlame.Checked;
            mainForm.b_WPN_Minigun = checkMinigun.Checked;
            mainForm.b_WPN_Suit = checkSuit.Checked;

            // Ammo
            mainForm.i_AMMO_9mm = (int)numericPistol.Value;
            mainForm.i_AMMO_SAW = (int)numericAssault.Value;
            mainForm.i_AMMO_Shotgun = (int)numericShotgun.Value;
            mainForm.i_AMMO_Shock = (int)numericShock.Value;
            mainForm.i_AMMO_Sniper = (int)numericSniper.Value;
            mainForm.i_AMMO_ARGrenade = (int)numericARGrenades.Value;
            mainForm.i_AMMO_Flame = (int)numericFlame.Value;
            mainForm.i_AMMO_Minigun = (int)numericMinigun.Value;
            mainForm.i_AMMO_357 = (int)numericPython.Value;
            mainForm.i_AMMO_Gauss = (int)numericGauss.Value;
            mainForm.i_AMMO_RPG = (int)numericRPG.Value;
            mainForm.i_AMMO_Crossbow = (int)numericCrossbow.Value;
            mainForm.i_AMMO_Tripmine = (int)numericTripmines.Value;
            mainForm.i_AMMO_Satchel = (int)numericSatchels.Value;
            mainForm.i_AMMO_Grenade = (int)numericHandGrenades.Value;
            mainForm.i_AMMO_GLauncher = (int)numericGL.Value;

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Weapons
            checkMelee.Checked = mainForm.b_WPN_Melee;
            checkAxe.Checked = mainForm.b_WPN_Axe;
            checkPistol.Checked = mainForm.b_WPN_Pistol;
            checkBlaster.Checked = mainForm.b_WPN_Blaster;
            check357.Checked = mainForm.b_WPN_357;
            checkAkimbo.Checked = mainForm.b_WPN_Akimbo;
            checkMP5.Checked = mainForm.b_WPN_MP5;
            checkShotgun.Checked = mainForm.b_WPN_Shotgun;
            checkCrossbow.Checked = mainForm.b_WPN_Crossbow;
            checkAssault.Checked = mainForm.b_WPN_Assault;
            checkSAW.Checked = mainForm.b_WPN_SAW;
            checkSniper.Checked = mainForm.b_WPN_Sniper;
            checkRPG.Checked = mainForm.b_WPN_RPG;
            checkGauss.Checked = mainForm.b_WPN_Gauss;
            checkShock.Checked = mainForm.b_WPN_Shock;
            checkGL.Checked = mainForm.b_WPN_GL;
            checkFlame.Checked = mainForm.b_WPN_Flame;
            checkMinigun.Checked = mainForm.b_WPN_Minigun;
            checkSuit.Checked = mainForm.b_WPN_Suit;

            // Ammo
            numericPistol.Value = numericAkimbo.Value = numericMP5.Value = mainForm.i_AMMO_9mm;
            numericAssault.Value = numericSAW.Value = mainForm.i_AMMO_SAW;
            numericShotgun.Value = mainForm.i_AMMO_Shotgun;
            numericShock.Value = mainForm.i_AMMO_Shock;
            numericSniper.Value = mainForm.i_AMMO_Sniper;
            numericARGrenades.Value = mainForm.i_AMMO_ARGrenade;
            numericFlame.Value = mainForm.i_AMMO_Flame;
            numericMinigun.Value = mainForm.i_AMMO_Minigun;
            numericPython.Value = mainForm.i_AMMO_357;
            numericGauss.Value = mainForm.i_AMMO_Gauss;
            numericRPG.Value = mainForm.i_AMMO_RPG;
            numericCrossbow.Value = mainForm.i_AMMO_Crossbow;
            numericTripmines.Value = mainForm.i_AMMO_Tripmine;
            numericSatchels.Value = mainForm.i_AMMO_Satchel;
            numericHandGrenades.Value = mainForm.i_AMMO_Grenade;
            numericGL.Value = mainForm.i_AMMO_GLauncher;
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            mainForm.UpdateUpgradesContextItems();
        }

        // These are for shared weapon ammo
        private void pistolLeave(object sender, EventArgs e)
        {
            numericAkimbo.Value = numericMP5.Value = numericPistol.Value;
        }

        private void akimboLeave(object sender, EventArgs e)
        {
            numericPistol.Value = numericMP5.Value = numericAkimbo.Value;
        }

        private void mp5Leave(object sender, EventArgs e)
        {
            numericAkimbo.Value = numericPistol.Value = numericMP5.Value;
        }

        private void assaultLeave(object sender, EventArgs e)
        {
            numericSAW.Value = numericAssault.Value;
        }

        private void sawLeave(object sender, EventArgs e)
        {
            numericAssault.Value = numericSAW.Value;
        }
    }
}
