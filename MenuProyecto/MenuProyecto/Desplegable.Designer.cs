namespace MenuProyecto
{
    partial class Desplegable
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblNombrePlato = new System.Windows.Forms.Label();
            this.btnPedido = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pbPlatillo = new System.Windows.Forms.PictureBox();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblNombrePlato);
            this.gbDatos.Controls.Add(this.btnPedido);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Controls.Add(this.pbPlatillo);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(413, 509);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlato.Location = new System.Drawing.Point(6, 40);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(383, 37);
            this.lblNombrePlato.TabIndex = 7;
            this.lblNombrePlato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Location = new System.Drawing.Point(106, 422);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(192, 46);
            this.btnPedido.TabIndex = 6;
            this.btnPedido.Text = "Agregar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(7, 330);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(383, 89);
            this.lblDescripcion.TabIndex = 5;
            // 
            // pbPlatillo
            // 
            this.pbPlatillo.Location = new System.Drawing.Point(6, 89);
            this.pbPlatillo.Name = "pbPlatillo";
            this.pbPlatillo.Size = new System.Drawing.Size(383, 238);
            this.pbPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlatillo.TabIndex = 4;
            this.pbPlatillo.TabStop = false;
            // 
            // Desplegable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 524);
            this.Controls.Add(this.gbDatos);
            this.Name = "Desplegable";
            this.Text = "Desplegable";
            this.Load += new System.EventHandler(this.Desplegable_Load);
            this.gbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblNombrePlato;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pbPlatillo;
    }
}