namespace BokenDataBase
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
            this.lbBoeks = new System.Windows.Forms.ListBox();
            this.lblBoeksInfo = new System.Windows.Forms.Label();
            this.labelTitel = new System.Windows.Forms.Label();
            this.btntoevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBoeks
            // 
            this.lbBoeks.FormattingEnabled = true;
            this.lbBoeks.Location = new System.Drawing.Point(12, 30);
            this.lbBoeks.Name = "lbBoeks";
            this.lbBoeks.Size = new System.Drawing.Size(140, 199);
            this.lbBoeks.TabIndex = 0;
            this.lbBoeks.SelectedIndexChanged += new System.EventHandler(this.lbBoeks_SelectedIndexChanged);
            // 
            // lblBoeksInfo
            // 
            this.lblBoeksInfo.AutoSize = true;
            this.lblBoeksInfo.Location = new System.Drawing.Point(167, 30);
            this.lblBoeksInfo.Name = "lblBoeksInfo";
            this.lblBoeksInfo.Size = new System.Drawing.Size(35, 13);
            this.lblBoeksInfo.TabIndex = 1;
            this.lblBoeksInfo.Text = "label1";
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(9, 9);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(44, 13);
            this.labelTitel.TabIndex = 2;
            this.labelTitel.Text = "Boeken";
            // 
            // btntoevoegen
            // 
            this.btntoevoegen.Location = new System.Drawing.Point(12, 247);
            this.btntoevoegen.Name = "btntoevoegen";
            this.btntoevoegen.Size = new System.Drawing.Size(140, 23);
            this.btntoevoegen.TabIndex = 3;
            this.btntoevoegen.Text = "Nieuw Boek";
            this.btntoevoegen.UseVisualStyleBackColor = true;
            this.btntoevoegen.Click += new System.EventHandler(this.btntoevoegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.btntoevoegen);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.lblBoeksInfo);
            this.Controls.Add(this.lbBoeks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBoeks;
        private System.Windows.Forms.Label lblBoeksInfo;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Button btntoevoegen;
    }
}

