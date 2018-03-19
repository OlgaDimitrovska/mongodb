<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="mongodb.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1036px;
        }
        .auto-style2 {
            height: 201px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    </div>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" style="text-align: right" Width="200px" SelectedDate="03/16/2018 13:43:47">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
        <p>
            &nbsp;</p>
         <table width="80%" align="center">
      <tr>
        <td>
          <asp:Button Text="EUR" BorderStyle="None" ID="Tab1" CssClass="Initial" runat="server"

              OnClick="Tab1_Click" />
          <asp:Button Text="USD" BorderStyle="None" ID="Tab2" CssClass="Initial" runat="server"

              OnClick="Tab2_Click" />
          <asp:Button Text="GBP" BorderStyle="None" ID="Tab3" CssClass="Initial" runat="server"

              OnClick="Tab3_Click" />
          <asp:Button Text="CHF" BorderStyle="None" ID="Tab4" CssClass="Initial" runat="server"

              OnClick="Tab4_Click" />
            <asp:Button Text="SEK" BorderStyle="None" ID="Tab5" CssClass="Initial" runat="server"

              OnClick="Tab5_Click" />
            <asp:Button Text="NOK" BorderStyle="None" ID="Tab6" CssClass="Initial" runat="server"

              OnClick="Tab6_Click" />
            <asp:Button Text="DKK" BorderStyle="None" ID="Tab7" CssClass="Initial" runat="server"

              OnClick="Tab7_Click" />
            <asp:Button Text="CAD" BorderStyle="None" ID="Tab8" CssClass="Initial" runat="server"

              OnClick="Tab8_Click" />
          <asp:MultiView ID="MainView" runat="server">
            <asp:View ID="View1" runat="server" OnLoad="View1_Load">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td class="auto-style1">
                    <h3>
                      <span>View 1</span></h3>
                      <h3><span style="text-align: center">&nbsp;<asp:GridView ID="GridView1" runat="server" style="text-align: left" AllowSorting="True" OnSorting="GridView1_Sorting" >
                          </asp:GridView>
                          </span></h3>
                  </td>
                </tr>
              </table>
            </asp:View>
            <asp:View ID="View2" runat="server" OnLoad="View2_Load">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td class="auto-style2">
                    <h3>
                      View 2
                        <asp:GridView ID="GridView2" runat="server" AllowSorting="True" OnSorting="GridView2_Sorting">
                        </asp:GridView>
                    </h3>
                      <p>
                          &nbsp;</p>
                  </td>
                </tr>
              </table>
            </asp:View>
            <asp:View ID="View3" runat="server" OnLoad="View3_Load">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 3
                       
                        <asp:GridView ID="GridView3" runat="server" AllowSorting="True" OnSorting="GridView3_Sorting">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View4" runat="server" OnLoad="View4_Load">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 4
                        
                        <asp:GridView ID="GridView4" runat="server" AllowSorting="True" OnSorting="GridView4_Sorting">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View5" runat="server" OnLoad="View5_Load">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 5
                        
                        <asp:GridView ID="GridView5" runat="server" AllowSorting="True" OnSorting="GridView5_Sorting">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View6" runat="server" OnLoad="View6_Load">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 6
                        
                        <asp:GridView ID="GridView6" runat="server" AllowSorting="True" OnSorting="GridView6_Sorting">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View7" runat="server" OnLoad="View7_Load">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 7
                       
                        <asp:GridView ID="GridView7" runat="server" AllowSorting="True" OnSorting="GridView7_Sorting">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View8" runat="server" OnLoad="View8_Load">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 8
                        
                        <asp:GridView ID="GridView8" runat="server" AllowSorting="True" OnSorting="GridView8_Sorting">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
          </asp:MultiView>
        </td>
      </tr>
    </table>
    </form>
</body>
</html>
