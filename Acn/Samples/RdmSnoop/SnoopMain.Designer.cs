﻿namespace RdmSnoop
{
    partial class SnoopMain
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
            this.tools = new System.Windows.Forms.ToolStrip();
            this.rdmNetSelect = new System.Windows.Forms.ToolStripButton();
            this.artNetSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.networkCardSelect = new System.Windows.Forms.ToolStripComboBox();
            this.discoverSelect = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rdmDevices = new System.Windows.Forms.TreeView();
            this.deviceInformation = new System.Windows.Forms.PropertyGrid();
            this.deviceToolbox = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.identifyOn = new System.Windows.Forms.ToolStripMenuItem();
            this.identifyOff = new System.Windows.Forms.ToolStripMenuItem();
            this.addressTool = new System.Windows.Forms.ToolStripButton();
            this.modeTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.resetTool = new System.Windows.Forms.ToolStripMenuItem();
            this.selfTestTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.powerOffTool = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownTool = new System.Windows.Forms.ToolStripMenuItem();
            this.powerStandbyTool = new System.Windows.Forms.ToolStripMenuItem();
            this.powerOnTool = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.packetView = new System.Windows.Forms.ListView();
            this.tools.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.deviceToolbox.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rdmNetSelect,
            this.artNetSelect,
            this.toolStripSeparator1,
            this.networkCardSelect,
            this.discoverSelect});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(980, 38);
            this.tools.TabIndex = 0;
            this.tools.Text = "tools";
            // 
            // rdmNetSelect
            // 
            this.rdmNetSelect.Checked = true;
            this.rdmNetSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdmNetSelect.Image = global::RdmSnoop.Properties.Resources.OrgChartHS;
            this.rdmNetSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rdmNetSelect.Name = "rdmNetSelect";
            this.rdmNetSelect.Size = new System.Drawing.Size(56, 35);
            this.rdmNetSelect.Text = "RDMNet";
            this.rdmNetSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdmNetSelect.Click += new System.EventHandler(this.rdmNetSelect_Click);
            // 
            // artNetSelect
            // 
            this.artNetSelect.Image = global::RdmSnoop.Properties.Resources.ArtNet;
            this.artNetSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.artNetSelect.Name = "artNetSelect";
            this.artNetSelect.Size = new System.Drawing.Size(46, 35);
            this.artNetSelect.Text = "ArtNet";
            this.artNetSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.artNetSelect.Click += new System.EventHandler(this.artNetSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // networkCardSelect
            // 
            this.networkCardSelect.DropDownWidth = 600;
            this.networkCardSelect.Name = "networkCardSelect";
            this.networkCardSelect.Size = new System.Drawing.Size(250, 38);
            this.networkCardSelect.SelectedIndexChanged += new System.EventHandler(this.networkCardSelect_SelectedIndexChanged);
            // 
            // discoverSelect
            // 
            this.discoverSelect.Image = global::RdmSnoop.Properties.Resources.RepeatHS;
            this.discoverSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.discoverSelect.Name = "discoverSelect";
            this.discoverSelect.Size = new System.Drawing.Size(50, 35);
            this.discoverSelect.Text = "Refresh";
            this.discoverSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.discoverSelect.Click += new System.EventHandler(this.discoverSelect_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rdmDevices);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deviceInformation);
            this.splitContainer1.Panel2.Controls.Add(this.deviceToolbox);
            this.splitContainer1.Size = new System.Drawing.Size(980, 335);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 1;
            // 
            // rdmDevices
            // 
            this.rdmDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdmDevices.Location = new System.Drawing.Point(0, 0);
            this.rdmDevices.Name = "rdmDevices";
            this.rdmDevices.Size = new System.Drawing.Size(325, 335);
            this.rdmDevices.TabIndex = 0;
            this.rdmDevices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rdmDevices_AfterSelect);
            // 
            // deviceInformation
            // 
            this.deviceInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceInformation.Location = new System.Drawing.Point(0, 38);
            this.deviceInformation.Name = "deviceInformation";
            this.deviceInformation.Size = new System.Drawing.Size(651, 297);
            this.deviceInformation.TabIndex = 0;
            // 
            // deviceToolbox
            // 
            this.deviceToolbox.Enabled = false;
            this.deviceToolbox.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.deviceToolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.addressTool,
            this.modeTool,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.deviceToolbox.Location = new System.Drawing.Point(0, 0);
            this.deviceToolbox.Name = "deviceToolbox";
            this.deviceToolbox.Size = new System.Drawing.Size(651, 38);
            this.deviceToolbox.TabIndex = 1;
            this.deviceToolbox.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identifyOn,
            this.identifyOff});
            this.toolStripDropDownButton1.Image = global::RdmSnoop.Properties.Resources._008_Reminder_32x42_72;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 35);
            this.toolStripDropDownButton1.Text = "Identify";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // identifyOn
            // 
            this.identifyOn.Name = "identifyOn";
            this.identifyOn.Size = new System.Drawing.Size(91, 22);
            this.identifyOn.Text = "On";
            this.identifyOn.Click += new System.EventHandler(this.identifyOn_Click);
            // 
            // identifyOff
            // 
            this.identifyOff.Name = "identifyOff";
            this.identifyOff.Size = new System.Drawing.Size(91, 22);
            this.identifyOff.Text = "Off";
            this.identifyOff.Click += new System.EventHandler(this.identifyOff_Click);
            // 
            // addressTool
            // 
            this.addressTool.Image = global::RdmSnoop.Properties.Resources._1446_envelope_stamp_clsd_48;
            this.addressTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addressTool.Name = "addressTool";
            this.addressTool.Size = new System.Drawing.Size(53, 35);
            this.addressTool.Text = "Address";
            this.addressTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addressTool.Click += new System.EventHandler(this.addressTool_Click);
            // 
            // modeTool
            // 
            this.modeTool.Image = global::RdmSnoop.Properties.Resources.settings_16;
            this.modeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modeTool.Name = "modeTool";
            this.modeTool.Size = new System.Drawing.Size(51, 35);
            this.modeTool.Text = "Mode";
            this.modeTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.modeTool.DropDownOpened += new System.EventHandler(this.modeTool_DropDownOpened);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetTool,
            this.selfTestTool});
            this.toolStripDropDownButton2.Image = global::RdmSnoop.Properties.Resources.Gear;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(58, 35);
            this.toolStripDropDownButton2.Text = "System";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // resetTool
            // 
            this.resetTool.Name = "resetTool";
            this.resetTool.Size = new System.Drawing.Size(118, 22);
            this.resetTool.Text = "Reset";
            this.resetTool.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // selfTestTool
            // 
            this.selfTestTool.Name = "selfTestTool";
            this.selfTestTool.Size = new System.Drawing.Size(118, 22);
            this.selfTestTool.Text = "Self Test";
            this.selfTestTool.Click += new System.EventHandler(this.selfTestTool_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerOffTool,
            this.shutdownTool,
            this.powerStandbyTool,
            this.powerOnTool});
            this.toolStripDropDownButton3.Image = global::RdmSnoop.Properties.Resources.Red_Power_Button_clip_art_small;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(53, 35);
            this.toolStripDropDownButton3.Text = "Power";
            this.toolStripDropDownButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // powerOffTool
            // 
            this.powerOffTool.Name = "powerOffTool";
            this.powerOffTool.Size = new System.Drawing.Size(152, 22);
            this.powerOffTool.Text = "Off";
            this.powerOffTool.Click += new System.EventHandler(this.powerOffTool_Click);
            // 
            // shutdownTool
            // 
            this.shutdownTool.Name = "shutdownTool";
            this.shutdownTool.Size = new System.Drawing.Size(152, 22);
            this.shutdownTool.Text = "Shutdown";
            this.shutdownTool.Click += new System.EventHandler(this.shutdownTool_Click);
            // 
            // powerStandbyTool
            // 
            this.powerStandbyTool.Name = "powerStandbyTool";
            this.powerStandbyTool.Size = new System.Drawing.Size(152, 22);
            this.powerStandbyTool.Text = "Standby";
            this.powerStandbyTool.Click += new System.EventHandler(this.powerStandbyTool_Click);
            // 
            // powerOnTool
            // 
            this.powerOnTool.Name = "powerOnTool";
            this.powerOnTool.Size = new System.Drawing.Size(152, 22);
            this.powerOnTool.Text = "On";
            this.powerOnTool.Click += new System.EventHandler(this.powerOnTool_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 38);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.packetView);
            this.splitContainer2.Size = new System.Drawing.Size(980, 502);
            this.splitContainer2.SplitterDistance = 335;
            this.splitContainer2.TabIndex = 2;
            // 
            // packetView
            // 
            this.packetView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packetView.Location = new System.Drawing.Point(0, 0);
            this.packetView.Name = "packetView";
            this.packetView.Size = new System.Drawing.Size(980, 163);
            this.packetView.TabIndex = 0;
            this.packetView.UseCompatibleStateImageBehavior = false;
            this.packetView.View = System.Windows.Forms.View.Details;
            // 
            // SnoopMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 540);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.tools);
            this.Name = "SnoopMain";
            this.Text = "RDM Snoop";
            this.Load += new System.EventHandler(this.SnoopMain_Load);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.deviceToolbox.ResumeLayout(false);
            this.deviceToolbox.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView rdmDevices;
        private System.Windows.Forms.PropertyGrid deviceInformation;
        private System.Windows.Forms.ToolStripButton rdmNetSelect;
        private System.Windows.Forms.ToolStripButton artNetSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox networkCardSelect;
        private System.Windows.Forms.ToolStripButton discoverSelect;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView packetView;
        private System.Windows.Forms.ToolStrip deviceToolbox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem identifyOn;
        private System.Windows.Forms.ToolStripMenuItem identifyOff;
        private System.Windows.Forms.ToolStripButton addressTool;
        private System.Windows.Forms.ToolStripDropDownButton modeTool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem resetTool;
        private System.Windows.Forms.ToolStripMenuItem selfTestTool;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem powerOffTool;
        private System.Windows.Forms.ToolStripMenuItem shutdownTool;
        private System.Windows.Forms.ToolStripMenuItem powerStandbyTool;
        private System.Windows.Forms.ToolStripMenuItem powerOnTool;

    }
}

