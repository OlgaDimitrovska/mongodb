﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mongodb.Models;
using MongoDB.Driver;

namespace mongodb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string str1 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tab1.CssClass = "Clicked";
                MainView.ActiveViewIndex = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Info> lista = new List<Info>();
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            IMongoCollection<Info> valuti = database.GetCollection<Info>("Valuti");
            valuti.Find(_ => true).ToList().ForEach(valuta =>
            {
                //str1 = str1 + valuta.Date + " "+ valuta.Valuta + " " + valuta.Kupoven + " " + valuta.Sreden + " " + valuta.Prodazen + "</br>";
                if ((Convert.ToDateTime(valuta.Date) == DateTime.ParseExact(Convert.ToString(DateTime.Today), "dd.mm.yyyy", CultureInfo.InvariantCulture)))
                lista.Add(valuta);
            });

            //Label1.Text = str1;
            GridView1.DataSource = lista;
            GridView1.DataBind();

            Chart1.DataSource = lista;
            Chart1.Series[0].XValueMember = "Valuta";
            Chart1.Series[0].YValueMembers = "Sreden";
            Chart1.DataBind();
        }

        protected void Tab1_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Clicked";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Initial";
            MainView.ActiveViewIndex = 0;
        }

        protected void Tab2_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Clicked";
            Tab3.CssClass = "Initial";
            MainView.ActiveViewIndex = 1;
        }

        protected void Tab3_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Clicked";
            MainView.ActiveViewIndex = 2;
        }
    }
}