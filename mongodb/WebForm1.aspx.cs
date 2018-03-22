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
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

namespace mongodb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        string str1 = "";
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tab1.CssClass = "Clicked btn btn-primary";
                MainView.ActiveViewIndex = 0;
                //postaviRegionalOptions();
               

            }
        }

        protected void Tab1_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Clicked btn btn-primary";
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
            Tab2.CssClass = "Clicked btn btn-primary";
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
            Tab3.CssClass = "Clicked btn btn-primary";
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
            Tab4.CssClass = "Clicked btn btn-primary";
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
            Tab5.CssClass = "Clicked btn btn-primary";
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
            Tab6.CssClass = "Clicked btn btn-primary";
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
            Tab7.CssClass = "Clicked btn btn-primary";
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
            Tab8.CssClass = "Clicked btn btn-primary";
            MainView.ActiveViewIndex = 7;
        }

       

        public void Load1()
        {
            DataTable tabela = new DataTable();
            DataTable tabela2 = new DataTable();
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

            //GridView1.HeaderRow.ForeColor = Color.Blue;
            GridView1.DataSource = tabela;
            GridView1.DataBind();

            DataColumn k1 = new DataColumn("Датум");
            DataColumn k2 = new DataColumn("Назив на Банка");
            DataColumn k3 = new DataColumn("Валута");
            DataColumn k4 = new DataColumn("Куповен");
            DataColumn k5 = new DataColumn("Среден");
            DataColumn k6 = new DataColumn("Продажен");

            tabela2.Columns.Add(k1);
            tabela2.Columns.Add(k2);
            tabela2.Columns.Add(k3);
            tabela2.Columns.Add(k4);
            tabela2.Columns.Add(k5);
            tabela2.Columns.Add(k6);
            var query2 = from p in collection.AsQueryable<Info>() where p.Valuta == "eur" select p;
            foreach (var t in query2)
            {

                if (t.Date == null || t.Banka.Name == null || t.Valuta == null || t.Kupoven == 0 || t.Prodazen == 0 || t.Sreden==0)
                {
                }
                else
                {
                    tabela2.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen, t.Sreden);
                }
            }

            string[] x = new string[tabela2.Rows.Count];
            double[] y = new double[tabela2.Rows.Count];
           

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                x[i] = tabela2.Rows[i][0].ToString();
                y[i] = Convert.ToDouble(tabela2.Rows[i][5]);
                
            }
           
            //foreach(DataRow row in tabela.Rows)
            //{
            //    tabela.Rows[0]
            //}
            
            Chart1.Series["Series1"].Points.DataBindXY(x,y);
            Chart1.Series["Series1"].IsValueShownAsLabel=true;
            Chart1.Series["Series1"].ToolTip = "Датум: #VALX Среден курс на НБРМ: #VALY";
            Chart1.Series["Series1"].Font = new System.Drawing.Font("Helvetica", 12);
            Chart1.Series["Series1"].MarkerSize = 20;
            Chart1.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;

            Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart1.ChartAreas[0].AxisY.Maximum = Double.NaN;
            Chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            Chart1.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 18;
            Chart1.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -10;
            Chart1.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 18;
            Chart1.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Chart1.ChartAreas[0].RecalculateAxesScale();

        }
        public void Load2()
        {
            DataTable tabela2 = new DataTable();
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

            DataColumn k1 = new DataColumn("Датум");
            DataColumn k2 = new DataColumn("Назив на Банка");
            DataColumn k3 = new DataColumn("Валута");
            DataColumn k4 = new DataColumn("Куповен");
            DataColumn k5 = new DataColumn("Среден");
            DataColumn k6 = new DataColumn("Продажен");

            tabela2.Columns.Add(k1);
            tabela2.Columns.Add(k2);
            tabela2.Columns.Add(k3);
            tabela2.Columns.Add(k4);
            tabela2.Columns.Add(k5);
            tabela2.Columns.Add(k6);
            var query2 = from p in collection.AsQueryable<Info>() where p.Valuta == "usd" select p;
            foreach (var t in query2)
            {

                if (t.Date == null || t.Banka.Name == null || t.Valuta == null || t.Kupoven == 0 || t.Prodazen == 0 || t.Sreden == 0)
                {
                }
                else
                {
                    tabela2.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen, t.Sreden);
                }
            }

            string[] x = new string[tabela2.Rows.Count];
            double[] y = new double[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                x[i] = tabela2.Rows[i][0].ToString();
                y[i] = Convert.ToDouble(tabela2.Rows[i][5]);
            }


            Chart2.Series["Series1"].Points.DataBindXY(x, y);
            Chart2.Series["Series1"].IsValueShownAsLabel = true;
            Chart2.Series["Series1"].ToolTip = "Датум: #VALX Среден курс на НБРМ: #VALY";
            Chart2.Series["Series1"].Font = new System.Drawing.Font("Helvetica", 12);
            Chart2.Series["Series1"].MarkerSize = 20;
            Chart2.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;

            Chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart2.ChartAreas[0].AxisY.Maximum = Double.NaN;
            Chart2.ChartAreas[0].AxisY.IsStartedFromZero = false;
            Chart2.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 18;
            Chart2.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -10;
            Chart2.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 18;
            Chart2.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Chart2.ChartAreas[0].RecalculateAxesScale();
        }
        public void Load3()
        {

            DataTable tabela2 = new DataTable();
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

            DataColumn k1 = new DataColumn("Датум");
            DataColumn k2 = new DataColumn("Назив на Банка");
            DataColumn k3 = new DataColumn("Валута");
            DataColumn k4 = new DataColumn("Куповен");
            DataColumn k5 = new DataColumn("Среден");
            DataColumn k6 = new DataColumn("Продажен");

            tabela2.Columns.Add(k1);
            tabela2.Columns.Add(k2);
            tabela2.Columns.Add(k3);
            tabela2.Columns.Add(k4);
            tabela2.Columns.Add(k5);
            tabela2.Columns.Add(k6);
            var query2 = from p in collection.AsQueryable<Info>() where p.Valuta == "gbp" select p;
            foreach (var t in query2)
            {

                if (t.Date == null || t.Banka.Name == null || t.Valuta == null || t.Kupoven == 0 || t.Prodazen == 0 || t.Sreden == 0)
                {
                }
                else
                {
                    tabela2.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen, t.Sreden);
                }
            }

            string[] x = new string[tabela2.Rows.Count];
            double[] y = new double[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                x[i] = tabela2.Rows[i][0].ToString();
                y[i] = Convert.ToDouble(tabela2.Rows[i][5]);
            }

            Chart3.Series["Series1"].Points.DataBindXY(x, y);
            Chart3.Series["Series1"].IsValueShownAsLabel = true;
            Chart3.Series["Series1"].ToolTip = "Датум: #VALX Среден курс на НБРМ: #VALY";
            Chart3.Series["Series1"].Font = new System.Drawing.Font("Helvetica", 12);
            Chart3.Series["Series1"].MarkerSize = 20;
            Chart3.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;

            Chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart3.ChartAreas[0].AxisY.Maximum = Double.NaN;
            Chart3.ChartAreas[0].AxisY.IsStartedFromZero = false;
            Chart3.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 18;
            Chart3.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -10;
            Chart3.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 18;
            Chart3.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Chart3.ChartAreas[0].RecalculateAxesScale();
        }
        public void Load4()
        {

            DataTable tabela2 = new DataTable();
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

            DataColumn k1 = new DataColumn("Датум");
            DataColumn k2 = new DataColumn("Назив на Банка");
            DataColumn k3 = new DataColumn("Валута");
            DataColumn k4 = new DataColumn("Куповен");
            DataColumn k5 = new DataColumn("Среден");
            DataColumn k6 = new DataColumn("Продажен");

            tabela2.Columns.Add(k1);
            tabela2.Columns.Add(k2);
            tabela2.Columns.Add(k3);
            tabela2.Columns.Add(k4);
            tabela2.Columns.Add(k5);
            tabela2.Columns.Add(k6);
            var query2 = from p in collection.AsQueryable<Info>() where p.Valuta == "chf" select p;
            foreach (var t in query2)
            {

                if (t.Date == null || t.Banka.Name == null || t.Valuta == null || t.Kupoven == 0 || t.Prodazen == 0 || t.Sreden == 0)
                {
                }
                else
                {
                    tabela2.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen, t.Sreden);
                }
            }

            string[] x = new string[tabela2.Rows.Count];
            double[] y = new double[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                x[i] = tabela2.Rows[i][0].ToString();
                y[i] = Convert.ToDouble(tabela2.Rows[i][5]);
            }


            Chart4.Series["Series1"].Points.DataBindXY(x, y);
            Chart4.Series["Series1"].IsValueShownAsLabel = true;
            Chart4.Series["Series1"].ToolTip = "Датум: #VALX Среден курс на НБРМ: #VALY";
            Chart4.Series["Series1"].Font = new System.Drawing.Font("Helvetica", 12);
            Chart4.Series["Series1"].MarkerSize = 20;
            Chart4.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;

            Chart4.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart4.ChartAreas[0].AxisY.Maximum = Double.NaN;
            Chart4.ChartAreas[0].AxisY.IsStartedFromZero = false;
            Chart4.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 18;
            Chart4.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -10;
            Chart4.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 18;
            Chart4.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Chart4.ChartAreas[0].RecalculateAxesScale();
        }
        public void Load5()
        {
            DataTable tabela2 = new DataTable();
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

            DataColumn k1 = new DataColumn("Датум");
            DataColumn k2 = new DataColumn("Назив на Банка");
            DataColumn k3 = new DataColumn("Валута");
            DataColumn k4 = new DataColumn("Куповен");
            DataColumn k5 = new DataColumn("Среден");
            DataColumn k6 = new DataColumn("Продажен");

            tabela2.Columns.Add(k1);
            tabela2.Columns.Add(k2);
            tabela2.Columns.Add(k3);
            tabela2.Columns.Add(k4);
            tabela2.Columns.Add(k5);
            tabela2.Columns.Add(k6);
            var query2 = from p in collection.AsQueryable<Info>() where p.Valuta == "sek" select p;
            foreach (var t in query2)
            {

                if (t.Date == null || t.Banka.Name == null || t.Valuta == null || t.Kupoven == 0 || t.Prodazen == 0 || t.Sreden == 0)
                {
                }
                else
                {
                    tabela2.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen, t.Sreden);
                }
            }

            string[] x = new string[tabela2.Rows.Count];
            double[] y = new double[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                x[i] = tabela2.Rows[i][0].ToString();
                y[i] = Convert.ToDouble(tabela2.Rows[i][5]);
            }


            Chart5.Series["Series1"].Points.DataBindXY(x, y);
            Chart5.Series["Series1"].IsValueShownAsLabel = true;
            Chart5.Series["Series1"].ToolTip = "Датум: #VALX Среден курс на НБРМ: #VALY";
            Chart5.Series["Series1"].Font = new System.Drawing.Font("Helvetica", 12);
            Chart5.Series["Series1"].MarkerSize = 20;
            Chart5.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;

            Chart5.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart5.ChartAreas[0].AxisY.Maximum = Double.NaN;
            Chart5.ChartAreas[0].AxisY.IsStartedFromZero = false;
            Chart5.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 18;
            Chart5.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -10;
            Chart5.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 18;
            Chart5.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Chart5.ChartAreas[0].RecalculateAxesScale();
        }
        public void Load6()
        {
            DataTable tabela2 = new DataTable();
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

            DataColumn k1 = new DataColumn("Датум");
            DataColumn k2 = new DataColumn("Назив на Банка");
            DataColumn k3 = new DataColumn("Валута");
            DataColumn k4 = new DataColumn("Куповен");
            DataColumn k5 = new DataColumn("Среден");
            DataColumn k6 = new DataColumn("Продажен");

            tabela2.Columns.Add(k1);
            tabela2.Columns.Add(k2);
            tabela2.Columns.Add(k3);
            tabela2.Columns.Add(k4);
            tabela2.Columns.Add(k5);
            tabela2.Columns.Add(k6);
            var query2 = from p in collection.AsQueryable<Info>() where p.Valuta == "nok" select p;
            foreach (var t in query2)
            {

                if (t.Date == null || t.Banka.Name == null || t.Valuta == null || t.Kupoven == 0 || t.Prodazen == 0 || t.Sreden == 0)
                {
                }
                else
                {
                    tabela2.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen, t.Sreden);
                }
            }

            string[] x = new string[tabela2.Rows.Count];
            double[] y = new double[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                x[i] = tabela2.Rows[i][0].ToString();
                y[i] = Convert.ToDouble(tabela2.Rows[i][5]);
            }


            Chart6.Series["Series1"].Points.DataBindXY(x, y);
            Chart6.Series["Series1"].IsValueShownAsLabel = true;
            Chart6.Series["Series1"].ToolTip = "Датум: #VALX Среден курс на НБРМ: #VALY";
            Chart6.Series["Series1"].Font = new System.Drawing.Font("Helvetica", 12);
            Chart6.Series["Series1"].MarkerSize = 20;
            Chart6.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;

            Chart6.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart6.ChartAreas[0].AxisY.Maximum = Double.NaN;
            Chart6.ChartAreas[0].AxisY.IsStartedFromZero = false;
            Chart6.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 18;
            Chart6.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -10;
            Chart6.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 18;
            Chart6.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Chart6.ChartAreas[0].RecalculateAxesScale();
        }
        public void Load7()
        {
            DataTable tabela2 = new DataTable();
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
                
                tabela.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven,t.Prodazen);
            }

            GridView7.DataSource = tabela;
            GridView7.DataBind();
            DataColumn k1 = new DataColumn("Датум");
            DataColumn k2 = new DataColumn("Назив на Банка");
            DataColumn k3 = new DataColumn("Валута");
            DataColumn k4 = new DataColumn("Куповен");
            DataColumn k5 = new DataColumn("Среден");
            DataColumn k6 = new DataColumn("Продажен");

            tabela2.Columns.Add(k1);
            tabela2.Columns.Add(k2);
            tabela2.Columns.Add(k3);
            tabela2.Columns.Add(k4);
            tabela2.Columns.Add(k5);
            tabela2.Columns.Add(k6);
            var query2 = from p in collection.AsQueryable<Info>() where p.Valuta == "dkk" select p;
            foreach (var t in query2)
            {

                if (t.Date == null || t.Banka.Name == null || t.Valuta == null || t.Kupoven == 0 || t.Prodazen == 0 || t.Sreden == 0)
                {
                }
                else
                {
                    tabela2.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen, t.Sreden);
                }
            }

            string[] x = new string[tabela2.Rows.Count];
            double[] y = new double[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                x[i] = tabela2.Rows[i][0].ToString();
                y[i] = Convert.ToDouble(tabela2.Rows[i][5]);
            }


            Chart7.Series["Series1"].Points.DataBindXY(x, y);
            Chart7.Series["Series1"].IsValueShownAsLabel = true;
            Chart7.Series["Series1"].ToolTip = "Датум: #VALX Среден курс на НБРМ: #VALY";
            Chart7.Series["Series1"].Font = new System.Drawing.Font("Helvetica", 12);
            Chart7.Series["Series1"].MarkerSize = 20;
            Chart7.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;

            Chart7.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart7.ChartAreas[0].AxisY.Maximum = Double.NaN;
            Chart7.ChartAreas[0].AxisY.IsStartedFromZero = false;
            Chart7.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 18;
            Chart7.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -10;
            Chart7.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 18;
            Chart7.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Chart7.ChartAreas[0].RecalculateAxesScale();
        }
        public void Load8()
        {
            DataTable tabela2 = new DataTable();
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

            DataColumn k1 = new DataColumn("Датум");
            DataColumn k2 = new DataColumn("Назив на Банка");
            DataColumn k3 = new DataColumn("Валута");
            DataColumn k4 = new DataColumn("Куповен");
            DataColumn k5 = new DataColumn("Среден");
            DataColumn k6 = new DataColumn("Продажен");

            tabela2.Columns.Add(k1);
            tabela2.Columns.Add(k2);
            tabela2.Columns.Add(k3);
            tabela2.Columns.Add(k4);
            tabela2.Columns.Add(k5);
            tabela2.Columns.Add(k6);
            var query2 = from p in collection.AsQueryable<Info>() where p.Valuta == "cad" select p;
            foreach (var t in query2)
            {

                if (t.Date == null || t.Banka.Name == null || t.Valuta == null || t.Kupoven == 0 || t.Prodazen == 0 || t.Sreden == 0)
                {
                }
                else
                {
                    tabela2.Rows.Add(t.Date, t.Banka.Name, t.Valuta, t.Kupoven, t.Prodazen, t.Sreden);
                }
            }

            string[] x = new string[tabela2.Rows.Count];
            double[] y = new double[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                x[i] = tabela2.Rows[i][0].ToString();
                y[i] = Convert.ToDouble(tabela2.Rows[i][5]);
            }


            Chart8.Series["Series1"].Points.DataBindXY(x, y);
            Chart8.Series["Series1"].IsValueShownAsLabel = true;
            Chart8.Series["Series1"].ToolTip = "Датум: #VALX Среден курс на НБРМ: #VALY";
            Chart8.Series["Series1"].Font = new System.Drawing.Font("Helvetica", 12);
            Chart8.Series["Series1"].MarkerSize = 20;
            Chart8.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;

            Chart8.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart8.ChartAreas[0].AxisY.Maximum = Double.NaN;
            Chart8.ChartAreas[0].AxisY.IsStartedFromZero = false;
            Chart8.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 18;
            Chart8.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -10;
            Chart8.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 18;
            Chart8.ChartAreas[0].AxisY.Minimum = Double.NaN;
            Chart8.ChartAreas[0].RecalculateAxesScale();
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

                //if (ViewState["SortExpression"] == null)
                //{
                //    ViewState["SortExpression"] = "Prodazen";
                //}

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
                var query = from p in collection.AsQueryable<Info>() where p.Valuta == "sek" && p.Date == Calendar1.SelectedDate.ToString("dd.MM.yyyy") select p;

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
   
    

