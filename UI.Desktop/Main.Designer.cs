﻿
namespace UI.Desktop
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlVertical = new System.Windows.Forms.Panel();
            this.lblPosCur = new System.Windows.Forms.Label();
            this.lblPosEsp = new System.Windows.Forms.Label();
            this.lblPosPer = new System.Windows.Forms.Label();
            this.lblPosPlan = new System.Windows.Forms.Label();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnEspecialiades = new System.Windows.Forms.Button();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.lblNombrePersona = new System.Windows.Forms.Label();
            this.lblPosImg = new System.Windows.Forms.Label();
            this.lblPosTipo = new System.Windows.Forms.Label();
            this.lblPosNombre = new System.Windows.Forms.Label();
            this.cirPicImg = new UI.Desktop.Clases.CircularPictureBox();
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnReportePlanes = new System.Windows.Forms.Button();
            this.btnExamenes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pctrLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pctrMinimizar = new System.Windows.Forms.PictureBox();
            this.pctrMaximizar = new System.Windows.Forms.PictureBox();
            this.pctrMenu = new System.Windows.Forms.PictureBox();
            this.pctrSalir = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirPicImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVertical
            // 
            this.pnlVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.pnlVertical.Controls.Add(this.lblPosCur);
            this.pnlVertical.Controls.Add(this.lblPosEsp);
            this.pnlVertical.Controls.Add(this.lblPosPer);
            this.pnlVertical.Controls.Add(this.lblPosPlan);
            this.pnlVertical.Controls.Add(this.btnCursos);
            this.pnlVertical.Controls.Add(this.btnEspecialiades);
            this.pnlVertical.Controls.Add(this.lblTipoPersona);
            this.pnlVertical.Controls.Add(this.lblNombrePersona);
            this.pnlVertical.Controls.Add(this.lblPosImg);
            this.pnlVertical.Controls.Add(this.lblPosTipo);
            this.pnlVertical.Controls.Add(this.lblPosNombre);
            this.pnlVertical.Controls.Add(this.cirPicImg);
            this.pnlVertical.Controls.Add(this.btnInscripciones);
            this.pnlVertical.Controls.Add(this.btnLogout);
            this.pnlVertical.Controls.Add(this.btnPersonas);
            this.pnlVertical.Controls.Add(this.btnReportePlanes);
            this.pnlVertical.Controls.Add(this.btnExamenes);
            this.pnlVertical.Controls.Add(this.btnUsuarios);
            this.pnlVertical.Controls.Add(this.pctrLogo);
            this.pnlVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlVertical.Name = "pnlVertical";
            this.pnlVertical.Size = new System.Drawing.Size(200, 600);
            this.pnlVertical.TabIndex = 0;
            // 
            // lblPosCur
            // 
            this.lblPosCur.AutoSize = true;
            this.lblPosCur.Location = new System.Drawing.Point(15, 330);
            this.lblPosCur.Name = "lblPosCur";
            this.lblPosCur.Size = new System.Drawing.Size(35, 13);
            this.lblPosCur.TabIndex = 15;
            this.lblPosCur.Text = "label1";
            this.lblPosCur.Visible = false;
            // 
            // lblPosEsp
            // 
            this.lblPosEsp.AutoSize = true;
            this.lblPosEsp.Location = new System.Drawing.Point(15, 284);
            this.lblPosEsp.Name = "lblPosEsp";
            this.lblPosEsp.Size = new System.Drawing.Size(35, 13);
            this.lblPosEsp.TabIndex = 14;
            this.lblPosEsp.Text = "label1";
            this.lblPosEsp.Visible = false;
            // 
            // lblPosPer
            // 
            this.lblPosPer.AutoSize = true;
            this.lblPosPer.Location = new System.Drawing.Point(15, 238);
            this.lblPosPer.Name = "lblPosPer";
            this.lblPosPer.Size = new System.Drawing.Size(35, 13);
            this.lblPosPer.TabIndex = 13;
            this.lblPosPer.Text = "label1";
            this.lblPosPer.Visible = false;
            // 
            // lblPosPlan
            // 
            this.lblPosPlan.AutoSize = true;
            this.lblPosPlan.Location = new System.Drawing.Point(15, 192);
            this.lblPosPlan.Name = "lblPosPlan";
            this.lblPosPlan.Size = new System.Drawing.Size(35, 13);
            this.lblPosPlan.TabIndex = 12;
            this.lblPosPlan.Text = "label1";
            this.lblPosPlan.Visible = false;
            // 
            // btnCursos
            // 
            this.btnCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Location = new System.Drawing.Point(12, 422);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(180, 40);
            this.btnCursos.TabIndex = 11;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnEspecialiades
            // 
            this.btnEspecialiades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEspecialiades.FlatAppearance.BorderSize = 0;
            this.btnEspecialiades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEspecialiades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEspecialiades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialiades.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialiades.ForeColor = System.Drawing.Color.White;
            this.btnEspecialiades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecialiades.Location = new System.Drawing.Point(12, 376);
            this.btnEspecialiades.Name = "btnEspecialiades";
            this.btnEspecialiades.Size = new System.Drawing.Size(180, 40);
            this.btnEspecialiades.TabIndex = 10;
            this.btnEspecialiades.Text = "Especialidades";
            this.btnEspecialiades.UseVisualStyleBackColor = true;
            this.btnEspecialiades.Click += new System.EventHandler(this.buttonEspecialidades_Click);
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPersona.ForeColor = System.Drawing.Color.White;
            this.lblTipoPersona.Location = new System.Drawing.Point(12, 103);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(38, 13);
            this.lblTipoPersona.TabIndex = 6;
            this.lblTipoPersona.Text = "label1";
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePersona.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersona.ForeColor = System.Drawing.Color.White;
            this.lblNombrePersona.Location = new System.Drawing.Point(12, 78);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(38, 13);
            this.lblNombrePersona.TabIndex = 0;
            this.lblNombrePersona.Text = "label1";
            // 
            // lblPosImg
            // 
            this.lblPosImg.AutoSize = true;
            this.lblPosImg.Location = new System.Drawing.Point(10, 75);
            this.lblPosImg.Name = "lblPosImg";
            this.lblPosImg.Size = new System.Drawing.Size(0, 13);
            this.lblPosImg.TabIndex = 9;
            // 
            // lblPosTipo
            // 
            this.lblPosTipo.AutoSize = true;
            this.lblPosTipo.Location = new System.Drawing.Point(12, 160);
            this.lblPosTipo.Name = "lblPosTipo";
            this.lblPosTipo.Size = new System.Drawing.Size(0, 13);
            this.lblPosTipo.TabIndex = 8;
            // 
            // lblPosNombre
            // 
            this.lblPosNombre.AutoSize = true;
            this.lblPosNombre.Location = new System.Drawing.Point(12, 130);
            this.lblPosNombre.Name = "lblPosNombre";
            this.lblPosNombre.Size = new System.Drawing.Size(0, 13);
            this.lblPosNombre.TabIndex = 7;
            // 
            // cirPicImg
            // 
            this.cirPicImg.Location = new System.Drawing.Point(73, 56);
            this.cirPicImg.Name = "cirPicImg";
            this.cirPicImg.Size = new System.Drawing.Size(75, 75);
            this.cirPicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cirPicImg.TabIndex = 0;
            this.cirPicImg.TabStop = false;
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInscripciones.FlatAppearance.BorderSize = 0;
            this.btnInscripciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInscripciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInscripciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripciones.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripciones.ForeColor = System.Drawing.Color.White;
            this.btnInscripciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripciones.Location = new System.Drawing.Point(12, 192);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(180, 40);
            this.btnInscripciones.TabIndex = 5;
            this.btnInscripciones.Text = "Inscribirse";
            this.btnInscripciones.UseVisualStyleBackColor = true;
            this.btnInscripciones.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(13, 523);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Cerrar Sesion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersonas.FlatAppearance.BorderSize = 0;
            this.btnPersonas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPersonas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.ForeColor = System.Drawing.Color.White;
            this.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonas.Location = new System.Drawing.Point(13, 330);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(180, 40);
            this.btnPersonas.TabIndex = 3;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReportePlanes
            // 
            this.btnReportePlanes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReportePlanes.FlatAppearance.BorderSize = 0;
            this.btnReportePlanes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReportePlanes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReportePlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePlanes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePlanes.ForeColor = System.Drawing.Color.White;
            this.btnReportePlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePlanes.Location = new System.Drawing.Point(12, 284);
            this.btnReportePlanes.Name = "btnReportePlanes";
            this.btnReportePlanes.Size = new System.Drawing.Size(180, 40);
            this.btnReportePlanes.TabIndex = 2;
            this.btnReportePlanes.Text = "Planes";
            this.btnReportePlanes.UseVisualStyleBackColor = true;
            this.btnReportePlanes.Click += new System.EventHandler(this.btnReportePlanes_Click);
            // 
            // btnExamenes
            // 
            this.btnExamenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExamenes.FlatAppearance.BorderSize = 0;
            this.btnExamenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExamenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamenes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamenes.ForeColor = System.Drawing.Color.White;
            this.btnExamenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamenes.Location = new System.Drawing.Point(15, 238);
            this.btnExamenes.Name = "btnExamenes";
            this.btnExamenes.Size = new System.Drawing.Size(180, 40);
            this.btnExamenes.TabIndex = 1;
            this.btnExamenes.Text = "Examenes";
            this.btnExamenes.UseVisualStyleBackColor = true;
            this.btnExamenes.Click += new System.EventHandler(this.btnExamenes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 146);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(180, 40);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pctrLogo
            // 
            this.pctrLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctrLogo.Image")));
            this.pctrLogo.Location = new System.Drawing.Point(-2, 3);
            this.pctrLogo.Name = "pctrLogo";
            this.pctrLogo.Size = new System.Drawing.Size(194, 47);
            this.pctrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrLogo.TabIndex = 0;
            this.pctrLogo.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.pnlTitulo.Controls.Add(this.pctrMinimizar);
            this.pnlTitulo.Controls.Add(this.pctrMaximizar);
            this.pnlTitulo.Controls.Add(this.pctrMenu);
            this.pnlTitulo.Controls.Add(this.pctrSalir);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(200, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(700, 50);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // pctrMinimizar
            // 
            this.pctrMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pctrMinimizar.Image")));
            this.pctrMinimizar.Location = new System.Drawing.Point(610, 3);
            this.pctrMinimizar.Name = "pctrMinimizar";
            this.pctrMinimizar.Size = new System.Drawing.Size(25, 25);
            this.pctrMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrMinimizar.TabIndex = 2;
            this.pctrMinimizar.TabStop = false;
            this.pctrMinimizar.Click += new System.EventHandler(this.pctrMinimizar_Click);
            // 
            // pctrMaximizar
            // 
            this.pctrMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pctrMaximizar.Image")));
            this.pctrMaximizar.Location = new System.Drawing.Point(641, 3);
            this.pctrMaximizar.Name = "pctrMaximizar";
            this.pctrMaximizar.Size = new System.Drawing.Size(25, 25);
            this.pctrMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrMaximizar.TabIndex = 3;
            this.pctrMaximizar.TabStop = false;
            this.pctrMaximizar.Click += new System.EventHandler(this.pctrMaximizar_Click);
            // 
            // pctrMenu
            // 
            this.pctrMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrMenu.Image = ((System.Drawing.Image)(resources.GetObject("pctrMenu.Image")));
            this.pctrMenu.Location = new System.Drawing.Point(3, 7);
            this.pctrMenu.Name = "pctrMenu";
            this.pctrMenu.Size = new System.Drawing.Size(40, 40);
            this.pctrMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrMenu.TabIndex = 0;
            this.pctrMenu.TabStop = false;
            this.pctrMenu.Click += new System.EventHandler(this.pctrMenu_Click);
            // 
            // pctrSalir
            // 
            this.pctrSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrSalir.Image = ((System.Drawing.Image)(resources.GetObject("pctrSalir.Image")));
            this.pctrSalir.Location = new System.Drawing.Point(672, 3);
            this.pctrSalir.Name = "pctrSalir";
            this.pctrSalir.Size = new System.Drawing.Size(25, 25);
            this.pctrSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrSalir.TabIndex = 1;
            this.pctrSalir.TabStop = false;
            this.pctrSalir.Click += new System.EventHandler(this.pctrSalir_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Gray;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(700, 550);
            this.pnlContenedor.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.pnlVertical.ResumeLayout(false);
            this.pnlVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirPicImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVertical;
        private System.Windows.Forms.PictureBox pctrLogo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pctrMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pctrMinimizar;
        private System.Windows.Forms.PictureBox pctrMaximizar;
        private System.Windows.Forms.PictureBox pctrSalir;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnInscripciones;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnReportePlanes;
        private System.Windows.Forms.Button btnExamenes;
        private System.Windows.Forms.Label lblNombrePersona;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Clases.CircularPictureBox cirPicImg;
        private System.Windows.Forms.Label lblPosImg;
        private System.Windows.Forms.Label lblPosTipo;
        private System.Windows.Forms.Label lblPosNombre;
        private System.Windows.Forms.Button btnEspecialiades;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Label lblPosPer;
        private System.Windows.Forms.Label lblPosPlan;
        private System.Windows.Forms.Label lblPosCur;
        private System.Windows.Forms.Label lblPosEsp;
    }
}