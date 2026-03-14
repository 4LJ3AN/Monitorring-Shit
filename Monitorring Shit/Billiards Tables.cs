using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Monitorring_Shit
{
    public partial class Billiards_Tables : UserControl
    {
        public Billiards_Tables()
        {
            InitializeComponent();
            SetDefaultImages();
        }

        private void SetDefaultImages()
        {
            // Set all tables to available state
            UpdateTableStatus(1, "Available");
            UpdateTableStatus(2, "Available");
            UpdateTableStatus(3, "Available");
            UpdateTableStatus(4, "Available");
            UpdateTableStatus(5, "Available");
            UpdateTableStatus(6, "Available");
        }

        public void UpdateTableStatus(int tableNumber, string status)
        {
            // Get the correct PictureBox and TextBox for this table
            PictureBox targetPictureBox = null;
            TextBox targetTextBox = null;

            switch (tableNumber)
            {
                case 1:
                    targetPictureBox = pictureBox1;
                    targetTextBox = textStat1;
                    break;
                case 2:
                    targetPictureBox = pictureBox2;
                    targetTextBox = textBox2;
                    break;
                case 3:
                    targetPictureBox = pictureBox3;
                    targetTextBox = textBox3;
                    break;
                case 4:
                    targetPictureBox = pictureBox6;
                    targetTextBox = textBox6;
                    break;
                case 5:
                    targetPictureBox = pictureBox5;
                    targetTextBox = textBox5;
                    break;
                case 6:
                    targetPictureBox = pictureBox4;
                    targetTextBox = textBox4;
                    break;
            }

            if (targetPictureBox != null)
            {
                // Set image based on status using your image names
                switch (status)
                {
                    case "Available":
                        targetPictureBox.Image = Properties.Resources.Billiards_Table_Available;
                        break;
                    case "In Use":
                        targetPictureBox.Image = Properties.Resources.Billiards_Table_Inuse;
                        break;
                    default:
                        targetPictureBox.Image = Properties.Resources.Billiards_Table_Available;
                        break;
                }

                targetPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (targetTextBox != null)
            {
                targetTextBox.Text = $"Table {status}";

                // Change textbox color based on status
                switch (status)
                {
                    case "Available":
                        targetTextBox.BackColor = Color.FromArgb(200, 255, 200); // Light green
                        break;
                    case "In Use":
                        targetTextBox.BackColor = Color.FromArgb(255, 200, 200); // Light red
                        break;
                }
            }
        }

        // Convenience methods for easy status changes
        public void SetTableAvailable(int tableNumber)
        {
            UpdateTableStatus(tableNumber, "Available");
        }

        public void SetTableInUse(int tableNumber)
        {
            UpdateTableStatus(tableNumber, "In Use");
        }

        // Method to get current table status
        public string GetTableStatus(int tableNumber)
        {
            switch (tableNumber)
            {
                case 1:
                    return textStat1.Text.Replace("Table ", "");
                case 2:
                    return textBox2.Text.Replace("Table ", "");
                case 3:
                    return textBox3.Text.Replace("Table ", "");
                case 4:
                    return textBox6.Text.Replace("Table ", "");
                case 5:
                    return textBox5.Text.Replace("Table ", "");
                case 6:
                    return textBox4.Text.Replace("Table ", "");
                default:
                    return "Unknown";
            }
        }

        // Optional: Method to toggle between states
        public void ToggleTableStatus(int tableNumber)
        {
            string currentStatus = GetTableStatus(tableNumber);
            if (currentStatus == "Available")
                SetTableInUse(tableNumber);
            else if (currentStatus == "In Use")
                SetTableAvailable(tableNumber);
        }
    }
}