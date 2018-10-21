<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Admin.Master"
    CodeBehind="Default.aspx.cs" Inherits="FMS._Default" %>

<asp:Content ID="ContentPlaceHolder1" ContentPlaceHolderID="ContentPlaceHolder1"
    runat="Server">
    <div>
        <table style="width:100">
            <tr>
                <td style="width:100">
                    <asp:Label ID="lblmsg" runat="server" Font-Bold="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width:100">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td style="width:100">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
