<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TopicsMaster.aspx.cs" Inherits="FinalProject3.Webforms.TopicsMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:SqlDataSource ID="Topicdatasource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Topic]"></asp:SqlDataSource>
            <asp:GridView ID="TopicGridView" runat="server" DataSourceID="Topicdatasource" Width="910px" AutoGenerateColumns="False" BackColor="#999999" BorderColor="Black" BorderStyle="Solid" BorderWidth="8px" Font-Names="Georgia" ForeColor="Black" GridLines="Horizontal" AutoGenerateSelectButton="True" DataKeyNames="Id" OnSelectedIndexChanged="TopicGridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Topic" HeaderText="Topic" SortExpression="Topic" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            </Columns>
            <SelectedRowStyle BackColor="#6600CC" />
    </asp:GridView>
</asp:Content>
