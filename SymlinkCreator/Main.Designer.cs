namespace SymlinkCreator
{
    partial class Main
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_Link = new System.Windows.Forms.TextBox();
            this.button_BrowseLink = new System.Windows.Forms.Button();
            this.label_Type = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label_Link = new System.Windows.Forms.Label();
            this.label_Source = new System.Windows.Forms.Label();
            this.textBox_Target = new System.Windows.Forms.TextBox();
            this.button_BrowseTarget = new System.Windows.Forms.Button();
            this.textBox_CMDCommand = new System.Windows.Forms.TextBox();
            this.label_CMDCommand = new System.Windows.Forms.Label();
            this.button_CreateLink = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox_Link
            // 
            this.textBox_Link.Location = new System.Drawing.Point(106, 33);
            this.textBox_Link.Name = "textBox_Link";
            this.textBox_Link.Size = new System.Drawing.Size(100, 20);
            this.textBox_Link.TabIndex = 0;
            // 
            // button_BrowseLink
            // 
            this.button_BrowseLink.Location = new System.Drawing.Point(212, 31);
            this.button_BrowseLink.Name = "button_BrowseLink";
            this.button_BrowseLink.Size = new System.Drawing.Size(75, 23);
            this.button_BrowseLink.TabIndex = 1;
            this.button_BrowseLink.Tag = "Link";
            this.button_BrowseLink.Text = "Browse";
            this.button_BrowseLink.UseVisualStyleBackColor = true;
            this.button_BrowseLink.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(12, 9);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(69, 13);
            this.label_Type.TabIndex = 2;
            this.label_Type.Text = "Type of Link:";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(106, 6);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(181, 21);
            this.comboBox_Type.TabIndex = 3;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // label_Link
            // 
            this.label_Link.AutoSize = true;
            this.label_Link.Location = new System.Drawing.Point(12, 36);
            this.label_Link.Name = "label_Link";
            this.label_Link.Size = new System.Drawing.Size(92, 13);
            this.label_Link.TabIndex = 4;
            this.label_Link.Text = "Destination (Link):";
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Location = new System.Drawing.Point(12, 62);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(84, 13);
            this.label_Source.TabIndex = 5;
            this.label_Source.Text = "Source (Target):";
            // 
            // textBox_Target
            // 
            this.textBox_Target.Location = new System.Drawing.Point(106, 59);
            this.textBox_Target.Name = "textBox_Target";
            this.textBox_Target.Size = new System.Drawing.Size(100, 20);
            this.textBox_Target.TabIndex = 6;
            // 
            // button_BrowseTarget
            // 
            this.button_BrowseTarget.Location = new System.Drawing.Point(212, 57);
            this.button_BrowseTarget.Name = "button_BrowseTarget";
            this.button_BrowseTarget.Size = new System.Drawing.Size(75, 23);
            this.button_BrowseTarget.TabIndex = 7;
            this.button_BrowseTarget.Tag = "Target";
            this.button_BrowseTarget.Text = "Browse";
            this.button_BrowseTarget.UseVisualStyleBackColor = true;
            this.button_BrowseTarget.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // textBox_CMDCommand
            // 
            this.textBox_CMDCommand.Location = new System.Drawing.Point(106, 85);
            this.textBox_CMDCommand.Multiline = true;
            this.textBox_CMDCommand.Name = "textBox_CMDCommand";
            this.textBox_CMDCommand.Size = new System.Drawing.Size(181, 100);
            this.textBox_CMDCommand.TabIndex = 8;
            this.textBox_CMDCommand.Click += new System.EventHandler(this.textBox_CMDCommand_Click);
            // 
            // label_CMDCommand
            // 
            this.label_CMDCommand.AutoSize = true;
            this.label_CMDCommand.Location = new System.Drawing.Point(12, 88);
            this.label_CMDCommand.Name = "label_CMDCommand";
            this.label_CMDCommand.Size = new System.Drawing.Size(84, 13);
            this.label_CMDCommand.TabIndex = 9;
            this.label_CMDCommand.Text = "CMD Command:";
            // 
            // button_CreateLink
            // 
            this.button_CreateLink.Location = new System.Drawing.Point(212, 191);
            this.button_CreateLink.Name = "button_CreateLink";
            this.button_CreateLink.Size = new System.Drawing.Size(75, 23);
            this.button_CreateLink.TabIndex = 10;
            this.button_CreateLink.Text = "Create Link";
            this.button_CreateLink.UseVisualStyleBackColor = true;
            this.button_CreateLink.Click += new System.EventHandler(this.button_CreateLink_Click);
            // 
            // button_Help
            // 
            this.button_Help.Location = new System.Drawing.Point(15, 191);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(75, 23);
            this.button_Help.TabIndex = 11;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 219);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.button_CreateLink);
            this.Controls.Add(this.label_CMDCommand);
            this.Controls.Add(this.textBox_CMDCommand);
            this.Controls.Add(this.button_BrowseTarget);
            this.Controls.Add(this.textBox_Target);
            this.Controls.Add(this.label_Source);
            this.Controls.Add(this.label_Link);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.button_BrowseLink);
            this.Controls.Add(this.textBox_Link);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Symlink Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_Link;
        private System.Windows.Forms.Button button_BrowseLink;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label_Link;
        private System.Windows.Forms.Label label_Source;
        private System.Windows.Forms.TextBox textBox_Target;
        private System.Windows.Forms.Button button_BrowseTarget;
        private System.Windows.Forms.TextBox textBox_CMDCommand;
        private System.Windows.Forms.Label label_CMDCommand;
        private System.Windows.Forms.Button button_CreateLink;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

