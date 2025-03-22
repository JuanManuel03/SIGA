
namespace SIGA
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarp = new System.Windows.Forms.Button();
            this.txtnomadmin = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.ListadoProfes = new System.Windows.Forms.DataGridView();
            this.btnCrearH = new System.Windows.Forms.Button();
            this.GuardarProfes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProfes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarProfes)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(271, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Sistema integrado de gestión académica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(91, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 37);
            this.label11.TabIndex = 32;
            this.label11.Text = "SIGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bienvenido";
            // 
            // btnGuardarp
            // 
            this.btnGuardarp.BackColor = System.Drawing.Color.Lime;
            this.btnGuardarp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarp.Location = new System.Drawing.Point(266, 817);
            this.btnGuardarp.Name = "btnGuardarp";
            this.btnGuardarp.Size = new System.Drawing.Size(126, 37);
            this.btnGuardarp.TabIndex = 39;
            this.btnGuardarp.Text = "GUARDAR";
            this.btnGuardarp.UseVisualStyleBackColor = false;
            this.btnGuardarp.Click += new System.EventHandler(this.btnGuardarp_Click);
            // 
            // txtnomadmin
            // 
            this.txtnomadmin.AutoSize = true;
            this.txtnomadmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomadmin.Location = new System.Drawing.Point(129, 101);
            this.txtnomadmin.Name = "txtnomadmin";
            this.txtnomadmin.Size = new System.Drawing.Size(140, 22);
            this.txtnomadmin.TabIndex = 41;
            this.txtnomadmin.Text = "_____________";
            this.txtnomadmin.Click += new System.EventHandler(this.txtnomadmin_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(183, 423);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(209, 38);
            this.btnMostrar.TabIndex = 44;
            this.btnMostrar.Text = "LISTAR DOCENTES";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(477, 816);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 37);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "SALIR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ListadoProfes
            // 
            this.ListadoProfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoProfes.Location = new System.Drawing.Point(16, 215);
            this.ListadoProfes.Name = "ListadoProfes";
            this.ListadoProfes.Size = new System.Drawing.Size(545, 202);
            this.ListadoProfes.TabIndex = 46;
            this.ListadoProfes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoProfes_CellContentClick);
            // 
            // btnCrearH
            // 
            this.btnCrearH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCrearH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearH.Location = new System.Drawing.Point(50, 816);
            this.btnCrearH.Name = "btnCrearH";
            this.btnCrearH.Size = new System.Drawing.Size(166, 38);
            this.btnCrearH.TabIndex = 47;
            this.btnCrearH.Text = "CREAR HORARIO";
            this.btnCrearH.UseVisualStyleBackColor = false;
            this.btnCrearH.Click += new System.EventHandler(this.btnCrearH_Click);
            // 
            // GuardarProfes
            // 
            this.GuardarProfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuardarProfes.Location = new System.Drawing.Point(12, 596);
            this.GuardarProfes.Name = "GuardarProfes";
            this.GuardarProfes.Size = new System.Drawing.Size(642, 202);
            this.GuardarProfes.TabIndex = 48;
            this.GuardarProfes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GuardarProfes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "LISTADO DE DOCENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "GENERAR HORARIO";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(733, 893);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuardarProfes);
            this.Controls.Add(this.btnCrearH);
            this.Controls.Add(this.ListadoProfes);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtnomadmin);
            this.Controls.Add(this.btnGuardarp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Name = "FormAdmin";
            this.Text = "FormProfe";
            this.Load += new System.EventHandler(this.FormProfe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProfes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarProfes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarp;
        private System.Windows.Forms.Label txtnomadmin;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView ListadoProfes;
        private System.Windows.Forms.Button btnCrearH;
        private System.Windows.Forms.DataGridView GuardarProfes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}