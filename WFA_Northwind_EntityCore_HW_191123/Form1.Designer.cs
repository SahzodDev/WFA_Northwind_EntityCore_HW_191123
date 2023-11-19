namespace WFA_Northwind_EntityCore_HW_191123
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
            lstEmployees = new ListBox();
            lstShippers = new ListBox();
            btnGetorderList = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // lstEmployees
            // 
            lstEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 21;
            lstEmployees.Location = new Point(12, 84);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(191, 298);
            lstEmployees.TabIndex = 0;
            // 
            // lstShippers
            // 
            lstShippers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstShippers.FormattingEnabled = true;
            lstShippers.ItemHeight = 21;
            lstShippers.Location = new Point(12, 403);
            lstShippers.Name = "lstShippers";
            lstShippers.Size = new Size(191, 193);
            lstShippers.TabIndex = 1;
            // 
            // btnGetorderList
            // 
            btnGetorderList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetorderList.Location = new Point(12, 12);
            btnGetorderList.Name = "btnGetorderList";
            btnGetorderList.Size = new Size(162, 51);
            btnGetorderList.TabIndex = 2;
            btnGetorderList.Text = "Get Order List";
            btnGetorderList.UseVisualStyleBackColor = true;
            btnGetorderList.Click += btnGetorderList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(180, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 51);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(348, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 51);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(516, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 51);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeColumns = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(209, 84);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.Size = new Size(349, 517);
            dgvOrders.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 617);
            Controls.Add(dgvOrders);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnGetorderList);
            Controls.Add(lstShippers);
            Controls.Add(lstEmployees);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstEmployees;
        private ListBox lstShippers;
        private Button btnGetorderList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvOrders;
    }
}