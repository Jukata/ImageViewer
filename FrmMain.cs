using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class FrmMain : Form
    {
        List<string> fileNames = new List<string>();

        public FrmMain()
        {
            InitializeComponent();
        }

        // browsing for a folder
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fbd.RootFolder = Environment.SpecialFolder.Desktop; // root folder of the dialog will be the Desktop
            fbd.ShowDialog();
            fbd.ShowNewFolderButton = true; // set to true if you wish to be able to create a new folder using the dialog

            // We will use a custom method to get our files and populate the ComboBox
            cbImageFiles.Items.Clear();
            try
            {
                cbImageFiles.Items.AddRange(GetImageNames(fbd.SelectedPath).ToArray());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private List<string> GetImageNames(string directoryPath)
        {
            try
            {
                var fullFilesPath = Directory.GetFiles(fbd.SelectedPath); // getting the files from the selected directory
                List<string> fileNames = new List<string>();
                foreach (var path in fullFilesPath)
                {
                    if (path.Contains(".jpg") || path.Contains(".gif") || path.Contains(".jpeg") || path.Contains(".bmp") || path.Contains(".png"))
                    {
                        fileNames.Add(Path.GetFileName(path)); // Getting only the File's name + Extension from the full file path
                    }
                }

                if (fileNames.Count != 0)
                {
                    return fileNames;
                }
                else
                {
                    fileNames.Add("No available images, select a different folder");
                    return fileNames;
                }
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return null;
            
        }

        private void cbImageFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // displaying the image
            try
            {
                pbImage.Image = GetImage(fbd.SelectedPath, cbImageFiles.SelectedItem.ToString());
                // using a custom method to populate the textboxes and get the image's info
                GetFileInfo(fbd.SelectedPath, cbImageFiles.SelectedItem.ToString(), pbImage.Image.Width.ToString(), pbImage.Image.Height.ToString());
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
            catch(FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            
        }

        // Populating the textboxes in the Image Info groupbox
        private void GetFileInfo (string filePath, string fileName, string fileWidth, string fileHeight)
        {
            tbLocation.Text = filePath;
            tbName.Text = fileName;
            tbHeight.Text = fileHeight;
            tbWidth.Text = fileWidth;
        }

        // returning an image using the folderBrowserDialog's selected directory and the images' combo box's selected image name
        private Bitmap GetImage (string directoryPath, string imageName)
        {
            Bitmap image;
            try
            {
                var imagePath = Path.Combine(directoryPath, imageName);
                image = new Bitmap(imagePath);

                return image;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            return null;
        }

        // browsing images instead of folders
        private void btnImageBrowser_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();

            ofd.ShowHelp = true;
            ofd.HelpRequest += Ofd_HelpRequest;
            // making sure our openfiledialog browses only for the selected image formats or All files if needed
            ofd.Filter = "BMP Files (.bmp)|*.bmp|JPEG Files (.jpeg)|*.jpeg|GIF Files (.gif)|*.gif|PNG Files (.png)|*.png|JPG Files (.jpg)|*.jpg|All Files (*.*)|*.*";
            ofd.Multiselect = false; // making sure the user can't select more than one image
            
            

            try
            {
                pbImage.Image = Image.FromStream(ofd.OpenFile());
                GetFileInfo(ofd.FileName, ofd.SafeFileName, pbImage.Image.Width.ToString(), pbImage.Image.Height.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            

        }

        private void Ofd_HelpRequest(object sender, EventArgs e)
        {
            // providing help if needed
            MessageBox.Show("Instead of browsing for a folder, select a concrete image.", "Image selector",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // clearing
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbHeight.Text = string.Empty;
            tbLocation.Text = string.Empty;
            tbName.Text = string.Empty;
            tbWidth.Text = string.Empty;
            pbImage.Image = null;
            cbImageFiles.Items.Clear();
        }
    }
}
