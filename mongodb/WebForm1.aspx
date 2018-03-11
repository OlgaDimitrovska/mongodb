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
          <asp:Button Text="Tab 1" BorderStyle="None" ID="Tab1" CssClass="Initial" runat="server"

              OnClick="Tab1_Click" />
          <asp:Button Text="Tab 2" BorderStyle="None" ID="Tab2" CssClass="Initial" runat="server"

              OnClick="Tab2_Click" />
          <asp:Button Text="Tab 3" BorderStyle="None" ID="Tab3" CssClass="Initial" runat="server"

              OnClick="Tab3_Click" />
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
                    </h3>
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
