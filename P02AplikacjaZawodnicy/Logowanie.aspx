<%@ Page Title="" Language="C#" MasterPageFile="~/Glowna.Master" AutoEventWireup="true" CodeBehind="Logowanie.aspx.cs" Inherits="P02AplikacjaZawodnicy.Logowanie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="podstrona" runat="server">

    <form runat="server" style="margin-top:40px">
          <asp:Login ID="Login1" OnAuthenticate="Login1_Authenticate" runat="server"></asp:Login>
    </form>

  


</asp:Content>
