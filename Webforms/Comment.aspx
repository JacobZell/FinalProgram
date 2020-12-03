<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Comment.aspx.cs" Inherits="FinalProject3.Comments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete Comment" />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Comment" />
    <asp:TextBox ID="TextBox1" runat="server" Height="111px" Width="522px"></asp:TextBox>
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update Comment" />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="CommentDataSource" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataKeyNames="Id">
        <Columns>
            <asp:BoundField DataField="Comment" HeaderText="Comment" SortExpression="Comment" />
            <asp:BoundField DataField="TopicId" HeaderText="TopicId" SortExpression="TopicId" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        </Columns>
    </asp:GridView>
            <br />
            <asp:SqlDataSource ID="Commentdatasource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Comment], [TopicId], [Id] FROM [Comment]"></asp:SqlDataSource>
        </asp:Content>
