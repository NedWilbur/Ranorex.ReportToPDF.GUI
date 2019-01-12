using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ranorex.ReportToPDF;
using System.IO;

namespace Ranorex.ReportToPDF.GUI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            inpDetailLevel.SelectedIndex = 0; //Set Default Value
        }

        #region Browse Buttons
        private void btnBrowseReportFile_Click(object sender, EventArgs e)
        {
            //inpReportPath.Text = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.rxzlog").First(), SearchOption.AllDirectories;
            DialogResult result = rxzlogFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                inpReportPath.Text = rxzlogFileDialog.FileName;
        }

        private void btnBrowsesaveDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
                inpSaveDirectory.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnSelectStyleSheet_Click(object sender, EventArgs e)
        {
            DialogResult result = cssFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                inpStyleSheet.Text = cssFileDialog.FileName;
        }
        #endregion 

        /// <summary>
        /// Autocomplete PDF File Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inpReportPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Remove Extension
                string filePath = inpReportPath.Text;
                filePath = filePath.Substring(0, filePath.LastIndexOf(".") + 1);

                //Get FileName
                string[] splitFilePath = filePath.Split('\\');
                inpPDFName.Text = splitFilePath[splitFilePath.Length - 1] + "pdf";
            }
            catch (Exception)
            {
                //Do Nothing, Not a needed feature
            }
        }

        /// <summary>
        /// Convert rxzlog to PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Validate Inputs
            if (inpReportPath.Text.Length <= 0 ||
                inpPDFName.Text.Length <= 0)
            {
                MessageBox.Show("Missing input. Please complete all required input fields before converting.");
                return;
            }

            //Format File Path
            inpSaveDirectory.Text.TrimEnd('/');
            if (inpSaveDirectory.Text.Length > 0 &&
                !inpSaveDirectory.Text.EndsWith("\\"))
                inpSaveDirectory.Text += "\\";

            //Create Save Directory
            if (inpSaveDirectory.Text.Length > 0 &&
                !Directory.Exists(inpSaveDirectory.Text))
                Directory.CreateDirectory(inpSaveDirectory.Text);

            //Set Inputs
            string input = inpReportPath.Text;
            string pdf = inpSaveDirectory.Text + inpPDFName.Text;
            //string xml = inpStyleSheet.Text; //Custom xms bugged, use below in meantime
            string xml = string.Empty; //Use until reporttopdf assembly fixed
            string details = inpDetailLevel.SelectedItem.ToString().ToLower();

            try
            {
                PDF.Creator.CreatePDF(input, pdf, xml, details);

                //Open Report?
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something happened. {Environment.NewLine}{Environment.NewLine}{ex}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
