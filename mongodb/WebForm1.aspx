<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="mongodb.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
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
            <asp:View ID="View1" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      <span>View 1</span></h3>
                      <h3><span style="text-align: center">&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                          <asp:GridView ID="GridView1" runat="server" style="text-align: left">
                          </asp:GridView>
                          <asp:Chart ID="Chart1" runat="server">
                              <Series>
                                  <asp:Series Name="Series1">
                                  </asp:Series>
                              </Series>
                              <ChartAreas>
                                  <asp:ChartArea Name="ChartArea1">
                                  </asp:ChartArea>
                              </ChartAreas>
                          </asp:Chart>
                          </span></h3>
                  </td>
                </tr>
              </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 2
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                    </h3>
                      <p>
                          &nbsp;</p>
                  </td>
                </tr>
              </table>
            </asp:View>
            <asp:View ID="View3" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 3
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
                        <asp:GridView ID="GridView3" runat="server">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View4" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 4
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
                        <asp:GridView ID="GridView4" runat="server">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View5" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 5
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
                        <asp:GridView ID="GridView5" runat="server">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View6" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 6
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Button" />
                        <asp:GridView ID="GridView6" runat="server">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View7" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 7
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Button" />
                        <asp:GridView ID="GridView7" runat="server">
                        </asp:GridView>
                    </h3>
                  </td>
                </tr>
              </table>
            </asp:View>
              <asp:View ID="View8" runat="server">
              <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                <tr>
                  <td>
                    <h3>
                      View 8
                        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Button" />
                        <asp:GridView ID="GridView8" runat="server">
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
