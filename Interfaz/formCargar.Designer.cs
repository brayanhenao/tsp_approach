namespace Interfaz
{
    partial class FormCargar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butFiltro = new System.Windows.Forms.Button();
            this.butBuscarCiudad = new System.Windows.Forms.Button();
            this.labPorcentajeCiudades = new System.Windows.Forms.Label();
            this.barraCiudades = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaCiudades = new System.Windows.Forms.DataGridView();
            this.colNombreCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLatitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLongitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreViewCiudad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.butCargarCiudades = new System.Windows.Forms.Button();
            this.txtBuscarCiudad = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mapaCiudades = new GMap.NET.WindowsForms.GMapControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Estadisticas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butSolucionarTodo = new System.Windows.Forms.Button();
            this.labPaginaIr = new System.Windows.Forms.Label();
            this.labPaginasTotales = new System.Windows.Forms.Label();
            this.butIr = new System.Windows.Forms.Button();
            this.txtBuscarPagina = new System.Windows.Forms.TextBox();
            this.butBuscarTodo = new System.Windows.Forms.Button();
            this.labPagina = new System.Windows.Forms.Label();
            this.butSiguiente = new System.Windows.Forms.Button();
            this.butAnterior = new System.Windows.Forms.Button();
            this.tablaViajeros = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreViajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudades = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colPreViewViajero = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colMapViewViajero = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.butCargarViajeros = new System.Windows.Forms.Button();
            this.txtBuscarViajero = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mapaViajeros = new GMap.NET.WindowsForms.GMapControl();
            this.workCargarCiudades = new System.ComponentModel.BackgroundWorker();
            this.workFiltrarCiudades = new System.ComponentModel.BackgroundWorker();
            this.workCargarViajeros = new System.ComponentModel.BackgroundWorker();
            this.workBuscarViajero = new System.ComponentModel.BackgroundWorker();
            this.workContarPaginas = new System.ComponentModel.BackgroundWorker();
            this.workFuerzaBruta = new System.ComponentModel.BackgroundWorker();
            this.workIr = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudades)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajeros)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 267);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Estadisticas);
            this.panel1.Controls.Add(this.butFiltro);
            this.panel1.Controls.Add(this.butBuscarCiudad);
            this.panel1.Controls.Add(this.labPorcentajeCiudades);
            this.panel1.Controls.Add(this.barraCiudades);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tablaCiudades);
            this.panel1.Controls.Add(this.butCargarCiudades);
            this.panel1.Controls.Add(this.txtBuscarCiudad);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 261);
            this.panel1.TabIndex = 1;
            // 
            // butFiltro
            // 
            this.butFiltro.BackColor = System.Drawing.Color.DodgerBlue;
            this.butFiltro.Enabled = false;
            this.butFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFiltro.ForeColor = System.Drawing.Color.White;
            this.butFiltro.Location = new System.Drawing.Point(375, 216);
            this.butFiltro.Name = "butFiltro";
            this.butFiltro.Size = new System.Drawing.Size(138, 42);
            this.butFiltro.TabIndex = 18;
            this.butFiltro.Text = "Filtro";
            this.butFiltro.UseVisualStyleBackColor = false;
            this.butFiltro.Click += new System.EventHandler(this.butFiltro_Click);
            // 
            // butBuscarCiudad
            // 
            this.butBuscarCiudad.Location = new System.Drawing.Point(259, 33);
            this.butBuscarCiudad.Name = "butBuscarCiudad";
            this.butBuscarCiudad.Size = new System.Drawing.Size(49, 23);
            this.butBuscarCiudad.TabIndex = 6;
            this.butBuscarCiudad.Text = "Buscar";
            this.butBuscarCiudad.UseVisualStyleBackColor = true;
            this.butBuscarCiudad.Click += new System.EventHandler(this.butBuscarCiudad_Click);
            // 
            // labPorcentajeCiudades
            // 
            this.labPorcentajeCiudades.AutoSize = true;
            this.labPorcentajeCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPorcentajeCiudades.Location = new System.Drawing.Point(255, 221);
            this.labPorcentajeCiudades.Name = "labPorcentajeCiudades";
            this.labPorcentajeCiudades.Size = new System.Drawing.Size(32, 20);
            this.labPorcentajeCiudades.TabIndex = 5;
            this.labPorcentajeCiudades.Text = "0%";
            // 
            // barraCiudades
            // 
            this.barraCiudades.Location = new System.Drawing.Point(12, 218);
            this.barraCiudades.Name = "barraCiudades";
            this.barraCiudades.Size = new System.Drawing.Size(240, 23);
            this.barraCiudades.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar ciudad:";
            // 
            // tablaCiudades
            // 
            this.tablaCiudades.AllowUserToAddRows = false;
            this.tablaCiudades.AllowUserToDeleteRows = false;
            this.tablaCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreCiudad,
            this.colLatitud,
            this.colLongitud,
            this.colPoblacion,
            this.colPreViewCiudad});
            this.tablaCiudades.Location = new System.Drawing.Point(12, 61);
            this.tablaCiudades.Name = "tablaCiudades";
            this.tablaCiudades.ReadOnly = true;
            this.tablaCiudades.RowHeadersVisible = false;
            this.tablaCiudades.Size = new System.Drawing.Size(501, 150);
            this.tablaCiudades.TabIndex = 2;
            this.tablaCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCiudades_CellClick);
            // 
            // colNombreCiudad
            // 
            this.colNombreCiudad.HeaderText = "Nombre";
            this.colNombreCiudad.Name = "colNombreCiudad";
            this.colNombreCiudad.ReadOnly = true;
            this.colNombreCiudad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLatitud
            // 
            this.colLatitud.HeaderText = "Latitud";
            this.colLatitud.Name = "colLatitud";
            this.colLatitud.ReadOnly = true;
            this.colLatitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLongitud
            // 
            this.colLongitud.HeaderText = "Longitud";
            this.colLongitud.Name = "colLongitud";
            this.colLongitud.ReadOnly = true;
            this.colLongitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPoblacion
            // 
            this.colPoblacion.HeaderText = "Población";
            this.colPoblacion.Name = "colPoblacion";
            this.colPoblacion.ReadOnly = true;
            this.colPoblacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPreViewCiudad
            // 
            this.colPreViewCiudad.HeaderText = "PreView";
            this.colPreViewCiudad.Name = "colPreViewCiudad";
            this.colPreViewCiudad.ReadOnly = true;
            this.colPreViewCiudad.Text = "Ver";
            this.colPreViewCiudad.ToolTipText = "Ver";
            this.colPreViewCiudad.UseColumnTextForButtonValue = true;
            this.colPreViewCiudad.Width = 75;
            // 
            // butCargarCiudades
            // 
            this.butCargarCiudades.BackColor = System.Drawing.Color.DodgerBlue;
            this.butCargarCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCargarCiudades.ForeColor = System.Drawing.Color.White;
            this.butCargarCiudades.Location = new System.Drawing.Point(375, 13);
            this.butCargarCiudades.Name = "butCargarCiudades";
            this.butCargarCiudades.Size = new System.Drawing.Size(138, 42);
            this.butCargarCiudades.TabIndex = 1;
            this.butCargarCiudades.Text = "Cargar ciudades";
            this.butCargarCiudades.UseVisualStyleBackColor = false;
            this.butCargarCiudades.Click += new System.EventHandler(this.butCargarCiudades_Click);
            // 
            // txtBuscarCiudad
            // 
            this.txtBuscarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCiudad.Location = new System.Drawing.Point(12, 33);
            this.txtBuscarCiudad.Name = "txtBuscarCiudad";
            this.txtBuscarCiudad.Size = new System.Drawing.Size(240, 22);
            this.txtBuscarCiudad.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.mapaCiudades);
            this.panel4.Location = new System.Drawing.Point(540, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(351, 267);
            this.panel4.TabIndex = 3;
            // 
            // mapaCiudades
            // 
            this.mapaCiudades.Bearing = 0F;
            this.mapaCiudades.CanDragMap = true;
            this.mapaCiudades.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapaCiudades.GrayScaleMode = false;
            this.mapaCiudades.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapaCiudades.LevelsKeepInMemmory = 5;
            this.mapaCiudades.Location = new System.Drawing.Point(5, 3);
            this.mapaCiudades.MarkersEnabled = true;
            this.mapaCiudades.MaxZoom = 2;
            this.mapaCiudades.MinZoom = 2;
            this.mapaCiudades.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapaCiudades.Name = "mapaCiudades";
            this.mapaCiudades.NegativeMode = false;
            this.mapaCiudades.PolygonsEnabled = true;
            this.mapaCiudades.RetryLoadTile = 0;
            this.mapaCiudades.RoutesEnabled = true;
            this.mapaCiudades.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapaCiudades.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapaCiudades.ShowTileGridLines = false;
            this.mapaCiudades.Size = new System.Drawing.Size(340, 261);
            this.mapaCiudades.TabIndex = 0;
            this.mapaCiudades.Zoom = 0D;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(12, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 284);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.butSolucionarTodo);
            this.panel5.Controls.Add(this.labPaginaIr);
            this.panel5.Controls.Add(this.labPaginasTotales);
            this.panel5.Controls.Add(this.butIr);
            this.panel5.Controls.Add(this.txtBuscarPagina);
            this.panel5.Controls.Add(this.butBuscarTodo);
            this.panel5.Controls.Add(this.labPagina);
            this.panel5.Controls.Add(this.butSiguiente);
            this.panel5.Controls.Add(this.butAnterior);
            this.panel5.Controls.Add(this.tablaViajeros);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.butCargarViajeros);
            this.panel5.Controls.Add(this.txtBuscarViajero);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(516, 278);
            this.panel5.TabIndex = 1;
            // 
            // Estadisticas
            // 
            this.Estadisticas.BackColor = System.Drawing.Color.DodgerBlue;
            this.Estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estadisticas.ForeColor = System.Drawing.SystemColors.Control;
            this.Estadisticas.Location = new System.Drawing.Point(292, 216);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(77, 40);
            this.Estadisticas.TabIndex = 18;
            this.Estadisticas.Text = "Estadísticas";
            this.Estadisticas.UseVisualStyleBackColor = false;
            this.Estadisticas.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ir a página:";
            // 
            // butSolucionarTodo
            // 
            this.butSolucionarTodo.BackColor = System.Drawing.Color.DodgerBlue;
            this.butSolucionarTodo.Enabled = false;
            this.butSolucionarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSolucionarTodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butSolucionarTodo.Location = new System.Drawing.Point(405, 218);
            this.butSolucionarTodo.Name = "butSolucionarTodo";
            this.butSolucionarTodo.Size = new System.Drawing.Size(108, 48);
            this.butSolucionarTodo.TabIndex = 16;
            this.butSolucionarTodo.Text = "Solucionar todo";
            this.butSolucionarTodo.UseVisualStyleBackColor = false;
            this.butSolucionarTodo.Click += new System.EventHandler(this.butSolucionarTodo_Click_1);
            // 
            // labPaginaIr
            // 
            this.labPaginaIr.AutoSize = true;
            this.labPaginaIr.Location = new System.Drawing.Point(93, 223);
            this.labPaginaIr.Name = "labPaginaIr";
            this.labPaginaIr.Size = new System.Drawing.Size(29, 13);
            this.labPaginaIr.TabIndex = 15;
            this.labPaginaIr.Text = "Pág.";
            // 
            // labPaginasTotales
            // 
            this.labPaginasTotales.AutoSize = true;
            this.labPaginasTotales.Location = new System.Drawing.Point(241, 249);
            this.labPaginasTotales.Name = "labPaginasTotales";
            this.labPaginasTotales.Size = new System.Drawing.Size(55, 13);
            this.labPaginasTotales.TabIndex = 14;
            this.labPaginasTotales.Text = "(1 Página)";
            // 
            // butIr
            // 
            this.butIr.Location = new System.Drawing.Point(200, 243);
            this.butIr.Name = "butIr";
            this.butIr.Size = new System.Drawing.Size(41, 23);
            this.butIr.TabIndex = 13;
            this.butIr.Text = "Ir";
            this.butIr.UseVisualStyleBackColor = true;
            this.butIr.Click += new System.EventHandler(this.butIr_Click);
            // 
            // txtBuscarPagina
            // 
            this.txtBuscarPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPagina.Location = new System.Drawing.Point(75, 245);
            this.txtBuscarPagina.Name = "txtBuscarPagina";
            this.txtBuscarPagina.Size = new System.Drawing.Size(119, 22);
            this.txtBuscarPagina.TabIndex = 12;
            // 
            // butBuscarTodo
            // 
            this.butBuscarTodo.Location = new System.Drawing.Point(271, 33);
            this.butBuscarTodo.Name = "butBuscarTodo";
            this.butBuscarTodo.Size = new System.Drawing.Size(75, 23);
            this.butBuscarTodo.TabIndex = 11;
            this.butBuscarTodo.Text = "Búsqueda";
            this.butBuscarTodo.UseVisualStyleBackColor = true;
            this.butBuscarTodo.Click += new System.EventHandler(this.butBuscarTodo_Click);
            // 
            // labPagina
            // 
            this.labPagina.AutoSize = true;
            this.labPagina.Location = new System.Drawing.Point(128, 223);
            this.labPagina.Name = "labPagina";
            this.labPagina.Size = new System.Drawing.Size(13, 13);
            this.labPagina.TabIndex = 10;
            this.labPagina.Text = "1";
            // 
            // butSiguiente
            // 
            this.butSiguiente.Location = new System.Drawing.Point(147, 218);
            this.butSiguiente.Name = "butSiguiente";
            this.butSiguiente.Size = new System.Drawing.Size(75, 23);
            this.butSiguiente.TabIndex = 9;
            this.butSiguiente.Text = "Siguiente";
            this.butSiguiente.UseVisualStyleBackColor = true;
            this.butSiguiente.Click += new System.EventHandler(this.butSiguiente_Click);
            // 
            // butAnterior
            // 
            this.butAnterior.Location = new System.Drawing.Point(12, 218);
            this.butAnterior.Name = "butAnterior";
            this.butAnterior.Size = new System.Drawing.Size(75, 23);
            this.butAnterior.TabIndex = 8;
            this.butAnterior.Text = "Anterior";
            this.butAnterior.UseVisualStyleBackColor = true;
            this.butAnterior.Click += new System.EventHandler(this.butAnterior_Click);
            // 
            // tablaViajeros
            // 
            this.tablaViajeros.AllowUserToAddRows = false;
            this.tablaViajeros.AllowUserToDeleteRows = false;
            this.tablaViajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaViajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombreViajero,
            this.colCiudades,
            this.colPreViewViajero,
            this.colMapViewViajero});
            this.tablaViajeros.Location = new System.Drawing.Point(12, 62);
            this.tablaViajeros.Name = "tablaViajeros";
            this.tablaViajeros.ReadOnly = true;
            this.tablaViajeros.RowHeadersVisible = false;
            this.tablaViajeros.Size = new System.Drawing.Size(501, 150);
            this.tablaViajeros.TabIndex = 7;
            this.tablaViajeros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaViajeros_CellClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNombreViajero
            // 
            this.colNombreViajero.HeaderText = "Nombre";
            this.colNombreViajero.Name = "colNombreViajero";
            this.colNombreViajero.ReadOnly = true;
            this.colNombreViajero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNombreViajero.Width = 125;
            // 
            // colCiudades
            // 
            this.colCiudades.HeaderText = "Ciudades";
            this.colCiudades.LinkColor = System.Drawing.Color.Navy;
            this.colCiudades.Name = "colCiudades";
            this.colCiudades.ReadOnly = true;
            this.colCiudades.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCiudades.Text = "Mostrar ciudades";
            this.colCiudades.ToolTipText = "Mostrar ciudades";
            this.colCiudades.UseColumnTextForLinkValue = true;
            // 
            // colPreViewViajero
            // 
            this.colPreViewViajero.HeaderText = "PreView";
            this.colPreViewViajero.Name = "colPreViewViajero";
            this.colPreViewViajero.ReadOnly = true;
            this.colPreViewViajero.Text = "Ver";
            this.colPreViewViajero.ToolTipText = "Ver";
            this.colPreViewViajero.UseColumnTextForButtonValue = true;
            this.colPreViewViajero.Width = 75;
            // 
            // colMapViewViajero
            // 
            this.colMapViewViajero.HeaderText = "Soluciones";
            this.colMapViewViajero.Name = "colMapViewViajero";
            this.colMapViewViajero.ReadOnly = true;
            this.colMapViewViajero.Text = "Ver";
            this.colMapViewViajero.ToolTipText = "Ver";
            this.colMapViewViajero.UseColumnTextForButtonValue = true;
            this.colMapViewViajero.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar viajero en tabla actual:";
            // 
            // butCargarViajeros
            // 
            this.butCargarViajeros.BackColor = System.Drawing.Color.DodgerBlue;
            this.butCargarViajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCargarViajeros.ForeColor = System.Drawing.Color.White;
            this.butCargarViajeros.Location = new System.Drawing.Point(375, 13);
            this.butCargarViajeros.Name = "butCargarViajeros";
            this.butCargarViajeros.Size = new System.Drawing.Size(138, 42);
            this.butCargarViajeros.TabIndex = 1;
            this.butCargarViajeros.Text = "Cargar viajeros";
            this.butCargarViajeros.UseVisualStyleBackColor = false;
            this.butCargarViajeros.Click += new System.EventHandler(this.butCargarViajeros_Click);
            // 
            // txtBuscarViajero
            // 
            this.txtBuscarViajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarViajero.Location = new System.Drawing.Point(12, 33);
            this.txtBuscarViajero.Name = "txtBuscarViajero";
            this.txtBuscarViajero.Size = new System.Drawing.Size(240, 22);
            this.txtBuscarViajero.TabIndex = 0;
            this.txtBuscarViajero.TextChanged += new System.EventHandler(this.txtBuscarViajero_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.mapaViajeros);
            this.panel6.Location = new System.Drawing.Point(540, 299);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(351, 284);
            this.panel6.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(71, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // mapaViajeros
            // 
            this.mapaViajeros.Bearing = 0F;
            this.mapaViajeros.CanDragMap = true;
            this.mapaViajeros.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapaViajeros.GrayScaleMode = false;
            this.mapaViajeros.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapaViajeros.LevelsKeepInMemmory = 5;
            this.mapaViajeros.Location = new System.Drawing.Point(5, 3);
            this.mapaViajeros.MarkersEnabled = true;
            this.mapaViajeros.MaxZoom = 2;
            this.mapaViajeros.MinZoom = 2;
            this.mapaViajeros.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapaViajeros.Name = "mapaViajeros";
            this.mapaViajeros.NegativeMode = false;
            this.mapaViajeros.PolygonsEnabled = true;
            this.mapaViajeros.RetryLoadTile = 0;
            this.mapaViajeros.RoutesEnabled = true;
            this.mapaViajeros.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapaViajeros.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapaViajeros.ShowTileGridLines = false;
            this.mapaViajeros.Size = new System.Drawing.Size(340, 278);
            this.mapaViajeros.TabIndex = 0;
            this.mapaViajeros.Zoom = 0D;
            // 
            // workCargarCiudades
            // 
            this.workCargarCiudades.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workCargarCiudades_DoWork);
            this.workCargarCiudades.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workCargarCiudades_ProgressChanged);
            this.workCargarCiudades.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workCargarCiudades_RunWorkerCompleted);
            // 
            // workFiltrarCiudades
            // 
            this.workFiltrarCiudades.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workFiltrarCiudades_DoWork);
            this.workFiltrarCiudades.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workFiltrarCiudades_RunWorkerCompleted);
            // 
            // workCargarViajeros
            // 
            this.workCargarViajeros.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workCargarViajeros_DoWork);
            this.workCargarViajeros.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workCargarViajeros_ProgressChanged);
            this.workCargarViajeros.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workCargarViajeros_RunWorkerCompleted);
            // 
            // workBuscarViajero
            // 
            this.workBuscarViajero.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workBuscarViajero_DoWork);
            this.workBuscarViajero.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workBuscarViajero_RunWorkerCompleted);
            // 
            // workContarPaginas
            // 
            this.workContarPaginas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workContarPaginas_DoWork);
            this.workContarPaginas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workContarPaginas_RunWorkerCompleted);
            // 
            // workIr
            // 
            this.workIr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workIr_DoWork);
            this.workIr.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workIr_RunWorkerCompleted);
            // 
            // FormCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(903, 595);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "FormCargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agente viajero";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCiudades)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaViajeros)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar barraCiudades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaCiudades;
        private System.Windows.Forms.Button butCargarCiudades;
        private System.Windows.Forms.TextBox txtBuscarCiudad;
        private System.Windows.Forms.Panel panel4;
        private GMap.NET.WindowsForms.GMapControl mapaCiudades;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butCargarViajeros;
        private System.Windows.Forms.TextBox txtBuscarViajero;
        private System.Windows.Forms.Panel panel6;
        private GMap.NET.WindowsForms.GMapControl mapaViajeros;
        private System.Windows.Forms.DataGridView tablaViajeros;
        private System.ComponentModel.BackgroundWorker workCargarCiudades;
        private System.Windows.Forms.Label labPorcentajeCiudades;
        private System.ComponentModel.BackgroundWorker workFiltrarCiudades;
        private System.Windows.Forms.Button butBuscarCiudad;
        private System.ComponentModel.BackgroundWorker workCargarViajeros;
        private System.Windows.Forms.Label labPagina;
        private System.Windows.Forms.Button butSiguiente;
        private System.Windows.Forms.Button butAnterior;
        private System.Windows.Forms.Button butBuscarTodo;
        private System.ComponentModel.BackgroundWorker workBuscarViajero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labPaginaIr;
        private System.Windows.Forms.Label labPaginasTotales;
        private System.Windows.Forms.Button butIr;
        private System.Windows.Forms.TextBox txtBuscarPagina;
        private System.ComponentModel.BackgroundWorker workContarPaginas;
        private System.ComponentModel.BackgroundWorker workFuerzaBruta;
        private System.ComponentModel.BackgroundWorker workIr;
        private System.Windows.Forms.DataGridViewButtonColumn colMapViewViajero;
        private System.Windows.Forms.DataGridViewButtonColumn colPreViewViajero;
        private System.Windows.Forms.DataGridViewLinkColumn colCiudades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreViajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewButtonColumn colPreViewCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoblacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLongitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCiudad;
        private System.Windows.Forms.Button butSolucionarTodo;
        private System.Windows.Forms.Button butFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Estadisticas;
    }
}

