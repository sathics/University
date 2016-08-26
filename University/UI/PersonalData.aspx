<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalData.aspx.cs" Inherits="University.UI.PersonalData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            color: #66FF99;
        }
        .auto-style3 {
            width: 237px;
        }
        .auto-style4 {
            width: 237px;
            height: 22px;
        }
        .auto-style5 {
            height: 22px;
        }
    </style>
      <link rel="stylesheet" href="//code.jquery.com/ui/1.12.0/themes/base/jquery-ui.css"/>
  <link rel="stylesheet" href="/resources/demos/style.css"/>
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.0/jquery-ui.js"></script>

      <script>
          $(function () {
              $("#datepicker").datepicker();
          });
  </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 553px; width: 685px; margin-left: 107px; margin-top: 28px">
    
        <table class="auto-style1">
            <tr>
                <td>
                    <h1 class="auto-style2">Personal Information</h1>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">First Name</td>
                <td>
                    <asp:TextBox ID="firstNameTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Last Name</td>
                <td class="auto-style5">
                    <asp:TextBox ID="lastNameTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Father Name</td>
                <td>
                    <asp:TextBox ID="fatherNameTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Mother Name</td>
                <td>
                    <asp:TextBox ID="motherNameTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Date Of Birth</td>
                <td>
                    <asp:TextBox ID="datepicker" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Mobile No</td>
                <td>
                    <asp:TextBox ID="mobileNumberTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Village</td>
                <td>
                    <asp:TextBox ID="villageNameTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Thana</td>
                <td>
                    <asp:TextBox ID="thanaNameTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">District</td>
                <td>
                    <asp:TextBox ID="districtNameTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Country</td>
                <td>
                    <asp:DropDownList ID="countryNameDropDownList" runat="server" Height="16px" Width="209px">
                        <asp:ListItem Value="Bangladesh"></asp:ListItem>
                        <asp:ListItem Value="India"></asp:ListItem>
                        <asp:ListItem Value="London"></asp:ListItem>
                        <asp:ListItem Value="America"></asp:ListItem>
                        <asp:ListItem Value="Australia"></asp:ListItem>
                        <asp:ListItem Value="Canada"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" Width="75px" />
                    <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" style="margin-left: 60px" Text="Show All Information" />
                </td>
            </tr>
        </table>
    
        <asp:Label ID="messageLabel" runat="server" Text="Message"></asp:Label>
        <br />
        <asp:GridView ID="personalInformationGridView" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
