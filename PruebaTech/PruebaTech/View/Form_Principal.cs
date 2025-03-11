using PruebaTech.Controller;
using PruebaTech.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace PruebaTech.View
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            Ctrl_Productos ctrl = new Ctrl_Productos();
            List<Productos> listaProductos = ctrl.Cargar_Productos();

            if (listaProductos.Count > 0)
            {
                foreach (var producto in listaProductos)
                {
                    Console.WriteLine($"{producto.Id} - {producto.Nombre} - {producto.Descripcion} - {producto.Precio} - {producto.Cantidad}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron productos.");
            }

            dataGridView1.DataSource = listaProductos;
            dataGridView1.Columns[0].Visible = false;
        }


        private void Bttn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = Txt_Nombre.Text.Trim();
            string descripcion = Txt_Descripcion.Text.Trim();
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
            bool resultado = ctrl.AgregarProducto(nombre, descripcion, precio, cantidadEnStock);

            if (resultado)
            {
                MessageBox.Show("Producto agregado exitosamente.");
                CargarProductos();
                clear();
                Txt_Nombre.Focus();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto.");
            }
        }

        private void clear()
        {
            Txt_Nombre.Clear();
            Txt_Descripcion.Clear();
            Txt_Precio.Clear();
            Txt_Cantidad.Clear();
        }
        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = Txt_Buscar.Text.Trim().ToLower();
            Ctrl_Productos ctrl = new Ctrl_Productos();
            List<Productos> productosFiltrados = ctrl.Cargar_Productos().Where(p =>
                p.Nombre.ToLower().Contains(filtro) ||
                p.Descripcion.ToLower().Contains(filtro)
            ).ToList();

            dataGridView1.DataSource = productosFiltrados;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    ContextMenuStrip menu = new ContextMenuStrip();
                    int pos = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                    if (pos >= 0 && pos < dataGridView1.Rows.Count)
                    {
                        menu.Items.Add("Borrar").Name = "Borrar" + pos;
                        menu.Items.Add("Editar").Name = "Editar" + pos;
                        menu.Show(dataGridView1, e.X, e.Y);
                        menu.ItemClicked += new ToolStripItemClickedEventHandler(menuClick_Opciones);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el menú de contexto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuClick_Opciones(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                string id_pos = e.ClickedItem.Name.ToString();

                if (id_pos.Contains("Borrar"))
                {
                    id_pos = id_pos.Replace("Borrar", "");
                    Eliminar_Abastecedor(int.Parse(id_pos));
                }
                else if (id_pos.Contains("Editar"))
                {
                    id_pos = id_pos.Replace("Editar", "");
                    Editar_Abastecedor(int.Parse(id_pos));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la opción del menú: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Abastecedor(int id_pos)
        {
            try
            {
                if (id_pos >= 0 && id_pos < dataGridView1.Rows.Count)
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        Ctrl_Productos ctrl = new Ctrl_Productos();
                        ctrl.EliminarProducto(int.Parse(dataGridView1.Rows[id_pos].Cells[0].Value.ToString()));
                        MessageBox.Show("Se ha eliminado el producto con éxito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                    }
                }
                else
                {
                    MessageBox.Show("Índice de fila no válido.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar_Abastecedor(int id_pos)
        {
            try
            {
                if (id_pos >= 0 && id_pos < dataGridView1.Rows.Count)
                {
                    var fila = dataGridView1.Rows[id_pos];
                    string ID = fila.Cells[0].Value.ToString();
                    string nombre = fila.Cells[1].Value.ToString();
                    string descripcion = fila.Cells[2].Value.ToString();
                    string precio = fila.Cells[3].Value.ToString();
                    string cantidad = fila.Cells[4].Value.ToString();

                    using (Form_Actualizar dialog = new Form_Actualizar())
                    {
                        dialog.Id = ID;
                        dialog.Nombre = nombre;
                        dialog.Descripcion = descripcion;
                        dialog.Precio = precio;
                        dialog.Cantidad = cantidad;
                        dialog.ShowDialog();
                        CargarProductos();                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
