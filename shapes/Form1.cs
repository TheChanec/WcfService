using shapes.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class Form1 : Form
    {
        public List<object> figuras;


        public Form1()
        {
            InitializeComponent();
            figuras = new List<object>();

            LlenarCombo(cbColorTriangulo);
            LlenarCombo(cbColorCirculo);
            LlenarCombo(cbColorCuadrado);
            LlenarCombo(cbColorRectangulo);

        }

        public void LlenarCombo(ComboBox cb)
        {
            cb.Items.Add("yellow");
            cb.Items.Add("red");
            cb.Items.Add("blue");
            cb.Items.Add("green");
            cb.Items.Add("purple");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        public void Acomodo()
        {
            List<Resultado> res = new List<Resultado>();

            foreach (var item in figuras)
            {
                var type = item.GetType();
                dynamic figura = item;
                res.Add(new Resultado { Nombre = type.Name, Area = figura.Area, Color = figura.Nombre });

            }

            dataGridView1.DataSource = res.OrderBy(x => x.Area).ThenBy(x => x.Color).ToList();
        }

        private void btnAgregarRectangulo_Click(object sender, EventArgs e)
        {
            if (cbColorRectangulo.SelectedIndex == -1)
            {
                
            }
            else {
                Double altura = Convert.ToDouble(tbAlturaRectangulo.Text);
                tbAlturaRectangulo.Text = "0";
                Double baseRectangulo = Convert.ToDouble(tbBaseRectangulo.Text);
                tbBaseRectangulo.Text = "0";
                String nombreColor = cbColorRectangulo.SelectedItem.ToString();
                cbColorRectangulo.SelectedItem = null;

                figuras.Add(new Rectangulo { Altura = altura, Base = baseRectangulo, Nombre = nombreColor });
                Acomodo();
            }




            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbColorCirculo.SelectedIndex == -1)
            {

            }
            else
            {
                Double radio = Convert.ToDouble(tbRadioCirculo.Text);
                tbRadioCirculo.Text = "0";

                String nombreColor = cbColorCirculo.SelectedItem.ToString();
                cbColorCirculo.SelectedItem = null;


                figuras.Add(new Circle { Radio = radio, Nombre = nombreColor });
                Acomodo();
            }

            


        }

        private void btnAgregarCuadrado_Click(object sender, EventArgs e)
        {
            if (cbColorCuadrado.SelectedIndex == -1)
            {

            }
            else
            {
                Double altura = Convert.ToDouble(tbLadoCuadrado.Text);
                tbLadoCuadrado.Text = "0";

                String nombreColor = cbColorCuadrado.SelectedItem.ToString();
                cbColorCuadrado.SelectedItem = null;

                figuras.Add(new Cuadrado { Lado = altura, Nombre = nombreColor });
                Acomodo();
            }


           
        }

        private void buttonAgregarTriangulo_Click(object sender, EventArgs e)
        {
            if (cbColorTriangulo.SelectedIndex == -1)
            {

            }
            else
            {
                Double altura = Convert.ToDouble(tbAlturaTriangulo.Text);
                tbAlturaTriangulo.Text = "0";
                Double baseTriangulo = Convert.ToDouble(tbBaseTriangulo.Text);
                tbBaseTriangulo.Text = "0";
                String nombreColor = cbColorTriangulo.SelectedItem.ToString();
                cbColorTriangulo.SelectedText = null;
                figuras.Add(new Triangulo { Altura = altura, Base = baseTriangulo, Nombre = nombreColor });
                Acomodo();
            }

            
        }

        private void tbLadoCuadrado_TextChanged(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }



        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbBaseRectangulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbAlturaRectangulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbRadioCirculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbBaseTriangulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void tbAlturaTriangulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }
    }
}
