namespace WFA_Northwind_EntityCore_HW_191123
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbEmployees = new ComboBox();
            cbShipper = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            txtShipCity = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 57);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 104);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 155);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Ship City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 201);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Shipper";
            // 
            // cbEmployees
            // 
            cbEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(179, 57);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(187, 29);
            cbEmployees.TabIndex = 4;
            // 
            // cbShipper
            // 
            cbShipper.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbShipper.FormattingEnabled = true;
            cbShipper.Location = new Point(179, 201);
            cbShipper.Name = "cbShipper";
            cbShipper.Size = new Size(187, 29);
            cbShipper.TabIndex = 5;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpOrderDate.Location = new Point(179, 106);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(187, 29);
            dtpOrderDate.TabIndex = 6;
            // 
            // txtShipCity
            // 
            txtShipCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipCity.Location = new Point(179, 155);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(187, 29);
            txtShipCity.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(179, 292);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 54);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 371);
            Controls.Add(btnAdd);
            Controls.Add(txtShipCity);
            Controls.Add(dtpOrderDate);
            Controls.Add(cbShipper);
            Controls.Add(cbEmployees);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbEmployees;
        private ComboBox cbShipper;
        private DateTimePicker dtpOrderDate;
        private TextBox txtShipCity;
        private Button btnAdd;
    }
}