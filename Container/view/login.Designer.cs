namespace cont.view
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btnentrar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcontainer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.White;
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btnentrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(12)))));
            this.btnentrar.Location = new System.Drawing.Point(197, 358);
            this.btnentrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(209, 65);
            this.btnentrar.TabIndex = 0;
            this.btnentrar.Tag = "";
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            this.btnentrar.MouseLeave += new System.EventHandler(this.btnentrar_MouseLeave);
            this.btnentrar.MouseHover += new System.EventHandler(this.btnentrar_MouseHover);
            // 
            // btncad
            // 
            this.btncad.BackColor = System.Drawing.Color.White;
            this.btncad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncad.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.btncad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(12)))));
            this.btncad.Location = new System.Drawing.Point(428, 358);
            this.btncad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(205, 65);
            this.btncad.TabIndex = 1;
            this.btncad.Tag = "";
            this.btncad.Text = "CADASTRAR";
            this.btncad.UseVisualStyleBackColor = false;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            this.btncad.MouseLeave += new System.EventHandler(this.btncad_MouseLeave);
            this.btncad.MouseHover += new System.EventHandler(this.btncad_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblcontainer
            // 
            this.lblcontainer.AutoSize = true;
            this.lblcontainer.BackColor = System.Drawing.Color.Transparent;
            this.lblcontainer.Font = new System.Drawing.Font("Century Gothic", 60F);
            this.lblcontainer.ForeColor = System.Drawing.Color.White;
            this.lblcontainer.Location = new System.Drawing.Point(169, 222);
            this.lblcontainer.Name = "lblcontainer";
            this.lblcontainer.Size = new System.Drawing.Size(497, 96);
            this.lblcontainer.TabIndex = 3;
            this.lblcontainer.Text = "CONTAINER";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 483);
            this.ControlBox = false;
            this.Controls.Add(this.lblcontainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.btnentrar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTAINER";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcontainer;
    }
}