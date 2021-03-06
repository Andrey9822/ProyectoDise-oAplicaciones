﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPage
{
    public partial class PrincipalWebFormCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebServiceProyecto.Service1Client servicio = new WebServiceProyecto.Service1Client();
            var cliente = servicio.GetCliente(12345, "Pedro Picapiedra", 36251485, "San Jose");
            lblIdCliente.Text = cliente.Id.ToString();
            lblNombreCliente.Text = cliente.Nombre;
            lblTelefonoCliente.Text = cliente.Telefono.ToString();
            lblDireccionCliente.Text = cliente.Direccion;
        }
    }
}