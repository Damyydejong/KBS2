namespace OpleidingenbedrijfKBS2
{
    partial class Startscherm
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
            this.menuLeftView1 = new OpleidingenbedrijfKBS2.Hoofdmenu.MenuLeftView();
            this.SuspendLayout();
            // 
            // menuLeftView1
            // 
            this.menuLeftView1.BackColor = System.Drawing.SystemColors.Control;
            this.menuLeftView1.Location = new System.Drawing.Point(3, 3);
            this.menuLeftView1.Name = "menuLeftView1";
            this.menuLeftView1.Size = new System.Drawing.Size(218, 627);
            this.menuLeftView1.TabIndex = 0;
            this.menuLeftView1.Load += new System.EventHandler(this.menuLeftView1_Load);
            // 
            // Startscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.menuLeftView1);
            this.Name = "Startscherm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Hoofdmenu.MenuLeftView menuLeftView1;
    }
}

