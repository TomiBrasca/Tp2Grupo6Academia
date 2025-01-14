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
    public partial class ExamenesABM : ApplicationForm
    {
        Persona _personaRegistrada = new Persona();
        private int btonClick;
        private int idSiguiente;
        private string datoAdd;
        private List<int> idCursosPersona;
        private Examen _examenActual;
        public ExamenesABM(Persona per, ModoForm modo)
        {
            InitializeComponent();

            _personaRegistrada = per;
            _modo = modo;
        }

        public ExamenesABM(Persona per, Examen examen, ModoForm modo)
        {
            InitializeComponent();

            _personaRegistrada = per;
            _examenActual = examen;
            _modo = modo;


        }

        

        private void ExamenesABM_Load(object sender, EventArgs e)
        {
            dgvDatosExamenes.AutoGenerateColumns = false;
            /*EspecialidadLogic esp = new EspecialidadLogic();
           
            this.dgvDatosExamenes.DataSource = esp.GetAll();*/
            if(!(_modo == ModoForm.Baja))
            {
                btnGuardar.Text = "Crear";
                txtLegajoAlumno.Enabled = false;
                
                cbNota.Enabled = true;
                if (_modo == ModoForm.Modificacion)
                {
                    btnGuardar.Text = "Editar";
                    txtIDinscripcion.Text = (_examenActual.ID).ToString();
                    txtLegajoAlumno.Text = (_examenActual.Legajo).ToString();
                   
                    txtIdCurso.Text = (_examenActual.IdCurso).ToString();
                    cbNota.Text = (_examenActual.Nota).ToString();

                }
                CursoLogic curso = new CursoLogic();
                ExamenesLogic examen = new ExamenesLogic();
                idCursosPersona = curso.CursosProfesor(_personaRegistrada.ID);
                dgvDatosExamenes.DataSource = examen.GetEP(idCursosPersona);

            }
            else
            {
                btnGuardar.Text = "Eliminar";
                txtLegajoAlumno.Enabled = false;
                
                cbNota.Enabled = false;
                txtIDinscripcion.Text = (_examenActual.ID).ToString();
                txtLegajoAlumno.Text = (_examenActual.Legajo).ToString();
                
                txtIdCurso.Text = (_examenActual.IdCurso).ToString();
                cbNota.Text = (_examenActual.Nota).ToString();

            }
        }

        public void ListarPlan(int idEspecialidad)
        {
            PlanLogic plan = new PlanLogic();
            dgvDatosExamenes.DataSource = null;
            dgvDatosExamenes.Rows.Clear();
            dgvDatosExamenes.DataSource = plan.GetAll(idEspecialidad);
        }

        public void ListarMaterias(int idPlan)
        {
            MateriasLogic materia = new MateriasLogic();
            dgvDatosExamenes.DataSource = null;
            dgvDatosExamenes.Rows.Clear();
            dgvDatosExamenes.DataSource = materia.GetAll(idPlan);
        }


        public void ListarCursos(int idMateria)
        {
            CursoLogic curso = new CursoLogic();
            dgvDatosExamenes.DataSource = null;
            dgvDatosExamenes.Rows.Clear();
            dgvDatosExamenes.DataSource = curso.GetAll(idMateria);
        }

        public void GuardarNuevoExamen()
        {   
            // if => No es admin
                // if => Si el curso le pertenece al profesor
                //      Guardar id_curso, Nota( n >= 6 = Aprobada), y por legajo buscar y luego guardar el id_Alumno
                  
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaLogic per = new PersonaLogic();
                Inscripcion insc = new Inscripcion();
                ExamenesLogic inscLogic = new ExamenesLogic();
                int idPersona = per.GetIdPersona(Int32.Parse(txtLegajoAlumno.Text));

                insc.IdCurso = (Int32.Parse(txtIdCurso.Text));

                insc.Nota = Int32.Parse(cbNota.Text);
                if (Int32.Parse(cbNota.Text) < 6)
                {
                    insc.Condicion = "Reprobado";
                }
                else
                {
                    insc.Condicion = "Aprobado";
                }

                insc.IdAlumno = idPersona;

                if (_modo == ModoForm.Modificacion)
                {
                    insc.State = BusinessEntity.States.Modified;
                    insc.ID = Int32.Parse(txtIDinscripcion.Text);
                }
                else if (_modo == ModoForm.Alta)
                {
                    insc.State = BusinessEntity.States.New;
                }
                else
                {
                    insc.State = BusinessEntity.States.Deleted;
                    insc.ID = Int32.Parse(txtIDinscripcion.Text);
                }

                inscLogic.Save(insc);

                this.Dispose();
            }
            catch (Exception Ex)
            {
                Exception ExepcionManejada = new Exception("Error al " + btnGuardar.Text + " Examen");
                MessageBox.Show("Codigo de error: #404", ExepcionManejada.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

            

        }

        private void dgvDatosExamenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        private void btonFiltrar_Click(object sender, EventArgs e)
        {
            if(txtIdCurso.Text == null || txtIdCurso.Text == "")
            {
                MessageBox.Show("Seleccione algun curso");
            }
            else
            {
                InscripcionLogic insc = new InscripcionLogic();
                dgvAlumnos.DataSource = insc.getAlumnoCurso(Int32.Parse(txtIdCurso.Text));
            }
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void dgvDatosExamenes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdCurso.Text = ((Examen)dgvDatosExamenes.SelectedRows[0].DataBoundItem).IdCurso.ToString();
        }

        private void dgvAlumnos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtLegajoAlumno.Text = ((Persona)dgvAlumnos.SelectedRows[0].DataBoundItem).Legajo.ToString();
        }
    }
}
