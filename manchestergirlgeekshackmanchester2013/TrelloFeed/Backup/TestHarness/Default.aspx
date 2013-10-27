<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TestHarness._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
       Test Harness for Trello Feed
    </h2>
    <p />
    <asp:TextBox id="Results" 
    TextMode="MultiLine"
    ReadOnly="true"
    runat="server"/>    
    <p>
      <asp:Button id="Test"
           Text="Submit"
           OnClick="SubmitBtn_Click" 
           runat="server"/>
     </p>
</asp:Content>
