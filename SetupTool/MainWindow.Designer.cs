﻿namespace SetupTool
{
    partial class MainWindow
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
            this.checkedListBoxApps = new System.Windows.Forms.CheckedListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxSettings = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDeletePackage = new System.Windows.Forms.Button();
            this.buttonAddPackage = new System.Windows.Forms.Button();
            this.buttonUncheckAllSoftware = new System.Windows.Forms.Button();
            this.buttonCheckRecommendedSoftware = new System.Windows.Forms.Button();
            this.buttonCheckRecommendedSettings = new System.Windows.Forms.Button();
            this.buttonUncheckAllSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxApps
            // 
            this.checkedListBoxApps.FormattingEnabled = true;
            this.checkedListBoxApps.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxApps.Name = "checkedListBoxApps";
            this.checkedListBoxApps.Size = new System.Drawing.Size(363, 274);
            this.checkedListBoxApps.Sorted = true;
            this.checkedListBoxApps.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(336, 379);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 41);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxApps);
            this.groupBox1.Location = new System.Drawing.Point(8, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Software";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxSettings);
            this.groupBox2.Location = new System.Drawing.Point(389, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 300);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkedListBoxSettings
            // 
            this.checkedListBoxSettings.FormattingEnabled = true;
            this.checkedListBoxSettings.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxSettings.Name = "checkedListBoxSettings";
            this.checkedListBoxSettings.Size = new System.Drawing.Size(363, 274);
            this.checkedListBoxSettings.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // buttonDeletePackage
            // 
            this.buttonDeletePackage.Location = new System.Drawing.Point(95, 333);
            this.buttonDeletePackage.Name = "buttonDeletePackage";
            this.buttonDeletePackage.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePackage.TabIndex = 6;
            this.buttonDeletePackage.Text = "Delete";
            this.buttonDeletePackage.UseVisualStyleBackColor = true;
            this.buttonDeletePackage.Click += new System.EventHandler(this.ButtonDeletePackage_Click);
            // 
            // buttonAddPackage
            // 
            this.buttonAddPackage.Location = new System.Drawing.Point(14, 333);
            this.buttonAddPackage.Name = "buttonAddPackage";
            this.buttonAddPackage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPackage.TabIndex = 7;
            this.buttonAddPackage.Text = "Add";
            this.buttonAddPackage.UseVisualStyleBackColor = true;
            this.buttonAddPackage.Click += new System.EventHandler(this.ButtonAddPackage_Click);
            // 
            // buttonUncheckAllSoftware
            // 
            this.buttonUncheckAllSoftware.Location = new System.Drawing.Point(308, 333);
            this.buttonUncheckAllSoftware.Name = "buttonUncheckAllSoftware";
            this.buttonUncheckAllSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonUncheckAllSoftware.TabIndex = 8;
            this.buttonUncheckAllSoftware.Text = "Uncheck all";
            this.buttonUncheckAllSoftware.UseVisualStyleBackColor = true;
            // 
            // buttonCheckRecommendedSoftware
            // 
            this.buttonCheckRecommendedSoftware.Location = new System.Drawing.Point(176, 333);
            this.buttonCheckRecommendedSoftware.Name = "buttonCheckRecommendedSoftware";
            this.buttonCheckRecommendedSoftware.Size = new System.Drawing.Size(126, 23);
            this.buttonCheckRecommendedSoftware.TabIndex = 9;
            this.buttonCheckRecommendedSoftware.Text = "Check recommended";
            this.buttonCheckRecommendedSoftware.UseVisualStyleBackColor = true;
            // 
            // buttonCheckRecommendedSettings
            // 
            this.buttonCheckRecommendedSettings.Location = new System.Drawing.Point(557, 333);
            this.buttonCheckRecommendedSettings.Name = "buttonCheckRecommendedSettings";
            this.buttonCheckRecommendedSettings.Size = new System.Drawing.Size(126, 23);
            this.buttonCheckRecommendedSettings.TabIndex = 11;
            this.buttonCheckRecommendedSettings.Text = "Check recommended";
            this.buttonCheckRecommendedSettings.UseVisualStyleBackColor = true;
            // 
            // buttonUncheckAllSettings
            // 
            this.buttonUncheckAllSettings.Location = new System.Drawing.Point(689, 333);
            this.buttonUncheckAllSettings.Name = "buttonUncheckAllSettings";
            this.buttonUncheckAllSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonUncheckAllSettings.TabIndex = 10;
            this.buttonUncheckAllSettings.Text = "Uncheck all";
            this.buttonUncheckAllSettings.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 432);
            this.Controls.Add(this.buttonCheckRecommendedSettings);
            this.Controls.Add(this.buttonUncheckAllSettings);
            this.Controls.Add(this.buttonCheckRecommendedSoftware);
            this.Controls.Add(this.buttonUncheckAllSoftware);
            this.Controls.Add(this.buttonAddPackage);
            this.Controls.Add(this.buttonDeletePackage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "SetupTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxApps;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxSettings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonDeletePackage;
        private System.Windows.Forms.Button buttonAddPackage;
        private System.Windows.Forms.Button buttonUncheckAllSoftware;
        private System.Windows.Forms.Button buttonCheckRecommendedSoftware;
        private System.Windows.Forms.Button buttonCheckRecommendedSettings;
        private System.Windows.Forms.Button buttonUncheckAllSettings;
    }
}
