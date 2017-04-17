using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SymlinkCreator
{
    public partial class Main : Form
    {
        //Some of these are unnecessary in some cases, such as when saveFileDialog and openFileDialog are used, but are kept for expandability.
        string lastLinkFolder; //Used to restore last path.
        string lastTargetFolder; //User to restore last path.
        string lastLinkName; //Used to populate last file name.
        string lastTargetName; //Used to populate last file name.

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set up all the choices.
            comboBox_Type.Items.Add("File Symbolic Link (Default)");
            comboBox_Type.Items.Add("Directory Symbolic Link (/D)");
            comboBox_Type.Items.Add("File Hard Link (/H)");
            comboBox_Type.Items.Add("Directory Hard Link (/J)");

            //We force the user to select the first item in the list.
            comboBox_Type.SelectedIndex = 0;

            UpdateCMDCommand();
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //So the user doesn't mess up, we reset their choices after switching options.
            //This way, we won't have a mix of dirs/files.
            lastLinkFolder = "";
            lastTargetFolder = "";
            textBox_Link.Text = "";
            textBox_Target.Text = "";

            UpdateCMDCommand();
        }

        enum BrowseType
        {
            Link,
            Target
        }

        //We use one dialog. Maybe not the best idea, but using two seperate dialogs didn't give ideal results either.
        //We still have to manually modify some stuff in order to make it appear nicely.
        //Still probably better to use two dialogs, but not important.
        private void button_Browse_Click(object sender, EventArgs e)
        {
            BrowseType browseType = ((Button)sender).Tag.ToString() == "Link" ? BrowseType.Link : BrowseType.Target;

            if (comboBox_Type.SelectedIndex == 0 || comboBox_Type.SelectedIndex == 2) //File browsing.
            {
                if (browseType == BrowseType.Link)
                {
                    saveFileDialog1.InitialDirectory = lastLinkFolder;
                    saveFileDialog1.FileName = lastLinkName;
                    DialogResult result = saveFileDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        textBox_Link.Text = saveFileDialog1.FileName;
                        lastLinkFolder = Path.GetDirectoryName(saveFileDialog1.FileName);
                        lastLinkName = Path.GetFileName(saveFileDialog1.FileName);
                    }

                    UpdateCMDCommand();
                }
                else
                {
                    openFileDialog1.InitialDirectory = lastTargetFolder;
                    openFileDialog1.FileName = lastTargetName;
                    DialogResult result = openFileDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        textBox_Target.Text = openFileDialog1.FileName;
                        lastTargetFolder = Path.GetDirectoryName(openFileDialog1.FileName);
                        lastTargetName = Path.GetFileName(openFileDialog1.FileName);
                    }

                    UpdateCMDCommand();
                }
            }
            else //Folder browsing.
            {
                if (browseType == BrowseType.Link)
                {
                    folderBrowserDialog1.SelectedPath = lastLinkFolder;
                    DialogResult result = folderBrowserDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        textBox_Link.Text = folderBrowserDialog1.SelectedPath;
                        lastLinkFolder = folderBrowserDialog1.SelectedPath;
                    }

                    UpdateCMDCommand();
                }
                else
                {
                    folderBrowserDialog1.SelectedPath = lastTargetFolder;
                    DialogResult result = folderBrowserDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        textBox_Target.Text = folderBrowserDialog1.SelectedPath;
                        lastTargetFolder = folderBrowserDialog1.SelectedPath;
                    }

                    UpdateCMDCommand();
                }
            }
        }

        private void button_CreateLink_Click(object sender, EventArgs e)
        {
            CreateLink();
        }

        private void CreateLink()
        {
            bool error = false;

            if (textBox_Link.Text == "" || textBox_Target.Text == "") //Checks if they didn't just press submit before doing anything.
            {
                error = true;
                MessageBox.Show("You must specify files/directories.");
            }
            else if (textBox_Link.Text == textBox_Target.Text) //Check to make sure link/target are not the same.
            {
                error = true;
                MessageBox.Show("Your destination cannot be the same as your source.");
            }
            else if (comboBox_Type.SelectedIndex == 0 || comboBox_Type.SelectedIndex == 2) //File link.
            {
                if (File.Exists(textBox_Link.Text) == true) //This means user probably wants to replace an existing file with the new link, but due to symlink safety/limitations, we have to delete it first.
                {
                    if (MessageBox.Show("Replace " + textBox_Link.Text + "?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        File.Delete(textBox_Link.Text);
                    }
                    else
                    {
                        error = true;
                        MessageBox.Show("Cannot proceed without replacing " + textBox_Link.Text);
                    }
                }

                if (File.Exists(textBox_Target.Text) == false) //Check if target file exists.
                {
                    error = true;
                    MessageBox.Show("The file you specified in the \"Source\" textbox does not exist.");
                }
            }
            else //Directory link.
            {
                if (Directory.Exists(textBox_Link.Text) == true) //We will replace the "new folder" the user has most likely created.
                {
                    if (MessageBox.Show("Replace " + textBox_Link.Text + "?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Directory.Delete(textBox_Link.Text, true);
                    }
                    else
                    {
                        error = true;
                        MessageBox.Show("Cannot proceed without replacing " + textBox_Link.Text);
                    }
                }

                if (Directory.Exists(textBox_Target.Text) == false) //Check if target directory exists.
                {
                    error = true;
                    MessageBox.Show("The folder you specified in the \"Source\" textbox does not exist.");
                }
            }

            if (error == false) //Now we make the actual link, since there were no problems.
            {
                Process processSymlink = new Process();
                ProcessStartInfo startInfoSymlink = new ProcessStartInfo();
                startInfoSymlink.FileName = "cmd.exe";

                string linkType = " ";

                if (comboBox_Type.SelectedIndex == 0)
                    linkType = " ";
                else if (comboBox_Type.SelectedIndex == 1)
                    linkType = " /D ";
                else if (comboBox_Type.SelectedIndex == 2)
                    linkType = " /H ";
                else if (comboBox_Type.SelectedIndex == 3)
                    linkType = " /J ";

                startInfoSymlink.Arguments = "/C MKLINK" + linkType + "\"" + textBox_Link.Text + "\" \"" + textBox_Target.Text + "\""; //The /C means it finishes without waiting for user to do something.
                startInfoSymlink.CreateNoWindow = true;

                //Gives the programmer control over output, even if we don't output it, no harm since user won't see it anyways.
                startInfoSymlink.UseShellExecute = false;
                startInfoSymlink.RedirectStandardOutput = true;

                //Sets up process and executes it.
                processSymlink.StartInfo = startInfoSymlink;
                processSymlink.Start();
            }
        }

        //A way to update the CMD command in textbox when user seeks to use it.
        private void textBox_CMDCommand_Click(object sender, EventArgs e)
        {
            UpdateCMDCommand();
        }

        //Updates the textbox that contains the CMD command.
        private void UpdateCMDCommand()
        {
            string linkType;

            if (comboBox_Type.SelectedIndex == 0)
                linkType = " ";
            else if (comboBox_Type.SelectedIndex == 1)
                linkType = " /D ";
            else if (comboBox_Type.SelectedIndex == 2)
                linkType = " /H ";
            else
                linkType = " /J ";

            textBox_CMDCommand.Text = "MKLINK" + linkType + "\"" + textBox_Link.Text + "\" \"" + textBox_Target.Text + "\"";
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. First select the type of symbolic link you want. The first two options are the most common.\n" +
            "2. Select the destination item. This is the item that will be the link.\n" +
            "3. Select the source item. This item will be the content you want to create a link from.\n" +
            "4. Click the \"Create Link\" button and you are done.\n\n" +
            "Run the program as an administrator if it behaves incorrectly.\n\n" + 
            "Tip: When creating a directory link, it is easiest to create an empty folder to use as your destination. " + 
            "This avoids having to manually enter a folder name and allows you to replace the existing folder. " +
            "You can also do this while browsing.");
        }
    }
}