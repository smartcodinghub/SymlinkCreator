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
            this.switchControl = new Cartif.UserControls.SwitchControl();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.bSource = new System.Windows.Forms.Button();
            this.bTarget = new System.Windows.Forms.Button();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbCommand = new System.Windows.Forms.TextBox();
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
            this.switchControl.OnSelectionChanged += new Cartif.UserControls.SwitchControl.SelectionChanged(this.switchControl_OnSelectionChanged);
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
            // bSource
            // 
            this.bSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSource.Location = new System.Drawing.Point(648, 139);
            this.bSource.Margin = new System.Windows.Forms.Padding(20);
            this.bSource.Name = "bSource";
            this.bSource.Size = new System.Drawing.Size(107, 42);
            this.bSource.TabIndex = 3;
            this.bSource.Text = "Source";
            this.bSource.UseVisualStyleBackColor = true;
            // 
            // bTarget
            // 
            this.bTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTarget.Location = new System.Drawing.Point(648, 221);
            this.bTarget.Margin = new System.Windows.Forms.Padding(20);
            this.bTarget.Name = "bTarget";
            this.bTarget.Size = new System.Drawing.Size(107, 42);
            this.bTarget.TabIndex = 5;
            this.bTarget.Text = "Target";
            this.bTarget.UseVisualStyleBackColor = true;
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
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.bTarget);
            this.Controls.Add(this.tbTarget);
            this.Controls.Add(this.bSource);
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
        private Cartif.UserControls.SwitchControl switchControl;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Button bSource;
        private System.Windows.Forms.Button bTarget;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbCommand;
    }
}