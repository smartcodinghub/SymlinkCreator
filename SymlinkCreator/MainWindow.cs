using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smartcodinghub.CustomControls;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace SymlinkCreator
{
    public partial class MainWindow : Form
    {
        private Symlink symlink;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            switchControl.AddItems(SymlinkOption.Values);

            symlink = new Symlink();
        }

        private void bSource_Click(object sender, EventArgs e)
        {
            if (SymlinkOption.FILE_SYMBOLIC == switchControl.SelectedItem || SymlinkOption.FILE_HARD == switchControl.SelectedItem)
                OpenDialog(saveFileDialog, tbSource);
            else
                OpenDialog(folderBrowserDialog, tbSource);

            RefreshCommand();
        }

        private void bTarget_Click(object sender, EventArgs e)
        {
            if (SymlinkOption.FILE_SYMBOLIC == switchControl.SelectedItem || SymlinkOption.FILE_HARD == switchControl.SelectedItem)
                OpenDialog(openFileDialog, tbTarget);
            else
                OpenDialog(folderBrowserDialog, tbTarget);

            RefreshCommand();
        }

        private void OpenDialog(CommonDialog dialog, TextBox text)
        {
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                text.Text = (dialog as FileDialog)?.FileName ?? (dialog as FolderBrowserDialog).SelectedPath;
        }

        private void switchControl_OnSelectionChanged(object value)
        {
            RefreshCommand();
        }

        private void RefreshCommand()
        {
            symlink.SymlinkOption = (SymlinkOption)switchControl.SelectedItem;
            symlink.Source = tbSource.Text;
            symlink.Target = tbTarget.Text;

            tbCommand.Text = symlink.CreateSymlink();
        }

        private void s_Click(object sender, EventArgs e)
        {
            /* Check */
            SelectionCheck checkResult = Check();

            /* Prepare */
            Boolean isPreparationOk = Prepare(checkResult);

            /* Execute it! */
            Execute();
        }

        private SelectionCheck Check()
        {
            SelectionCheck check = new SelectionCheck();

            if (symlink.IsCompleted() || String.Equals(symlink.Source, symlink.Target))
                return check;

            check.IsFile = SymlinkOption.FILE_SYMBOLIC == symlink.SymlinkOption || SymlinkOption.FILE_HARD == symlink.SymlinkOption;

            if (check.IsFile)
            {
                check.SourceExists = File.Exists(symlink.Source);
                check.TargetExists = File.Exists(symlink.Target);
            }
            else
            {
                check.SourceExists = Directory.Exists(symlink.Source);
                check.TargetExists = Directory.Exists(symlink.Target);
            }

            return check;
        }

        private bool Prepare(SelectionCheck checkResult)
        {
            if (!checkResult.IsSelectionReady)
                return false;

            if (!checkResult.IsFile)
            {
                if (!checkResult.TargetExists)
                {
                    DialogResult result = MessageBox.Show("The Target doesn't exists. Do you want to create it?",
                        "Target doesn't exists", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                        Directory.CreateDirectory(symlink.Target);
                    else if (result == DialogResult.No)
                        return false;
                }

                if (checkResult.SourceExists)
                {
                    DialogResult result = MessageBox.Show("The Source exists. Do you want to: copy the content to target (Yes), replace it (No) or nothing (Cancel)?",
                        "Source exists", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                        Copy(checkResult.IsFile);
                    else if (result == DialogResult.No)
                        File.Delete(symlink.Source);
                    else
                        return false;
                }
            }

            return true;
        }

        private void Copy(Boolean isFile)
        {
            if (isFile)
            {
                FileSystem.CopyFile(symlink.Source, symlink.Target, UIOption.AllDialogs);
            }
            else
            {
                FileSystem.CopyDirectory(symlink.Source, symlink.Target, UIOption.AllDialogs);
            }
        }
    }
}
