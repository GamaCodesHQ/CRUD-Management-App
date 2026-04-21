namespace Students_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnDisplay = new Button();
            dgvDisplay = new DataGridView();
            txtName = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnDisplay);
            panel1.Controls.Add(dgvDisplay);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(116, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 640);
            panel1.TabIndex = 0;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.Cyan;
            btnDisplay.Location = new Point(526, 473);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(132, 49);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            // 
            // dgvDisplay
            // 
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(395, 64);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.RowHeadersWidth = 51;
            dgvDisplay.Size = new Size(623, 239);
            dgvDisplay.TabIndex = 8;
            dgvDisplay.CellClick += dgvDisplay_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(18, 190);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 27);
            txtName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(18, 100);
            txtID.Name = "txtID";
            txtID.Size = new Size(361, 27);
            txtID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 156);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 64);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Product ID";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(1004, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 49);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Location = new Point(776, 473);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 49);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Location = new Point(277, 473);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 760);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtName;
        private TextBox txtID;
        private DataGridView dgvDisplay;
        private Button btnDisplay;
    }
}
