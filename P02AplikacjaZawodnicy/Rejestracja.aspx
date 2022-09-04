<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Glowna.Master" CodeBehind="Rejestracja.aspx.cs" Inherits="P02AplikacjaZawodnicy.Rejestracja" %>


<asp:Content ID="Content1" ContentPlaceHolderID="podstrona" runat="server">

    <form runat="server" style="margin-top:40px">
           <asp:CreateUserWizard OnCreatedUser="CreateUserWizard1_CreatedUser" OnContinueButtonClick="CreateUserWizard1_ContinueButtonClick" ID="CreateUserWizard1" runat="server">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
    </form>

  


</asp:Content>



 