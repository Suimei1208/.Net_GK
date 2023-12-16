namespace _521H0049_521H0174
{
    partial class uC_userManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_userData = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_adjust = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_filterOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_userData)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_userData
            // 
            this.DGV_userData.AllowUserToAddRows = false;
            this.DGV_userData.AllowUserToDeleteRows = false;
            this.DGV_userData.AllowUserToResizeColumns = false;
            this.DGV_userData.AllowUserToResizeRows = false;
            this.DGV_userData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_userData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_userData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_userData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_userData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_userData.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_userData.EnableHeadersVisualStyles = false;
            this.DGV_userData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.DGV_userData.Location = new System.Drawing.Point(23, 64);
            this.DGV_userData.MultiSelect = false;
            this.DGV_userData.Name = "DGV_userData";
            this.DGV_userData.ReadOnly = true;
            this.DGV_userData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_userData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_userData.Size = new System.Drawing.Size(967, 513);
            this.DGV_userData.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.Location = new System.Drawing.Point(23, 595);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 54);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_adjust
            // 
            this.btn_adjust.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_adjust.FlatAppearance.BorderSize = 0;
            this.btn_adjust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adjust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_adjust.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_adjust.Location = new System.Drawing.Point(143, 595);
            this.btn_adjust.Name = "btn_adjust";
            this.btn_adjust.Size = new System.Drawing.Size(91, 54);
            this.btn_adjust.TabIndex = 2;
            this.btn_adjust.Text = "Adjust";
            this.btn_adjust.UseVisualStyleBackColor = false;
            this.btn_adjust.Click += new System.EventHandler(this.btn_adjust_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Brown;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.Location = new System.Drawing.Point(899, 595);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 54);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "USER MANAGEMENT";
            // 
            // cbx_filterOption
            // 
            this.cbx_filterOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.cbx_filterOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_filterOption.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_filterOption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbx_filterOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.cbx_filterOption.FormattingEnabled = true;
            this.cbx_filterOption.Location = new System.Drawing.Point(694, 24);
            this.cbx_filterOption.Name = "cbx_filterOption";
            this.cbx_filterOption.Size = new System.Drawing.Size(296, 27);
            this.cbx_filterOption.TabIndex = 17;
            this.cbx_filterOption.SelectedIndexChanged += new System.EventHandler(this.optionChanged);
            // 
            // uC_userManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(184)))), ((int)(((byte)(151)))));
            this.Controls.Add(this.cbx_filterOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_adjust);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.DGV_userData);
            this.Name = "uC_userManagement";
            this.Size = new System.Drawing.Size(1010, 670);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_userData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_userData;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_adjust;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_filterOption;
    }
}
