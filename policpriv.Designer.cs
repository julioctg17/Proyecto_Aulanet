namespace Proyecto_Aulanet
{
    partial class frmpolicpriv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpolicpriv));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.policprivtxt = new System.Windows.Forms.TabControl();
            this.nahuatl = new System.Windows.Forms.TabPage();
            this.espanol = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnregpo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.policprivtxt.SuspendLayout();
            this.nahuatl.SuspendLayout();
            this.espanol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(124)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(233, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Politicas de Privacidad";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(258, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tlatlauhca tlayoltilizpanaj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-241, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // policprivtxt
            // 
            this.policprivtxt.AccessibleName = "";
            this.policprivtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.policprivtxt.Controls.Add(this.nahuatl);
            this.policprivtxt.Controls.Add(this.espanol);
            this.policprivtxt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policprivtxt.Location = new System.Drawing.Point(22, 101);
            this.policprivtxt.Name = "policprivtxt";
            this.policprivtxt.SelectedIndex = 0;
            this.policprivtxt.Size = new System.Drawing.Size(737, 369);
            this.policprivtxt.TabIndex = 13;
            // 
            // nahuatl
            // 
            this.nahuatl.Controls.Add(this.textBox2);
            this.nahuatl.Location = new System.Drawing.Point(4, 24);
            this.nahuatl.Name = "nahuatl";
            this.nahuatl.Padding = new System.Windows.Forms.Padding(3);
            this.nahuatl.Size = new System.Drawing.Size(729, 341);
            this.nahuatl.TabIndex = 0;
            this.nahuatl.Text = "Nahuatl";
            this.nahuatl.UseVisualStyleBackColor = true;
            this.nahuatl.Click += new System.EventHandler(this.nahuatl_Click);
            // 
            // espanol
            // 
            this.espanol.Controls.Add(this.textBox1);
            this.espanol.Location = new System.Drawing.Point(4, 24);
            this.espanol.Name = "espanol";
            this.espanol.Padding = new System.Windows.Forms.Padding(3);
            this.espanol.Size = new System.Drawing.Size(729, 341);
            this.espanol.TabIndex = 1;
            this.espanol.Text = "Español";
            this.espanol.UseVisualStyleBackColor = true;
            this.espanol.Click += new System.EventHandler(this.espanol_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(-4, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(733, 345);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnregpo
            // 
            this.btnregpo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnregpo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnregpo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregpo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(124)))));
            this.btnregpo.Image = ((System.Drawing.Image)(resources.GetObject("btnregpo.Image")));
            this.btnregpo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregpo.Location = new System.Drawing.Point(22, 498);
            this.btnregpo.Name = "btnregpo";
            this.btnregpo.Size = new System.Drawing.Size(122, 46);
            this.btnregpo.TabIndex = 14;
            this.btnregpo.Text = "  Regresar\r\nTimochīhua";
            this.btnregpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregpo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(618, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(-4, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(733, 345);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // frmpolicpriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnregpo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.policprivtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 612);
            this.Name = "frmpolicpriv";
            this.Text = "Aul@Net";
            this.Load += new System.EventHandler(this.policpriv_Load);
            this.policprivtxt.ResumeLayout(false);
            this.nahuatl.ResumeLayout(false);
            this.nahuatl.PerformLayout();
            this.espanol.ResumeLayout(false);
            this.espanol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl policprivtxt;
        private System.Windows.Forms.TabPage nahuatl;
        private System.Windows.Forms.TabPage espanol;
        private System.Windows.Forms.Button btnregpo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}