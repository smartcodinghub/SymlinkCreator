namespace SymlinkCreator
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
            this.components = new System.ComponentModel.Container();
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat2 = new System.Drawing.StringFormat();
            this.switchControl = new Smartcodinghub.UserControls.SwitchControl();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.bTarget = new Smartcodinghub.CustomControls.FormTextIconButton();
            this.bSource = new Smartcodinghub.CustomControls.FormTextIconButton();
            this.SuspendLayout();
            // 
            // switchControl
            // 
            this.switchControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switchControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchControl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.switchControl.Location = new System.Drawing.Point(29, 29);
            this.switchControl.Margin = new System.Windows.Forms.Padding(20);
            this.switchControl.Name = "switchControl";
            this.switchControl.Size = new System.Drawing.Size(726, 70);
            this.switchControl.TabIndex = 1;
            this.switchControl.OnSelectionChanged += new Smartcodinghub.UserControls.SwitchControl.SelectionChanged(this.switchControl_OnSelectionChanged);
            // 
            // tbSource
            // 
            this.tbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSource.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSource.Location = new System.Drawing.Point(29, 139);
            this.tbSource.Margin = new System.Windows.Forms.Padding(20);
            this.tbSource.Multiline = true;
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(579, 42);
            this.tbSource.TabIndex = 2;
            // 
            // tbTarget
            // 
            this.tbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTarget.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTarget.Location = new System.Drawing.Point(29, 221);
            this.tbTarget.Margin = new System.Windows.Forms.Padding(20);
            this.tbTarget.Multiline = true;
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(579, 42);
            this.tbTarget.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbCommand
            // 
            this.tbCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommand.Location = new System.Drawing.Point(29, 303);
            this.tbCommand.Margin = new System.Windows.Forms.Padding(20);
            this.tbCommand.Multiline = true;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(726, 229);
            this.tbCommand.TabIndex = 7;
            // 
            // bTarget
            // 
            this.bTarget.AltGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTarget.Hover = false;
            this.bTarget.Image = null;
            this.bTarget.ImageLocation = new System.Drawing.Point(0, 0);
            this.bTarget.ImageSize = new System.Drawing.Size(0, 0);
            this.bTarget.Location = new System.Drawing.Point(648, 221);
            this.bTarget.Name = "bTarget";
            this.bTarget.PercentageForHover = 0.15F;
            this.bTarget.PercentageForPressed = 0.15F;
            this.bTarget.PercentageOfDark = 0.4F;
            this.bTarget.PercentageOfLight = 0.4F;
            this.bTarget.Pressed = false;
            this.bTarget.Radius = 8;
            this.bTarget.Size = new System.Drawing.Size(107, 42);
            stringFormat1.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.bTarget.StringFormat = stringFormat1;
            this.bTarget.TabIndex = 8;
            this.bTarget.Text = "Target";
            this.bTarget.TextGap = 0;
            this.bTarget.TextLocation = new System.Drawing.Point(0, 0);
            this.bTarget.UseGradient = true;
            this.bTarget.UseVisualStyleBackColor = false;
            // 
            // bSource
            // 
            this.bSource.AltGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSource.Hover = false;
            this.bSource.Image = null;
            this.bSource.ImageLocation = new System.Drawing.Point(0, 0);
            this.bSource.ImageSize = new System.Drawing.Size(0, 0);
            this.bSource.Location = new System.Drawing.Point(648, 139);
            this.bSource.Name = "bSource";
            this.bSource.PercentageForHover = 0.15F;
            this.bSource.PercentageForPressed = 0.15F;
            this.bSource.PercentageOfDark = 0.4F;
            this.bSource.PercentageOfLight = 0.4F;
            this.bSource.Pressed = false;
            this.bSource.Radius = 8;
            this.bSource.Size = new System.Drawing.Size(107, 42);
            stringFormat2.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat2.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat2.Trimming = System.Drawing.StringTrimming.Character;
            this.bSource.StringFormat = stringFormat2;
            this.bSource.TabIndex = 9;
            this.bSource.Text = "Source";
            this.bSource.TextGap = 0;
            this.bSource.TextLocation = new System.Drawing.Point(0, 0);
            this.bSource.UseGradient = true;
            this.bSource.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.bSource);
            this.Controls.Add(this.bTarget);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.tbTarget);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.switchControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Smartcodinghub.UserControls.SwitchControl switchControl;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbCommand;
        private Smartcodinghub.CustomControls.FormTextIconButton bTarget;
        private Smartcodinghub.CustomControls.FormTextIconButton bSource;
    }
}