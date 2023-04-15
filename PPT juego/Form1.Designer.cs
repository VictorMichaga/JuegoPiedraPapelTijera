namespace PPT_juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_piedra = new System.Windows.Forms.Button();
            this.btn_papel = new System.Windows.Forms.Button();
            this.btn_tijera = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_persona = new System.Windows.Forms.PictureBox();
            this.pb_computadora = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_mensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_computadora)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_piedra
            // 
            this.btn_piedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_piedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_piedra.Location = new System.Drawing.Point(68, 83);
            this.btn_piedra.Name = "btn_piedra";
            this.btn_piedra.Size = new System.Drawing.Size(135, 50);
            this.btn_piedra.TabIndex = 0;
            this.btn_piedra.Text = "Piedra";
            this.btn_piedra.UseVisualStyleBackColor = true;
            this.btn_piedra.Click += new System.EventHandler(this.btn_piedra_Click);
            // 
            // btn_papel
            // 
            this.btn_papel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_papel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_papel.Location = new System.Drawing.Point(68, 188);
            this.btn_papel.Name = "btn_papel";
            this.btn_papel.Size = new System.Drawing.Size(135, 50);
            this.btn_papel.TabIndex = 1;
            this.btn_papel.Text = "Papel";
            this.btn_papel.UseVisualStyleBackColor = true;
            this.btn_papel.Click += new System.EventHandler(this.btn_papel_Click);
            // 
            // btn_tijera
            // 
            this.btn_tijera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tijera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tijera.Location = new System.Drawing.Point(68, 300);
            this.btn_tijera.Name = "btn_tijera";
            this.btn_tijera.Size = new System.Drawing.Size(135, 50);
            this.btn_tijera.TabIndex = 2;
            this.btn_tijera.Text = "Tijera";
            this.btn_tijera.UseVisualStyleBackColor = true;
            this.btn_tijera.Click += new System.EventHandler(this.btn_tijera_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(763, 400);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(128, 51);
            this.btn_nuevo.TabIndex = 3;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(702, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Computadora";
            // 
            // pb_persona
            // 
            this.pb_persona.Image = ((System.Drawing.Image)(resources.GetObject("pb_persona.Image")));
            this.pb_persona.Location = new System.Drawing.Point(250, 100);
            this.pb_persona.Name = "pb_persona";
            this.pb_persona.Size = new System.Drawing.Size(250, 250);
            this.pb_persona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_persona.TabIndex = 6;
            this.pb_persona.TabStop = false;
            this.pb_persona.Click += new System.EventHandler(this.pb_persona_Click);
            // 
            // pb_computadora
            // 
            this.pb_computadora.Image = ((System.Drawing.Image)(resources.GetObject("pb_computadora.Image")));
            this.pb_computadora.Location = new System.Drawing.Point(698, 100);
            this.pb_computadora.Name = "pb_computadora";
            this.pb_computadora.Size = new System.Drawing.Size(250, 250);
            this.pb_computadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_computadora.TabIndex = 7;
            this.pb_computadora.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label3.Font = new System.Drawing.Font("Playbill", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(553, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 101);
            this.label3.TabIndex = 8;
            this.label3.Text = "VS";
            // 
            // lb_mensaje
            // 
            this.lb_mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mensaje.AutoSize = true;
            this.lb_mensaje.BackColor = System.Drawing.Color.Transparent;
            this.lb_mensaje.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lb_mensaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_mensaje.Font = new System.Drawing.Font("Broadway", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensaje.ForeColor = System.Drawing.Color.Black;
            this.lb_mensaje.Location = new System.Drawing.Point(251, 369);
            this.lb_mensaje.Name = "lb_mensaje";
            this.lb_mensaje.Size = new System.Drawing.Size(404, 91);
            this.lb_mensaje.TabIndex = 9;
            this.lb_mensaje.Text = "Mensaje";
            this.lb_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_mensaje.Visible = false;
            this.lb_mensaje.Click += new System.EventHandler(this.lb_mensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 469);
            this.Controls.Add(this.lb_mensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_computadora);
            this.Controls.Add(this.pb_persona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_tijera);
            this.Controls.Add(this.btn_papel);
            this.Controls.Add(this.btn_piedra);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pb_persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_computadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_piedra;
        private System.Windows.Forms.Button btn_papel;
        private System.Windows.Forms.Button btn_tijera;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_persona;
        private System.Windows.Forms.PictureBox pb_computadora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_mensaje;
    }
}

