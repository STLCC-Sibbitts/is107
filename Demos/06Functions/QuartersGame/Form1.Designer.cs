namespace QuartersGame
{
    partial class frmQuarters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuarters));
            this.pbComputerHeads = new System.Windows.Forms.PictureBox();
            this.pbPlayerHeads = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnMismatch = new System.Windows.Forms.Button();
            this.pbPlayerTails = new System.Windows.Forms.PictureBox();
            this.pbComputerTails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerTails)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputerHeads
            // 
            this.pbComputerHeads.Image = ((System.Drawing.Image)(resources.GetObject("pbComputerHeads.Image")));
            this.pbComputerHeads.Location = new System.Drawing.Point(64, 34);
            this.pbComputerHeads.Name = "pbComputerHeads";
            this.pbComputerHeads.Size = new System.Drawing.Size(120, 120);
            this.pbComputerHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputerHeads.TabIndex = 0;
            this.pbComputerHeads.TabStop = false;
            // 
            // pbPlayerHeads
            // 
            this.pbPlayerHeads.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerHeads.Image")));
            this.pbPlayerHeads.Location = new System.Drawing.Point(231, 34);
            this.pbPlayerHeads.Name = "pbPlayerHeads";
            this.pbPlayerHeads.Size = new System.Drawing.Size(120, 120);
            this.pbPlayerHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerHeads.TabIndex = 1;
            this.pbPlayerHeads.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(89, 212);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 34);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnMismatch
            // 
            this.btnMismatch.Location = new System.Drawing.Point(251, 212);
            this.btnMismatch.Name = "btnMismatch";
            this.btnMismatch.Size = new System.Drawing.Size(75, 34);
            this.btnMismatch.TabIndex = 5;
            this.btnMismatch.Text = "Mismatch";
            this.btnMismatch.UseVisualStyleBackColor = true;
            this.btnMismatch.Click += new System.EventHandler(this.btnMismatch_Click);
            // 
            // pbPlayerTails
            // 
            this.pbPlayerTails.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayerTails.Image")));
            this.pbPlayerTails.Location = new System.Drawing.Point(231, 34);
            this.pbPlayerTails.Name = "pbPlayerTails";
            this.pbPlayerTails.Size = new System.Drawing.Size(120, 120);
            this.pbPlayerTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerTails.TabIndex = 6;
            this.pbPlayerTails.TabStop = false;
            // 
            // pbComputerTails
            // 
            this.pbComputerTails.Image = ((System.Drawing.Image)(resources.GetObject("pbComputerTails.Image")));
            this.pbComputerTails.Location = new System.Drawing.Point(64, 34);
            this.pbComputerTails.Name = "pbComputerTails";
            this.pbComputerTails.Size = new System.Drawing.Size(120, 120);
            this.pbComputerTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComputerTails.TabIndex = 7;
            this.pbComputerTails.TabStop = false;
            // 
            // frmQuarters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 311);
            this.Controls.Add(this.pbComputerTails);
            this.Controls.Add(this.pbPlayerTails);
            this.Controls.Add(this.btnMismatch);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPlayerHeads);
            this.Controls.Add(this.pbComputerHeads);
            this.Name = "frmQuarters";
            this.Text = "Let\'s Play Quarters";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputerHeads;
        private System.Windows.Forms.PictureBox pbPlayerHeads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnMismatch;
        private System.Windows.Forms.PictureBox pbPlayerTails;
        private System.Windows.Forms.PictureBox pbComputerTails;
    }
}

