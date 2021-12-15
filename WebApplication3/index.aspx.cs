using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Comprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gracias.aspx");
            /*
            ClassFunciones.clsFunciones.CreaTicket Ticket1 = new ClassFunciones.clsFunciones.CreaTicket();

            Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Dirc: xxxx");
            Ticket1.TextoIzquierda("Tel:xxxx ");
            Ticket1.TextoIzquierda("Rnc: xxxx");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac:" + ClassBT.clsDetallesVenta.IdVentafk.ToString());
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            ClassFunciones.clsFunciones.CreaTicket.LineasGuion();

            ClassFunciones.clsFunciones.CreaTicket.EncabezadoVenta();
            ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
            Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
            Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
            Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lblCostoApagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(textBox3.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbldevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);




            Fila = 0;
            while (dataGridView1.RowCount > 0)//limpia el dgv
            { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

            txtIdProducto.Text = lblNombre.Text = txtCantidad.Text = textBox3.Text = "";
            lblCostoApagar.Text = lbldevolucion.Text = lblPrecio.Text = "0";
            txtIdProducto.Focus();
            //MessageBox.Show("Gracias por preferirnos");
            */
        }
    }
}