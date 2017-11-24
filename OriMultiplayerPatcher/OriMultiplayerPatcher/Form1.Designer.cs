namespace OriMultiplayerPatcher
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
            this.Ori = new System.Windows.Forms.Button();
            this.Ori_de = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ori
            // 
            this.Ori.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ori.Location = new System.Drawing.Point(12, 12);
            this.Ori.Name = "Ori";
            this.Ori.Size = new System.Drawing.Size(162, 32);
            this.Ori.TabIndex = 0;
            this.Ori.Text = "Ori";
            this.Ori.UseVisualStyleBackColor = true;
            this.Ori.Click += new System.EventHandler(this.Ori_Click);
            // 
            // Ori_de
            // 
            this.Ori_de.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ori_de.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ori_de.Location = new System.Drawing.Point(12, 50);
            this.Ori_de.Name = "Ori_de";
            this.Ori_de.Size = new System.Drawing.Size(162, 32);
            this.Ori_de.TabIndex = 1;
            this.Ori_de.Text = "Ori DE";
            this.Ori_de.UseVisualStyleBackColor = true;
            this.Ori_de.Click += new System.EventHandler(this.Ori_de_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(186, 93);
            this.Controls.Add(this.Ori_de);
            this.Controls.Add(this.Ori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ori;
        private System.Windows.Forms.Button Ori_de;
    }
}

