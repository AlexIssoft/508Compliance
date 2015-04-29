<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeFile="ConsumerProfiler.aspx.cs" Inherits="ElectronicDiary.WebUI.ConsumerProfiler" %>



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
              <form class="form-horizontal">
                <fieldset>
                  <legend>Profile</legend>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="FirstName">First Name</label>
                    <div class="col-lg-10">
                      <input type="text" placeholder="First Name" id="FirstName" runat="server" class="form-control">
                    </div>
                  </div>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="LastName">Last Name</label>
                    <div class="col-lg-10">
                      <input type="text" placeholder="Last Name" id="LastName" runat="server" class="form-control">
                    </div>
                  </div>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="inputEmail">Email</label>
                    <div class="col-lg-10">
                      <input type="text" placeholder="Email" id="inputEmail" runat="server" class="form-control">
                    </div>
                  </div>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="BirthDate">Birth Date</label>
                    <div class="col-lg-10">
                      <input type="text" placeholder="Email" id="BirthDate" runat="server" class="form-control">
                    </div>
                  </div>
                  <div class="form-group">
                    <label class="col-lg-2 control-label" for="University">University</label>
                    <div class="col-lg-10">
                      <input type="text" placeholder="Email" id="University" runat="server" class="form-control">
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


