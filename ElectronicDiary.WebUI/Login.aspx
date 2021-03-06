﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Authorization.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ElectronicDiary.WebUI.Login" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="center-block">
            <div class="col-lg-6">
                <div class="well bs-component">
                    <form class="form-horizontal">
                        <fieldset>
                            <legend>Login</legend>
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
                                    <div class="checkbox">
                                        <label>
                                            <asp:CheckBox ID="SaveMe" runat="server"/>
                                            Keep me logged in
                                        </label>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="Msg" runat="server"></asp:Label>
                            </div>
                            <div class="form-group">
                                <a href="Registration.aspx">Registration</a>
                            </div>
                            <div class="form-group">
                                <div class="col-lg-10 col-lg-offset-2">
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