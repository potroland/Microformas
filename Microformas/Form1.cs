using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microformas
{
    public partial class Form1 : Form
    {

        List<DateTime> oDiaFeriado;
        public Form1()
        {
            InitializeComponent();

            //se carngan dias no laborables
            oDiaFeriado = new List<DateTime>();
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 1, 1));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 2, 5));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 3, 14));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 4, 14));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 4, 15));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 5, 1));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 9, 16));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 10, 12));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 11, 14));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 11, 20));
            oDiaFeriado.Add(new DateTime(DateTime.Now.Year, 12, 25));
        }

        private void dtAdquisicion_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha;
            DateTime dtDiaCobro;
            
            try
            {
                fecha = dtAdquisicion.Value;//fecha obtenida del objeto calendario
                if (fecha != null) //se valida datos null 
                {
                    //se obtiene primer dia del mes
                    dtDiaCobro = new DateTime(fecha.Year, fecha.Month + 1, 1);


                    //se valida la ultima semana
                    if (UltimaSemana(fecha))
                    {
                        //funcion recursiva para validar y obtener el ultimo dia habil
                        txtFechaCobro.Text = ValidaDia(dtDiaCobro);
                    }
                    else
                    { 
                        txtFechaCobro.Text = fecha.ToString("dd/MM/yyyy");
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }


        public string ValidaDia(DateTime dtFecha) 
        {
            DateTime dtNuevaFecha = DateTime.Now;
            string salida;
            try
            {

                //se valida dia habil 
                if (dtFecha.DayOfWeek != DayOfWeek.Saturday && dtFecha.DayOfWeek != DayOfWeek.Sunday)
                {

                    //se valida si el dia es no laborable
                    foreach (var item in oDiaFeriado)
                    {
                        if (item == dtFecha)
                        {
                            dtNuevaFecha = new DateTime(dtFecha.Year, dtFecha.Month, dtFecha.Day + 1);
                            dtFecha = dtNuevaFecha;
                            break;
                        }
                    }

                    dtNuevaFecha = dtFecha;
                    salida = dtNuevaFecha.ToString("dd/MM/yyyy");

                }
                else 
                {

                    //se agrega un dia y entra a la validacion de nuevo
                    dtNuevaFecha = new DateTime(dtFecha.Year, dtFecha.Month, dtFecha.Day + 1);

                    salida = ValidaDia(dtNuevaFecha);
                }
                          
            return salida;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el dia. "+ex.Message);
                return "";
            }
        }

        public bool UltimaSemana(DateTime dtFecha) 
        {
            bool bUltima = false;
            DateTime dtUltimoDia;
            int iRestoUltimaSemana = 0;
            try 
            {
                //se obtiene el ultimo dia
                dtUltimoDia = new DateTime(dtFecha.Year, dtFecha.Month, DateTime.DaysInMonth(dtFecha.Year, dtFecha.Month));
                //obtiene el numero de dias del mes
                DateTime.DaysInMonth(dtFecha.Year, dtFecha.Month).ToString();

                //se calcula el limite de dias para la ultima semana restando los ultimos dias de la semana
                iRestoUltimaSemana = ((int)DateTime.DaysInMonth(dtFecha.Year, dtFecha.Month) - (int)dtUltimoDia.DayOfWeek);
                
                //si el dia seleccionado es mayor a la operacione entonces es esta en la ultima semana
                if ((int)dtFecha.Day > iRestoUltimaSemana)
                {
                    bUltima = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar la ultima semana. "+ex.Message);
                return false;
            }
            return bUltima;

        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            gridJSON gridJSON = new gridJSON();
            gridJSON.Show();
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            ConsumirApi gridJSON = new ConsumirApi();
            gridJSON.Show();
        }
    }
}
