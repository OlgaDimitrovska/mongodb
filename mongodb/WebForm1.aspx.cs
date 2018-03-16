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

       

        public void Load1()
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
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "eur" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView1.DataSource = tabela;
            GridView1.DataBind();
        }
        public void Load2()
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
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "usd" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView2.DataSource = tabela;
            GridView2.DataBind();
        }
        public void Load3()
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
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "gbp" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView3.DataSource = tabela;
            GridView3.DataBind();
        }
        public void Load4()
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
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "chf" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView4.DataSource = tabela;
            GridView4.DataBind();
        }
        public void Load5()
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
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "sek" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") orderby p.Kupoven ascending, p.Prodazen descending select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView5.DataSource = tabela;
            GridView5.DataBind();
        }
        public void Load6()
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
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "nok" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView6.DataSource = tabela;
            GridView6.DataBind();
        }
        public void Load7()
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
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "dkk" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView7.DataSource = tabela;
            GridView7.DataBind();
        }
        public void Load8()
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
            var query = from p in collection.AsQueryable<Info>() where p.Valuta == "cad" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;
            foreach (var t in query)
            {
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
            }

            GridView8.DataSource = tabela;
            GridView8.DataBind();
        }
        protected void View1_Load(object sender, EventArgs e)
        {
            Load1();
        }
        protected void View2_Load(object sender, EventArgs e)
        {
            Load2();
        }

        protected void View3_Load(object sender, EventArgs e)
        {
            Load3();
        }

        protected void View4_Load(object sender, EventArgs e)
        {
            Load4();
        }

        protected void View5_Load(object sender, EventArgs e)
        {
            Load5();
        }

        protected void View6_Load(object sender, EventArgs e)
        {
            Load6();
        }

        protected void View7_Load(object sender, EventArgs e)
        {
            Load7();
        }

        protected void View8_Load(object sender, EventArgs e)
        {
            Load8();
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Load1();
            Load2();
            Load3();
            Load4();
            Load5();
            Load6();
            Load7();
            Load8();
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dtrslt = (DataTable)ViewState["dirState"];
            if (dtrslt.Rows.Count > 0)
            {
                if (Convert.ToString(ViewState["sortdr"]) == "Asc")
                {
                    dtrslt.DefaultView.Sort = e.SortExpression + " Desc";
                    ViewState["sortdr"] = "Desc";
                }
                else
                {
                    dtrslt.DefaultView.Sort = e.SortExpression + " Asc";
                    ViewState["sortdr"] = "Asc";
                }
                GridView1.DataSource = dtrslt;
                GridView1.DataBind();


            }
        }
    }
}