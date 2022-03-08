using Microformas.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microformas
{
    public partial class ConsumirApi : Form
    {
        public ConsumirApi()
        {
            InitializeComponent();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            Consumir();
        }

        private void Consumir()
        {

            try
            {
                lblNombre.Text = "El nombre ingresado es mas común en:"; // se inicializa
                //se valida si el campo esta lleno
                if (txtNombre.Text.Trim() != "")
                {
                    //se crea request 
                    var url = $"https://api.nationalize.io?name=" + txtNombre.Text.Trim();
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    request.Method = "GET";
                    request.ContentType = "application/json";
                    request.Accept = "application/json";

                    using (WebResponse response = request.GetResponse()) // se obtiene la respuesta y se usa en objeto por bloque
                    {
                        using (Stream strResponse = response.GetResponseStream())// se instancia cuerpo de la respuesta
                        {
                            if (strResponse == null) return; //se valida si el cuerpo de la respueta esta vacio

                            using (StreamReader oBj = new StreamReader(strResponse)) // se instancia el objeto para obtener texto de la respuesta
                            {
                                string responseBody = oBj.ReadToEnd(); //se obtiene todo el texto del objeto

                                var oNationalize = JsonConvert.DeserializeObject<DTO_Nationalize>(responseBody); //se deserializa respuesta

                                //se arma texto de label
                                for (int i = 0; i < oNationalize.country.Count; i++)
                                {
                                    if (i == oNationalize.country.Count - 1)
                                    {
                                        lblNombre.Text = string.Format("{0} {1} ", lblNombre.Text, oNationalize.country[i].country_id);
                                    }
                                    else
                                    {
                                        lblNombre.Text = string.Format("{0} {1}, ", lblNombre.Text, oNationalize.country[i].country_id);
                                    }
                                }


                            }
                        }
                    }
                }

            }
            catch (WebException ex)
            {
                MessageBox.Show("Error al consumir api. " + ex.Message);
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {

            if ((int)e.KeyCode == (int)Keys.Enter) //se valida tecla presionada
            {
                Consumir();
            }
        }
    }
}
