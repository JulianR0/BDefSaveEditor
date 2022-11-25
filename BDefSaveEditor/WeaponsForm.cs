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
            mainForm.b_WPN_Railgun = checkRailgun.Checked;
            mainForm.b_WPN_Plasmagun = checkPlasmagun.Checked;
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
            mainForm.i_AMMO_Railgun = (int)numericRailgun.Value;
            mainForm.i_AMMO_Plasmagun = (int)numericPlasmagun.Value;

            // Upgrades
            mainForm.i_TIER_Melee = (int)upgradesMelee.Value;
            mainForm.i_TIER_Axe = (int)upgradesAxe.Value;
            mainForm.i_TIER_Pistol = (int)upgradesPistol.Value;
            mainForm.i_TIER_Blaster = (int)upgradesBlaster.Value;
            mainForm.i_TIER_357 = (int)upgrades357.Value;
            mainForm.i_TIER_Akimbo = (int)upgradesAkimbo.Value;
            mainForm.i_TIER_MP5 = (int)upgradesMP5.Value;
            mainForm.i_TIER_Shotgun = (int)upgradesShotgun.Value;
            mainForm.i_TIER_Crossbow = (int)upgradesCrossbow.Value;
            mainForm.i_TIER_Assault = (int)upgradesAssault.Value;
            mainForm.i_TIER_SAW = (int)upgradesSAW.Value;
            mainForm.i_TIER_Sniper = (int)upgradesSniper.Value;
            mainForm.i_TIER_RPG = (int)upgradesRPG.Value;
            mainForm.i_TIER_Gauss = (int)upgradesGauss.Value;
            mainForm.i_TIER_Shock = (int)upgradesShock.Value;
            mainForm.i_TIER_GL = (int)upgradesGL.Value;
            mainForm.i_TIER_Flame = (int)upgradesFlame.Value;
            mainForm.i_TIER_Grenade = (int)upgradesHandgrenade.Value;
            mainForm.i_TIER_Satchel = (int)upgradesSatchel.Value;
            mainForm.i_TIER_Tripmine = (int)upgradesTripmine.Value;
            mainForm.i_TIER_Minigun = (int)upgradesMinigun.Value;
            mainForm.i_TIER_Railgun = (int)upgradesRailgun.Value;
            mainForm.i_TIER_Plasmagun = (int)upgradesPlasmagun.Value;

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
            checkRailgun.Checked = mainForm.b_WPN_Railgun;
            checkPlasmagun.Checked = mainForm.b_WPN_Plasmagun;
            checkSuit.Checked = mainForm.b_WPN_Suit;

            // Ammo
            numericPistol.Value = numericAkimbo.Value = numericMP5.Value = mainForm.i_AMMO_9mm;
            numericAssault.Value = numericSAW.Value = mainForm.i_AMMO_SAW;
            numericShotgun.Value = mainForm.i_AMMO_Shotgun;
            numericShock.Value = mainForm.i_AMMO_Shock;
            numericSniper.Value = mainForm.i_AMMO_Sniper;
            numericARGrenades.Value = numericGL.Value = mainForm.i_AMMO_ARGrenade;
            numericFlame.Value = mainForm.i_AMMO_Flame;
            numericMinigun.Value = mainForm.i_AMMO_Minigun;
            numericPython.Value = mainForm.i_AMMO_357;
            numericGauss.Value = mainForm.i_AMMO_Gauss;
            numericRPG.Value = mainForm.i_AMMO_RPG;
            numericCrossbow.Value = mainForm.i_AMMO_Crossbow;
            numericTripmines.Value = mainForm.i_AMMO_Tripmine;
            numericSatchels.Value = mainForm.i_AMMO_Satchel;
            numericHandGrenades.Value = mainForm.i_AMMO_Grenade;
            numericRailgun.Value = mainForm.i_AMMO_Railgun;
            numericPlasmagun.Value = mainForm.i_AMMO_Plasmagun;

            // Upgrades
            upgradesMelee.Value = mainForm.i_TIER_Melee;
            upgradesAxe.Value = mainForm.i_TIER_Axe;
            upgradesPistol.Value = mainForm.i_TIER_Pistol;
            upgradesBlaster.Value = mainForm.i_TIER_Blaster;
            upgrades357.Value = mainForm.i_TIER_357;
            upgradesAkimbo.Value = mainForm.i_TIER_Akimbo;
            upgradesMP5.Value = mainForm.i_TIER_MP5;
            upgradesShotgun.Value = mainForm.i_TIER_Shotgun;
            upgradesCrossbow.Value = mainForm.i_TIER_Crossbow;
            upgradesAssault.Value = mainForm.i_TIER_Assault;
            upgradesSAW.Value = mainForm.i_TIER_SAW;
            upgradesSniper.Value = mainForm.i_TIER_Sniper;
            upgradesRPG.Value = mainForm.i_TIER_RPG;
            upgradesGauss.Value = mainForm.i_TIER_Gauss;
            upgradesShock.Value = mainForm.i_TIER_Shock;
            upgradesGL.Value = mainForm.i_TIER_GL;
            upgradesFlame.Value = mainForm.i_TIER_Flame;
            upgradesHandgrenade.Value = mainForm.i_TIER_Grenade;
            upgradesSatchel.Value = mainForm.i_TIER_Satchel;
            upgradesTripmine.Value = mainForm.i_TIER_Tripmine;
            upgradesMinigun.Value = mainForm.i_TIER_Minigun;
            upgradesRailgun.Value = mainForm.i_TIER_Railgun;
            upgradesPlasmagun.Value = mainForm.i_TIER_Plasmagun;
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

        private void numericARGrenades_Leave(object sender, EventArgs e)
        {
            numericGL.Value = numericARGrenades.Value;
        }

        private void numericGL_Leave(object sender, EventArgs e)
        {
            numericARGrenades.Value = numericGL.Value;
        }
    }
}
