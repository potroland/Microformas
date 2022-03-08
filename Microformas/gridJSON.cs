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
using Microformas.Model;
using Newtonsoft.Json;

namespace Microformas
{
    public partial class gridJSON : Form
    {
        public gridJSON()
        {
            InitializeComponent();
        }

        private void gridJSON_Load(object sender, EventArgs e)
        {
            try
            {

                string miJson = File.ReadAllText("ubicaciones.txt");//se carga archivo  con estructura json

                var oUbicacion = JsonConvert.DeserializeObject<DTO_Ubicaciones>(miJson);//se deseraliza en clase modelo

                //se prepara grid
                grdJson.Columns.Clear();
                grdJson.Columns.Add("city", "Ciudad");
                grdJson.Columns.Add("description", "Descripcion");
                grdJson.Columns.Add("latitude", "latitude");
                grdJson.Columns.Add("longitude", "longitude");
                grdJson.Columns["description"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grdJson.Columns["latitude"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grdJson.Columns["longitude"].SortMode = DataGridViewColumnSortMode.NotSortable;
                grdJson.Columns["description"].ReadOnly = true;
                grdJson.Columns["latitude"].ReadOnly = true;
                grdJson.Columns["longitude"].ReadOnly = true;
                grdJson.Columns["city"].ReadOnly = true;

                foreach (var item in oUbicacion.ubicaciones)//se carga grid
                {
                    grdJson.Rows.Add(item.city, item.description, item.latitude,item.longitude);
                }
                //se acomoda tamaño de columnas
                grdJson.AutoResizeColumns();
                grdJson.Columns["city"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grdJson.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el grid. " + ex.Message);
            }
        }
    }
}
