<%@ Import Namespace="SamenSterker" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DebugPaginaMaëthé.aspx.cs" Inherits="SamenSterker.DebugPaginaMaëthé" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <% try
           {
               DBConnection conn = DBConnection.getInstance();
               conn.GetTable("Company");
           }
           catch (Exception e)
           {
               Response.Write(e.Message);
           }
           
             %>
    
    </div>
    </form>
</body>
</html>
