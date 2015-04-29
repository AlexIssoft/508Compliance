<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ConsumerProfiler.aspx.cs" Inherits="ElectronicDiary.WebUI.ConsumerProfiler" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="bs-docs-section">
        <div class="row">
          <div class="col-lg-12">
            <div class="page-header">
              <h1 id="forms">Consumer Profiler</h1>
            </div>
          </div>
        </div>

        <div class="row">
          <div class="col-lg-6">
            <div class="well bs-component">
              <form class="form-horizontal" runat="server">
                <fieldset>
                  <legend>Profile</legend>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="FirstName">First Name</label>
                    <div class="col-lg-10 has-error">
                            <asp:TextBox ID="FirstName" ClientIDMode="Static" runat="server" placeholder="First Name"  CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFirstNameValidator" CssClass="control-label" runat="server" ErrorMessage="First Name is required." ControlToValidate="FirstName" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                  </div>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="LastName">Last Name</label>
                    <div class="col-lg-10  has-error">
                        <asp:TextBox ID="LastName" ClientIDMode="Static" runat="server" placeholder="Last Name"  CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredLastNameValidator" CssClass="control-label" runat="server" ErrorMessage="Last Name is required." ControlToValidate="LastName" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                  </div>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="Email">Email</label>
                    <div class="col-lg-10  has-error">
                         <asp:TextBox ID="Email" ClientIDMode="Static" runat="server" placeholder="Email"  CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredEmailValidator" CssClass="control-label" runat="server" ErrorMessage="Email is required." ControlToValidate="Email" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionEmailValidator" runat="server" ErrorMessage="Email is wrong" ControlToValidate="Email" CssClass="control-label" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </div>
                  </div>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="BirthDate">Birth Date</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="BirthDate" ClientIDMode="Static" runat="server" placeholder="BirthDate"  CssClass="form-control"></asp:TextBox>
                    </div>
                  </div>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="University">University</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="University" ClientIDMode="Static" runat="server" placeholder="University"  CssClass="form-control"></asp:TextBox>
                    </div>
                  </div>

                  <div class="form-group">
                    <div class="col-lg-10 col-lg-offset-2">
                      <button class="btn btn-default" type="reset">Cancel</button>
                      <button class="btn btn-primary" type="submit">Submit</button>
                    </div>
                  </div>
                </fieldset>
              </form>
            <div class="btn btn-primary btn-xs" id="source-button" style="display: none;">&lt; &gt;</div></div>
          </div>
         
        </div>
      </div>


</asp:Content>


