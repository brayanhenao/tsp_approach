using Mundo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FormSolucionarTodo : Form
    {
        //Atributos
        private FormCargar principal;
        private FormMapa formMapa;
        private String estadoBoton;
        private Thread hiloKruskal;
        private Thread hiloFuerzaBruta;
        private Thread hiloInsercion;

        public const String ESTADO_SIN_INICIAR = "sin iniciar";
        public const String ESTADO_CORRIENDO = "corriendo";
        public const String ESTADO_PAUSA = "pausado";

        public DataGridView TablaViajeros
        {
            get { return tablaViajeros; }
            set { tablaViajeros = value; }
        }

        public FormCargar Principal
        {
            get { return principal; }
            set { principal = value; }
        }

        public ProgressBar BarraProgreso
        {
            get { return progressBar1; }
            set { progressBar1 = value; }
        }

        public Label EtiquetaPorcentaje
        {
            get { return labPorcentaje; }
            set { labPorcentaje = value; }
        }
        //Constructor
        public FormSolucionarTodo(FormCargar principal)
        {
            InitializeComponent();
            this.principal = principal;
            picGif.Visible = false;
            estadoBoton = ESTADO_SIN_INICIAR;
        }

        private void FormSolucionarTodo_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Enabled = true;
            this.Dispose();
        }

        private void tablaViajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Código del viajero que se obtiene al presionar el botón Ver de la columna MapView de tablaViajero
            String codigoViajero = tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value.ToString();
            if (rbKruskal.Checked)
            {
                formMapa = new FormMapa(this, codigoViajero, Viajero.SOLUCION_KRUSKAL_PREORDEN);
                formMapa.Visible = true;
            }
            else if (rbFuerzaBruta.Checked)
            {
                formMapa = new FormMapa(this, codigoViajero, Viajero.SOLUCION_FUERZA_BRUTA);
                formMapa.Visible = true;
            }
            else
            {
                formMapa = new FormMapa(this, codigoViajero, Viajero.SOLUCION_OTRA);
                formMapa.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbKruskal.Checked)
            {
                rbInsercion.Enabled = false;
                rbFuerzaBruta.Enabled = false;
                rbKruskal.Enabled = false;
                if (estadoBoton.Equals(ESTADO_SIN_INICIAR))
                {
                    estadoBoton = ESTADO_CORRIENDO;
                    WorkKruskalTodo workKruskal = new WorkKruskalTodo(this);
                    picGif.Visible = true;
                    button1.Text = "Pausar";
                    button1.BackColor = Color.Red;
                    hiloKruskal = new Thread(workKruskal.DoWork);
                    picGif.Visible = true;
                    hiloKruskal.Start();
                }
                else if (estadoBoton.Equals(ESTADO_CORRIENDO))
                {
                    if (hiloKruskal.IsAlive)
                    {
                        estadoBoton = ESTADO_PAUSA;
                        button1.BackColor = Color.GreenYellow;
                        button1.Text = "Resume";
                        picGif.Visible = true;
                        hiloKruskal.Suspend();
                        picGif.Visible = false;
                    }
                }
                else if(estadoBoton.Equals(ESTADO_PAUSA))
                {
                    estadoBoton = ESTADO_CORRIENDO;
                    button1.BackColor = Color.Red;
                    picGif.Visible = true;
                    button1.Text = "Pausar";
                    hiloKruskal.Resume();
                }
            }
            else if (rbFuerzaBruta.Checked)
            {
                rbInsercion.Enabled = false;
                rbFuerzaBruta.Enabled = false;
                rbKruskal.Enabled = false;
                if (estadoBoton.Equals(ESTADO_SIN_INICIAR))
                {
                    estadoBoton = ESTADO_CORRIENDO;
                    WorkFuerzaBrutaTodos workFuerza = new WorkFuerzaBrutaTodos(this);
                    picGif.Visible = true;
                    button1.Text = "Pausar";
                    button1.BackColor = Color.Red;
                    hiloFuerzaBruta = new Thread(workFuerza.DoWork);
                    picGif.Visible = true;
                    hiloFuerzaBruta.Start();
                }
                else if (estadoBoton.Equals(ESTADO_CORRIENDO))
                {
                    if (hiloFuerzaBruta.IsAlive)
                    {
                        estadoBoton = ESTADO_PAUSA;
                        button1.BackColor = Color.GreenYellow;
                        button1.Text = "Resume";
                        picGif.Visible = true;
                        hiloFuerzaBruta.Suspend();
                        picGif.Visible = false;
                    }
                }
                else if (estadoBoton.Equals(ESTADO_PAUSA))
                {
                    estadoBoton = ESTADO_CORRIENDO;
                    button1.BackColor = Color.Red;
                    picGif.Visible = true;
                    button1.Text = "Pausar";
                    hiloFuerzaBruta.Resume();
                }
            }
            else //--------------------------------------------------
            {
                rbInsercion.Enabled = false;
                rbFuerzaBruta.Enabled = false;
                rbKruskal.Enabled = false;
                if (estadoBoton.Equals(ESTADO_SIN_INICIAR))
                {
                    estadoBoton = ESTADO_CORRIENDO;
                    workInsercionTodo workFuerza = new workInsercionTodo(this);
                    picGif.Visible = true;
                    button1.Text = "Pausar";
                    button1.BackColor = Color.Red;
                    hiloInsercion = new Thread(workFuerza.DoWork);
                    picGif.Visible = true;
                    hiloInsercion.Start();
                }
                else if (estadoBoton.Equals(ESTADO_CORRIENDO))
                {
                    if (hiloInsercion.IsAlive)
                    {
                        estadoBoton = ESTADO_PAUSA;
                        button1.BackColor = Color.GreenYellow;
                        button1.Text = "Resume";
                        picGif.Visible = true;
                        hiloInsercion.Suspend();
                        picGif.Visible = false;
                    }
                }
                else if (estadoBoton.Equals(ESTADO_PAUSA))
                {
                    estadoBoton = ESTADO_CORRIENDO;
                    button1.BackColor = Color.Red;
                    picGif.Visible = true;
                    button1.Text = "Pausar";
                    hiloInsercion.Resume();
                }
            }
        }

        private void tablaViajeros_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (rbKruskal.Checked)
            {
                if (tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value != null)
                {
                    //Nombre de la ciudad que se obtiene al presionar el botón Ver de tablaCiudades
                    String codigo = tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value.ToString();
                    formMapa = new FormMapa(this, codigo, Viajero.SOLUCION_KRUSKAL_PREORDEN);
                    formMapa.Visible = true;
                    this.Enabled = false;
                }
            }
            else if (rbFuerzaBruta.Checked)
            {
                //Nombre de la ciudad que se obtiene al presionar el botón Ver de tablaCiudades
                String codigo = tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value.ToString();
                formMapa = new FormMapa(this, codigo, Viajero.SOLUCION_FUERZA_BRUTA);
                formMapa.Visible = true;
                this.Enabled = false;
            }
            else
            {
                String codigo = tablaViajeros[0, tablaViajeros.CurrentCell.RowIndex].Value.ToString();
                formMapa = new FormMapa(this, codigo, Viajero.SOLUCION_OTRA);
                formMapa.Visible = true;
                this.Enabled = false;
            }
        }
    }
}
