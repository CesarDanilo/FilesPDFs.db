namespace FilesPDFs
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
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_add_file = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tbx_edit = new System.Windows.Forms.TextBox();
            this.label_bottom = new System.Windows.Forms.Label();
            this.btn_create_database = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_search
            // 
            resources.ApplyResources(this.tbx_search, "tbx_search");
            this.tbx_search.Name = "tbx_search";
            // 
            // btn_search
            // 
            this.btn_search.AllowDrop = true;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Name = "btn_search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Extencion,
            this.DATETIME});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Extencion
            // 
            resources.ApplyResources(this.Extencion, "Extencion");
            this.Extencion.Name = "Extencion";
            // 
            // DATETIME
            // 
            resources.ApplyResources(this.DATETIME, "DATETIME");
            this.DATETIME.Name = "DATETIME";
            // 
            // btn_edit
            // 
            resources.ApplyResources(this.btn_edit, "btn_edit");
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_search_all_Click);
            // 
            // btn_open
            // 
            resources.ApplyResources(this.btn_open, "btn_open");
            this.btn_open.Name = "btn_open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_add_file
            // 
            resources.ApplyResources(this.btn_add_file, "btn_add_file");
            this.btn_add_file.Name = "btn_add_file";
            this.btn_add_file.UseVisualStyleBackColor = true;
            this.btn_add_file.Click += new System.EventHandler(this.btn_add_file_Click);
            // 
            // btn_delete
            // 
            resources.ApplyResources(this.btn_delete, "btn_delete");
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tbx_edit
            // 
            resources.ApplyResources(this.tbx_edit, "tbx_edit");
            this.tbx_edit.Name = "tbx_edit";
            // 
            // label_bottom
            // 
            resources.ApplyResources(this.label_bottom, "label_bottom");
            this.label_bottom.ForeColor = System.Drawing.Color.Red;
            this.label_bottom.Name = "label_bottom";
            // 
            // btn_create_database
            // 
            resources.ApplyResources(this.btn_create_database, "btn_create_database");
            this.btn_create_database.Name = "btn_create_database";
            this.btn_create_database.UseVisualStyleBackColor = true;
            this.btn_create_database.Click += new System.EventHandler(this.btn_create_database_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_create_database);
            this.Controls.Add(this.label_bottom);
            this.Controls.Add(this.tbx_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add_file);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbx_search);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbx_search;
        private Button btn_search;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridView dataGridView1;
        private Button btn_edit;
        private Button btn_open;
        private Button btn_add_file;
        private Button btn_delete;
        private TextBox tbx_edit;
        private Label label_bottom;
        private Button btn_create_database;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DATETIME;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Extencion;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}