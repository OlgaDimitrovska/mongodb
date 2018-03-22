<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="mongodb.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 1036px;
           
        }
        .auto-style2 {
            height: 201px;
        }
       
    </style>
<link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" /> 
<link rel="stylesheet" href="/resources/demos/style.css" />
<script src="https://code.jquery.com/jquery-1.12.4.js"></script>
<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>   
    <!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
   
       <p></p>
        <div style="width:10%; margin: 0 auto;">
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" Style="text-align: center" Width="100%" SelectedDate="03/16/2018 13:43:47">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
        </div>
        <p></p>
     <table width="50%" align="center" style="background-color:white">
      <tr>
        <td>
           <asp:Button Text="EUR" BorderStyle="None" ID="Tab1" CssClass="Clicked" runat="server"
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
          <asp:MultiView ID="MainView" runat="server" >
            <asp:View ID="View1" runat="server" OnLoad="View1_Load">
              <table class="table-bordered" width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td class="auto-style1">
                    <h3>
                        <span style="text-align: center;">
                        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" OnSorting="GridView1_Sorting" style="text-align: left" >
                        </asp:GridView>
                        </span></h3>
                      <p>
                          <asp:Chart ID="Chart1" runat="server" style="text-align: center" Width="1037px" >
                              <Series>
                                  <asp:Series ChartType="Line" Name="Series1" BorderWidth="4">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                  <%--<AxisY  LabelAutoFitMaxFontSize="18"> </AxisY>--%>
                                  <%--<AxisX  LabelAutoFitMaxFontSize="18" > </AxisX>--%>
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </p>
                  </td>
                </tr>
              </table>
            </asp:View>
            <asp:View ID="View2" runat="server" OnLoad="View2_Load">
              <table  class="table-bordered" style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td class="auto-style2">
                      <h3>
                          <asp:GridView ID="GridView2" runat="server" AllowSorting="True" OnSorting="GridView2_Sorting">
                          </asp:GridView>
                      </h3>
                      <p>
                          <asp:Chart ID="Chart2" runat="server" style="text-align: center" Width="1037px">
                              <Series>
                                  <asp:Series ChartType="Line" Name="Series1" BorderWidth="4" >
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                      <AxisY  LabelAutoFitMaxFontSize="18"> </AxisY>
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </p>
                  </td>
                </tr>
              </table>
            </asp:View>
            <asp:View ID="View3" runat="server" OnLoad="View3_Load">
              <table class="table-bordered" style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                       
                        <asp:GridView ID="GridView3" runat="server" AllowSorting="True" OnSorting="GridView3_Sorting">
                        </asp:GridView>
                    </h3>
                      <p>
                          <asp:Chart ID="Chart3" runat="server" style="text-align: center" Width="1037px">
                              <Series>
                                  <asp:Series ChartType="Line" Name="Series1">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                      <%--<AxisY  Minimum="Double.NaN" Maximum="Double.NaN"> </AxisY>--%>
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </p>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View4" runat="server" OnLoad="View4_Load">
              <table class="table-bordered" style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                        
                        <asp:GridView ID="GridView4" runat="server" AllowSorting="True" OnSorting="GridView4_Sorting">
                        </asp:GridView>
                    </h3>
                      <p>
                          <asp:Chart ID="Chart4" runat="server" style="text-align: center" Width="1037px">
                              <Series>
                                  <asp:Series ChartType="Line" Name="Series1">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                      <%--<AxisY  Minimum="Double.NaN" Maximum="Double.NaN"> </AxisY>--%>
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </p>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View5" runat="server" OnLoad="View5_Load">
              <table class="table-bordered" style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                        
                        <asp:GridView ID="GridView5" runat="server" AllowSorting="True" OnSorting="GridView5_Sorting">
                        </asp:GridView>
                    </h3>
                      <p>
                          <asp:Chart ID="Chart5" runat="server" style="text-align: center" Width="1037px">
                              <Series>
                                  <asp:Series ChartType="Line" Name="Series1">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                      <%--<AxisY  Minimum="Double.NaN" Maximum="Double.NaN"> </AxisY>--%>
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </p>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View6" runat="server" OnLoad="View6_Load">
              <table class="table-bordered" style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                        
                        <asp:GridView ID="GridView6" runat="server" AllowSorting="True" OnSorting="GridView6_Sorting">
                        </asp:GridView>
                    </h3>
                      <p>
                          <asp:Chart ID="Chart6" runat="server" style="text-align: center" Width="1037px">
                              <Series>
                                  <asp:Series ChartType="Line" Name="Series1">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                      <%--<AxisY  Minimum="Double.NaN" Maximum="Double.NaN"> </AxisY>--%>
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </p>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View7" runat="server" OnLoad="View7_Load">
              <table class="table-bordered" style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                       
                        <asp:GridView ID="GridView7" runat="server" AllowSorting="True" OnSorting="GridView7_Sorting">
                        </asp:GridView>
                    </h3>
                      <p>
                          <asp:Chart ID="Chart7" runat="server" style="text-align: center" Width="1037px">
                              <Series>
                                  <asp:Series ChartType="Line" Name="Series1">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                      <%--<AxisY  Minimum="Double.NaN" Maximum="Double.NaN"> </AxisY>--%>
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </p>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View8" runat="server" OnLoad="View8_Load">
              <table class="table-bordered" style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                        
                        <asp:GridView ID="GridView8" runat="server" AllowSorting="True" OnSorting="GridView8_Sorting">
                        </asp:GridView>
                    </h3>
                      <p>
                          <asp:Chart ID="Chart8" runat="server" style="text-align: center" Width="1037px">
                              <Series>
                                  <asp:Series ChartType="Line" Name="Series1">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                      <%--<AxisY  Minimum="Double.NaN" Maximum="Double.NaN"> </AxisY>--%>
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                      </p>
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
