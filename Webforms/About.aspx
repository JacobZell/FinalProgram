<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FinalProject3.Webforms.HomeMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
</asp:Login>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Account" />
</asp:Content>
