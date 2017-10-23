namespace cont.view
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.lbllogin = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.btnlogar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.numsenhauser = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.Font = new System.Drawing.Font("Century Gothic", 45F);
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(33, 22);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(222, 74);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "LOGIN";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(37, 149);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(122, 40);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "EMAIL:";
            this.lbluser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.lblsenha.ForeColor = System.Drawing.Color.White;
            this.lblsenha.Location = new System.Drawing.Point(39, 267);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(132, 40);
            this.lblsenha.TabIndex = 0;
            this.lblsenha.Text = "SENHA:";
            // 
            // btnlogar
            // 
            this.btnlogar.BackColor = System.Drawing.Color.White;
            this.btnlogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogar.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btnlogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(12)))));
            this.btnlogar.Location = new System.Drawing.Point(447, 396);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Size = new System.Drawing.Size(124, 55);
            this.btnlogar.TabIndex = 3;
            this.btnlogar.Text = "LOGAR";
            this.btnlogar.UseVisualStyleBackColor = false;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            this.btnlogar.MouseLeave += new System.EventHandler(this.btnlogar_MouseLeave);
            this.btnlogar.MouseHover += new System.EventHandler(this.btnlogar_MouseHover);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.White;
            this.btnvoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvoltar.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btnvoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(12)))));
            this.btnvoltar.Location = new System.Drawing.Point(606, 396);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(124, 55);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            this.btnvoltar.MouseLeave += new System.EventHandler(this.btnvoltar_MouseLeave);
            this.btnvoltar.MouseHover += new System.EventHandler(this.btnvoltar_MouseHover);
            // 
            // numsenhauser
            // 
            this.numsenhauser.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.numsenhauser.Location = new System.Drawing.Point(46, 320);
            this.numsenhauser.Mask = "0000000000000000000000000000000000000000000000000000000000000000000";
            this.numsenhauser.Name = "numsenhauser";
            this.numsenhauser.PasswordChar = '$';
            this.numsenhauser.Size = new System.Drawing.Size(230, 40);
            this.numsenhauser.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.txtemail.Location = new System.Drawing.Point(44, 202);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(265, 40);
            this.txtemail.TabIndex = 7;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 494);
            this.ControlBox = false;
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.numsenhauser);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlogar);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lbllogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTAINER";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Button btnlogar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.MaskedTextBox numsenhauser;
        private System.Windows.Forms.TextBox txtemail;
    }
}