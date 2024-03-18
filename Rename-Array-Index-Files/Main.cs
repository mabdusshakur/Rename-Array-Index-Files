using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename_Array_Index_Files
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string[] names;

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        
        private void selectFiles_btn_Click(object sender, EventArgs e)
        {
            int startingNumber = (int)startNumber.Value;

            /*
             * Configurations
             */
            selectFiles.Multiselect = true;

            /*
             * Functionality
             */
            selectFiles.ShowDialog();

            int counter = startingNumber;
            foreach (string name in selectFiles.FileNames)
            {
                string fileName = System.IO.Path.GetFileNameWithoutExtension(name);
                string fileExtension = System.IO.Path.GetExtension(name);
                string[] parts = fileName.Split('_');
                if (parts.Length > 1)
                {
                    string prefix = string.Join("_", parts.Take(parts.Length - 1));
                    string newFileName = prefix + "_" + counter;
                    string newFilePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(name), newFileName + fileExtension);
                    System.IO.File.Move(name, newFilePath);
                }
                counter++;
            }
            MessageBox.Show("done");
        }
    }
}
