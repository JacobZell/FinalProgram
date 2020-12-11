<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Comment.aspx.cs" Inherits="FinalProject3.Comments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;<asp:GridView ID="GridView1" runat="server" DataSourceID="CommentDataSource" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataKeyNames="Id" style="margin-top: 0px" BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" ForeColor="Black" GridLines="Horizontal">
        <Columns>
            <asp:BoundField DataField="Comment" HeaderText="Comment" SortExpression="Comment" />
            <asp:BoundField DataField="TopicId" HeaderText="TopicId" SortExpression="TopicId" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
        </Columns>
    </asp:GridView>
            &nbsp;
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update Comment" Width="145px" />
    <br />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete Comment" />
    <br />
    &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Comment" Width="145px" />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="111px" Width="522px" MaxLength="500"></asp:TextBox>
    <br />
    <br />
<br />
            <br />
            <asp:SqlDataSource ID="Commentdatasource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Comment], [TopicId], [Id], [Username] FROM [Comment]"></asp:SqlDataSource>
        </asp:Content>
