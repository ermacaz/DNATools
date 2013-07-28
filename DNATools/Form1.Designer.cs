namespace DNATools
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
            this.txtOrig = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnRev = new System.Windows.Forms.Button();
            this.btnCmp = new System.Windows.Forms.Button();
            this.btnParallel = new System.Windows.Forms.Button();
            this.btnprotein = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOrig
            // 
            this.txtOrig.Location = new System.Drawing.Point(12, 40);
            this.txtOrig.Name = "txtOrig";
            this.txtOrig.Size = new System.Drawing.Size(271, 20);
            this.txtOrig.TabIndex = 0;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(12, 174);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(244, 20);
            this.txtNew.TabIndex = 1;
            // 
            // btnRev
            // 
            this.btnRev.Location = new System.Drawing.Point(35, 76);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(75, 23);
            this.btnRev.TabIndex = 2;
            this.btnRev.Text = "Rev";
            this.btnRev.UseVisualStyleBackColor = true;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // btnCmp
            // 
            this.btnCmp.Location = new System.Drawing.Point(35, 115);
            this.btnCmp.Name = "btnCmp";
            this.btnCmp.Size = new System.Drawing.Size(75, 23);
            this.btnCmp.TabIndex = 3;
            this.btnCmp.Text = "complement";
            this.btnCmp.UseVisualStyleBackColor = true;
            this.btnCmp.Click += new System.EventHandler(this.btnCmp_Click);
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(116, 115);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(75, 23);
            this.btnParallel.TabIndex = 4;
            this.btnParallel.Text = "Parallel";
            this.btnParallel.UseVisualStyleBackColor = true;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // btnprotein
            // 
            this.btnprotein.Location = new System.Drawing.Point(197, 115);
            this.btnprotein.Name = "btnprotein";
            this.btnprotein.Size = new System.Drawing.Size(75, 23);
            this.btnprotein.TabIndex = 5;
            this.btnprotein.Text = "protein";
            this.btnprotein.UseVisualStyleBackColor = true;
            this.btnprotein.Click += new System.EventHandler(this.btnprotein_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnprotein);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.btnCmp);
            this.Controls.Add(this.btnRev);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOrig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrig;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Button btnCmp;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Button btnprotein;
    }
}

