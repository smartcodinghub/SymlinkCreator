using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void switchControl_OnSelectionChanged(object value)
        {
            RefreshCommand();
        }

        private void RefreshCommand()
        {
            symlink.SymlinkOption = (SymlinkOption)switchControl.SelectedItem;
            symlink.Source = tbSource.Text;
            symlink.Target = tbTarget.Text;

            if (symlink.IsValid())
                tbCommand.Text = symlink.CreateSymlink();
        }
    }
}
