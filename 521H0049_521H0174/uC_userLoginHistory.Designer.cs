namespace _521H0049_521H0174
{
    partial class uC_userLoginHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_logHistory = new System.Windows.Forms.DataGridView();
            this.cbx_filterOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_logHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_logHistory
            // 
            this.DGV_logHistory.AllowUserToAddRows = false;
            this.DGV_logHistory.AllowUserToDeleteRows = false;
            this.DGV_logHistory.AllowUserToResizeColumns = false;
            this.DGV_logHistory.AllowUserToResizeRows = false;
            this.DGV_logHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_logHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_logHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_logHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_logHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_logHistory.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_logHistory.EnableHeadersVisualStyles = false;
            this.DGV_logHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(135)))), ((int)(((byte)(105)))));
            this.DGV_logHistory.Location = new System.Drawing.Point(21, 63);
            this.DGV_logHistory.MultiSelect = false;
            this.DGV_logHistory.Name = "DGV_logHistory";
            this.DGV_logHistory.ReadOnly = true;
            this.DGV_logHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_logHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_logHistory.Size = new System.Drawing.Size(964, 584);
            this.DGV_logHistory.TabIndex = 1;
            // 
            // cbx_filterOption
            // 
            this.cbx_filterOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.cbx_filterOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_filterOption.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_filterOption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbx_filterOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.cbx_filterOption.FormattingEnabled = true;
            this.cbx_filterOption.Location = new System.Drawing.Point(689, 27);
            this.cbx_filterOption.Name = "cbx_filterOption";
            this.cbx_filterOption.Size = new System.Drawing.Size(296, 27);
            this.cbx_filterOption.TabIndex = 14;
            this.cbx_filterOption.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "LOGIN HISTORY";
            // 
            // uC_userLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(184)))), ((int)(((byte)(151)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_filterOption);
            this.Controls.Add(this.DGV_logHistory);
            this.Name = "uC_userLoginHistory";
            this.Size = new System.Drawing.Size(1010, 670);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_logHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_logHistory;
        private System.Windows.Forms.ComboBox cbx_filterOption;
        private System.Windows.Forms.Label label1;
    }
}
