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
    public partial class Form3 : Form
    {
        Main mainForm;

        // Can't make "const"...?
        string[] szTaskGoal1 =
        {
            "Raise",
            "Kill", // I know, duplicates...
            "Kill",
            "Kill",
            "Kill",
            "Kill",
            "Kill",
            "Kill",
            "Kill",
            "Make",
            "Kill",
            "Kill",
            "Kill"
        };

        string[] szTaskGoal2 =
        {
            "gate",
            "Panther",
            "Gonome",
            "Grunt",
            "Controller",
            "Slave",
            "Houndeye",
            "Bullsquid",
            "monster",
            "melee kill",
            "Pit Drone",
            "Trooper",
            "Zombie"
        };

        public Form3(Main link)
        {
            InitializeComponent();
            mainForm = link;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            mainForm.i_TASK_Number = (int)boxTaskNumber.Value;
            mainForm.i_TASK_Type = comboTaskType.SelectedIndex;
            mainForm.i_TASK_Remain = (int)boxTaskProgress.Value;
            
            if (boxTaskEvent.Enabled)
                mainForm.i_TASK_Event = (int)boxTaskEvent.Value;

            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            boxTaskNumber.Value = mainForm.i_TASK_Number;
            comboTaskType.SelectedIndex = mainForm.i_TASK_Type;
            boxTaskProgress.Value = mainForm.i_TASK_Remain;

            if (mainForm.i_TASK_Event > 31)
            {
                boxTaskEvent.Value = 31;
                boxTaskEvent.Enabled = false;
                labelEventProgress.Text = "Event complete";
            }
            else
            {
                boxTaskEvent.Value = mainForm.i_TASK_Event;
                boxTaskEvent.Enabled = true;
                labelEventProgress.Text = "Candies collected";
            }
        }

        private void comboTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTaskGoal1.Text = szTaskGoal1[comboTaskType.SelectedIndex];
            boxTaskProgress_ValueChanged(sender, e);
        }

        private void boxTaskProgress_ValueChanged(object sender, EventArgs e)
        {
            if (boxTaskProgress.Value > 1)
                labelTaskGoal2.Text = szTaskGoal2[comboTaskType.SelectedIndex] + "s";
            else
                labelTaskGoal2.Text = szTaskGoal2[comboTaskType.SelectedIndex];
        }
    }
}
