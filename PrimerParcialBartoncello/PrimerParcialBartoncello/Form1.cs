using Entidades;

namespace PrimerParcialBartoncello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            profesorLabo = new Profesor(99000123, "profesorLabo@email.com", EMateria.Laboratorio);
            profesorProgra = new Profesor(99000123, "profesorProgra@email.com", EMateria.Programacion);
            cursoProgramacion = new Curso((Profesor)profesorProgra);
            cursoLaboratorio = new Curso((Profesor)profesorLabo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMaterias.DataSource = Enum.GetValues(typeof(EMateria));
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            alumno = (Alumno)txtDni.Text;
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            lstAlumnosCreados.Items.Add(alumno);
        }

        private void ActualizarInscriptos()
        {
            lstAlumnosInscriptosLaboratorio.DataSource = null;
            lstAlumnosInscriptosProgramacion.DataSource = null;
            lstAlumnosInscriptosLaboratorio.DataSource = cursoLaboratorio.Alumnos;
            lstAlumnosInscriptosProgramacion.DataSource = cursoProgramacion.Alumnos;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            EMateria materia = (EMateria)cmbMaterias.SelectedItem;
            string mensaje = string.Empty;

            if (materia == EMateria.Programacion)
            {
                mensaje = cursoProgramacion.InscribirAlumno((Alumno)alumno);
            }
            else
            {
                mensaje = cursoLaboratorio.InscribirAlumno((Alumno)alumno);
            }

            lstAlumnosCreados.Items.Remove(alumno);
            MessageBox.Show(mensaje, "Incripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarInscriptos();
        }
    }
}