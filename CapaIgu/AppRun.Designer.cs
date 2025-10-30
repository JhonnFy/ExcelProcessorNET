namespace CapaIgu
{
    partial class AppRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppRun));
            dataGridViewExcel = new DataGridView();
            btnCreate = new Button();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExcel).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewExcel
            // 
            dataGridViewExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExcel.Dock = DockStyle.Fill;
            dataGridViewExcel.Location = new Point(0, 0);
            dataGridViewExcel.Name = "dataGridViewExcel";
            dataGridViewExcel.Size = new Size(699, 345);
            dataGridViewExcel.TabIndex = 2;
            dataGridViewExcel.CellContentClick += dataGridViewExcel_CellContentClick;
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = (Image)resources.GetObject("btnCreate.BackgroundImage");
            btnCreate.Location = new Point(473, 36);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(123, 21);
            btnCreate.TabIndex = 3;
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnImport
            // 
            btnImport.BackgroundImage = (Image)resources.GetObject("btnImport.BackgroundImage");
            btnImport.Location = new Point(473, 77);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(123, 21);
            btnImport.TabIndex = 4;
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // AppRun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 345);
            Controls.Add(btnImport);
            Controls.Add(btnCreate);
            Controls.Add(dataGridViewExcel);
            Name = "AppRun";
            Text = "AppRun";
            Load += AppRun_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewExcel).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewExcel;
        private Button btnCreate;
        private Button btnImport;
    }
}