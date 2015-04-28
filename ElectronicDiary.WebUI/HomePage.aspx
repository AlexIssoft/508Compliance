<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ElectronicDiary.WebUI.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:label id="lblFile" runat="server">Wired Commute Enrollment Confirmation</asp:label>
     <asp:Button ID="btnSubmit" Runat="server" Text="Submit" OnClick="btnSubmit_Click"></asp:Button>
</asp:Content>
