using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDefSaveEditor
{
    public partial class Form2 : Form
    {
        Main mainForm;

        public Form2(Main link)
        {
            InitializeComponent();
            mainForm = link;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
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
            mainForm.b_WPN_RPG = checkRPG.Checked;
            mainForm.b_WPN_Gauss = checkGauss.Checked;
            mainForm.b_WPN_Shock = checkShock.Checked;
            mainForm.b_WPN_GL = checkGL.Checked;
            mainForm.b_WPN_Flame = checkFlame.Checked;
            mainForm.b_WPN_Minigun = checkMinigun.Checked;
            mainForm.b_WPN_Suit = checkSuit.Checked;

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
            checkRPG.Checked = mainForm.b_WPN_RPG;
            checkGauss.Checked = mainForm.b_WPN_Gauss;
            checkShock.Checked = mainForm.b_WPN_Shock;
            checkGL.Checked = mainForm.b_WPN_GL;
            checkFlame.Checked = mainForm.b_WPN_Flame;
            checkMinigun.Checked = mainForm.b_WPN_Minigun;
            checkSuit.Checked = mainForm.b_WPN_Suit;
        }
    }
}
