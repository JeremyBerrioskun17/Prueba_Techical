using PruebaTech.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTech.View
{
    public partial class Form_Actualizar : Form
    {
        string id;
        string nombre;
        string descripcion;
        string precio;
        string cantidad;
        public Form_Actualizar()
        {
            InitializeComponent();
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }

        private void Form_Actualizar_Load(object sender, EventArgs e)
        {
            LB_IDProducto.Text = id;          
            Txt_Nombre.Text = nombre;         
            Txt_Descripcion.Text = descripcion;  
            Txt_Precio.Text = precio;          
            Txt_Cantidad.Text = cantidad;      
        }

        private void Bttn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = Txt_Nombre.Text.Trim();
            string descripcion = Txt_Descripcion.Text.Trim();
            int idProducto = int.Parse(LB_IDProducto.Text);
            decimal precio;
            int cantidadEnStock;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre del producto es obligatorio.");
                Txt_Nombre.Focus();
                return;
            }

            if (!decimal.TryParse(Txt_Precio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un valor numérico positivo.");
                Txt_Precio.Focus();
                return;
            }

            if (!int.TryParse(Txt_Cantidad.Text, out cantidadEnStock) || cantidadEnStock < 0)
            {
                MessageBox.Show("La cantidad en stock debe ser un número entero no negativo.");
                Txt_Cantidad.Focus();
                return;
            }

            Ctrl_Productos ctrl = new Ctrl_Productos();
            bool resultado = ctrl.ActualizarProducto(idProducto, nombre, descripcion, precio, cantidadEnStock);

            if (resultado)
            {
                MessageBox.Show("Producto agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al agregar el producto.");
            }
        }
    }
}
