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
using System.Linq.Expressions;
using System.Collections.Specialized;
using System.Collections;

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
            if (this.SortExpression.Equals(e.SortExpression))
            {
                this.SortDirection = (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending)
                    ? System.Web.UI.WebControls.SortDirection.Descending
                    : System.Web.UI.WebControls.SortDirection.Ascending;
            }
            else
            {
                this.SortDirection = System.Web.UI.WebControls.SortDirection.Ascending;
            }

            this.SortExpression = e.SortExpression;

            this.SetData();


        }

        protected void GridView2_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (this.SortExpression.Equals(e.SortExpression))
            {
                this.SortDirection = (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending)
                    ? System.Web.UI.WebControls.SortDirection.Descending
                    : System.Web.UI.WebControls.SortDirection.Ascending;
            }
            else
            {
                this.SortDirection = System.Web.UI.WebControls.SortDirection.Ascending;
            }

            this.SortExpression = e.SortExpression;

            this.SetData2();

        }

        protected void GridView3_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (this.SortExpression.Equals(e.SortExpression))
            {
                this.SortDirection = (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending)
                    ? System.Web.UI.WebControls.SortDirection.Descending
                    : System.Web.UI.WebControls.SortDirection.Ascending;
            }
            else
            {
                this.SortDirection = System.Web.UI.WebControls.SortDirection.Ascending;
            }

            this.SortExpression = e.SortExpression;

            this.SetData3();

        }

        protected void GridView4_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (this.SortExpression.Equals(e.SortExpression))
            {
                this.SortDirection = (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending)
                    ? System.Web.UI.WebControls.SortDirection.Descending
                    : System.Web.UI.WebControls.SortDirection.Ascending;
            }
            else
            {
                this.SortDirection = System.Web.UI.WebControls.SortDirection.Ascending;
            }

            this.SortExpression = e.SortExpression;

            this.SetData4();

        }

        protected void GridView5_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (this.SortExpression.Equals(e.SortExpression))
            {
                this.SortDirection = (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending)
                    ? System.Web.UI.WebControls.SortDirection.Descending
                    : System.Web.UI.WebControls.SortDirection.Ascending;
            }
            else
            {
                this.SortDirection = System.Web.UI.WebControls.SortDirection.Ascending;
            }

            this.SortExpression = e.SortExpression;

            this.SetData5();

        }

        protected void GridView6_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (this.SortExpression.Equals(e.SortExpression))
            {
                this.SortDirection = (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending)
                    ? System.Web.UI.WebControls.SortDirection.Descending
                    : System.Web.UI.WebControls.SortDirection.Ascending;
            }
            else
            {
                this.SortDirection = System.Web.UI.WebControls.SortDirection.Ascending;
            }

            this.SortExpression = e.SortExpression;

            this.SetData6();

        }

        protected void GridView7_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (this.SortExpression.Equals(e.SortExpression))
            {
                this.SortDirection = (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending)
                    ? System.Web.UI.WebControls.SortDirection.Descending
                    : System.Web.UI.WebControls.SortDirection.Ascending;
            }
            else
            {
                this.SortDirection = System.Web.UI.WebControls.SortDirection.Ascending;
            }

            this.SortExpression = e.SortExpression;

            this.SetData7();

        }

        protected void GridView8_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (this.SortExpression.Equals(e.SortExpression))
            {
                this.SortDirection = (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending)
                    ? System.Web.UI.WebControls.SortDirection.Descending
                    : System.Web.UI.WebControls.SortDirection.Ascending;
            }
            else
            {
                this.SortDirection = System.Web.UI.WebControls.SortDirection.Ascending;
            }

            this.SortExpression = e.SortExpression;

            this.SetData8();

        }

        private string Sort
        {
            get
            {
                return String.Concat(
                        this.SortExpression,
                        (this.SortDirection == System.Web.UI.WebControls.SortDirection.Ascending) ? " ASC" : " DESC");
            }
        }

        private System.Web.UI.WebControls.SortDirection SortDirection
        {
            get
            {
                if (ViewState["SortDirection"] == null)
                {
                    ViewState["SortDirection"] = System.Web.UI.WebControls.SortDirection.Ascending;
                }

                return (System.Web.UI.WebControls.SortDirection)ViewState["SortDirection"];
            }
            set { ViewState["SortDirection"] = value; }
        }

        private string SortExpression
        {
            get
            {
                if (ViewState["SortExpression"] == null)
                {
                    ViewState["SortExpression"] = "Kupoven";
                }

                return ViewState["SortExpression"].ToString();
            }
            set { ViewState["SortExpression"] = value; }
        }

        public void SetData()
        {
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");
           
           
                try
                {

                DataTable tabela = new DataTable();
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "eur" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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

                foreach (var t in query)
                {
                    tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
                }
                DataView dv = tabela.DefaultView;
                    dv.Sort = this.Sort;

                    GridView1.DataSource = dv;
                    GridView1.DataBind();
                }
                catch { }
            }

        public void SetData2()
        {
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");


            try
            {

                DataTable tabela = new DataTable();
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "usd" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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

                foreach (var t in query)
                {
                    tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
                }
                DataView dv = tabela.DefaultView;
                dv.Sort = this.Sort;

                GridView2.DataSource = dv;
                GridView2.DataBind();
            }
            catch { }
        }

        public void SetData3()
        {
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");


            try
            {

                DataTable tabela = new DataTable();
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "gbp" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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

                foreach (var t in query)
                {
                    tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
                }
                DataView dv = tabela.DefaultView;
                dv.Sort = this.Sort;

                GridView3.DataSource = dv;
                GridView3.DataBind();
            }
            catch { }
        }

        public void SetData4()
        {
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");


            try
            {

                DataTable tabela = new DataTable();
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "chf" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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

                foreach (var t in query)
                {
                    tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
                }
                DataView dv = tabela.DefaultView;
                dv.Sort = this.Sort;

                GridView4.DataSource = dv;
                GridView4.DataBind();
            }
            catch { }
        }

        public void SetData5()
        {
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");


            try
            {

                DataTable tabela = new DataTable();
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "gbp" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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

                foreach (var t in query)
                {
                    tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
                }
                DataView dv = tabela.DefaultView;
                dv.Sort = this.Sort;

                GridView5.DataSource = dv;
                GridView5.DataBind();
            }
            catch { }
        }

        public void SetData6()
        {
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");


            try
            {

                DataTable tabela = new DataTable();
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "nok" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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

                foreach (var t in query)
                {
                    tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
                }
                DataView dv = tabela.DefaultView;
                dv.Sort = this.Sort;

                GridView6.DataSource = dv;
                GridView6.DataBind();
            }
            catch { }
        }

        public void SetData7()
        {
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");


            try
            {

                DataTable tabela = new DataTable();
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "dkk" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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

                foreach (var t in query)
                {
                    tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
                }
                DataView dv = tabela.DefaultView;
                dv.Sort = this.Sort;

                GridView7.DataSource = dv;
                GridView7.DataBind();
            }
            catch { }
        }

        public void SetData8()
        {
            var server = new MongoClient(MongoUrl.Create("mongodb://localhost:27017"));
            IMongoDatabase database = server.GetDatabase("prvaDB");
            var collection = database.GetCollection<Info>("Valuti");


            try
            {

                DataTable tabela = new DataTable();
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "cad" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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

                foreach (var t in query)
                {
                    tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen);
                }
                DataView dv = tabela.DefaultView;
                dv.Sort = this.Sort;

                GridView8.DataSource = dv;
                GridView8.DataBind();
            }
            catch { }
        }

      
    }

}
   
    

