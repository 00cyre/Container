namespace cont.view
{
    partial class minhaempresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(minhaempresa));
            this.lbl_perfil_nomeemp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtnomeroc = new System.Windows.Forms.TextBox();
            this.lblnomeorc = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.txtnovoorçamento = new System.Windows.Forms.ToolStripMenuItem();
            this.histórico = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmateriais = new System.Windows.Forms.ToolStripMenuItem();
            this.txtfunci = new System.Windows.Forms.ToolStripMenuItem();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_perfil_nomeemp
            // 
            this.lbl_perfil_nomeemp.AutoSize = true;
            this.lbl_perfil_nomeemp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_perfil_nomeemp.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lbl_perfil_nomeemp.ForeColor = System.Drawing.Color.White;
            this.lbl_perfil_nomeemp.Location = new System.Drawing.Point(58, 25);
            this.lbl_perfil_nomeemp.Name = "lbl_perfil_nomeemp";
            this.lbl_perfil_nomeemp.Size = new System.Drawing.Size(146, 21);
            this.lbl_perfil_nomeemp.TabIndex = 0;
            this.lbl_perfil_nomeemp.Text = "Nome empresa";
            this.lbl_perfil_nomeemp.Click += new System.EventHandler(this.lbl_perfil_nomeemp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dtglistar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblarea);
            this.panel1.Controls.Add(this.txtnomeroc);
            this.panel1.Controls.Add(this.lblnomeorc);
            this.panel1.Location = new System.Drawing.Point(10, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 319);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(558, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "CRIAR ORÇAMENTO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(707, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 21);
            this.textBox1.TabIndex = 3;
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblarea.ForeColor = System.Drawing.Color.White;
            this.lblarea.Location = new System.Drawing.Point(226, 15);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(169, 19);
            this.lblarea.TabIndex = 2;
            this.lblarea.Text = "AREA DE CONSTRUÇÃO:";
            // 
            // txtnomeroc
            // 
            this.txtnomeroc.Location = new System.Drawing.Point(19, 38);
            this.txtnomeroc.Name = "txtnomeroc";
            this.txtnomeroc.Size = new System.Drawing.Size(171, 21);
            this.txtnomeroc.TabIndex = 1;
            // 
            // lblnomeorc
            // 
            this.lblnomeorc.AutoSize = true;
            this.lblnomeorc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnomeorc.ForeColor = System.Drawing.Color.White;
            this.lblnomeorc.Location = new System.Drawing.Point(15, 15);
            this.lblnomeorc.Name = "lblnomeorc";
            this.lblnomeorc.Size = new System.Drawing.Size(175, 19);
            this.lblnomeorc.TabIndex = 0;
            this.lblnomeorc.Text = "NOME DO ORÇAMENTO:";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtnovoorçamento,
            this.histórico,
            this.txtmateriais,
            this.txtfunci});
            this.menu.Location = new System.Drawing.Point(427, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(374, 25);
            this.menu.TabIndex = 3;
            this.menu.Text = "menu";
            // 
            // txtnovoorçamento
            // 
            this.txtnovoorçamento.ForeColor = System.Drawing.Color.White;
            this.txtnovoorçamento.Name = "txtnovoorçamento";
            this.txtnovoorçamento.Size = new System.Drawing.Size(125, 21);
            this.txtnovoorçamento.Text = "Novo Orçamento";
            this.txtnovoorçamento.Click += new System.EventHandler(this.txtnovoorçamento_Click);
            // 
            // histórico
            // 
            this.histórico.ForeColor = System.Drawing.Color.White;
            this.histórico.Name = "histórico";
            this.histórico.Size = new System.Drawing.Size(72, 21);
            this.histórico.Text = "Histórico";
            // 
            // txtmateriais
            // 
            this.txtmateriais.ForeColor = System.Drawing.Color.White;
            this.txtmateriais.Name = "txtmateriais";
            this.txtmateriais.Size = new System.Drawing.Size(75, 21);
            this.txtmateriais.Text = "Materiais";
            // 
            // txtfunci
            // 
            this.txtfunci.ForeColor = System.Drawing.Color.White;
            this.txtfunci.Name = "txtfunci";
            this.txtfunci.Size = new System.Drawing.Size(94, 21);
            this.txtfunci.Text = "Funcionários";
            // 
            // dtglistar
            // 
            this.dtglistar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(12)))));
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.GridColor = System.Drawing.Color.White;
            this.dtglistar.Location = new System.Drawing.Point(19, 116);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(542, 150);
            this.dtglistar.TabIndex = 6;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // minhaempresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_perfil_nomeemp);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "minhaempresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTAINER";
            this.Load += new System.EventHandler(this.minhaempresa_Load);
            this.Shown += new System.EventHandler(this.minhaempresa_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_perfil_nomeemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem txtnovoorçamento;
        private System.Windows.Forms.ToolStripMenuItem histórico;
        private System.Windows.Forms.ToolStripMenuItem txtmateriais;
        private System.Windows.Forms.ToolStripMenuItem txtfunci;
        private System.Windows.Forms.Label lblnomeorc;
        private System.Windows.Forms.TextBox txtnomeroc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dtglistar;
    }
}