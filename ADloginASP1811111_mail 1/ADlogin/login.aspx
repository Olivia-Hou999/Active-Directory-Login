<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ADlogin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href='CSS/bootstrap.min.3.3.7.css' rel="stylesheet" type="text/css" />
     <link href='CSS/font-awesome.min.css' rel="stylesheet" type="text/css" />
    <link href='CSS/Mylogin.css' rel="stylesheet" type="text/css" />
    

    <script src="JS/jquery-1.7.2.min.js" type="text/javascript" ></script>
   <script type="text/javascript" src="JS/bootstrap.min.3.3.7.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-content" style="max-width:1680px;text-align:center;margin-top:100px;margin:100px auto;">
     <div class="col-lg-4"></div>
     <div class="col-lg-4">
         <div class="login_panel" style="">
            <ul>
                <li>
                    <img src="./images/logo.jpg" alt="" style="width:241px;height:118px;" />
                </li>
                <li>
                    <div style="width:100%;background-color:white;border-radius:6px;height:36px;">
                         <i class="fa fa-envelope"></i>
                         <input id="inp_username" type="text" name="username" class="track-number" placeholder="Please enter a valid email address！"  runat="server"/>
                                             
                    </div>
                </li>
                  <li>
                    <div style="width:100%;background-color:white;border-radius:6px;height:36px;font-size: 18px;">
                        <i class="fa fa-lock"></i>
                        <input id="pwd" type="password" name="password" class="track-number" placeholder="Please enter your password！"  runat="server" />
                        
                      
                    </div>
                </li>
               <%--  <li>
                    <div>
                        <span>My Domain:</span>
                        <asp:TextBox ID="txt_Domain" runat="server"></asp:TextBox>
                    </div>
                </li>--%>
                <li style="margin:0px;">
                    <div style="" class="remember">
                         <asp:CheckBox ID="chk_remember" runat="server" Text="Remember Me" />
                    </div>
                   
                </li>
                <li style="">
                    <asp:Label ID="lbl_msg" runat="server" Text=""></asp:Label>
                </li>
                <li>
                    <div>
                        <asp:Button ID="btn_Login" runat="server" Text="Login" OnClick="btn_Login_Click"  CssClass="btn btn-default track-number-btn org-btn"/>
                        <%--<asp:Button ID="btn_EmployeeLogin" runat="server" Text="Employee Login" OnClick="btn_EmployeeLogin_Click" />--%>
                    </div>
                </li>
               
            </ul>
           
         </div>
           <div style="margin-bottom:5px;margin-top:30px;">
                 Welcome to  <a href="loginem.aspx" target=""  title="employee login">Employee login</a> 
     </div>
     <div class="col-lg-4">

     </div>

       <%-- <div class="col-lg-12">
            <footer>
                <div class="container_foot">
                    <img src="/images/logo-footer.png">
                    <div class="pull-right pure-visible-desktop">
                        <ul class="nav-item-column-style">
                            <li><a href="https://kerrylogistics.com" target="_blank">Head Office</a></li>
                            <li><a href="http://www.kerrylogistics.com.au/our-company/terms-and-conditions">T &amp; C</a></li>
                            <li><a href="http://www.kerrylogistics.com.au/contact">Contact</a></li>
                            <li><a href="https://simple.com.au" target="_blank">Website by Simple</a></li>
                            <li class="divider-vertical"></li>
                        </ul>
                    </div>
                   
                </div>
            </footer>
        </div>--%>

    </div>
    </form>

    
</body>
</html>
