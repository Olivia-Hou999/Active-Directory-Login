<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserWeb.aspx.cs" Inherits="ADlogin.UserWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href='CSS/bootstrap.min.3.3.7.css' rel="stylesheet" type="text/css" />
    <link href='CSS/mystyle.css' rel="stylesheet" type="text/css" />
    <link href='CSS/Mylogin.css' rel="stylesheet" type="text/css" />

    <style type="text/css">
        body{

            /*background: url("./images/iStock-466994392.jpg") no-repeat;*/

            height:100%;

            width:100%;

            overflow: hidden;

            background-size:cover;/*或者background-size:100%;*/

            }
        ul li {
                list-style: outside none none;
                margin:10px 10px;
        }
        .lg_usermail {
            margin-top:20px;
        }

        .welcome {
            font-size: 18px !important;
            color: #ff6633;
            padding: 10px;
            line-height: 12px;
            /*margin-top:10px;*/
            font-weight:600px;
        }
        .exit {
            float: right !important;
            margin-right: 35px;
        }
            /*.exit a, a:link {
                color: #ffffff;
                text-decoration: none;
                background-color: transparent;
            }*/


    </style>
    <script src="JS/jquery-1.7.2.min.js" type="text/javascript" ></script>    
    <script type="text/javascript" src="JS/bootstrap.min.3.3.7.js"></script>
</head>
<body >
    <form id="form1" runat="server">
        <div class="container-content" style="min-width:1680px;text-align:center;margin-top:0px;">
                 <div class="col-lg-12" style="height:90px;width:100%;background-color:black;color:white;margin-top:0px;z-index:999;text-align:left; line-height:30px;">
                           <div class="col-lg-4">
                                 <img src="./images/KLNL-Bilingual_orange-white-72dpi.png" width="281" style="    margin: 16px 0px;margin-left:150px;" />
                           </div>
                             <div class="col-lg-4">
                             </div>
                           <div class="col-lg-4">
                               <asp:LinkButton ID="lb_exit" runat="server" OnClick="lb_exit_Click" CssClass="nav_a"  >Sign out</asp:LinkButton>
                            </div>

                  </div>
        
                 <div class="col-lg-4"></div>
                 <div class="col-lg-4" style="margin-top:40px;">
                      <div class="welcome" >
                          Welcome：<asp:Label ID="lbl_username" runat="server" Text=""></asp:Label>
                       
                        </div>
                        <div  class="welcome">
                             Your account has been successfully logged in.
                        </div>
                 </div>
                 <div class="col-lg-4"></div>
                   
               <div class="col-lg-12">
                <footer>
                    <div class="container_foot">
                        <img src="/images/logo-footer.png"/>
                        <div class="pull-right pure-visible-desktop">
                            <ul class="nav-item-column-style">
                                <li><a href="https://kerrylogistics.com" target="_blank">Head Office</a></li>
                                <li><a href="http://www.kerrylogistics.com.au/our-company/terms-and-conditions">T &amp; C</a></li>
                                <li><a href="http://www.kerrylogistics.com.au/contact">Contact</a></li>
                                <li><a href="https://simple.com.au" target="_blank">Website by Simple</a></li>
                                <li class="divider-vertical"></li>
                            </ul>
                        </div>
                        <%--<div class="pure-hidden-desktop">
                            <ul class="nav-item-row-style">
                                <li><a href="https://kerrylogistics.com" target="_blank">Head Office</a></li>
                                <li><a href="https://simple.com.au" target="_blank">Website by Simple</a></li>
                                <li></li>
                            </ul>
                        </div>--%>
                    </div>
                </footer>
            </div>     
          </div>
    </form>
</body>
</html>
