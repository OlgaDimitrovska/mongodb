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
        
        string str1 = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tab1.CssClass = "Clicked";
                MainView.ActiveViewIndex = 0;
                //postaviRegionalOptions();
            }
        }
        
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

            //postaviRegionalOptions();
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "eur" && p.Date == DateTime.Now.ToString("dd.MM.yyyy") select p;
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

        private void postaviRegionalOptions()
        {

            var appCulture = new System.Globalization.CultureInfo("mk-MK");
            appCulture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            appCulture.DateTimeFormat.LongDatePattern = "dd.MM.yyyy";
            appCulture.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            appCulture.NumberFormat.NumberDecimalSeparator = ",";
            appCulture.NumberFormat.NumberGroupSeparator = ".";
            appCulture.NumberFormat.CurrencyDecimalSeparator = ",";
            appCulture.NumberFormat.CurrencyGroupSeparator = ".";
          
        }

        protected void Tab1_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Clicked";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Initial";
            Tab4.CssClass = "Initial";
            Tab5.CssClass = "Initial";
            Tab6.CssClass = "Initial";
            Tab7.CssClass = "Initial";
            Tab8.CssClass = "Initial";
            MainView.ActiveViewIndex = 0;
        }

        protected void Tab2_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Clicked";
            Tab3.CssClass = "Initial";
            Tab4.CssClass = "Initial";
            Tab5.CssClass = "Initial";
            Tab6.CssClass = "Initial";
            Tab7.CssClass = "Initial";
            Tab8.CssClass = "Initial";
            MainView.ActiveViewIndex = 1;
        }

        protected void Tab3_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Clicked";
            Tab4.CssClass = "Initial";
            Tab5.CssClass = "Initial";
            Tab6.CssClass = "Initial";
            Tab7.CssClass = "Initial";
            Tab8.CssClass = "Initial";
            MainView.ActiveViewIndex = 2;
        }

        protected void Button2_Click(object sender, EventArgs e)
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

            //postaviRegionalOptions();
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "usd" && p.Date == DateTime.Now.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }
  
            GridView2.DataSource = tabela;
            GridView2.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
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

            //postaviRegionalOptions();
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "gbp" && p.Date == DateTime.Now.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }
 
            GridView3.DataSource = tabela;
            GridView3.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
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

            //postaviRegionalOptions();
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "chf" && p.Date == DateTime.Now.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView4.DataSource = tabela;
            GridView4.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
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

            //postaviRegionalOptions();
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "sek" && p.Date == DateTime.Now.ToString("dd.MM.yyyy") orderby p.Kupoven ascending, p.Prodazen descending select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView5.DataSource = tabela;
            GridView5.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
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

            //postaviRegionalOptions();
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "nok" && p.Date == DateTime.Now.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView6.DataSource = tabela;
            GridView6.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
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

            //postaviRegionalOptions();
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "dkk" && p.Date == DateTime.Now.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView7.DataSource = tabela;
            GridView7.DataBind();
        }

        protected void Button8_Click(object sender, EventArgs e)
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

            //postaviRegionalOptions();
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "cad" && p.Date == DateTime.Now.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView8.DataSource = tabela;
            GridView8.DataBind();
        }

        protected void Tab4_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Initial";
            Tab4.CssClass = "Clicked";
            Tab5.CssClass = "Initial";
            Tab6.CssClass = "Initial";
            Tab7.CssClass = "Initial";
            Tab8.CssClass = "Initial";
            MainView.ActiveViewIndex = 3;
        }

        protected void Tab5_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Initial";
            Tab4.CssClass = "Initial";
            Tab5.CssClass = "Clicked";
            Tab6.CssClass = "Initial";
            Tab7.CssClass = "Initial";
            Tab8.CssClass = "Initial";
            MainView.ActiveViewIndex = 4;
        }

        protected void Tab6_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Initial";
            Tab4.CssClass = "Initial";
            Tab5.CssClass = "Initial";
            Tab6.CssClass = "Clicked";
            Tab7.CssClass = "Initial";
            Tab8.CssClass = "Initial";
            MainView.ActiveViewIndex = 5;
        }

        protected void Tab7_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Initial";
            Tab4.CssClass = "Initial";
            Tab5.CssClass = "Initial";
            Tab6.CssClass = "Initial";
            Tab7.CssClass = "Clicked";
            Tab8.CssClass = "Initial";
            MainView.ActiveViewIndex = 6;
        }

        protected void Tab8_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Initial";
            Tab2.CssClass = "Initial";
            Tab3.CssClass = "Initial";
            Tab4.CssClass = "Initial";
            Tab5.CssClass = "Initial";
            Tab6.CssClass = "Initial";
            Tab7.CssClass = "Initial";
            Tab8.CssClass = "Clicked";
            MainView.ActiveViewIndex = 7;
        }
    }
}