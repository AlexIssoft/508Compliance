<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Authorization.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ElectronicDiary.WebUI.Registration" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="center-block">
            <div class="col-lg-6">
                <div class="well bs-component">
                    <form class="form-horizontal">
                        <fieldset>
                            <legend>Registration</legend>
                            <div class="form-group">
                                <label class="col-lg-3 control-label">User Name</label>
                                <div class="col-lg-9">
                                    <asp:TextBox ID="UserName" runat="server" placeholder="User Name" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameValidator" runat="server" ErrorMessage="User Name is required."
                                        ControlToValidate="UserName" Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-lg-3 control-label">Password</label>
                                <div class="col-lg-9">
                                    <asp:TextBox ID="Password" TextMode="Password" runat="server" placeholder="Password" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredPasswordValidator" runat="server" ErrorMessage="Password is required."
                                        ControlToValidate="Password" Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-lg-3 control-label">Email Address</label>
                                <div class="col-lg-9">
                                    <asp:TextBox ID="EmailAddress" runat="server" placeholder="Email Address" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="EmailAddressValidator" runat="server" ErrorMessage="Email Address is required."
                                        ControlToValidate="EmailAddress" Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                    <asp:CustomValidator ID="EmailAddressHasValidFormat" runat="server" Display="Static" ControlToValidate="EmailAddress"
                                        ErrorMessage="Please specify a valid email address." OnServerValidate="EmailAddrHasValidFormat_ServerValidate"></asp:CustomValidator>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Msg" runat="server"></asp:Label>
                            </div>
                            <div class="form-group">
                                <div class="col-lg-10 col-lg-offset-2">
                                    <button class="btn btn-default" type="reset">Cancel</button>
                                    <asp:Button ID="formSubmit" runat="server" Text="Submit" class="btn btn-primary" OnClick="formSubmit_Click"></asp:Button>
                                </div>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
