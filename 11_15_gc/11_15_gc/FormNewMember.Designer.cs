namespace _11_15_gc
{
    partial class FormNewMember
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
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.Location = new System.Drawing.Point(101, 52);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(100, 23);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "label1";
            this.lb_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 408);
            this.Controls.Add(this.lb_1);
            this.Name = "FormNewMember";
            this.Text = "Form_newMember";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
    }
}