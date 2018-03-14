using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mongodb.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using System.Threading;

namespace mongodb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CultureInfo currentUserCulture = Thread.CurrentThread.CurrentCulture;
        string str1 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tab1.CssClass = "Clicked";
                MainView.ActiveViewIndex = 0;
            }
        }
        //public void postaviRegionalOptions()
        //{
        //    var appCulture = new System.Globalization.CultureInfo("mk-MK");
        //    appCulture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
        //    appCulture.DateTimeFormat.LongDatePattern = "dd.MM.yyyy";
        //    appCulture.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
        //    appCulture.NumberFormat.NumberDecimalSeparator = ",";
        //    appCulture.NumberFormat.NumberGroupSeparator = ".";
        //    appCulture.NumberFormat.CurrencyDecimalSeparator = ",";
        //    appCulture.NumberFormat.CurrencyGroupSeparator = ".";
        //}
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable tabela = new DataTable();
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");

            
            DataColumn dc1 = new DataColumn("Датум");
            DataColumn dc5 = new DataColumn("Назив на Банка");
            DataColumn dc2 = new DataColumn("Валута");
            DataColumn dc3 = new DataColumn("Куповен");
            DataColumn dc4 = new DataColumn("Продажен");
            
            tabela.Columns.Add(dc1);
            tabela.Columns.Add(dc5);
            tabela.Columns.Add(dc2);
            tabela.Columns.Add(dc3);
            tabela.Columns.Add(dc4);
            
            
            var query = from p in collection.AsQueryable<Info>() where p.Valuta=="eur" && p.Date==Convert.ToString(DateTime.Now.ToShortDateString()) select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date,t.Banka.Name,t.Valuta,t.Kupoven,t.Prodazen); 
            }
           

            
            GridView1.DataSource = tabela;
            GridView1.DataBind();

            //Chart1.DataSource = tabela;
            //Chart1.Series[0].XValueMember = "Valuta";
            //Chart1.Series[0].YValueMembers = "Sreden";
            //Chart1.DataBind();
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