<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logowanie.aspx.cs" Inherits="P02AplikacjaZawodnicy.Logowanie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Zaloguj się do naszego serwisu</p>


            <asp:Login ID="Login1" OnAuthenticate="Login1_Authenticate" runat="server"></asp:Login>



        </div>
    </form>
</body>
</html>
