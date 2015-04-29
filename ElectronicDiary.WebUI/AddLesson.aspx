<%@ Page Language="C#" MasterPageFile="~/Master.Master" EnableViewState="true" CodeFile="AddLesson.aspx.cs" CodeBehind="AddLesson.aspx.cs" Inherits="ElectronicDiary.WebUI.AddLesson" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="bs-docs-section">
        <asp:Panel ID="Panel1" runat="server" GroupingText="Selected lessons">
            <asp:CheckBoxList ID="CheckBoxListConsumerLessons" runat="server">
            </asp:CheckBoxList>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" GroupingText="Unselected lessons">
            <asp:CheckBoxList ID="CheckBoxListUnselectedLessons" runat="server">
            </asp:CheckBoxList>
        </asp:Panel>
        <asp:Button ID="ChangeListLessonsBtn" runat="server" OnClick="ChangeListLessonsBtn_Click" Text="Save" />
    </div>
    </form>
</asp:Content>

