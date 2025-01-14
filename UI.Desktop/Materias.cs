﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;


namespace UI.Desktop
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            try
            {
                this.dgvMaterias.DataSource = ul.GetAll();
            }
            catch (Exception Ex)
            {
                Exception ExepcionManejada = new Exception("Error al obtener todos los usuarios");
                MessageBox.Show("Codigo de error: #404", ExepcionManejada.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            
            UsuariosDesktop formTest = new UsuariosDesktop();
            formTest.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
            else
            {
                int ID = ((Business.Entities.Usuario)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                UsuariosDesktop formTest = new UsuariosDesktop( ID, ApplicationForm.ModoForm.Baja);
                formTest.ShowDialog();
                Listar();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
            else { 
                int ID = ((Business.Entities.Usuario)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                UsuariosDesktop formTest = new UsuariosDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formTest.ShowDialog();
                Listar();
            }
        }


    }
}
