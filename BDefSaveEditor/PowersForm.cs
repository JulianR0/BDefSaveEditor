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
    public partial class PowersForm : Form
    {
        Main mainForm;
        int iPlayerClass;

        public PowersForm(Main link)
        {
            InitializeComponent();
            mainForm = link;
        }

        private void PowersForm_Load(object sender, EventArgs e)
        {
            // Update texts
            iPlayerClass = mainForm.comboClass.SelectedIndex + 1;
            switch (iPlayerClass)
            {
                case 1: // Rushing
                    {
                        radioSkill1B2.Text = "Swiftness";
                        radioSkill1B3.Text = "Striking";
                        radioSkill2B2.Text = "Thorns";
                        radioSkill2B3.Text = "Stomping";
                        radioSkill3B2.Text = "Mighty";
                        radioSkill3B3.Text = "Enduring";
                        radioSkill4B2.Text = "Unstoppable";
                        break;
                    }
                case 2: // Religious
                    {
                        radioSkill1B2.Text = "Fortitude";
                        radioSkill1B3.Text = "Lethality";
                        radioSkill2B2.Text = "Defensive";
                        radioSkill2B3.Text = "Healing";
                        radioSkill3B2.Text = "Hunting";
                        radioSkill3B3.Text = "Assault";
                        radioSkill4B2.Text = "Enchanting";
                        break;
                    }
                case 3: // Provident
                    {
                        radioSkill1B2.Text = "Rapid";
                        radioSkill1B3.Text = "Sharp";
                        radioSkill2B2.Text = "Explosive";
                        radioSkill2B3.Text = "Generous";
                        radioSkill3B2.Text = "Binding";
                        radioSkill3B3.Text = "Furious";
                        radioSkill4B2.Text = "Numerous";
                        break;
                    }
            }

            // Set the radio boxes
            switch (mainForm.i_POWER_First)
            {
                case 0: radioSkill1B1.Checked = true; break;
                case 1: radioSkill1B2.Checked = true; break;
                case 2: radioSkill1B3.Checked = true; break;
            }
            switch (mainForm.i_POWER_Second)
            {
                case 0: radioSkill2B1.Checked = true; break;
                case 1: radioSkill2B2.Checked = true; break;
                case 2: radioSkill2B3.Checked = true; break;
            }
            switch (mainForm.i_POWER_Third)
            {
                case 0: radioSkill3B1.Checked = true; break;
                case 1: radioSkill3B2.Checked = true; break;
                case 2: radioSkill3B3.Checked = true; break;
            }
            switch (mainForm.i_POWER_Fourth)
            {
                case 0: radioSkill4B1.Checked = true; break;
                case 1: radioSkill4B2.Checked = true; break;
            }

            // Update the label descriptions
            //UpdatePowersDescription();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioSkill1B1.Checked) mainForm.i_POWER_First = 0;
            else if (radioSkill1B2.Checked) mainForm.i_POWER_First = 1;
            else if (radioSkill1B3.Checked) mainForm.i_POWER_First = 2;

            if (radioSkill2B1.Checked) mainForm.i_POWER_Second = 0;
            else if (radioSkill1B2.Checked) mainForm.i_POWER_Second = 1;
            else if (radioSkill1B3.Checked) mainForm.i_POWER_Second = 2;

            if (radioSkill3B1.Checked) mainForm.i_POWER_Third = 0;
            else if (radioSkill1B2.Checked) mainForm.i_POWER_Third = 1;
            else if (radioSkill1B3.Checked) mainForm.i_POWER_Third = 2;

            if (radioSkill4B1.Checked) mainForm.i_POWER_Fourth = 0;
            else if (radioSkill1B2.Checked) mainForm.i_POWER_Fourth = 1;

            this.Close();
        }

        private void UpdatePowersDescription()
        {
            if (radioSkill1B1.Checked)
                label1Info.Text = "No power selected.";
            else if (radioSkill1B2.Checked)
            {
                switch (iPlayerClass)
                {
                    case 1: // Rushing
                        {
                            label1Info.Text = "You will have increased move speed while affected by\nRush skill.\n\n";
                            label1Info.Text += "Additional move speed: 100";
                            break;
                        }
                    case 2: // Religious
                        {
                            label1Info.Text = "Your angels will have damage reduction and increased\nHP regeneration.\n\n";
                            label1Info.Text += "HP regeneration: 8% of max HP per second\nDamage reduction: 25%";
                            break;
                        }
                    case 3: // Provident
                        {
                            label1Info.Text = "Machinegun upgrade.\n\nIt will change attack speed and damage of your turrets.\n\n";
                            label1Info.Text += "Attack speed: 5 shots per second\nAttack damage: 10";
                            break;
                        }
                }
            }
            else if (radioSkill1B3.Checked)
            {
                switch (iPlayerClass)
                {
                    case 1: // Rushing
                        {
                            label1Info.Text = "You will get critical hit chance while affected by Rush skill.\n\n";
                            label1Info.Text += "Critical hit chance: 25%\nCritical hit damage: 200%";
                            break;
                        }
                    case 2: // Religious
                        {
                            label1Info.Text = "Your angels will deal more damage to enemies.\n\n";
                            label1Info.Text += "Bonus damage: 50%";
                            break;
                        }
                    case 3: // Provident
                        {
                            label1Info.Text = "Sniper rifle upgrade.\n\nIt will change attack speed and damage of your turrets.\n\n";
                            label1Info.Text += "Attack speed: 1 shot per second\nAttack damage: 85";
                            break;
                        }
                }
            }

            if (radioSkill2B1.Checked)
                label2Info.Text = "No power selected.";
            else if (radioSkill2B2.Checked)
            {
                switch (iPlayerClass)
                {
                    case 1: // Rushing
                        {
                            label2Info.Text = "You will return damage taken to it's dealer while affected\nby Rush skill.\n\n";
                            label2Info.Text += "Damage returned: 75%";
                            break;
                        }
                    case 2: // Religious
                        {
                            label2Info.Text = "Your angels will grant Defiance aura.\n\n";
                            label2Info.Text += "Defiance aura increases defense points of all characters.\nDefiance radius: 512\nDefiance bonus armor: 50%";
                            break;
                        }
                    case 3: // Provident
                        {
                            label2Info.Text = "Explosive charge upgrade.\n\nWhen your turrets are broken by enemies they will\nexplode, dealing massive damage around.\n\n";
                            label2Info.Text += "Explosion damage: 150";
                            break;
                        }
                }
            }
            else if (radioSkill2B3.Checked)
            {
                switch (iPlayerClass)
                {
                    case 1: // Rushing
                        {
                            label2Info.Text = "You will deal massive damage around you when\nRush skill effect ends.\n\n";
                            label2Info.Text += "Damage: 120";
                            break;
                        }
                    case 2: // Religious
                        {
                            label2Info.Text = "When your angels fall in battle they will heal all allies.\n\n";
                            label2Info.Text += "Heal radius: 512\nHeal amount: 25%";
                            break;
                        }
                    case 3: // Provident
                        {
                            label2Info.Text = "Supply crates upgrade.\n\nYour turrets will spawn a supply crate every 1 minute.\nCrate is usable 4 times and dissappears after.\n\n";
                            label2Info.Text += "It contains 4 packs of:\n- 4 Shotgun rounds\n- 15 Pistol/SMG rounds\n- 10 HP medical kit\n\n";
                            label2Info.Text += "You get 1 pack per use.\n\nNew crate won't appear if the old one still exists.";
                            break;
                        }
                }
            }

            if (radioSkill3B1.Checked)
                label3Info.Text = "No power selected.";
            else if (radioSkill3B2.Checked)
            {
                switch (iPlayerClass)
                {
                    case 1: // Rushing
                        {
                            label3Info.Text = "You will deal more damage while affected by Rush skill.\n\n";
                            label3Info.Text += "Bonus damage: 100%";
                            break;
                        }
                    case 2: // Religious
                        {
                            label3Info.Text = "All angels now will have Hand Grenades.\nYou will have a chance to call angel armed with Shotgun.\n\n";
                            label3Info.Text += "Call chance: 50%\n\nOther angels will be armed with SMGs by default.";
                            break;
                        }
                    case 3: // Provident
                        {
                            label3Info.Text = "Builder binding upgrade.\n\nYour turrets will be bound with your characteristics\nincreasing their own power.\n\n";
                            label3Info.Text += "Legerity: attack speed. 2% per point, caps at 100%\nPrecision: attack damage. 2% per point, caps at 300%\nToughness: maximum HP. Square of points, no cap.";
                            break;
                        }
                }
            }
            else if (radioSkill3B3.Checked)
            {
                switch (iPlayerClass)
                {
                    case 1: // Rushing
                        {
                            label3Info.Text = "Duration of Rush skill will become longer.\nAdds bonus duration to base duration of the Rush skill.\n\n";
                            label3Info.Text += "Bonus duration: 8 seconds";
                            break;
                        }
                    case 2: // Religious
                        {
                            label3Info.Text = "You will have a chance to call angel with Assault Rifle\nand Grenade Launcher.\n\n";
                            label3Info.Text += "Call chance: 50%\n\nOther angels will be armed with SMGs by default.";
                            break;
                        }
                    case 3: // Provident
                        {
                            label3Info.Text = "Berserker mode upgrade.\n\nIf your turrets are surrounded by 3 or more enemies, they\nwill go berserker mode.\n\n";
                            label3Info.Text += "Berserker damage reduction: 75%\nBerserker bonus attack speed: 100%\n\n";
                            label3Info.Text += "Bonus turret maximum HP: 40 per builder level";
                            break;
                        }
                }
            }

            if (radioSkill4B1.Checked)
                label4Info.Text = "No power selected.";
            else if (radioSkill4B2.Checked)
            {
                switch (iPlayerClass)
                {
                    case 1: // Rushing
                        {
                            label4Info.Text = "Basic damage reduction of Rush skill is increased.\n\n";
                            label4Info.Text += "Damage reduction: 99%";
                            break;
                        }
                    case 2: // Religious
                        {
                            label4Info.Text = "Your angels will have an enchantment on their weapons.\nStacks with Lethality Power.\n\n";
                            label4Info.Text += "Enchantment damage: 1 per 4 Sorcery";
                            break;
                        }
                    case 3: // Provident
                        {
                            label4Info.Text = "Builder technical skills improvement.\n\nAllows you to build more turrets.\n\n";
                            label4Info.Text += "Amount: 3 turrets.\nBonus: +1 turret per 10 builder levels (from level 40)";
                            break;
                        }
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePowersDescription();
        }
    }
}
