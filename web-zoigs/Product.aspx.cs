using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dorflaedali.Models;
using Dorflaedali.Persistency;

namespace web_zoigs
{
    public partial class ProductPage : Page
    {
        public Product Product { get; set; }

      

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            if (
                !string.IsNullOrEmpty(Request.QueryString["productId"])
            )
            {
                var Fuck = new ProductsPersistency();
                Product = Fuck.GetById(Request.QueryString["productId"]);
            }
            else
            {
                Response.Redirect("/");
            }
        }
    }
}