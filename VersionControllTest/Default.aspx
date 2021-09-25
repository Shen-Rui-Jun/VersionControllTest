<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VersionControllTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%
        System.Reflection.Assembly assembly = typeof(VersionControllTest.SiteMaster).Assembly;
        System.Diagnostics.FileVersionInfo fileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

        var versionText = assembly.GetName().Version;
        var fileVersionText = fileVersion.FileVersion;
        var productVersion = fileVersion.ProductVersion;

    %>
    <p>&copy; Assembly Version. : <%= versionText %></p>
    <p>&copy; Assembly File Version : <%= fileVersionText %></p>
    <p>&copy; Assembly Informational Version : <%= productVersion %></p>

</asp:Content>
