namespace DVLD_3Tier.People
{
    partial class FrmListPeople
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuEditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolstripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.contextMenuEditDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(486, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 64);
            this.lblTitle.TabIndex = 89;
            this.lblTitle.Text = "Manage People";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 90;
            this.label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cbFilterBy.Location = new System.Drawing.Point(109, 174);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 28);
            this.cbFilterBy.TabIndex = 91;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(336, 176);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 26);
            this.txtFilterValue.TabIndex = 92;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.contextMenuEditDelete;
            this.dgvPeople.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeople.Location = new System.Drawing.Point(13, 226);
            this.dgvPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeople.RowHeadersWidth = 62;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1220, 347);
            this.dgvPeople.TabIndex = 94;
            this.dgvPeople.TabStop = false;
            this.dgvPeople.DoubleClick += new System.EventHandler(this.dgvPeople_DoubleClick);
            // 
            // contextMenuEditDelete
            // 
            this.contextMenuEditDelete.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuEditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripEdit,
            this.toolstripDelete,
            this.toolStripMenuShowDetails,
            this.toolStripMenuAddNewPerson});
            this.contextMenuEditDelete.Name = "contextMenuEditDelete";
            this.contextMenuEditDelete.Size = new System.Drawing.Size(225, 132);
            // 
            // toolstripEdit
            // 
            this.toolstripEdit.Image = global::DVLD_3Tier.Properties.Resources.edit_32;
            this.toolstripEdit.Name = "toolstripEdit";
            this.toolstripEdit.Size = new System.Drawing.Size(224, 32);
            this.toolstripEdit.Text = "Edit";
            this.toolstripEdit.Click += new System.EventHandler(this.toolstripEdit_Click);
            // 
            // toolstripDelete
            // 
            this.toolstripDelete.Image = global::DVLD_3Tier.Properties.Resources.Delete_32_2;
            this.toolstripDelete.Name = "toolstripDelete";
            this.toolstripDelete.Size = new System.Drawing.Size(224, 32);
            this.toolstripDelete.Text = "Delete";
            this.toolstripDelete.Click += new System.EventHandler(this.toolstripDelete_Click);
            // 
            // toolStripMenuShowDetails
            // 
            this.toolStripMenuShowDetails.Image = global::DVLD_3Tier.Properties.Resources.List_32;
            this.toolStripMenuShowDetails.Name = "toolStripMenuShowDetails";
            this.toolStripMenuShowDetails.Size = new System.Drawing.Size(224, 32);
            this.toolStripMenuShowDetails.Text = "Show Details";
            this.toolStripMenuShowDetails.Click += new System.EventHandler(this.toolStripMenuShowDetails_Click);
            // 
            // toolStripMenuAddNewPerson
            // 
            this.toolStripMenuAddNewPerson.Image = global::DVLD_3Tier.Properties.Resources.Add_Person_402;
            this.toolStripMenuAddNewPerson.Name = "toolStripMenuAddNewPerson";
            this.toolStripMenuAddNewPerson.Size = new System.Drawing.Size(224, 32);
            this.toolStripMenuAddNewPerson.Text = "Add New Person";
            this.toolStripMenuAddNewPerson.Click += new System.EventHandler(this.toolStripMenuAddNewPerson_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 95;
            this.label2.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(136, 591);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lblRecordsCount.TabIndex = 96;
            this.lblRecordsCount.Text = "??";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::DVLD_3Tier.Properties.Resources.People_400;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(553, 66);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(133, 72);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 87;
            this.pbPersonImage.TabStop = false;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewPerson.Image = global::DVLD_3Tier.Properties.Resources.AddPerson_32;
            this.btnAddNewPerson.Location = new System.Drawing.Point(1125, 179);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(108, 37);
            this.btnAddNewPerson.TabIndex = 98;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLD_3Tier.Properties.Resources.closeBlack32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1048, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 40);
            this.button1.TabIndex = 99;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmListPeople
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1316, 1050);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmListPeople";
            this.Text = "FrmListPeople";
            this.Load += new System.EventHandler(this.FrmListPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.contextMenuEditDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuEditDelete;
        private System.Windows.Forms.ToolStripMenuItem toolstripEdit;
        private System.Windows.Forms.ToolStripMenuItem toolstripDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuShowDetails;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAddNewPerson;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button button1;
    }
}