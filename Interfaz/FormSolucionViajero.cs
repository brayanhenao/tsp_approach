using Mundo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FormSolucionViajero : Form
    {
        //Atributos
        private FormCargar principal;
        private FormMapa formMapa;

        //Constructor
        public FormSolucionViajero()
        {
            InitializeComponent();
        }

        public FormSolucionViajero(FormCargar principal, String codigo)
        {

            this.principal = principal;
            InitializeComponent();
            cargarInformacion(codigo);
            gifCargando.Image = Image.FromFile("Img/cargando4.gif");
            gifCargando.Visible = false;
        }

        //Métodos
        private void cargarInformacion(String codigo)
        {
            Viajero v = principal.Aerolinea.buscarViajero(codigo);
            labCodigo.Text = codigo;
            labNombre.Text = v.Nombre;
            if(v.Grafo.Vertices.Count > 0)
            {
                labCiudadInicio.Text = v.Grafo.Vertices[0].Info.Nombre;
            }

            //Cargar la información personal del viajero
        }

        private void FormSolucionesViajero_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Enabled = true;
            this.Dispose();
        }

        private bool esNumero()
        {
            String texto = txtPoblacion.Text;
            int resultado = 0;
            bool numero = int.TryParse(texto, out resultado);
            if (numero)
            {
                return true;
            }
            return false;
        }

        private void butSolucion_Click(object sender, EventArgs e)
        {
            String texto = txtPoblacion.Text;
            if (rbKruskal.Checked)
            {
                if (texto.Equals(""))
                {
                    principal.Visible = false;
                    formMapa = new FormMapa(principal, labCodigo.Text, Viajero.SOLUCION_KRUSKAL_PREORDEN);
                    formMapa.Visible = true;
                    this.Dispose();
                }
                else if(esNumero())
                {
                    int numero = int.Parse(texto);
                    principal.Aerolinea.buscarViajero(labCodigo.Text).filtrarCiudadPorPoblacion(numero);
                    principal.Visible = false;
                    formMapa = new FormMapa(principal, labCodigo.Text, Viajero.SOLUCION_KRUSKAL_PREORDEN);
                    formMapa.Visible = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("El número ingresado no es válido, pruebe nuevamente",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPoblacion.Text = "";
                }
            }
            else if (rbFuerzaBruta.Checked)
            {
                if (texto.Equals(""))
                {
                    gifCargando.Visible = true;
                    workFuerzaBruta.RunWorkerAsync();
                }
                else if(esNumero())
                {
                    int numero = int.Parse(texto);
                    principal.Aerolinea.buscarViajero(labCodigo.Text).filtrarCiudadPorPoblacion(numero);
                    gifCargando.Visible = true;
                    workFuerzaBruta.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("El número ingresado no es válido, pruebe nuevamente",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPoblacion.Text = "";
                }
                
            }
            else
            {
                if (texto.Equals(""))
                {
                    gifCargando.Visible = true;
                    workInsercion.RunWorkerAsync();
                }
                else if (!texto.Equals("") && esNumero())
                {
                    int numero = int.Parse(texto);
                    principal.Aerolinea.buscarViajero(labCodigo.Text).filtrarCiudadPorPoblacion(numero);
                    gifCargando.Visible = true;
                    workInsercion.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("El número ingresado no es válido, pruebe nuevamente",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPoblacion.Text = "";
                }
            }
        }

        private void workFuerzaBruta_DoWork(object sender, DoWorkEventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            principal.Aerolinea.buscarViajero(labCodigo.Text).generarSolucionFuerzaBruta();
            Console.WriteLine(watch.Elapsed.ToString());
        }

        private void workFuerzaBruta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            principal.Visible = false;
            formMapa = new FormMapa(principal, labCodigo.Text, Viajero.SOLUCION_FUERZA_BRUTA);
            principal.Visible = false;
            gifCargando.Visible = false;
            formMapa.Visible = true;
            this.Dispose();
            
        }

        private void workInsercion_DoWork(object sender, DoWorkEventArgs e)
        {
            principal.Aerolinea.buscarViajero(labCodigo.Text).generarSolucionInsercion();
        }

        private void workInsercion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            principal.Visible = false;
            formMapa = new FormMapa(principal, labCodigo.Text, Viajero.SOLUCION_OTRA);
            principal.Visible = false;
            gifCargando.Visible = false;
            formMapa.Visible = true;
            this.Dispose();
        }
    }
}
