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
    public partial class _Default : Page
    {
        public int TheNumber;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cord"] == null)
            {
                Session["cord"] = new Dictionary<int, int>();
                System.Console.Out.WriteLine("Hello Mama");
            }

            var cord = ((Dictionary<int, int>) Session["cord"]);
            int pref = 1;
            if (cord.TryGetValue(1, out pref))
            {
                cord.Remove(1);
            }
            cord.Add(1, ++pref);
            TheNumber = pref;
        }

        public string GetProdsucts()
        {
            return " test";
        }

        public IEnumerable<Product> GetProducts()
        {
            var iHateMyswlf = new ProductsPersistency();
            return iHateMyswlf.GetAll();
        }
    }
}