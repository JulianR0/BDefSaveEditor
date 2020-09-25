namespace BDefSaveEditor
{
    partial class PowersForm
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
            this.radioSkill1B1 = new System.Windows.Forms.RadioButton();
            this.label1Info = new System.Windows.Forms.Label();
            this.radioSkill1B2 = new System.Windows.Forms.RadioButton();
            this.radioSkill1B3 = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSkill1 = new System.Windows.Forms.TabPage();
            this.tabSkill2 = new System.Windows.Forms.TabPage();
            this.radioSkill2B3 = new System.Windows.Forms.RadioButton();
            this.radioSkill2B1 = new System.Windows.Forms.RadioButton();
            this.radioSkill2B2 = new System.Windows.Forms.RadioButton();
            this.label2Info = new System.Windows.Forms.Label();
            this.tabSkill3 = new System.Windows.Forms.TabPage();
            this.radioSkill3B3 = new System.Windows.Forms.RadioButton();
            this.radioSkill3B1 = new System.Windows.Forms.RadioButton();
            this.radioSkill3B2 = new System.Windows.Forms.RadioButton();
            this.label3Info = new System.Windows.Forms.Label();
            this.tabSkill4 = new System.Windows.Forms.TabPage();
            this.radioSkill4B2 = new System.Windows.Forms.RadioButton();
            this.radioSkill4B1 = new System.Windows.Forms.RadioButton();
            this.label4Info = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabSkill1.SuspendLayout();
            this.tabSkill2.SuspendLayout();
            this.tabSkill3.SuspendLayout();
            this.tabSkill4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioSkill1B1
            // 
            this.radioSkill1B1.AutoSize = true;
            this.radioSkill1B1.Location = new System.Drawing.Point(3, 6);
            this.radioSkill1B1.Name = "radioSkill1B1";
            this.radioSkill1B1.Size = new System.Drawing.Size(81, 17);
            this.radioSkill1B1.TabIndex = 1;
            this.radioSkill1B1.TabStop = true;
            this.radioSkill1B1.Text = "Unassigned";
            this.radioSkill1B1.UseVisualStyleBackColor = true;
            this.radioSkill1B1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label1Info
            // 
            this.label1Info.AutoSize = true;
            this.label1Info.Location = new System.Drawing.Point(0, 35);
            this.label1Info.Name = "label1Info";
            this.label1Info.Size = new System.Drawing.Size(101, 13);
            this.label1Info.TabIndex = 2;
            this.label1Info.Text = "labelSkillDescription";
            // 
            // radioSkill1B2
            // 
            this.radioSkill1B2.AutoSize = true;
            this.radioSkill1B2.Location = new System.Drawing.Point(97, 6);
            this.radioSkill1B2.Name = "radioSkill1B2";
            this.radioSkill1B2.Size = new System.Drawing.Size(85, 17);
            this.radioSkill1B2.TabIndex = 3;
            this.radioSkill1B2.TabStop = true;
            this.radioSkill1B2.Text = "radioButton2";
            this.radioSkill1B2.UseVisualStyleBackColor = true;
            this.radioSkill1B2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioSkill1B3
            // 
            this.radioSkill1B3.AutoSize = true;
            this.radioSkill1B3.Location = new System.Drawing.Point(188, 6);
            this.radioSkill1B3.Name = "radioSkill1B3";
            this.radioSkill1B3.Size = new System.Drawing.Size(85, 17);
            this.radioSkill1B3.TabIndex = 4;
            this.radioSkill1B3.TabStop = true;
            this.radioSkill1B3.Text = "radioButton3";
            this.radioSkill1B3.UseVisualStyleBackColor = true;
            this.radioSkill1B3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSkill1);
            this.tabControl.Controls.Add(this.tabSkill2);
            this.tabControl.Controls.Add(this.tabSkill3);
            this.tabControl.Controls.Add(this.tabSkill4);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(288, 263);
            this.tabControl.TabIndex = 3;
            // 
            // tabSkill1
            // 
            this.tabSkill1.Controls.Add(this.radioSkill1B3);
            this.tabSkill1.Controls.Add(this.radioSkill1B1);
            this.tabSkill1.Controls.Add(this.radioSkill1B2);
            this.tabSkill1.Controls.Add(this.label1Info);
            this.tabSkill1.Location = new System.Drawing.Point(4, 22);
            this.tabSkill1.Name = "tabSkill1";
            this.tabSkill1.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkill1.Size = new System.Drawing.Size(280, 237);
            this.tabSkill1.TabIndex = 0;
            this.tabSkill1.Text = "Level 15";
            this.tabSkill1.UseVisualStyleBackColor = true;
            // 
            // tabSkill2
            // 
            this.tabSkill2.Controls.Add(this.radioSkill2B3);
            this.tabSkill2.Controls.Add(this.radioSkill2B1);
            this.tabSkill2.Controls.Add(this.radioSkill2B2);
            this.tabSkill2.Controls.Add(this.label2Info);
            this.tabSkill2.Location = new System.Drawing.Point(4, 22);
            this.tabSkill2.Name = "tabSkill2";
            this.tabSkill2.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkill2.Size = new System.Drawing.Size(280, 237);
            this.tabSkill2.TabIndex = 1;
            this.tabSkill2.Text = "Level 20";
            this.tabSkill2.UseVisualStyleBackColor = true;
            // 
            // radioSkill2B3
            // 
            this.radioSkill2B3.AutoSize = true;
            this.radioSkill2B3.Location = new System.Drawing.Point(188, 6);
            this.radioSkill2B3.Name = "radioSkill2B3";
            this.radioSkill2B3.Size = new System.Drawing.Size(85, 17);
            this.radioSkill2B3.TabIndex = 8;
            this.radioSkill2B3.TabStop = true;
            this.radioSkill2B3.Text = "radioButton3";
            this.radioSkill2B3.UseVisualStyleBackColor = true;
            this.radioSkill2B3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioSkill2B1
            // 
            this.radioSkill2B1.AutoSize = true;
            this.radioSkill2B1.Location = new System.Drawing.Point(3, 6);
            this.radioSkill2B1.Name = "radioSkill2B1";
            this.radioSkill2B1.Size = new System.Drawing.Size(81, 17);
            this.radioSkill2B1.TabIndex = 5;
            this.radioSkill2B1.TabStop = true;
            this.radioSkill2B1.Text = "Unassigned";
            this.radioSkill2B1.UseVisualStyleBackColor = true;
            this.radioSkill2B1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioSkill2B2
            // 
            this.radioSkill2B2.AutoSize = true;
            this.radioSkill2B2.Location = new System.Drawing.Point(97, 6);
            this.radioSkill2B2.Name = "radioSkill2B2";
            this.radioSkill2B2.Size = new System.Drawing.Size(85, 17);
            this.radioSkill2B2.TabIndex = 7;
            this.radioSkill2B2.TabStop = true;
            this.radioSkill2B2.Text = "radioButton2";
            this.radioSkill2B2.UseVisualStyleBackColor = true;
            this.radioSkill2B2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label2Info
            // 
            this.label2Info.AutoSize = true;
            this.label2Info.Location = new System.Drawing.Point(0, 35);
            this.label2Info.Name = "label2Info";
            this.label2Info.Size = new System.Drawing.Size(101, 13);
            this.label2Info.TabIndex = 6;
            this.label2Info.Text = "labelSkillDescription";
            // 
            // tabSkill3
            // 
            this.tabSkill3.Controls.Add(this.radioSkill3B3);
            this.tabSkill3.Controls.Add(this.radioSkill3B1);
            this.tabSkill3.Controls.Add(this.radioSkill3B2);
            this.tabSkill3.Controls.Add(this.label3Info);
            this.tabSkill3.Location = new System.Drawing.Point(4, 22);
            this.tabSkill3.Name = "tabSkill3";
            this.tabSkill3.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkill3.Size = new System.Drawing.Size(280, 237);
            this.tabSkill3.TabIndex = 2;
            this.tabSkill3.Text = "Level 25";
            this.tabSkill3.UseVisualStyleBackColor = true;
            // 
            // radioSkill3B3
            // 
            this.radioSkill3B3.AutoSize = true;
            this.radioSkill3B3.Location = new System.Drawing.Point(188, 6);
            this.radioSkill3B3.Name = "radioSkill3B3";
            this.radioSkill3B3.Size = new System.Drawing.Size(85, 17);
            this.radioSkill3B3.TabIndex = 12;
            this.radioSkill3B3.TabStop = true;
            this.radioSkill3B3.Text = "radioButton3";
            this.radioSkill3B3.UseVisualStyleBackColor = true;
            this.radioSkill3B3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioSkill3B1
            // 
            this.radioSkill3B1.AutoSize = true;
            this.radioSkill3B1.Location = new System.Drawing.Point(3, 6);
            this.radioSkill3B1.Name = "radioSkill3B1";
            this.radioSkill3B1.Size = new System.Drawing.Size(81, 17);
            this.radioSkill3B1.TabIndex = 9;
            this.radioSkill3B1.TabStop = true;
            this.radioSkill3B1.Text = "Unassigned";
            this.radioSkill3B1.UseVisualStyleBackColor = true;
            this.radioSkill3B1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioSkill3B2
            // 
            this.radioSkill3B2.AutoSize = true;
            this.radioSkill3B2.Location = new System.Drawing.Point(97, 6);
            this.radioSkill3B2.Name = "radioSkill3B2";
            this.radioSkill3B2.Size = new System.Drawing.Size(85, 17);
            this.radioSkill3B2.TabIndex = 11;
            this.radioSkill3B2.TabStop = true;
            this.radioSkill3B2.Text = "radioButton2";
            this.radioSkill3B2.UseVisualStyleBackColor = true;
            this.radioSkill3B2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label3Info
            // 
            this.label3Info.AutoSize = true;
            this.label3Info.Location = new System.Drawing.Point(0, 35);
            this.label3Info.Name = "label3Info";
            this.label3Info.Size = new System.Drawing.Size(101, 13);
            this.label3Info.TabIndex = 10;
            this.label3Info.Text = "labelSkillDescription";
            // 
            // tabSkill4
            // 
            this.tabSkill4.Controls.Add(this.radioSkill4B2);
            this.tabSkill4.Controls.Add(this.radioSkill4B1);
            this.tabSkill4.Controls.Add(this.label4Info);
            this.tabSkill4.Location = new System.Drawing.Point(4, 22);
            this.tabSkill4.Name = "tabSkill4";
            this.tabSkill4.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkill4.Size = new System.Drawing.Size(280, 237);
            this.tabSkill4.TabIndex = 3;
            this.tabSkill4.Text = "Level 40";
            this.tabSkill4.UseVisualStyleBackColor = true;
            // 
            // radioSkill4B2
            // 
            this.radioSkill4B2.AutoSize = true;
            this.radioSkill4B2.Location = new System.Drawing.Point(188, 6);
            this.radioSkill4B2.Name = "radioSkill4B2";
            this.radioSkill4B2.Size = new System.Drawing.Size(85, 17);
            this.radioSkill4B2.TabIndex = 12;
            this.radioSkill4B2.TabStop = true;
            this.radioSkill4B2.Text = "radioButton3";
            this.radioSkill4B2.UseVisualStyleBackColor = true;
            this.radioSkill4B2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioSkill4B1
            // 
            this.radioSkill4B1.AutoSize = true;
            this.radioSkill4B1.Location = new System.Drawing.Point(3, 6);
            this.radioSkill4B1.Name = "radioSkill4B1";
            this.radioSkill4B1.Size = new System.Drawing.Size(81, 17);
            this.radioSkill4B1.TabIndex = 9;
            this.radioSkill4B1.TabStop = true;
            this.radioSkill4B1.Text = "Unassigned";
            this.radioSkill4B1.UseVisualStyleBackColor = true;
            this.radioSkill4B1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label4Info
            // 
            this.label4Info.AutoSize = true;
            this.label4Info.Location = new System.Drawing.Point(0, 35);
            this.label4Info.Name = "label4Info";
            this.label4Info.Size = new System.Drawing.Size(101, 13);
            this.label4Info.TabIndex = 10;
            this.label4Info.Text = "labelSkillDescription";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(199, 269);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // PowersForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 299);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Powers";
            this.Load += new System.EventHandler(this.PowersForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSkill1.ResumeLayout(false);
            this.tabSkill1.PerformLayout();
            this.tabSkill2.ResumeLayout(false);
            this.tabSkill2.PerformLayout();
            this.tabSkill3.ResumeLayout(false);
            this.tabSkill3.PerformLayout();
            this.tabSkill4.ResumeLayout(false);
            this.tabSkill4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioSkill1B1;
        private System.Windows.Forms.RadioButton radioSkill1B3;
        private System.Windows.Forms.RadioButton radioSkill1B2;
        private System.Windows.Forms.Label label1Info;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSkill1;
        private System.Windows.Forms.TabPage tabSkill2;
        private System.Windows.Forms.TabPage tabSkill3;
        private System.Windows.Forms.TabPage tabSkill4;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RadioButton radioSkill2B3;
        private System.Windows.Forms.RadioButton radioSkill2B1;
        private System.Windows.Forms.RadioButton radioSkill2B2;
        private System.Windows.Forms.Label label2Info;
        private System.Windows.Forms.RadioButton radioSkill3B3;
        private System.Windows.Forms.RadioButton radioSkill3B1;
        private System.Windows.Forms.RadioButton radioSkill3B2;
        private System.Windows.Forms.Label label3Info;
        private System.Windows.Forms.RadioButton radioSkill4B2;
        private System.Windows.Forms.RadioButton radioSkill4B1;
        private System.Windows.Forms.Label label4Info;
    }
}