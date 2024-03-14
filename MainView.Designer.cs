using System.Drawing;

namespace WF_Notepad
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.replaceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceFromTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.replaceToTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.replaceButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lineStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.capsLockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.languageStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.linesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1330, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu,
            this.toolStripSeparator1,
            this.saveMenu,
            this.saveAsMenu,
            this.toolStripSeparator2,
            this.exitMenu});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 44);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(240, 46);
            this.openMenu.Text = "Open";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(240, 46);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // saveAsMenu
            // 
            this.saveAsMenu.Name = "saveAsMenu";
            this.saveAsMenu.Size = new System.Drawing.Size(240, 46);
            this.saveAsMenu.Text = "Save as";
            this.saveAsMenu.Click += new System.EventHandler(this.saveAsMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(240, 46);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMenu,
            this.copyMenu,
            this.pasteMenu,
            this.toolStripSeparator3,
            this.replaceMenu});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(85, 44);
            this.toolStripDropDownButton2.Text = "Edit";
            // 
            // cutMenu
            // 
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.Size = new System.Drawing.Size(245, 46);
            this.cutMenu.Text = "Cut";
            this.cutMenu.Click += new System.EventHandler(this.cutMenu_Click);
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.Size = new System.Drawing.Size(245, 46);
            this.copyMenu.Text = "Copy";
            this.copyMenu.Click += new System.EventHandler(this.copyMenu_Click);
            // 
            // pasteMenu
            // 
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.Size = new System.Drawing.Size(245, 46);
            this.pasteMenu.Text = "Paste";
            this.pasteMenu.Click += new System.EventHandler(this.pasteMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
            // 
            // replaceMenu
            // 
            this.replaceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceFromTextBox,
            this.replaceToTextBox,
            this.replaceButton});
            this.replaceMenu.Name = "replaceMenu";
            this.replaceMenu.Size = new System.Drawing.Size(245, 46);
            this.replaceMenu.Text = "Replace";
            // 
            // replaceFromTextBox
            // 
            this.replaceFromTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replaceFromTextBox.Name = "replaceFromTextBox";
            this.replaceFromTextBox.Size = new System.Drawing.Size(100, 39);
            // 
            // replaceToTextBox
            // 
            this.replaceToTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replaceToTextBox.Name = "replaceToTextBox";
            this.replaceToTextBox.Size = new System.Drawing.Size(100, 39);
            // 
            // replaceButton
            // 
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(296, 46);
            this.replaceButton.Text = "Replace text";
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorMenu,
            this.fontMenu});
            this.toolStripDropDownButton3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(97, 44);
            this.toolStripDropDownButton3.Text = "View";
            // 
            // colorMenu
            // 
            this.colorMenu.Name = "colorMenu";
            this.colorMenu.Size = new System.Drawing.Size(218, 46);
            this.colorMenu.Text = "Color";
            this.colorMenu.Click += new System.EventHandler(this.colorMenu_Click);
            // 
            // fontMenu
            // 
            this.fontMenu.Name = "fontMenu";
            this.fontMenu.Size = new System.Drawing.Size(218, 46);
            this.fontMenu.Text = "Font";
            this.fontMenu.Click += new System.EventHandler(this.fontMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lineStatusLabel,
            this.toolStripStatusLabel2,
            this.columnStatusLabel,
            this.capsLockLabel,
            this.languageStatusLabel,
            this.linesLabel,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 864);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1330, 42);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 32);
            this.toolStripStatusLabel1.Text = "Line :";
            // 
            // lineStatusLabel
            // 
            this.lineStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lineStatusLabel.Name = "lineStatusLabel";
            this.lineStatusLabel.Size = new System.Drawing.Size(0, 32);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(110, 32);
            this.toolStripStatusLabel2.Text = "Column :";
            // 
            // columnStatusLabel
            // 
            this.columnStatusLabel.Name = "columnStatusLabel";
            this.columnStatusLabel.Size = new System.Drawing.Size(0, 32);
            // 
            // capsLockLabel
            // 
            this.capsLockLabel.Name = "capsLockLabel";
            this.capsLockLabel.Size = new System.Drawing.Size(0, 32);
            // 
            // languageStatusLabel
            // 
            this.languageStatusLabel.Name = "languageStatusLabel";
            this.languageStatusLabel.Size = new System.Drawing.Size(0, 32);
            // 
            // linesLabel
            // 
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(0, 32);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(85, 32);
            this.toolStripStatusLabel3.Text = "- Lines";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(0, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1330, 814);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1330, 906);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1356, 977);
            this.Name = "MainView";
            this.Text = "Untitled";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem cutMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem replaceMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripStatusLabel lineStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel columnStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripTextBox replaceFromTextBox;
        private System.Windows.Forms.ToolStripMenuItem replaceButton;
        private System.Windows.Forms.ToolStripTextBox replaceToTextBox;
        private System.Windows.Forms.ToolStripMenuItem colorMenu;
        private System.Windows.Forms.ToolStripStatusLabel capsLockLabel;
        private System.Windows.Forms.ToolStripMenuItem fontMenu;
        private System.Windows.Forms.ToolStripStatusLabel languageStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel linesLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

