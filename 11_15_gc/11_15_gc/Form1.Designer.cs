namespace _11_15_gc
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
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.dtg_adat = new System.Windows.Forms.DataGridView();
            this.Azonosító = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vezetéknév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keresztnév = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Város = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonszám = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_szemely = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_adat)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_1.Location = new System.Drawing.Point(55, 43);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(394, 34);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "A természetjárók nyílvántartása";
            // 
            // lb_2
            // 
            this.lb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_2.Location = new System.Drawing.Point(12, 129);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(411, 27);
            this.lb_2.TabIndex = 1;
            this.lb_2.Text = "A nyílvántartásban szereplő túrázó adatai";
            // 
            // dtg_adat
            // 
            this.dtg_adat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_adat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_adat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Azonosító,
            this.Vezetéknév,
            this.Keresztnév,
            this.Város,
            this.Telefonszám});
            this.dtg_adat.Location = new System.Drawing.Point(12, 203);
            this.dtg_adat.Name = "dtg_adat";
            this.dtg_adat.RowHeadersVisible = false;
            this.dtg_adat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_adat.Size = new System.Drawing.Size(687, 150);
            this.dtg_adat.TabIndex = 2;
            this.dtg_adat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_adat_CellContentClick);
            // 
            // Azonosító
            // 
            this.Azonosító.HeaderText = "azon";
            this.Azonosító.Name = "Azonosító";
            // 
            // Vezetéknév
            // 
            this.Vezetéknév.HeaderText = "vezeteknev";
            this.Vezetéknév.Name = "Vezetéknév";
            // 
            // Keresztnév
            // 
            this.Keresztnév.HeaderText = "keresztnev";
            this.Keresztnév.Name = "Keresztnév";
            // 
            // Város
            // 
            this.Város.HeaderText = "varos";
            this.Város.Name = "Város";
            // 
            // Telefonszám
            // 
            this.Telefonszám.HeaderText = "telefonszam";
            this.Telefonszám.Name = "Telefonszám";
            // 
            // bt_szemely
            // 
            this.bt_szemely.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_szemely.Location = new System.Drawing.Point(44, 375);
            this.bt_szemely.Name = "bt_szemely";
            this.bt_szemely.Size = new System.Drawing.Size(266, 31);
            this.bt_szemely.TabIndex = 3;
            this.bt_szemely.Text = "Új személy felvétele";
            this.bt_szemely.UseVisualStyleBackColor = true;
            this.bt_szemely.Click += new System.EventHandler(this.Bt_szemely_Click);
            // 
            // bt_update
            // 
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_update.Location = new System.Drawing.Point(393, 375);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(266, 31);
            this.bt_update.TabIndex = 4;
            this.bt_update.Text = "Adatok frissítése";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_szemely);
            this.Controls.Add(this.dtg_adat);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Name = "Form1";
            this.Text = "Természetjáró App";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_adat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.DataGridView dtg_adat;
        private System.Windows.Forms.Button bt_szemely;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Azonosító;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vezetéknév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keresztnév;
        private System.Windows.Forms.DataGridViewTextBoxColumn Város;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonszám;
    }
}

