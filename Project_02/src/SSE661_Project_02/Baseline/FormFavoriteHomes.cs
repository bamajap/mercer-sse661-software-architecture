using System;
using System.Linq;
using System.Windows.Forms;
using FavoriteHomes.Adapters;

namespace Baseline
{
    public partial class FormFavoriteHomes : Form
    {
        /// <summary>
        /// The adapter used to handle communications with the Garmin GPS device.
        /// </summary>
        private GarminAdapter Garmin { get; set; }

        public FormFavoriteHomes()
        {
            InitializeComponent();
            Garmin = new GarminAdapter();
        }

        /// <summary>
        /// Closes the application when the Close button is pressed.
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Adds new homes to the list when the Add button is pressed.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var price = Double.Parse(textBoxPrice.Text.Remove(0, 1));
            var size = Int32.Parse(textBoxSize.Text);
            var pricePerSqFt = ((price == 0.0) || (size == 0)) ? 0.0 : price/size;

            favoriteHomesDataset.dt.Rows.Add(
                textBoxStreet.Text + ", " +
                textBoxCity.Text + ", " + maskedBoxState.Text + ", " + maskedBoxZip.Text,
                Int32.Parse(textBoxBedrooms.Text),
                Int32.Parse(textBoxBathrooms.Text),
                size,
                Int32.Parse(textBoxYearBuilt.Text),
                textBoxPrice.Text,
                pricePerSqFt.ToString("C") + " / sq. ft.");
        }

        /// <summary>
        /// Deletes homes from the list when the Delete button is pressed.
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                dataGridView.Rows.Remove(row);
            }

        }

        /// <summary>
        /// Listener for determining if the Delete button should be enabled or not.
        /// </summary>
        private void dataGridView_RowStateChanged(object sender,
                                                  DataGridViewRowStateChangedEventArgs e)
        {
            // If the list is not empty and the Delete button is disabled, then enable the
            // Delete button...
            if ((dataGridView.SelectedRows.Count > 0) &&
                (!buttonDelete.Enabled))
            {
                buttonDelete.Enabled = true;
            }
            // Else, if the list is empty and the Delete button is enabled, then disabled the
            // Delete button.
            else if ((dataGridView.SelectedRows.Count == 0) &&
                     (buttonDelete.Enabled))
            {
                buttonDelete.Enabled = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }

        /// <summary>
        /// Initiates the process that allows the user to save the list to a *.fhp file.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFhpFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Garmin.SaveFhpFile(dlg.Filename, favoriteHomesDataset.dt);
                MessageBox.Show("File succesfully saved!");
            }
        }

        /// <summary>
        /// Initiates the process that allows the user to export the list to a spreadsheet.
        /// </summary>
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var favoriteHomes = favoriteHomesDataset.dt;

            if (!favoriteHomes.Any()) return;

            Garmin.ExportToSpreadSheet(favoriteHomes);
        }

        /// <summary>
        /// Closes the application when the user selects the 'File > Exit' menu option.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Initiates the process of clearing all of the items from the list by first
        /// getting confirmation from the user and then actually clearing the items from the
        /// list if the user confirmed the clear all action.
        /// </summary>
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result =
                MessageBox.Show("Are you sure you wish to clear all items from the list?",
                                "Clear All Items?", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
                favoriteHomesDataset.Clear();
        }
    }
}