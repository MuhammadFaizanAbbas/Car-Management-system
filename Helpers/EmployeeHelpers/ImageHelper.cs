using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.EmployeeHelpers
{
    public static class ImageHelper
    {
        /// <summary>
        /// Opens a dialog to select an image and returns it if valid.
        /// </summary>
        public static bool TrySelectImage(out string imagePath, out Image image, out string errorMessage)
        {
            imagePath = string.Empty;
            image = null;
            errorMessage = string.Empty;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select an Image";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        imagePath = openFileDialog.FileName;

                        if (!File.Exists(imagePath))
                        {
                            errorMessage = "Selected file does not exist.";
                            return false;
                        }

                        image = Image.FromFile(imagePath);
                        return true;
                    }
                    else
                    {
                        errorMessage = "No image selected.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error loading image: " + ex.Message;
                return false;
            }
        }
    }
}
