<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>TESTING GETTING TIME UTC </h1>
        <p class="lead">Here, you just to input the time and the time zone to get it into UTC format.</p>
        
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Time (Local Time)
            </h2> <br>
            <asp:TextBox ID="txtLocalTime" runat="server" Height="16px"></asp:TextBox>
            
            <h2>Time Zone</h2><br>
            <asp:TextBox ID="txtTimeZone" runat="server" Height="16px"></asp:TextBox><br>
            <asp:Button ID="Get" runat="server" Height="34px" Text="Get UTC time" OnClick="Get_Click" /><br>
            
            <asp:Label ID="lblUTCtime" runat="server" Text="The UTC Time is: "></asp:Label>
            
        </div>
      
    </div>
</asp:Content>
