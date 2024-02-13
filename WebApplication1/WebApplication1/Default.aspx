<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="Cognome" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Registrati" runat="server" Text="Registrati" OnClick="Registrati_Click" />
    </main>

</asp:Content>
