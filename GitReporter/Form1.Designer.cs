namespace GitReporter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIterate = new System.Windows.Forms.Button();
            this.btnAddRepos = new System.Windows.Forms.Button();
            this.dgvRepos = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new System.Data.DataSet();
            this.tblRepos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.txtOutputFileFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pgb1 = new System.Windows.Forms.ProgressBar();
            this.chkShowDescription = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRepos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIterate
            // 
            this.btnIterate.Location = new System.Drawing.Point(668, 41);
            this.btnIterate.Name = "btnIterate";
            this.btnIterate.Size = new System.Drawing.Size(120, 23);
            this.btnIterate.TabIndex = 1;
            this.btnIterate.Text = "Iterate a Folder";
            this.btnIterate.UseVisualStyleBackColor = true;
            this.btnIterate.Click += new System.EventHandler(this.btnIterate_Click);
            // 
            // btnAddRepos
            // 
            this.btnAddRepos.Location = new System.Drawing.Point(668, 12);
            this.btnAddRepos.Name = "btnAddRepos";
            this.btnAddRepos.Size = new System.Drawing.Size(120, 23);
            this.btnAddRepos.TabIndex = 0;
            this.btnAddRepos.Text = "Add Repositories";
            this.btnAddRepos.UseVisualStyleBackColor = true;
            this.btnAddRepos.Click += new System.EventHandler(this.btnAddRepos_Click);
            // 
            // dgvRepos
            // 
            this.dgvRepos.AllowUserToAddRows = false;
            this.dgvRepos.AutoGenerateColumns = false;
            this.dgvRepos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRepos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRepos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn});
            this.dgvRepos.DataSource = this.bs;
            this.dgvRepos.Location = new System.Drawing.Point(12, 28);
            this.dgvRepos.Name = "dgvRepos";
            this.dgvRepos.RowHeadersVisible = false;
            this.dgvRepos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepos.Size = new System.Drawing.Size(650, 250);
            this.dgvRepos.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.Width = 54;
            // 
            // bs
            // 
            this.bs.DataMember = "repos";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.tblRepos});
            // 
            // tblRepos
            // 
            this.tblRepos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.tblRepos.TableName = "repos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Path";
            // 
            // dgvcName
            // 
            this.dgvcName.DataPropertyName = "Name";
            this.dgvcName.HeaderText = "Name";
            this.dgvcName.Name = "dgvcName";
            this.dgvcName.Width = 60;
            // 
            // dgvcPath
            // 
            this.dgvcPath.DataPropertyName = "Path";
            this.dgvcPath.HeaderText = "Path";
            this.dgvcPath.Name = "dgvcPath";
            this.dgvcPath.Width = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "use Del key to remove the selected row";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(668, 70);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(667, 388);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Gernerate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(65, 391);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(129, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(280, 391);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(115, 20);
            this.dtpFrom.TabIndex = 10;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(475, 391);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(115, 20);
            this.dtpTo.TabIndex = 11;
            // 
            // txtOutputFileFolder
            // 
            this.txtOutputFileFolder.Location = new System.Drawing.Point(88, 281);
            this.txtOutputFileFolder.Name = "txtOutputFileFolder";
            this.txtOutputFileFolder.Size = new System.Drawing.Size(503, 20);
            this.txtOutputFileFolder.TabIndex = 12;
            this.txtOutputFileFolder.Text = "C:\\temp";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(597, 281);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(65, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Output File to";
            // 
            // pgb1
            // 
            this.pgb1.Location = new System.Drawing.Point(12, 426);
            this.pgb1.Name = "pgb1";
            this.pgb1.Size = new System.Drawing.Size(775, 23);
            this.pgb1.TabIndex = 15;
            // 
            // chkShowDescription
            // 
            this.chkShowDescription.AutoSize = true;
            this.chkShowDescription.Location = new System.Drawing.Point(15, 316);
            this.chkShowDescription.Name = "chkShowDescription";
            this.chkShowDescription.Size = new System.Drawing.Size(105, 17);
            this.chkShowDescription.TabIndex = 16;
            this.chkShowDescription.Text = "show description";
            this.chkShowDescription.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkShowDescription);
            this.Controls.Add(this.pgb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtOutputFileFolder);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRepos);
            this.Controls.Add(this.btnAddRepos);
            this.Controls.Add(this.btnIterate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Git Reporter";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRepos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIterate;
        private System.Windows.Forms.Button btnAddRepos;
        private System.Windows.Forms.DataGridView dgvRepos;
        private System.Windows.Forms.BindingSource bs;
        private System.Data.DataSet ds;
        private System.Data.DataTable tblRepos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.TextBox txtOutputFileFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pgb1;
        private System.Windows.Forms.CheckBox chkShowDescription;
    }
}

