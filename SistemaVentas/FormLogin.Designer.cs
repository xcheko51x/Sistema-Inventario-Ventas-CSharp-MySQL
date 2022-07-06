
namespace SistemaVentas
{
    partial class FormLogin
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
            this.txtEtiqueta = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.txtContrasena = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtDesarrollado = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.AutoSize = true;
            this.txtEtiqueta.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtiqueta.ForeColor = System.Drawing.Color.White;
            this.txtEtiqueta.Location = new System.Drawing.Point(44, 9);
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(459, 39);
            this.txtEtiqueta.TabIndex = 0;
            this.txtEtiqueta.Text = "ACCESO AL SISTEMA SIV";
            this.txtEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(12, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(116, 31);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario:";
            // 
            // pbLogin
            // 
            this.pbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbLogin.Location = new System.Drawing.Point(0, -1);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(643, 64);
            this.pbLogin.TabIndex = 2;
            this.pbLogin.TabStop = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(12, 164);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(163, 31);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(181, 100);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbUsuario.TabIndex = 4;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(181, 175);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '*';
            this.tbContrasena.Size = new System.Drawing.Size(245, 20);
            this.tbContrasena.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(432, 89);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(199, 123);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "INICIAR SESIÓN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtDesarrollado
            // 
            this.txtDesarrollado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDesarrollado.AutoSize = true;
            this.txtDesarrollado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesarrollado.Location = new System.Drawing.Point(12, 220);
            this.txtDesarrollado.Name = "txtDesarrollado";
            this.txtDesarrollado.Size = new System.Drawing.Size(236, 20);
            this.txtDesarrollado.TabIndex = 7;
            this.txtDesarrollado.Text = "Desarrollado por: xcheko51x";
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersion.AutoSize = true;
            this.txtVersion.Location = new System.Drawing.Point(559, 227);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(72, 13);
            this.txtVersion.TabIndex = 8;
            this.txtVersion.Text = "Versión: 1.0.0";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 249);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtDesarrollado);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEtiqueta;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Label txtContrasena;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label txtDesarrollado;
        private System.Windows.Forms.Label txtVersion;
    }
}