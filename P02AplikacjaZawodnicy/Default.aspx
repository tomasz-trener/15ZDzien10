<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Glowna.Master"  CodeBehind="Default.aspx.cs" Inherits="P02AplikacjaZawodnicy.Default" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="podstrona" runat="server">

        <div class="row">

            <div id="dvLadowanie" style="display:none">
                <img src="https://johnjorgenson.com/wp-content/uploads/2018/05/colorful-loader-gif-transparent.gif" style="width:300px; margin-top:50px" />
            </div>


          <div class="col-md-12">
        
            <%-- <p style="margin-top:60px">Loading...</p> --%>
             <%-- <img src="https://johnjorgenson.com/wp-content/uploads/2018/05/colorful-loader-gif-transparent.gif" style="width:300px; margin-top:50px" />--%>


          </div>
         
        </div>
       
     
  </asp:Content>


 <asp:Content ID="Content2" ContentPlaceHolderID="WlasneSkrypty" runat="server">
     <script src="DefaultJS.js"></script>

  </asp:Content>




 