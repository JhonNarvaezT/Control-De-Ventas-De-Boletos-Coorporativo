using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap5
{
    
    public partial class FrmCine : Form
    {
        ListViewItem Item;
        double Precio = 0;
        string Categoria = "";

        public FrmCine()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Categoria = lblCategoria.Text;
            int Cantidad = int.Parse(txtCantidad.Text);

            double SubTotal = Precio * Cantidad;
            double Descuento = 0;
            switch (Categoria)
            {
                case "Niño":
                   Descuento = 20.0 / 100 * SubTotal;
                       break;

                case "JovenI":
                    Descuento = 10.0 / 100 * SubTotal;
                         break;

                case "JovenII":
                   Descuento = 5.0 / 100 * SubTotal;
                           break;

                case "AdultoI":
                   Descuento = 10.0 / 100 * SubTotal;
                            break;

                case "AdultoII":
                   Descuento = 20.0 / 100 * SubTotal;
                                break;
            }
                double Importe = SubTotal - Descuento;
            ListViewItem fila = new ListViewItem(Categoria);

            fila.SubItems.Add(Precio.ToString("0.00"));
                fila.SubItems.Add(Cantidad.ToString());
                  fila.SubItems.Add(SubTotal.ToString("0.00"));
                    fila.SubItems.Add(Descuento.ToString("0.00"));
                      fila.SubItems.Add(Importe.ToString("0.00"));

               lvRegistrar.Items.Add(fila);

            lvEstadisticas.Items.Clear();
        }

        private void CboEdad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Edad = CboEdad.SelectedIndex;

            switch (Edad)
            {
                case 0: Precio = 10; Categoria = "Niño"; break;
                   case 1: Precio = 20; Categoria = "JovenI"; break;
                     case 2: Precio = 30; Categoria = "JovenII"; break;
                       case 3: Precio = 40; Categoria = "AdultoI"; break;
                          case 4: Precio = 35; Categoria = "AdultoII"; break;
            }
                 lblPrecio.Text=Precio.ToString("C");
                        lblCategoria.Text = Categoria;

            if (CboEdad.SelectedItem.Equals("Niño"))
            {
                Niño.Visible = true;
                JovenI.Visible = false;
                JovenII.Visible = false;
                AdultoI.Visible = false;
                AdultoII.Visible = false;
            }

            if (CboEdad.SelectedItem.Equals("JovenI"))
            {
                Niño.Visible = false;
                JovenI.Visible = true;
                JovenII.Visible = false;
                AdultoI.Visible = false;
                AdultoII.Visible = false;
            }

            if (CboEdad.SelectedItem.Equals("JovenII"))
            {
                Niño.Visible = false;
                JovenI.Visible = false;
                JovenII.Visible = true;
                AdultoI.Visible = false;
                AdultoII.Visible = false;
            }

            if (CboEdad.SelectedItem.Equals("AdultoI"))
            {
                Niño.Visible = false;
                JovenI.Visible = false;
                JovenII.Visible = false;
                AdultoI.Visible = true;
                AdultoII.Visible = false;
            }
            if (CboEdad.SelectedItem.Equals("AdultoII"))
            {
                Niño.Visible = false;
                JovenI.Visible = false;
                JovenII.Visible = false;
                AdultoI.Visible = false;
                AdultoII.Visible = true;
            }

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
                    lvEstadisticas.Items.Clear();
                  double tSubTotal = 0;
                 int i;
                      for (i = 0; i < lvRegistrar.Items.Count; i++)
                      {
                           tSubTotal += double.Parse(lvRegistrar.Items[i].SubItems[3].Text);
                      }

                        double tDescuento = 0;
                       i = 0;
                 while (i < lvRegistrar.Items.Count)
                 {
                        tDescuento += double.Parse(lvRegistrar.Items[i].SubItems[4].Text);
                     i++;
                 }

                double aNiño = 0, aJovenI = 0, aJovenII = 0, aAdultoI = 0, aAdultoII = 0;
                    i = 0;
               do
               {
                      string Categoria = lvRegistrar.Items[i].SubItems[0].Text;
                   switch (Categoria)
                   {
                          case "Niño":
                        aNiño += double.Parse(lvRegistrar.Items[i].SubItems[5].Text);
                           break;

                        case "JovenI": 
                        aJovenI += double.Parse(lvRegistrar.Items[i].SubItems[5].Text);
                            break;

                         case "JovenII": 
                        aJovenII += double.Parse(lvRegistrar.Items[i].SubItems[5].Text); 
                            break;

                         case "AdultoI": 
                        aAdultoI += double.Parse(lvRegistrar.Items[i].SubItems[5].Text); 
                            break;

                         case "AdultoII":
                        aAdultoII += double.Parse(lvRegistrar.Items[i].SubItems[5].Text);
                            break;
                   }
                  i++;
               } while (i < lvRegistrar.Items.Count);

            lvEstadisticas.Items.Clear();
                  string[] elementosFila = new string[2];
                     ListViewItem row;

                       elementosFila[0] = "Monto total sin Descuento";
                   elementosFila[1] = tSubTotal.ToString("C");
               row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

                  elementosFila[0] = "Monto total que la Empresa no percibe";
                      elementosFila[1] = tDescuento.ToString("C");
                         row = new ListViewItem(elementosFila);
                             lvEstadisticas.Items.Add(row);

                   elementosFila[0] = "Monto Acumulado por Categoria Niño";
                elementosFila[1] = aNiño.ToString("C");
               row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

                  elementosFila[0] = "Monto Acumulado por Categoria JovenI";
                     elementosFila[1] = aJovenI.ToString("C");
                       row = new ListViewItem(elementosFila);
                          lvEstadisticas.Items.Add(row);

                       elementosFila[0] = "Monto Acumulado por Categoria JovenII";
                    elementosFila[1] = aJovenII.ToString("C");
                 row = new ListViewItem(elementosFila);
              lvEstadisticas.Items.Add(row);

                elementosFila[0] = "Monto Acumulado por Categoria AdultoI";
                   elementosFila[1] = aAdultoI.ToString("C");
                      row = new ListViewItem(elementosFila);
                        lvEstadisticas.Items.Add(row);

                     elementosFila[0] = "Monto Acumulado por Categoria AdultoII";
                  elementosFila[1] = aAdultoII.ToString("C");
                row = new ListViewItem(elementosFila);
             lvEstadisticas.Items.Add(row);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Usted Esta Seguro que quiere Salir?", "Control De Ventas De Boletos",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   if (r == DialogResult.Yes)
                   {
                       this.Close();
                   }
        }

        private void lvRegistrar_MouseClick(object sender, MouseEventArgs e)
        {
            Item = lvRegistrar.GetItemAt(e.X, e.Y);
            
        }

        private void FrmCine_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lvRegistrar.Items.Clear();
            lvEstadisticas.Items.Clear();
            txtCantidad.Clear();
            txtRazón.Clear();
            txtRazón.Focus();
            lblPrecio.Text="";
            lblCategoria.Text="";
        }
    }
}
