namespace ProyExamen1
{
    partial class frmAsignacionPracticaProfesional
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
            this.components = new System.ComponentModel.Container();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.grpDatosCarrera = new System.Windows.Forms.GroupBox();
            this.grpDocumentosEntregados = new System.Windows.Forms.GroupBox();
            this.grpDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.txtTelefonoMovil = new System.Windows.Forms.TextBox();
            this.lblTelefonoMovil = new System.Windows.Forms.Label();
            this.lblTelefonoFijo = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rbdE = new System.Windows.Forms.RadioButton();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.pctFotografiaMia = new System.Windows.Forms.PictureBox();
            this.grbFotografía = new System.Windows.Forms.GroupBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.chcServicioSocialConcluido = new System.Windows.Forms.CheckBox();
            this.chcSolicitud = new System.Windows.Forms.CheckBox();
            this.chcCartaCompromiso = new System.Windows.Forms.CheckBox();
            this.chcCurriculumVitae = new System.Windows.Forms.CheckBox();
            this.chcCartaDeAceptacion = new System.Windows.Forms.CheckBox();
            this.chcSeleccionDeEmpresas = new System.Windows.Forms.CheckBox();
            this.chcEntrevistaPorCompetencias = new System.Windows.Forms.CheckBox();
            this.chcCartaDeLiberacion = new System.Windows.Forms.CheckBox();
            this.chcCartaDePresentacion = new System.Windows.Forms.CheckBox();
            this.chcSeguroGastosMedicos = new System.Windows.Forms.CheckBox();
            this.lstEmpresas = new System.Windows.Forms.ListBox();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefonoMovilAsesor = new System.Windows.Forms.Label();
            this.txtTelefonoMovilAsesor = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dttFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.dttFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaTermino = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.grpDatosPersonales.SuspendLayout();
            this.grpDatosCarrera.SuspendLayout();
            this.grpDocumentosEntregados.SuspendLayout();
            this.grpDatosEmpresa.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotografiaMia)).BeginInit();
            this.grbFotografía.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.lblApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.lblTelefonoFijo);
            this.grpDatosPersonales.Controls.Add(this.lblTelefonoMovil);
            this.grpDatosPersonales.Controls.Add(this.txtTelefonoMovil);
            this.grpDatosPersonales.Controls.Add(this.txtTelefonoFijo);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(22, 24);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(548, 206);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos personales";
            // 
            // grpDatosCarrera
            // 
            this.grpDatosCarrera.Controls.Add(this.chcServicioSocialConcluido);
            this.grpDatosCarrera.Controls.Add(this.txtPromedio);
            this.grpDatosCarrera.Controls.Add(this.cmbSemestre);
            this.grpDatosCarrera.Controls.Add(this.cmbCarrera);
            this.grpDatosCarrera.Controls.Add(this.lblPromedio);
            this.grpDatosCarrera.Controls.Add(this.lblSemestre);
            this.grpDatosCarrera.Controls.Add(this.lblCarrera);
            this.grpDatosCarrera.Location = new System.Drawing.Point(22, 249);
            this.grpDatosCarrera.Name = "grpDatosCarrera";
            this.grpDatosCarrera.Size = new System.Drawing.Size(930, 140);
            this.grpDatosCarrera.TabIndex = 0;
            this.grpDatosCarrera.TabStop = false;
            this.grpDatosCarrera.Text = "Datos Carrera";
            this.grpDatosCarrera.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // grpDocumentosEntregados
            // 
            this.grpDocumentosEntregados.Controls.Add(this.chcCartaDeLiberacion);
            this.grpDocumentosEntregados.Controls.Add(this.chcCartaDePresentacion);
            this.grpDocumentosEntregados.Controls.Add(this.chcSeguroGastosMedicos);
            this.grpDocumentosEntregados.Controls.Add(this.chcCartaDeAceptacion);
            this.grpDocumentosEntregados.Controls.Add(this.chcSeleccionDeEmpresas);
            this.grpDocumentosEntregados.Controls.Add(this.chcEntrevistaPorCompetencias);
            this.grpDocumentosEntregados.Controls.Add(this.chcCurriculumVitae);
            this.grpDocumentosEntregados.Controls.Add(this.chcCartaCompromiso);
            this.grpDocumentosEntregados.Controls.Add(this.chcSolicitud);
            this.grpDocumentosEntregados.Location = new System.Drawing.Point(22, 395);
            this.grpDocumentosEntregados.Name = "grpDocumentosEntregados";
            this.grpDocumentosEntregados.Size = new System.Drawing.Size(930, 127);
            this.grpDocumentosEntregados.TabIndex = 0;
            this.grpDocumentosEntregados.TabStop = false;
            this.grpDocumentosEntregados.Text = "Documentos Entregados";
            // 
            // grpDatosEmpresa
            // 
            this.grpDatosEmpresa.Controls.Add(this.lblFechaTermino);
            this.grpDatosEmpresa.Controls.Add(this.lblFechaInicio);
            this.grpDatosEmpresa.Controls.Add(this.dttFechaInicio);
            this.grpDatosEmpresa.Controls.Add(this.dttFechaTermino);
            this.grpDatosEmpresa.Controls.Add(this.lblAsesor);
            this.grpDatosEmpresa.Controls.Add(this.lblEmail);
            this.grpDatosEmpresa.Controls.Add(this.lblTelefonoMovilAsesor);
            this.grpDatosEmpresa.Controls.Add(this.txtTelefonoMovilAsesor);
            this.grpDatosEmpresa.Controls.Add(this.txtEmail);
            this.grpDatosEmpresa.Controls.Add(this.txtAsesor);
            this.grpDatosEmpresa.Controls.Add(this.txtContacto);
            this.grpDatosEmpresa.Controls.Add(this.lblContacto);
            this.grpDatosEmpresa.Controls.Add(this.lstEmpresas);
            this.grpDatosEmpresa.Location = new System.Drawing.Point(22, 528);
            this.grpDatosEmpresa.Name = "grpDatosEmpresa";
            this.grpDatosEmpresa.Size = new System.Drawing.Size(930, 230);
            this.grpDatosEmpresa.TabIndex = 0;
            this.grpDatosEmpresa.TabStop = false;
            this.grpDatosEmpresa.Text = "Datos Empresa";
            this.grpDatosEmpresa.Enter += new System.EventHandler(this.grpDatosEmpresa_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(405, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(137, 57);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(405, 22);
            this.txtApellidoPaterno.TabIndex = 2;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(137, 85);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(405, 22);
            this.txtApellidoMaterno.TabIndex = 3;
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Location = new System.Drawing.Point(137, 113);
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(405, 22);
            this.txtTelefonoFijo.TabIndex = 4;
            // 
            // txtTelefonoMovil
            // 
            this.txtTelefonoMovil.Location = new System.Drawing.Point(137, 141);
            this.txtTelefonoMovil.Name = "txtTelefonoMovil";
            this.txtTelefonoMovil.Size = new System.Drawing.Size(405, 22);
            this.txtTelefonoMovil.TabIndex = 5;
            // 
            // lblTelefonoMovil
            // 
            this.lblTelefonoMovil.AutoSize = true;
            this.lblTelefonoMovil.Location = new System.Drawing.Point(6, 144);
            this.lblTelefonoMovil.Name = "lblTelefonoMovil";
            this.lblTelefonoMovil.Size = new System.Drawing.Size(104, 17);
            this.lblTelefonoMovil.TabIndex = 6;
            this.lblTelefonoMovil.Text = "Teléfono Movil:";
            // 
            // lblTelefonoFijo
            // 
            this.lblTelefonoFijo.AutoSize = true;
            this.lblTelefonoFijo.Location = new System.Drawing.Point(6, 113);
            this.lblTelefonoFijo.Name = "lblTelefonoFijo";
            this.lblTelefonoFijo.Size = new System.Drawing.Size(94, 17);
            this.lblTelefonoFijo.TabIndex = 7;
            this.lblTelefonoFijo.Text = "Teléfono Fijo:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(6, 85);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(122, 17);
            this.lblApellidoMaterno.TabIndex = 8;
            this.lblApellidoMaterno.Text = "Apellido Materno: ";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(6, 57);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(120, 17);
            this.lblApellidoPaterno.TabIndex = 9;
            this.lblApellidoPaterno.Text = "Apellido Paterno: ";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbFemenino);
            this.grpGenero.Controls.Add(this.rdbMasculino);
            this.grpGenero.Location = new System.Drawing.Point(585, 24);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(95, 99);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 27);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(40, 21);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "M";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 53);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(37, 21);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "F";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbdE);
            this.grpTipo.Controls.Add(this.rdbN);
            this.grpTipo.Location = new System.Drawing.Point(585, 131);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(95, 99);
            this.grpTipo.TabIndex = 2;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rbdE
            // 
            this.rbdE.AutoSize = true;
            this.rbdE.Location = new System.Drawing.Point(6, 53);
            this.rbdE.Name = "rbdE";
            this.rbdE.Size = new System.Drawing.Size(38, 21);
            this.rbdE.TabIndex = 1;
            this.rbdE.TabStop = true;
            this.rbdE.Text = "E";
            this.rbdE.UseVisualStyleBackColor = true;
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.Location = new System.Drawing.Point(6, 26);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(39, 21);
            this.rdbN.TabIndex = 0;
            this.rdbN.TabStop = true;
            this.rdbN.Text = "N";
            this.rdbN.UseVisualStyleBackColor = true;
            // 
            // pctFotografiaMia
            // 
            this.pctFotografiaMia.Image = global::ProyExamen1.Properties.Resources.WIN_20200424_22_52_55_Pro;
            this.pctFotografiaMia.Location = new System.Drawing.Point(16, 21);
            this.pctFotografiaMia.Name = "pctFotografiaMia";
            this.pctFotografiaMia.Size = new System.Drawing.Size(193, 179);
            this.pctFotografiaMia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotografiaMia.TabIndex = 3;
            this.pctFotografiaMia.TabStop = false;
            // 
            // grbFotografía
            // 
            this.grbFotografía.Controls.Add(this.pctFotografiaMia);
            this.grbFotografía.Location = new System.Drawing.Point(719, 24);
            this.grbFotografía.Name = "grbFotografía";
            this.grbFotografía.Size = new System.Drawing.Size(215, 206);
            this.grbFotografía.TabIndex = 1;
            this.grbFotografía.TabStop = false;
            this.grbFotografía.Text = "Fotografía";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(6, 59);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(72, 17);
            this.lblSemestre.TabIndex = 11;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(6, 29);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(60, 17);
            this.lblCarrera.TabIndex = 10;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(6, 93);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(76, 17);
            this.lblPromedio.TabIndex = 12;
            this.lblPromedio.Text = "Promedio: ";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Mercadotecnia",
            "Mecatronica",
            "Medicina",
            "Ing. de Software",
            "IT",
            "Diseño Grafico"});
            this.cmbCarrera.Location = new System.Drawing.Point(137, 26);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(787, 24);
            this.cmbCarrera.TabIndex = 13;
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Items.AddRange(new object[] {
            "6 semestre",
            "7 semestre",
            "8 semestre",
            "9 semestre"});
            this.cmbSemestre.Location = new System.Drawing.Point(137, 59);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(787, 24);
            this.cmbSemestre.TabIndex = 14;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(137, 93);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(184, 22);
            this.txtPromedio.TabIndex = 10;
            // 
            // chcServicioSocialConcluido
            // 
            this.chcServicioSocialConcluido.AutoSize = true;
            this.chcServicioSocialConcluido.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcServicioSocialConcluido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcServicioSocialConcluido.Location = new System.Drawing.Point(736, 94);
            this.chcServicioSocialConcluido.Name = "chcServicioSocialConcluido";
            this.chcServicioSocialConcluido.Size = new System.Drawing.Size(188, 21);
            this.chcServicioSocialConcluido.TabIndex = 15;
            this.chcServicioSocialConcluido.Text = "Servicio Social Concluido";
            this.chcServicioSocialConcluido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcServicioSocialConcluido.UseVisualStyleBackColor = true;
            this.chcServicioSocialConcluido.CheckedChanged += new System.EventHandler(this.chcServicioSocialConcluido_CheckedChanged);
            // 
            // chcSolicitud
            // 
            this.chcSolicitud.AutoSize = true;
            this.chcSolicitud.Location = new System.Drawing.Point(12, 32);
            this.chcSolicitud.Name = "chcSolicitud";
            this.chcSolicitud.Size = new System.Drawing.Size(233, 21);
            this.chcSolicitud.TabIndex = 0;
            this.chcSolicitud.Text = "Solicitud prácticas profesionales";
            this.chcSolicitud.UseVisualStyleBackColor = true;
            // 
            // chcCartaCompromiso
            // 
            this.chcCartaCompromiso.AutoSize = true;
            this.chcCartaCompromiso.Location = new System.Drawing.Point(12, 59);
            this.chcCartaCompromiso.Name = "chcCartaCompromiso";
            this.chcCartaCompromiso.Size = new System.Drawing.Size(144, 21);
            this.chcCartaCompromiso.TabIndex = 1;
            this.chcCartaCompromiso.Text = "Carta compromiso";
            this.chcCartaCompromiso.UseVisualStyleBackColor = true;
            // 
            // chcCurriculumVitae
            // 
            this.chcCurriculumVitae.AutoSize = true;
            this.chcCurriculumVitae.Location = new System.Drawing.Point(12, 86);
            this.chcCurriculumVitae.Name = "chcCurriculumVitae";
            this.chcCurriculumVitae.Size = new System.Drawing.Size(133, 21);
            this.chcCurriculumVitae.TabIndex = 2;
            this.chcCurriculumVitae.Text = "Currículum Vitae";
            this.chcCurriculumVitae.UseVisualStyleBackColor = true;
            // 
            // chcCartaDeAceptacion
            // 
            this.chcCartaDeAceptacion.AutoSize = true;
            this.chcCartaDeAceptacion.Location = new System.Drawing.Point(351, 86);
            this.chcCartaDeAceptacion.Name = "chcCartaDeAceptacion";
            this.chcCartaDeAceptacion.Size = new System.Drawing.Size(158, 21);
            this.chcCartaDeAceptacion.TabIndex = 5;
            this.chcCartaDeAceptacion.Text = "Carta de Aceptación";
            this.chcCartaDeAceptacion.UseVisualStyleBackColor = true;
            // 
            // chcSeleccionDeEmpresas
            // 
            this.chcSeleccionDeEmpresas.AutoSize = true;
            this.chcSeleccionDeEmpresas.Location = new System.Drawing.Point(351, 59);
            this.chcSeleccionDeEmpresas.Name = "chcSeleccionDeEmpresas";
            this.chcSeleccionDeEmpresas.Size = new System.Drawing.Size(178, 21);
            this.chcSeleccionDeEmpresas.TabIndex = 4;
            this.chcSeleccionDeEmpresas.Text = "Selección de Empresas";
            this.chcSeleccionDeEmpresas.UseVisualStyleBackColor = true;
            // 
            // chcEntrevistaPorCompetencias
            // 
            this.chcEntrevistaPorCompetencias.AutoSize = true;
            this.chcEntrevistaPorCompetencias.Location = new System.Drawing.Point(351, 32);
            this.chcEntrevistaPorCompetencias.Name = "chcEntrevistaPorCompetencias";
            this.chcEntrevistaPorCompetencias.Size = new System.Drawing.Size(211, 21);
            this.chcEntrevistaPorCompetencias.TabIndex = 3;
            this.chcEntrevistaPorCompetencias.Text = "Entrevista por Competencias";
            this.chcEntrevistaPorCompetencias.UseVisualStyleBackColor = true;
            // 
            // chcCartaDeLiberacion
            // 
            this.chcCartaDeLiberacion.AutoSize = true;
            this.chcCartaDeLiberacion.Location = new System.Drawing.Point(713, 86);
            this.chcCartaDeLiberacion.Name = "chcCartaDeLiberacion";
            this.chcCartaDeLiberacion.Size = new System.Drawing.Size(149, 21);
            this.chcCartaDeLiberacion.TabIndex = 8;
            this.chcCartaDeLiberacion.Text = "Carta de liberación";
            this.chcCartaDeLiberacion.UseVisualStyleBackColor = true;
            // 
            // chcCartaDePresentacion
            // 
            this.chcCartaDePresentacion.AutoSize = true;
            this.chcCartaDePresentacion.Location = new System.Drawing.Point(713, 59);
            this.chcCartaDePresentacion.Name = "chcCartaDePresentacion";
            this.chcCartaDePresentacion.Size = new System.Drawing.Size(170, 21);
            this.chcCartaDePresentacion.TabIndex = 7;
            this.chcCartaDePresentacion.Text = "Carta de presentación";
            this.chcCartaDePresentacion.UseVisualStyleBackColor = true;
            this.chcCartaDePresentacion.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // chcSeguroGastosMedicos
            // 
            this.chcSeguroGastosMedicos.AutoSize = true;
            this.chcSeguroGastosMedicos.Location = new System.Drawing.Point(713, 32);
            this.chcSeguroGastosMedicos.Name = "chcSeguroGastosMedicos";
            this.chcSeguroGastosMedicos.Size = new System.Drawing.Size(181, 21);
            this.chcSeguroGastosMedicos.TabIndex = 6;
            this.chcSeguroGastosMedicos.Text = "Seguro Gastos Médicos";
            this.chcSeguroGastosMedicos.UseVisualStyleBackColor = true;
            // 
            // lstEmpresas
            // 
            this.lstEmpresas.FormattingEnabled = true;
            this.lstEmpresas.ItemHeight = 16;
            this.lstEmpresas.Items.AddRange(new object[] {
            "T-System",
            "VW",
            "BMW",
            "Sysne",
            "GM",
            "Google",
            "SDR",
            "MEXAbat",
            "AWS",
            "Benteler",
            "Safrán",
            "IBM",
            "SAP"});
            this.lstEmpresas.Location = new System.Drawing.Point(12, 30);
            this.lstEmpresas.Name = "lstEmpresas";
            this.lstEmpresas.Size = new System.Drawing.Size(147, 180);
            this.lstEmpresas.TabIndex = 0;
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Location = new System.Drawing.Point(348, 61);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(56, 17);
            this.lblAsesor.TabIndex = 17;
            this.lblAsesor.Text = "Asesor:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(348, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefonoMovilAsesor
            // 
            this.lblTelefonoMovilAsesor.AutoSize = true;
            this.lblTelefonoMovilAsesor.Location = new System.Drawing.Point(348, 117);
            this.lblTelefonoMovilAsesor.Name = "lblTelefonoMovilAsesor";
            this.lblTelefonoMovilAsesor.Size = new System.Drawing.Size(152, 17);
            this.lblTelefonoMovilAsesor.TabIndex = 15;
            this.lblTelefonoMovilAsesor.Text = "Télefono Móvil Asesor:";
            // 
            // txtTelefonoMovilAsesor
            // 
            this.txtTelefonoMovilAsesor.Location = new System.Drawing.Point(513, 114);
            this.txtTelefonoMovilAsesor.Name = "txtTelefonoMovilAsesor";
            this.txtTelefonoMovilAsesor.Size = new System.Drawing.Size(405, 22);
            this.txtTelefonoMovilAsesor.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(513, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(405, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtAsesor
            // 
            this.txtAsesor.Location = new System.Drawing.Point(513, 58);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.Size = new System.Drawing.Size(405, 22);
            this.txtAsesor.TabIndex = 12;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(513, 30);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(405, 22);
            this.txtContacto.TabIndex = 11;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(348, 33);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(68, 17);
            this.lblContacto.TabIndex = 10;
            this.lblContacto.Text = "Contacto:";
            // 
            // dttFechaTermino
            // 
            this.dttFechaTermino.Location = new System.Drawing.Point(654, 185);
            this.dttFechaTermino.Name = "dttFechaTermino";
            this.dttFechaTermino.Size = new System.Drawing.Size(264, 22);
            this.dttFechaTermino.TabIndex = 18;
            // 
            // dttFechaInicio
            // 
            this.dttFechaInicio.Location = new System.Drawing.Point(654, 157);
            this.dttFechaInicio.Name = "dttFechaInicio";
            this.dttFechaInicio.Size = new System.Drawing.Size(264, 22);
            this.dttFechaInicio.TabIndex = 19;
            // 
            // lblFechaTermino
            // 
            this.lblFechaTermino.AutoSize = true;
            this.lblFechaTermino.Location = new System.Drawing.Point(536, 190);
            this.lblFechaTermino.Name = "lblFechaTermino";
            this.lblFechaTermino.Size = new System.Drawing.Size(111, 17);
            this.lblFechaTermino.TabIndex = 21;
            this.lblFechaTermino.Text = "Fecha Termino: ";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(536, 162);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.lblFechaInicio.TabIndex = 20;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // frmAsignacionPracticaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 812);
            this.Controls.Add(this.grbFotografía);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDocumentosEntregados);
            this.Controls.Add(this.grpDatosEmpresa);
            this.Controls.Add(this.grpDatosCarrera);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "frmAsignacionPracticaProfesional";
            this.Text = "Asignación Práctica Profesional";
            this.Load += new System.EventHandler(this.frmAsignacionPracticaProfesional_Load);
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpDatosCarrera.ResumeLayout(false);
            this.grpDatosCarrera.PerformLayout();
            this.grpDocumentosEntregados.ResumeLayout(false);
            this.grpDocumentosEntregados.PerformLayout();
            this.grpDatosEmpresa.ResumeLayout(false);
            this.grpDatosEmpresa.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotografiaMia)).EndInit();
            this.grbFotografía.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.GroupBox grpDocumentosEntregados;
        private System.Windows.Forms.GroupBox grpDatosEmpresa;
        private System.Windows.Forms.GroupBox grpDatosCarrera;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblTelefonoFijo;
        private System.Windows.Forms.Label lblTelefonoMovil;
        private System.Windows.Forms.TextBox txtTelefonoMovil;
        private System.Windows.Forms.TextBox txtTelefonoFijo;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rbdE;
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.PictureBox pctFotografiaMia;
        private System.Windows.Forms.GroupBox grbFotografía;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.CheckBox chcServicioSocialConcluido;
        private System.Windows.Forms.CheckBox chcCartaDeLiberacion;
        private System.Windows.Forms.CheckBox chcCartaDePresentacion;
        private System.Windows.Forms.CheckBox chcSeguroGastosMedicos;
        private System.Windows.Forms.CheckBox chcCartaDeAceptacion;
        private System.Windows.Forms.CheckBox chcSeleccionDeEmpresas;
        private System.Windows.Forms.CheckBox chcEntrevistaPorCompetencias;
        private System.Windows.Forms.CheckBox chcCurriculumVitae;
        private System.Windows.Forms.CheckBox chcCartaCompromiso;
        private System.Windows.Forms.CheckBox chcSolicitud;
        private System.Windows.Forms.ListBox lstEmpresas;
        private System.Windows.Forms.DateTimePicker dttFechaInicio;
        private System.Windows.Forms.DateTimePicker dttFechaTermino;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefonoMovilAsesor;
        private System.Windows.Forms.TextBox txtTelefonoMovilAsesor;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblFechaTermino;
        private System.Windows.Forms.Label lblFechaInicio;
    }
}

