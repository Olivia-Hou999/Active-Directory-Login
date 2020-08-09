<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginem.aspx.cs" Inherits="ADlogin.loginem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href='CSS/bootstrap.min.3.3.7.css' rel="stylesheet" type="text/css" />
    <link href='CSS/font-awesome.min.css' rel="stylesheet" type="text/css" />
    <link href='CSS/Mylogin.css' rel="stylesheet" type="text/css" />
     <style type="text/css">
        ul li {
                list-style: outside none none;
                margin:10px 10px;
        }
        .alertmsg {
            color:red;
        }
         .clip {
                 margin-left: 30px;
         }
         .track-number-btn {
             width:42%;
             margin:0 10px;
         }
         #btn_EmployeeLogin {
             padding:0;
         }
         #btn_login {
             background-color:#808285;
         }
    </style>
    <script src="JS/jquery-1.7.2.min.js" type="text/javascript" ></script>
    <script type="text/javascript" src="JS/bootstrap.min.3.3.7.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-content" style="max-width:1680px;text-align:center;margin-top:100px;width:100%;margin:100px auto;">
     <div class="col-lg-4"></div>
     <div class="col-lg-4">
         <div class="login_panel" >
            <ul>
                <li>
                    <img src="./images/logo.jpg" alt="" style="width:241px;height:118px;" />
                </li>
                <li>
                     <div style="width:100%;background-color:white;border-radius:6px;height:36px;">
                         <i class="fa fa-envelope"></i>
                         <input id="inp_username" type="text" name="username" class="track-number" placeholder="Please enter your username！"  runat="server"/>
                                             
                    </div>
                    <%--<div>
                        <span>Username:</span>
                        <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
                    </div>--%>
                </li>
                  <li>
                      <div style="width:100%;background-color:white;border-radius:6px;height:36px;font-size: 18px;">
                        <i class="fa fa-lock"></i>
                        <input id="pwd" type="password" name="password" class="track-number" placeholder="Please enter your password！"  runat="server" />
                    </div>
                   <%-- <div>
                        <span>Password:</span>
                        <asp:TextBox ID="txt_password" TextMode="Password" runat="server"></asp:TextBox>
                    </div>--%>
                </li>
                 <li>
                    <div>
                         <div style="width:100%;background-color:white;border-radius:6px;height:36px;font-size: 14px;">
                            <i class="fa fa-magnet"></i>
                            <input id="myDomain" type="text" name="myDomain" class="track-number" placeholder="kerrylogistics.com"  runat="server" value="kerrylogistics.com" readonly="readonly" />
                        </div>
                      <%--  <span>My Domain:</span>
                        <asp:TextBox ID="txt_Domain" runat="server"></asp:TextBox>--%>
                    </div>
                </li>
                <li style="margin:0px;">
                     <div style="" class="remember">
                        <asp:CheckBox ID="chk_remember" runat="server" Text="Remember Me" />
                     </div>
                </li>
                <li  style="display:none;">
                    <asp:Label ID="lbl_msg" runat="server" Text="" CssClass="alertmsg"></asp:Label>
                </li>
                <li>
                    <div>
                      
                        <asp:Button ID="btn_EmployeeLogin" runat="server" Text="Employee Login" OnClick="btn_EmployeeLogin_Click"  CssClass="btn btn-default track-number-btn" />
                        <asp:Button ID="btn_Login" runat="server" Text="Return" OnClick="btn_Login_Click"    CssClass="btn btn-default track-number-btn " />
                    </div>
                </li>
            </ul>
         </div>
     </div>
     <div class="col-lg-4">

     </div>

     <%--<div class="col-lg-12">
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
