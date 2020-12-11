<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CreateTopic.aspx.cs" Inherits="FinalProject3.Webforms.CreateTopic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="TopicGridView" runat="server" DataSourceID="Topicdatasource" Width="910px" AutoGenerateColumns="False" BackColor="#999999" BorderColor="Black" BorderStyle="Groove" BorderWidth="8px" Font-Names="Georgia" ForeColor="Black" GridLines="Horizontal" AutoGenerateSelectButton="True" DataKeyNames="Id">
            <Columns>
                <asp:BoundField DataField="Topic" HeaderText="Topic" SortExpression="Topic" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            </Columns>
            <SelectedRowStyle BackColor="#6600CC" />
    </asp:GridView>
    <br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Topic" Width="197px" />
    &nbsp;<asp:TextBox ID="TopicNametxt" runat="server" MaxLength="50"></asp:TextBox>
<br />
    <br />
    &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update Selected Topic" />
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="20px" style="margin-top: 0px"></asp:TextBox>
            <br />
<br />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete Selected Topic" Width="197px" />
    <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Please Select a Topic!" Visible="False"></asp:Label>
    <asp:SqlDataSource ID="Topicdatasource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Topic]"></asp:SqlDataSource>
</asp:Content>
