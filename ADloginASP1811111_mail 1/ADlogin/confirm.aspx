<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="ADlogin.confirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href='CSS/bootstrap.min.3.3.7.css' rel="stylesheet" type="text/css" />
    <style type="text/css">
        ul li {
                list-style: outside none none;
                margin:10px 10px;
        }
        .lg_usermail {
            margin-top:20px;
        }
    </style>

    <script src="js/jquery-1.7.2.min.js" type="text/javascript" ></script>    
    <script type="text/javascript" src="js/bootstrap.min.3.3.7.js"></script>
</head>
<body>
    <form id="form1" runat="server">
     <div class="container-content" style="min-width:1680px;text-align:center;margin-top:100px;">
        <div class="col-lg-4">

         </div>
         <div class="col-lg-4">
             <ul>
                 <li>
                     please input the code:<asp:TextBox ID="txt_regcode" runat="server"></asp:TextBox>
                 </li>
                 <li>
                     <asp:Button ID="btn_active" runat="server" Text="Active"  OnClick="btn_active_Click" />
                 </li>
             </ul>
             

         </div>
         <div class="col-lg-4">
         </div>
     </div>
    </form>
</body>
</html>
