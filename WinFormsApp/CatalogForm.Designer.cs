
namespace WinFormsApp
{
    partial class CatalogForm
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
            this.components = new System.ComponentModel.Container();
            this.lblFiePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chAutoSaveTimer = new System.Windows.Forms.CheckBox();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gbDataStore = new System.Windows.Forms.GroupBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.gbDataStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiePath
            // 
            this.lblFiePath.AutoSize = true;
            this.lblFiePath.Location = new System.Drawing.Point(17, 32);
            this.lblFiePath.Name = "lblFiePath";
            this.lblFiePath.Size = new System.Drawing.Size(52, 15);
            this.lblFiePath.TabIndex = 1;
            this.lblFiePath.Text = "File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(75, 29);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(202, 23);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Text = "Catalog.txt";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(295, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chAutoSaveTimer
            // 
            this.chAutoSaveTimer.AutoSize = true;
            this.chAutoSaveTimer.Location = new System.Drawing.Point(75, 69);
            this.chAutoSaveTimer.Name = "chAutoSaveTimer";
            this.chAutoSaveTimer.Size = new System.Drawing.Size(110, 19);
            this.chAutoSaveTimer.TabIndex = 4;
            this.chAutoSaveTimer.Text = "Auto Save Every";
            this.chAutoSaveTimer.UseVisualStyleBackColor = true;
            this.chAutoSaveTimer.CheckedChanged += new System.EventHandler(this.chAutoSaveTimer_CheckedChanged);
            // 
            // numTimer
            // 
            this.numTimer.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numTimer.Location = new System.Drawing.Point(184, 68);
            this.numTimer.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(93, 23);
            this.numTimer.TabIndex = 5;
            this.numTimer.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(435, 175);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(33, 15);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(494, 172);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(163, 23);
            this.txtFilter.TabIndex = 8;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // gbDataStore
            // 
            this.gbDataStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDataStore.Controls.Add(this.lblFiePath);
            this.gbDataStore.Controls.Add(this.txtFilePath);
            this.gbDataStore.Controls.Add(this.btnLoad);
            this.gbDataStore.Controls.Add(this.numTimer);
            this.gbDataStore.Controls.Add(this.chAutoSaveTimer);
            this.gbDataStore.Location = new System.Drawing.Point(22, 44);
            this.gbDataStore.Name = "gbDataStore";
            this.gbDataStore.Size = new System.Drawing.Size(391, 103);
            this.gbDataStore.TabIndex = 0;
            this.gbDataStore.TabStop = false;
            this.gbDataStore.Text = "Data Store";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(22, 175);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(127, 28);
            this.btnCreateProduct.TabIndex = 6;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToOrderColumns = true;
            this.dgvCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Location = new System.Drawing.Point(22, 209);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.RowTemplate.Height = 25;
            this.dgvCatalog.Size = new System.Drawing.Size(635, 228);
            this.dgvCatalog.TabIndex = 9;
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgvCatalog);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.gbDataStore);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Name = "CatalogForm";
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.gbDataStore.ResumeLayout(false);
            this.gbDataStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox chAutoSaveTimer;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.GroupBox gbDataStore;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.Timer timerAutoSave;
    }
}

