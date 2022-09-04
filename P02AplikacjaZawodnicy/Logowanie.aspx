<%@ Page Title="" Language="C#" MasterPageFile="~/Glowna.Master" AutoEventWireup="true" CodeBehind="Logowanie.aspx.cs" Inherits="P02AplikacjaZawodnicy.Logowanie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="podstrona" runat="server">

    
          <asp:Login ID="Login1" OnAuthenticate="Login1_Authenticate" runat="server"></asp:Login>
   

  


</asp:Content>
