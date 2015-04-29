<%@ Page Language="C#" MasterPageFile="~/Master.Master" EnableViewState="true" CodeFile="Lessons.aspx.cs" CodeBehind="Lessons.aspx.cs" Inherits="ElectronicDiary.WebUI.Lessons" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bs-docs-section">
        <asp:CheckBoxList ID="CheckBoxListLessons" ViewStateMode="Enabled" runat="server">
        </asp:CheckBoxList>
        <asp:Button ID="ChangeListLessonsBtn" runat="server" OnClick="ChangeListLessonsBtn_Click" Text="Update list" />
    </div>
</asp:Content>

