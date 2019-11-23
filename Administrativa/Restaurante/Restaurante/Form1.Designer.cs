namespace Restaurante
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
            this.components = new System.ComponentModel.Container();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbpEditar = new System.Windows.Forms.TabPage();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.Pedidos = new System.Windows.Forms.Label();
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecioPedido = new System.Windows.Forms.TextBox();
            this.lblPrecioPedido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescricpion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtNombreMenu = new System.Windows.Forms.TextBox();
            this.lblNombreMenu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpMenu = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Precio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tlpBarra = new System.Windows.Forms.TableLayoutPanel();
            this.tlsBarra = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.txtIdMenu = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomMenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptRestaurantes1 = new Restaurante.rptRestaurantes();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.tbpEditar.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tbcPrincipal.SuspendLayout();
            this.tbpMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tlpBarra.SuspendLayout();
            this.tlsBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADMINISTRACION DE RESTAURANTE";
            // 
            // tbpEditar
            // 
            this.tbpEditar.Controls.Add(this.grbDatos);
            this.tbpEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpEditar.Location = new System.Drawing.Point(4, 29);
            this.tbpEditar.Margin = new System.Windows.Forms.Padding(4);
            this.tbpEditar.Name = "tbpEditar";
            this.tbpEditar.Padding = new System.Windows.Forms.Padding(4);
            this.tbpEditar.Size = new System.Drawing.Size(1012, 571);
            this.tbpEditar.TabIndex = 0;
            this.tbpEditar.Text = "Pedidos";
            this.tbpEditar.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDatos.BackColor = System.Drawing.Color.White;
            this.grbDatos.Controls.Add(this.Pedidos);
            this.grbDatos.Controls.Add(this.cmbPedidos);
            this.grbDatos.Controls.Add(this.btnEntregar);
            this.grbDatos.Controls.Add(this.groupBox2);
            this.grbDatos.Controls.Add(this.groupBox1);
            this.grbDatos.Controls.Add(this.dgvPedidos);
            this.grbDatos.Location = new System.Drawing.Point(16, 7);
            this.grbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatos.Size = new System.Drawing.Size(985, 554);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos generales";
            // 
            // Pedidos
            // 
            this.Pedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pedidos.AutoSize = true;
            this.Pedidos.Location = new System.Drawing.Point(424, 292);
            this.Pedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(74, 20);
            this.Pedidos.TabIndex = 22;
            this.Pedidos.Text = "Pedidos:";
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Location = new System.Drawing.Point(517, 288);
            this.cmbPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(160, 28);
            this.cmbPedidos.TabIndex = 21;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // btnEntregar
            // 
            this.btnEntregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntregar.Location = new System.Drawing.Point(301, 283);
            this.btnEntregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(100, 38);
            this.btnEntregar.TabIndex = 20;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtPrecioPedido);
            this.groupBox2.Controls.Add(this.lblPrecioPedido);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblDescricpion);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.lblPedido);
            this.groupBox2.Controls.Add(this.txtPedido);
            this.groupBox2.Controls.Add(this.txtNombreMenu);
            this.groupBox2.Controls.Add(this.lblNombreMenu);
            this.groupBox2.Location = new System.Drawing.Point(8, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(960, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido";
            // 
            // txtPrecioPedido
            // 
            this.txtPrecioPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrecioPedido.Location = new System.Drawing.Point(396, 71);
            this.txtPrecioPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioPedido.Name = "txtPrecioPedido";
            this.txtPrecioPedido.Size = new System.Drawing.Size(212, 26);
            this.txtPrecioPedido.TabIndex = 21;
            // 
            // lblPrecioPedido
            // 
            this.lblPrecioPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrecioPedido.AutoSize = true;
            this.lblPrecioPedido.Location = new System.Drawing.Point(319, 77);
            this.lblPrecioPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioPedido.Name = "lblPrecioPedido";
            this.lblPrecioPedido.Size = new System.Drawing.Size(62, 20);
            this.lblPrecioPedido.TabIndex = 20;
            this.lblPrecioPedido.Text = "Precio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(650, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescricpion
            // 
            this.lblDescricpion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescricpion.AutoSize = true;
            this.lblDescricpion.Location = new System.Drawing.Point(8, 112);
            this.lblDescricpion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricpion.Name = "lblDescricpion";
            this.lblDescricpion.Size = new System.Drawing.Size(104, 20);
            this.lblDescricpion.TabIndex = 2;
            this.lblDescricpion.Text = "Descripcion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.Location = new System.Drawing.Point(401, 30);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(207, 27);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(319, 30);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcion.Location = new System.Drawing.Point(157, 108);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(451, 64);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblPedido
            // 
            this.lblPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(8, 30);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(91, 20);
            this.lblPedido.TabIndex = 10;
            this.lblPedido.Text = "Pedido No:";
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPedido.Location = new System.Drawing.Point(157, 30);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(124, 26);
            this.txtPedido.TabIndex = 11;
            // 
            // txtNombreMenu
            // 
            this.txtNombreMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreMenu.Location = new System.Drawing.Point(157, 71);
            this.txtNombreMenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMenu.Name = "txtNombreMenu";
            this.txtNombreMenu.Size = new System.Drawing.Size(124, 26);
            this.txtNombreMenu.TabIndex = 17;
            // 
            // lblNombreMenu
            // 
            this.lblNombreMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreMenu.AutoSize = true;
            this.lblNombreMenu.Location = new System.Drawing.Point(8, 71);
            this.lblNombreMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMenu.Name = "lblNombreMenu";
            this.lblNombreMenu.Size = new System.Drawing.Size(126, 20);
            this.lblNombreMenu.TabIndex = 16;
            this.lblNombreMenu.Text = "Nombre platillo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lblIdCliente);
            this.groupBox1.Location = new System.Drawing.Point(8, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(960, 60);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdCliente.Location = new System.Drawing.Point(171, 20);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(235, 26);
            this.txtIdCliente.TabIndex = 3;
            // 
            // lblNombres
            // 
            this.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(443, 23);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(73, 20);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombre:";
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombres.Location = new System.Drawing.Point(533, 20);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(347, 26);
            this.txtNombres.TabIndex = 1;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(69, 23);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(85, 20);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "ID cliente:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPedidos.Location = new System.Drawing.Point(8, 329);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(969, 218);
            this.dgvPedidos.TabIndex = 15;
            this.dgvPedidos.Click += new System.EventHandler(this.DgvPedidos_Click);
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcPrincipal.Controls.Add(this.tbpEditar);
            this.tbcPrincipal.Controls.Add(this.tbpMenu);
            this.tbcPrincipal.Controls.Add(this.tabPage1);
            this.tbcPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPrincipal.Location = new System.Drawing.Point(13, 58);
            this.tbcPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1020, 604);
            this.tbcPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcPrincipal.TabIndex = 2;
            // 
            // tbpMenu
            // 
            this.tbpMenu.Controls.Add(this.groupBox3);
            this.tbpMenu.Location = new System.Drawing.Point(4, 29);
            this.tbpMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tbpMenu.Name = "tbpMenu";
            this.tbpMenu.Padding = new System.Windows.Forms.Padding(4);
            this.tbpMenu.Size = new System.Drawing.Size(1012, 571);
            this.tbpMenu.TabIndex = 1;
            this.tbpMenu.Text = "Menu";
            this.tbpMenu.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dgvMenu);
            this.groupBox3.Location = new System.Drawing.Point(9, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(992, 553);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administración de Menús";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Precio);
            this.groupBox4.Controls.Add(this.txtPrecio);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tlpBarra);
            this.groupBox4.Controls.Add(this.txtIdMenu);
            this.groupBox4.Controls.Add(this.btnExaminar);
            this.groupBox4.Controls.Add(this.pbMenu);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNomMenu);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtDescMenu);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(9, 27);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(975, 235);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Platillo";
            // 
            // Precio
            // 
            this.Precio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(58, 197);
            this.Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(62, 20);
            this.Precio.TabIndex = 21;
            this.Precio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrecio.Location = new System.Drawing.Point(139, 197);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(257, 26);
            this.txtPrecio.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id Platillo:";
            this.label5.Visible = false;
            // 
            // tlpBarra
            // 
            this.tlpBarra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBarra.ColumnCount = 1;
            this.tlpBarra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarra.Controls.Add(this.tlsBarra, 0, 0);
            this.tlpBarra.Location = new System.Drawing.Point(772, 27);
            this.tlpBarra.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBarra.Name = "tlpBarra";
            this.tlpBarra.RowCount = 1;
            this.tlpBarra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBarra.Size = new System.Drawing.Size(195, 54);
            this.tlpBarra.TabIndex = 9;
            // 
            // tlsBarra
            // 
            this.tlsBarra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlsBarra.Dock = System.Windows.Forms.DockStyle.None;
            this.tlsBarra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.btnCancelar,
            this.btnGuardar});
            this.tlsBarra.Location = new System.Drawing.Point(63, 0);
            this.tlsBarra.Name = "tlsBarra";
            this.tlsBarra.Size = new System.Drawing.Size(132, 27);
            this.tlsBarra.Stretch = true;
            this.tlsBarra.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::Restaurante.Properties.Resources.add;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(24, 24);
            this.btnAgregar.Text = "Agregar registro";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::Restaurante.Properties.Resources.delete;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(24, 24);
            this.btnEditar.Text = "Editar registro";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::Restaurante.Properties.Resources.edit;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(24, 24);
            this.btnEliminar.Text = "Eliminar registro";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::Restaurante.Properties.Resources.undo;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(24, 24);
            this.btnCancelar.Text = "Cancelar operacion";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::Restaurante.Properties.Resources.save;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(24, 24);
            this.btnGuardar.Text = "Guardar registro";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdMenu
            // 
            this.txtIdMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdMenu.Location = new System.Drawing.Point(540, 197);
            this.txtIdMenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMenu.Name = "txtIdMenu";
            this.txtIdMenu.Size = new System.Drawing.Size(235, 26);
            this.txtIdMenu.TabIndex = 18;
            this.txtIdMenu.Visible = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExaminar.Location = new System.Drawing.Point(540, 142);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(100, 32);
            this.btnExaminar.TabIndex = 10;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMenu.Location = new System.Drawing.Point(540, 27);
            this.pbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(185, 107);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Foto:";
            // 
            // txtNomMenu
            // 
            this.txtNomMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomMenu.Location = new System.Drawing.Point(139, 31);
            this.txtNomMenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomMenu.Name = "txtNomMenu";
            this.txtNomMenu.Size = new System.Drawing.Size(257, 26);
            this.txtNomMenu.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción:";
            // 
            // txtDescMenu
            // 
            this.txtDescMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescMenu.Location = new System.Drawing.Point(139, 80);
            this.txtDescMenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescMenu.Multiline = true;
            this.txtDescMenu.Name = "txtDescMenu";
            this.txtDescMenu.Size = new System.Drawing.Size(257, 102);
            this.txtDescMenu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMenu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMenu.Location = new System.Drawing.Point(8, 270);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(976, 276);
            this.dgvMenu.TabIndex = 16;
            this.dgvMenu.Click += new System.EventHandler(this.dgvMenu_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crystalReportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1012, 571);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reportes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1004, 563);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1049, 677);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.tbpEditar.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tlpBarra.ResumeLayout(false);
            this.tlpBarra.PerformLayout();
            this.tlsBarra.ResumeLayout(false);
            this.tlsBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpEditar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescricpion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtNombreMenu;
        private System.Windows.Forms.Label lblNombreMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label Pedidos;
        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.TabPage tbpMenu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tlpBarra;
        private System.Windows.Forms.ToolStrip tlsBarra;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPrecioPedido;
        private System.Windows.Forms.Label lblPrecioPedido;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}

