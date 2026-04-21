using System.Data;
using System.Xml.Linq;

namespace Students_Test
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();

            // Define the columns
            dt.Columns.Add("ProductID", typeof(string));
            dt.Columns.Add("ProductName", typeof(string));

            // Bind to the grid
            dgvDisplay.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if ID field is empty
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter a Product ID.");
                return;
            }

            // Check for duplicates
            DataRow[] duplicates = dt.Select($"ProductID = '{txtID.Text}'");

            if (duplicates.Length > 0)
            {
                MessageBox.Show("Error: Product ID already exists!");
            }
            else
            {
                dt.Rows.Add(label1.Text, txtName.Text);
                // Inorder Clear boxes after clicking add
                txtID.Clear();
                txtName.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = dt.Select($"ProductID = '{txtID.Text}'");

            if (foundRows.Length > 0)
            {
                // Update the name of the found row
                foundRows[0]["ProductName"] = txtName.Text;
            }
            else
            {
                MessageBox.Show("Product ID not found. Cannot update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = dt.Select($"ProductID = '{txtID.Text}'");

            if (foundRows.Length > 0)
            {
                // This line removes only the specific row found
                foundRows[0].Delete();
                dt.AcceptChanges(); // Crucial to finalize the change
            }
            else
            {
                MessageBox.Show("Product ID not found. Cannot delete.");
            }
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure they clicked a valid row, not a header
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDisplay.Rows[e.RowIndex];
                txtID.Text = row.Cells["ProductID"].Value.ToString();
                txtName.Text = row.Cells["ProductName"].Value.ToString();
            }
        }
    }
}
