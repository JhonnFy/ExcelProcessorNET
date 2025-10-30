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
            btnImport = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.BackgroundImage = (Image)resources.GetObject("btnImport.BackgroundImage");
            btnImport.Location = new Point(12, 12);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(54, 50);
            btnImport.TabIndex = 0;
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = (Image)resources.GetObject("btnCreate.BackgroundImage");
            btnCreate.Location = new Point(72, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(54, 50);
            btnCreate.TabIndex = 1;
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // AppRun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 312);
            Controls.Add(btnCreate);
            Controls.Add(btnImport);
            Name = "AppRun";
            Text = "AppRun";
            Load += AppRun_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnImport;
        private Button btnCreate;
    }
}