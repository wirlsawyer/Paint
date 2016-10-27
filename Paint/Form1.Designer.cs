namespace Paint
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.widthMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.widthMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.widthMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.widthMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripSplitButton1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(43, 22);
            this.toolStripSplitButton2.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.rectToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.TextToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.toolStripMenuItem3,
            this.colorToolStripMenuItem,
            this.widthToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(47, 22);
            this.toolStripSplitButton3.Text = "Tool";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Checked = true;
            this.lineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // rectToolStripMenuItem
            // 
            this.rectToolStripMenuItem.Name = "rectToolStripMenuItem";
            this.rectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rectToolStripMenuItem.Text = "Rect";
            this.rectToolStripMenuItem.Click += new System.EventHandler(this.rectToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // TextToolStripMenuItem
            // 
            this.TextToolStripMenuItem.Name = "TextToolStripMenuItem";
            this.TextToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.TextToolStripMenuItem.Text = "Text";
            this.TextToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(141, 6);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorMenuItem1,
            this.colorMenuItem2,
            this.colorMenuItem3,
            this.colorMenuItem4,
            this.colorMenuItem5,
            this.colorMenuItem6,
            this.colorMenuItem7,
            this.colorMenuItem8});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // colorMenuItem1
            // 
            this.colorMenuItem1.Checked = true;
            this.colorMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMenuItem1.Image = global::Paint.Properties.Resources.color0;
            this.colorMenuItem1.Name = "colorMenuItem1";
            this.colorMenuItem1.ShowShortcutKeys = false;
            this.colorMenuItem1.Size = new System.Drawing.Size(68, 22);
            this.colorMenuItem1.Click += new System.EventHandler(this.colorMenuItem1_Click);
            // 
            // colorMenuItem2
            // 
            this.colorMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMenuItem2.Image = global::Paint.Properties.Resources.color1;
            this.colorMenuItem2.Name = "colorMenuItem2";
            this.colorMenuItem2.ShowShortcutKeys = false;
            this.colorMenuItem2.Size = new System.Drawing.Size(68, 22);
            this.colorMenuItem2.Click += new System.EventHandler(this.colorMenuItem2_Click);
            // 
            // colorMenuItem3
            // 
            this.colorMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMenuItem3.Image = global::Paint.Properties.Resources.color2;
            this.colorMenuItem3.Name = "colorMenuItem3";
            this.colorMenuItem3.Size = new System.Drawing.Size(68, 22);
            this.colorMenuItem3.Click += new System.EventHandler(this.colorMenuItem3_Click);
            // 
            // colorMenuItem4
            // 
            this.colorMenuItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMenuItem4.Image = global::Paint.Properties.Resources.color3;
            this.colorMenuItem4.Name = "colorMenuItem4";
            this.colorMenuItem4.Size = new System.Drawing.Size(68, 22);
            this.colorMenuItem4.Click += new System.EventHandler(this.colorMenuItem4_Click);
            // 
            // colorMenuItem5
            // 
            this.colorMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMenuItem5.Image = global::Paint.Properties.Resources.color4;
            this.colorMenuItem5.Name = "colorMenuItem5";
            this.colorMenuItem5.Size = new System.Drawing.Size(68, 22);
            this.colorMenuItem5.Click += new System.EventHandler(this.colorMenuItem5_Click);
            // 
            // colorMenuItem6
            // 
            this.colorMenuItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMenuItem6.Image = global::Paint.Properties.Resources.color5;
            this.colorMenuItem6.Name = "colorMenuItem6";
            this.colorMenuItem6.Size = new System.Drawing.Size(68, 22);
            this.colorMenuItem6.Click += new System.EventHandler(this.colorMenuItem6_Click);
            // 
            // colorMenuItem7
            // 
            this.colorMenuItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMenuItem7.Image = global::Paint.Properties.Resources.color6;
            this.colorMenuItem7.Name = "colorMenuItem7";
            this.colorMenuItem7.Size = new System.Drawing.Size(68, 22);
            this.colorMenuItem7.Click += new System.EventHandler(this.colorMenuItem7_Click);
            // 
            // colorMenuItem8
            // 
            this.colorMenuItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorMenuItem8.Image = global::Paint.Properties.Resources.color7;
            this.colorMenuItem8.Name = "colorMenuItem8";
            this.colorMenuItem8.Size = new System.Drawing.Size(68, 22);
            this.colorMenuItem8.Click += new System.EventHandler(this.colorMenuItem8_Click);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.widthMenuItem1,
            this.widthMenuItem2,
            this.widthMenuItem3,
            this.widthMenuItem4,
            this.widthMenuItem5});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // widthMenuItem1
            // 
            this.widthMenuItem1.Checked = true;
            this.widthMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.widthMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.widthMenuItem1.Image = global::Paint.Properties.Resources.line0;
            this.widthMenuItem1.Name = "widthMenuItem1";
            this.widthMenuItem1.Size = new System.Drawing.Size(68, 22);
            this.widthMenuItem1.Click += new System.EventHandler(this.widthMenuItem1_Click);
            // 
            // widthMenuItem2
            // 
            this.widthMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.widthMenuItem2.Image = global::Paint.Properties.Resources.line1;
            this.widthMenuItem2.Name = "widthMenuItem2";
            this.widthMenuItem2.Size = new System.Drawing.Size(68, 22);
            this.widthMenuItem2.Click += new System.EventHandler(this.widthMenuItem2_Click);
            // 
            // widthMenuItem3
            // 
            this.widthMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.widthMenuItem3.Image = global::Paint.Properties.Resources.line2;
            this.widthMenuItem3.Name = "widthMenuItem3";
            this.widthMenuItem3.Size = new System.Drawing.Size(68, 22);
            this.widthMenuItem3.Click += new System.EventHandler(this.widthMenuItem3_Click);
            // 
            // widthMenuItem4
            // 
            this.widthMenuItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.widthMenuItem4.Image = global::Paint.Properties.Resources.line3;
            this.widthMenuItem4.Name = "widthMenuItem4";
            this.widthMenuItem4.Size = new System.Drawing.Size(68, 22);
            this.widthMenuItem4.Click += new System.EventHandler(this.widthMenuItem4_Click);
            // 
            // widthMenuItem5
            // 
            this.widthMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.widthMenuItem5.Image = global::Paint.Properties.Resources.line4;
            this.widthMenuItem5.Name = "widthMenuItem5";
            this.widthMenuItem5.Size = new System.Drawing.Size(68, 22);
            this.widthMenuItem5.Click += new System.EventHandler(this.widthMenuItem5_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundMenuItem1,
            this.backgroundMenuItem2,
            this.backgroundMenuItem3,
            this.backgroundMenuItem4,
            this.backgroundMenuItem5,
            this.backgroundMenuItem6,
            this.backgroundMenuItem7,
            this.backgroundMenuItem8,
            this.backgroundMenuItem9});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // backgroundMenuItem1
            // 
            this.backgroundMenuItem1.Checked = true;
            this.backgroundMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backgroundMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backgroundMenuItem1.Name = "backgroundMenuItem1";
            this.backgroundMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem1.Text = "Transparent";
            this.backgroundMenuItem1.Click += new System.EventHandler(this.backgroundMenuItem1_Click);
            // 
            // backgroundMenuItem2
            // 
            this.backgroundMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundMenuItem2.Image = global::Paint.Properties.Resources.color0;
            this.backgroundMenuItem2.Name = "backgroundMenuItem2";
            this.backgroundMenuItem2.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem2.Text = "toolStripMenuItem18";
            this.backgroundMenuItem2.Click += new System.EventHandler(this.backgroundMenuItem2_Click);
            // 
            // backgroundMenuItem3
            // 
            this.backgroundMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundMenuItem3.Image = global::Paint.Properties.Resources.color1;
            this.backgroundMenuItem3.Name = "backgroundMenuItem3";
            this.backgroundMenuItem3.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem3.Text = "toolStripMenuItem19";
            this.backgroundMenuItem3.Click += new System.EventHandler(this.backgroundMenuItem3_Click);
            // 
            // backgroundMenuItem4
            // 
            this.backgroundMenuItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundMenuItem4.Image = global::Paint.Properties.Resources.color2;
            this.backgroundMenuItem4.Name = "backgroundMenuItem4";
            this.backgroundMenuItem4.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem4.Text = "toolStripMenuItem20";
            this.backgroundMenuItem4.Click += new System.EventHandler(this.backgroundMenuItem4_Click);
            // 
            // backgroundMenuItem5
            // 
            this.backgroundMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundMenuItem5.Image = global::Paint.Properties.Resources.color3;
            this.backgroundMenuItem5.Name = "backgroundMenuItem5";
            this.backgroundMenuItem5.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem5.Text = "toolStripMenuItem21";
            this.backgroundMenuItem5.Click += new System.EventHandler(this.backgroundMenuItem5_Click);
            // 
            // backgroundMenuItem6
            // 
            this.backgroundMenuItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundMenuItem6.Image = global::Paint.Properties.Resources.color4;
            this.backgroundMenuItem6.Name = "backgroundMenuItem6";
            this.backgroundMenuItem6.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem6.Text = "toolStripMenuItem22";
            this.backgroundMenuItem6.Click += new System.EventHandler(this.backgroundMenuItem6_Click);
            // 
            // backgroundMenuItem7
            // 
            this.backgroundMenuItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundMenuItem7.Image = global::Paint.Properties.Resources.color5;
            this.backgroundMenuItem7.Name = "backgroundMenuItem7";
            this.backgroundMenuItem7.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem7.Text = "toolStripMenuItem23";
            this.backgroundMenuItem7.Click += new System.EventHandler(this.backgroundMenuItem7_Click);
            // 
            // backgroundMenuItem8
            // 
            this.backgroundMenuItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundMenuItem8.Image = global::Paint.Properties.Resources.color6;
            this.backgroundMenuItem8.Name = "backgroundMenuItem8";
            this.backgroundMenuItem8.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem8.Text = "toolStripMenuItem24";
            this.backgroundMenuItem8.Click += new System.EventHandler(this.backgroundMenuItem8_Click);
            // 
            // backgroundMenuItem9
            // 
            this.backgroundMenuItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundMenuItem9.Image = global::Paint.Properties.Resources.color7;
            this.backgroundMenuItem9.Name = "backgroundMenuItem9";
            this.backgroundMenuItem9.Size = new System.Drawing.Size(197, 22);
            this.backgroundMenuItem9.Text = "toolStripMenuItem25";
            this.backgroundMenuItem9.Click += new System.EventHandler(this.backgroundMenuItem9_Click);
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(47, 22);
            this.toolStripSplitButton4.Text = "About";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);        
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem widthMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem widthMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem widthMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem widthMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem widthMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem backgroundMenuItem9;
        private System.Windows.Forms.ToolStripButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripMenuItem TextToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;


    }
}

