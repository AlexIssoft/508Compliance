<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeFile="AddLesson.aspx.cs" Inherits="ElectronicDiary.WebUI.AddLesson" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bs-docs-section">

        <div class="row">
          <div class="col-lg-12">
            <h2>Wells</h2>
          </div>
        </div>
        <div class="row">
          <div class="col-lg-4">
            <div class="bs-component">
              <div class="well">
                Look, I'm in a well!
              </div>
            <div class="btn btn-primary btn-xs" id="source-button" style="display: none;">&lt; &gt;</div></div>
          </div>
          <div class="col-lg-4">
            <div class="bs-component">
              <div class="well well-sm">
                Look, I'm in a small well!
              </div>
            </div>
          </div>
          <div class="col-lg-4">
            <div class="bs-component">
              <div class="well well-lg">
                Look, I'm in a large well!
              </div>
            </div>
          </div>
        </div>
      </div>

</asp:Content>

