namespace BDefSaveEditor
{
    partial class TasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTaskNumber = new System.Windows.Forms.Label();
            this.boxTaskNumber = new System.Windows.Forms.NumericUpDown();
            this.labelTaskType = new System.Windows.Forms.Label();
            this.comboTaskType = new System.Windows.Forms.ComboBox();
            this.labelTaskProgress = new System.Windows.Forms.Label();
            this.labelTaskGoal1 = new System.Windows.Forms.Label();
            this.boxTaskProgress = new System.Windows.Forms.NumericUpDown();
            this.labelTaskGoal2 = new System.Windows.Forms.Label();
            this.labelEventTask = new System.Windows.Forms.Label();
            this.boxTaskEvent = new System.Windows.Forms.NumericUpDown();
            this.labelEventProgress = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxTaskNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxTaskProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxTaskEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTaskNumber
            // 
            this.labelTaskNumber.AutoSize = true;
            this.labelTaskNumber.Location = new System.Drawing.Point(12, 9);
            this.labelTaskNumber.Name = "labelTaskNumber";
            this.labelTaskNumber.Size = new System.Drawing.Size(74, 13);
            this.labelTaskNumber.TabIndex = 0;
            this.labelTaskNumber.Text = "Task Number:";
            // 
            // boxTaskNumber
            // 
            this.boxTaskNumber.Location = new System.Drawing.Point(15, 25);
            this.boxTaskNumber.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.boxTaskNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxTaskNumber.Name = "boxTaskNumber";
            this.boxTaskNumber.Size = new System.Drawing.Size(90, 20);
            this.boxTaskNumber.TabIndex = 1;
            // 
            // labelTaskType
            // 
            this.labelTaskType.AutoSize = true;
            this.labelTaskType.Location = new System.Drawing.Point(120, 9);
            this.labelTaskType.Name = "labelTaskType";
            this.labelTaskType.Size = new System.Drawing.Size(61, 13);
            this.labelTaskType.TabIndex = 2;
            this.labelTaskType.Text = "Task Type:";
            // 
            // comboTaskType
            // 
            this.comboTaskType.FormattingEnabled = true;
            this.comboTaskType.Items.AddRange(new object[] {
            "Gates",
            "Kill Panthers",
            "Kill Gonomes",
            "Kill Grunts",
            "Kill Controllers",
            "Kill Slaves",
            "Kill Houndeyes",
            "Kill Bullsquids",
            "Kill ANY",
            "Melee Kills",
            "Kill Pit Drones",
            "Kill Troopers",
            "Kill Zombies"});
            this.comboTaskType.Location = new System.Drawing.Point(123, 25);
            this.comboTaskType.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.comboTaskType.Name = "comboTaskType";
            this.comboTaskType.Size = new System.Drawing.Size(90, 21);
            this.comboTaskType.TabIndex = 2;
            this.comboTaskType.SelectedIndexChanged += new System.EventHandler(this.comboTaskType_SelectedIndexChanged);
            // 
            // labelTaskProgress
            // 
            this.labelTaskProgress.AutoSize = true;
            this.labelTaskProgress.Location = new System.Drawing.Point(12, 57);
            this.labelTaskProgress.Name = "labelTaskProgress";
            this.labelTaskProgress.Size = new System.Drawing.Size(78, 13);
            this.labelTaskProgress.TabIndex = 4;
            this.labelTaskProgress.Text = "Task Progress:";
            // 
            // labelTaskGoal1
            // 
            this.labelTaskGoal1.AutoSize = true;
            this.labelTaskGoal1.Location = new System.Drawing.Point(12, 78);
            this.labelTaskGoal1.Name = "labelTaskGoal1";
            this.labelTaskGoal1.Size = new System.Drawing.Size(42, 13);
            this.labelTaskGoal1.TabIndex = 5;
            this.labelTaskGoal1.Text = "Dummy";
            // 
            // boxTaskProgress
            // 
            this.boxTaskProgress.Location = new System.Drawing.Point(60, 76);
            this.boxTaskProgress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.boxTaskProgress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxTaskProgress.Name = "boxTaskProgress";
            this.boxTaskProgress.Size = new System.Drawing.Size(41, 20);
            this.boxTaskProgress.TabIndex = 3;
            this.boxTaskProgress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxTaskProgress.ValueChanged += new System.EventHandler(this.boxTaskProgress_ValueChanged);
            // 
            // labelTaskGoal2
            // 
            this.labelTaskGoal2.AutoSize = true;
            this.labelTaskGoal2.Location = new System.Drawing.Point(107, 78);
            this.labelTaskGoal2.Name = "labelTaskGoal2";
            this.labelTaskGoal2.Size = new System.Drawing.Size(42, 13);
            this.labelTaskGoal2.TabIndex = 7;
            this.labelTaskGoal2.Text = "Dummy";
            // 
            // labelEventTask
            // 
            this.labelEventTask.AutoSize = true;
            this.labelEventTask.Location = new System.Drawing.Point(12, 108);
            this.labelEventTask.Name = "labelEventTask";
            this.labelEventTask.Size = new System.Drawing.Size(65, 13);
            this.labelEventTask.TabIndex = 8;
            this.labelEventTask.Text = "Event Task:";
            // 
            // boxTaskEvent
            // 
            this.boxTaskEvent.Location = new System.Drawing.Point(60, 124);
            this.boxTaskEvent.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.boxTaskEvent.Name = "boxTaskEvent";
            this.boxTaskEvent.Size = new System.Drawing.Size(41, 20);
            this.boxTaskEvent.TabIndex = 4;
            // 
            // labelEventProgress
            // 
            this.labelEventProgress.AutoSize = true;
            this.labelEventProgress.Location = new System.Drawing.Point(107, 126);
            this.labelEventProgress.Name = "labelEventProgress";
            this.labelEventProgress.Size = new System.Drawing.Size(91, 13);
            this.labelEventProgress.TabIndex = 10;
            this.labelEventProgress.Text = "Candies collected";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(138, 155);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.TabStop = false;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // TasksForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 190);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelEventProgress);
            this.Controls.Add(this.boxTaskEvent);
            this.Controls.Add(this.labelEventTask);
            this.Controls.Add(this.labelTaskGoal2);
            this.Controls.Add(this.boxTaskProgress);
            this.Controls.Add(this.labelTaskGoal1);
            this.Controls.Add(this.labelTaskProgress);
            this.Controls.Add(this.comboTaskType);
            this.Controls.Add(this.labelTaskType);
            this.Controls.Add(this.boxTaskNumber);
            this.Controls.Add(this.labelTaskNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TasksForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Tasks";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxTaskNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxTaskProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxTaskEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaskNumber;
        private System.Windows.Forms.NumericUpDown boxTaskNumber;
        private System.Windows.Forms.Label labelTaskType;
        private System.Windows.Forms.ComboBox comboTaskType;
        private System.Windows.Forms.Label labelTaskProgress;
        private System.Windows.Forms.Label labelTaskGoal1;
        private System.Windows.Forms.NumericUpDown boxTaskProgress;
        private System.Windows.Forms.Label labelTaskGoal2;
        private System.Windows.Forms.Label labelEventTask;
        private System.Windows.Forms.NumericUpDown boxTaskEvent;
        private System.Windows.Forms.Label labelEventProgress;
        private System.Windows.Forms.Button buttonOK;
    }
}