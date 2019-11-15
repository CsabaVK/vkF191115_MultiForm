namespace _11_15_gc
{
    partial class FormPopUp
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
            this.f2_lb_1 = new System.Windows.Forms.Label();
            this.f2_dtg = new System.Windows.Forms.DataGridView();
            this.f2_lb_2 = new System.Windows.Forms.Label();
            this.f2_lb_3 = new System.Windows.Forms.Label();
            this.f2_tb_osszkm = new System.Windows.Forms.TextBox();
            this.f2_tb_jutalomp = new System.Windows.Forms.TextBox();
            this.Indulás = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Érkezés = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MegtettÚt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.f2_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // f2_lb_1
            // 
            this.f2_lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f2_lb_1.Location = new System.Drawing.Point(92, 31);
            this.f2_lb_1.Name = "f2_lb_1";
            this.f2_lb_1.Size = new System.Drawing.Size(239, 23);
            this.f2_lb_1.TabIndex = 0;
            this.f2_lb_1.Text = "A kiválasztott túrázó kirándulása";
            // 
            // f2_dtg
            // 
            this.f2_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f2_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indulás,
            this.Érkezés,
            this.MegtettÚt});
            this.f2_dtg.Location = new System.Drawing.Point(12, 77);
            this.f2_dtg.Name = "f2_dtg";
            this.f2_dtg.Size = new System.Drawing.Size(398, 150);
            this.f2_dtg.TabIndex = 1;
            this.f2_dtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // f2_lb_2
            // 
            this.f2_lb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f2_lb_2.Location = new System.Drawing.Point(12, 252);
            this.f2_lb_2.Name = "f2_lb_2";
            this.f2_lb_2.Size = new System.Drawing.Size(239, 23);
            this.f2_lb_2.TabIndex = 3;
            this.f2_lb_2.Text = "A túrázó összes megtett km-e:";
            // 
            // f2_lb_3
            // 
            this.f2_lb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.f2_lb_3.Location = new System.Drawing.Point(12, 290);
            this.f2_lb_3.Name = "f2_lb_3";
            this.f2_lb_3.Size = new System.Drawing.Size(239, 23);
            this.f2_lb_3.TabIndex = 4;
            this.f2_lb_3.Text = "Jutalompontok összege:";
            // 
            // f2_tb_osszkm
            // 
            this.f2_tb_osszkm.Location = new System.Drawing.Point(257, 255);
            this.f2_tb_osszkm.Name = "f2_tb_osszkm";
            this.f2_tb_osszkm.Size = new System.Drawing.Size(153, 20);
            this.f2_tb_osszkm.TabIndex = 5;
            // 
            // f2_tb_jutalomp
            // 
            this.f2_tb_jutalomp.Location = new System.Drawing.Point(257, 293);
            this.f2_tb_jutalomp.Name = "f2_tb_jutalomp";
            this.f2_tb_jutalomp.Size = new System.Drawing.Size(153, 20);
            this.f2_tb_jutalomp.TabIndex = 6;
            // 
            // Indulás
            // 
            this.Indulás.HeaderText = "indulas";
            this.Indulás.Name = "Indulás";
            // 
            // Érkezés
            // 
            this.Érkezés.HeaderText = "erkezes";
            this.Érkezés.Name = "Érkezés";
            // 
            // MegtettÚt
            // 
            this.MegtettÚt.HeaderText = "megtettut";
            this.MegtettÚt.Name = "MegtettÚt";
            // 
            // FormPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 357);
            this.Controls.Add(this.f2_tb_jutalomp);
            this.Controls.Add(this.f2_tb_osszkm);
            this.Controls.Add(this.f2_lb_3);
            this.Controls.Add(this.f2_lb_2);
            this.Controls.Add(this.f2_dtg);
            this.Controls.Add(this.f2_lb_1);
            this.Name = "FormPopUp";
            this.Text = "FormPopUp";
            ((System.ComponentModel.ISupportInitialize)(this.f2_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f2_lb_1;
        private System.Windows.Forms.DataGridView f2_dtg;
        private System.Windows.Forms.Label f2_lb_2;
        private System.Windows.Forms.Label f2_lb_3;
        private System.Windows.Forms.TextBox f2_tb_osszkm;
        private System.Windows.Forms.TextBox f2_tb_jutalomp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indulás;
        private System.Windows.Forms.DataGridViewTextBoxColumn Érkezés;
        private System.Windows.Forms.DataGridViewTextBoxColumn MegtettÚt;
    }
}