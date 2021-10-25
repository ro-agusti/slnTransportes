using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Datos.Admin;
using System.Data;
using Entidades.Models;

namespace WebTransportes
{
    public partial class vistaAuto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MostrarAutos();
                LlenarComboMarca();
                LlenarComboFiltrarMarca();
            }
        }

        private void MostrarAutos()
        {
        gridAutos.DataSource = AdmAuto.Listar();
            gridAutos.DataBind();
        }

        private void LlenarComboMarca()
        {
            DataTable dt = AdmAuto.ListarMarcas();
            ddMarca.DataSource = dt;
            ddMarca.DataTextField = dt.Columns["Marca"].ToString();
            ddMarca.DataBind();
        }

        private void LlenarComboFiltrarMarca()
        {
            DataTable dt = AdmAuto.ListarMarcas();
            ddFiltrarMarca.DataSource = dt;
            ddFiltrarMarca.DataTextField = dt.Columns["Marca"].ToString();
            DataRow fila = dt.NewRow();
            fila["Marca"] = "[TODAS]";
            dt.Rows.InsertAt(fila,0);
            ddFiltrarMarca.DataBind();
        }

        protected void ddMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto()
            {
                Marca= ddMarca.SelectedValue,
                Modelo= txtModelo.Text,
                Matricula= txtMatricula.Text,
                Precio= Convert.ToDecimal(txtPrecio.Text)
            };
            int filasAfectadas = AdmAuto.Insertar(auto);
            if (filasAfectadas > 0)
            {
                MostrarAutos();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto()
            {
                Id = Convert.ToInt32(txtId.Text),
                Marca = ddMarca.SelectedValue,
                Modelo = txtModelo.Text,
                Matricula = txtMatricula.Text,
                Precio = Convert.ToInt32(txtPrecio.Text)
            };
            int filasAfectadas = AdmAuto.Modificar(auto);
            if (filasAfectadas > 0)
            {
                MostrarAutos();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int filasAfectadas = AdmAuto.Eliminar(id);
            if (filasAfectadas > 0)
            {
                MostrarAutos();
            }
        }

        protected void ddFiltrarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marca = ddFiltrarMarca.SelectedValue;
            if (marca == "[TODAS]")
            {
                MostrarAutos();
            }
            else
            {
            gridAutos.DataSource = AdmAuto.Listar(marca);
            gridAutos.DataBind();
            }
            
        }
    }
}