﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class InscripcionesDesktop : ApplicationForm
    {
        private Business.Entities.Usuario _usuarioActual;

        public Business.Entities.Usuario UsuarioActual { get { return _usuarioActual; } set { _usuarioActual = value; } }


        public InscripcionesDesktop(ModoForm modo) : this()
        {
            _modo = modo;
        }

        public InscripcionesDesktop(int ID, ModoForm modo) : this()
        {
            UsuarioLogic ul = new UsuarioLogic();
            _usuarioActual = ul.GetOne(ID);
            _modo = modo;
            MapearDeDatos();
        }

        public InscripcionesDesktop()
        {
            InitializeComponent();
        }
        public override  void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtMateria.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;

            switch (_modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }

        }
        public override void MapearADatos()
        {
            if (_modo == ModoForm.Alta)
            {
                _usuarioActual = new Business.Entities.Usuario();
                _usuarioActual.State = BusinessEntity.States.New;
            }
            else if (_modo == ModoForm.Modificacion)
            {
                _usuarioActual.State = BusinessEntity.States.Modified;
            }
            
            UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            
            UsuarioActual.Nombre = this.txtMateria.Text;

            UsuarioActual.Apellido = this.txtApellido.Text;

            UsuarioActual.NombreUsuario = this.txtUsuario.Text;

            UsuarioActual.EMail = this.txtEmail.Text;

            UsuarioActual.Clave = this.txtClave.Text;

            UsuarioActual.Clave = this.txtConfirmarClave.Text;            

        }

        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic _usuarioLogic = new UsuarioLogic();
            if (_modo == ModoForm.Alta || _modo == ModoForm.Modificacion)
            {
                try
                { 
                    _usuarioLogic.Save(_usuarioActual);
                }
                catch (Exception Ex)
                {
                    Exception ExepcionManejada = new Exception("Error al guardar el usuario");
                    MessageBox.Show("Codigo de error: #347", ExepcionManejada.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_modo == ModoForm.Baja)
            {
                try
                {
                    _usuarioLogic.Delete(_usuarioActual.ID);
                }
                catch (Exception Ex)
                {
                    Exception ExepcionManejada = new Exception("Error al eliminar el usuario, burro!");
                    MessageBox.Show("Codigo de error: #505", ExepcionManejada.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override bool Validar()
        {
            // Mail, contraseñas coincidencia / 8 caracteres, nada vacio 
            
            //String.IsNullOrEmpty(this.txtNombre.Text.Trim()) Cambiar
            
            if ( String.IsNullOrEmpty(this.txtMateria.Text.Trim()) || String.IsNullOrEmpty(this.txtApellido.Text.Trim()) || String.IsNullOrEmpty(this.txtEmail.Text.Trim()) 
                || String.IsNullOrEmpty(this.txtUsuario.Text.Trim()) || String.IsNullOrEmpty(this.txtClave.Text.Trim()) || String.IsNullOrEmpty(this.txtConfirmarClave.Text))
            {
                Notificar("Error numero: #777", "Hay casillas que estan vacias, por favor complete todos los datos!", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
            else
            {
                if (this.txtClave.Text.Trim().Length < 8)
                {
                    Notificar("Error numero: #000", "La contrasenia debe tener al menos 8 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (this.txtClave.Text.Trim() != this.txtConfirmarClave.Text.Trim())
                {
                    Notificar("Error numero: #111", "Las contrasenias son diferentes, por favor vuelva a ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return false;
                }
                if (!Validaciones.IsValidEmail(txtEmail.Text.Trim()))
                {
                    Notificar("Error numero: #333", "Mail invalido, por favor reviselo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public override void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(titulo, mensaje, botones, icono);
        }

        public override void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(this.Text, mensaje, botones, icono);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
            else
            {
                MessageBox.Show("Burro!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}