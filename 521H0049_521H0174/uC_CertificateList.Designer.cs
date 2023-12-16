namespace _521H0049_521H0174
{
    partial class uC_CertificateList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.DGV_CM = new System.Windows.Forms.DataGridView();
            this.DGV_studentData = new System.Windows.Forms.DataGridView();
            this.btn_adjust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_studentData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "CERTIFICATE MANAGEMENT";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Brown;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.Location = new System.Drawing.Point(901, 598);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 54);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.Location = new System.Drawing.Point(25, 598);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 54);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // DGV_CM
            // 
            this.DGV_CM.AllowUserToAddRows = false;
            this.DGV_CM.AllowUserToDeleteRows = false;
            this.DGV_CM.AllowUserToResizeColumns = false;
            this.DGV_CM.AllowUserToResizeRows = false;
            this.DGV_CM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CM.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CM.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_CM.EnableHeadersVisualStyles = false;
            this.DGV_CM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.DGV_CM.Location = new System.Drawing.Point(25, 347);
            this.DGV_CM.MultiSelect = false;
            this.DGV_CM.Name = "DGV_CM";
            this.DGV_CM.ReadOnly = true;
            this.DGV_CM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_CM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CM.Size = new System.Drawing.Size(967, 233);
            this.DGV_CM.TabIndex = 18;
            // 
            // DGV_studentData
            // 
            this.DGV_studentData.AllowUserToAddRows = false;
            this.DGV_studentData.AllowUserToDeleteRows = false;
            this.DGV_studentData.AllowUserToResizeColumns = false;
            this.DGV_studentData.AllowUserToResizeRows = false;
            this.DGV_studentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_studentData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_studentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_studentData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_studentData.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_studentData.EnableHeadersVisualStyles = false;
            this.DGV_studentData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.DGV_studentData.Location = new System.Drawing.Point(25, 104);
            this.DGV_studentData.MultiSelect = false;
            this.DGV_studentData.Name = "DGV_studentData";
            this.DGV_studentData.ReadOnly = true;
            this.DGV_studentData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_studentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_studentData.Size = new System.Drawing.Size(964, 226);
            this.DGV_studentData.TabIndex = 24;
            this.DGV_studentData.SelectionChanged += new System.EventHandler(this.DGV_studentData_SelectionChanged);
            // 
            // btn_adjust
            // 
            this.btn_adjust.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_adjust.FlatAppearance.BorderSize = 0;
            this.btn_adjust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adjust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_adjust.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_adjust.Location = new System.Drawing.Point(144, 598);
            this.btn_adjust.Name = "btn_adjust";
            this.btn_adjust.Size = new System.Drawing.Size(91, 54);
            this.btn_adjust.TabIndex = 25;
            this.btn_adjust.Text = "Adjust";
            this.btn_adjust.UseVisualStyleBackColor = false;
            this.btn_adjust.Click += new System.EventHandler(this.btn_adjust_Click);
            // 
            // uC_CertificateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(184)))), ((int)(((byte)(151)))));
            this.Controls.Add(this.btn_adjust);
            this.Controls.Add(this.DGV_studentData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.DGV_CM);
            this.Name = "uC_CertificateList";
            this.Size = new System.Drawing.Size(1010, 670);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_studentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView DGV_CM;
        private System.Windows.Forms.DataGridView DGV_studentData;
        private System.Windows.Forms.Button btn_adjust;
    }
}
