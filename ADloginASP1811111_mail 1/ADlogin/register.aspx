<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ADlogin.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Eployee Login</title>
    
    <link href='CSS/bootstrap.min.3.3.7.css' rel="stylesheet" type="text/css" />
    <link href='CSS/mystyle.css' rel="stylesheet" type="text/css" />
   <link href='CSS/Mylogin.css' rel="stylesheet" type="text/css" />
    <script src="JS/jquery-1.7.2.min.js" type="text/javascript" ></script>    
    <script type="text/javascript" src="JS/bootstrap.min.3.3.7.js"></script>
</head>
<body>
    <form id="form1" runat="server">

      <div class="container-content" style="min-width:1280px;text-align:center;margin-top:0px;">
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
        
            <div class="col-lg-4">

             </div>
            <div  class="col-lg-4" style="margin-top:40px;"> 

                 <div class="password-form">

                    <ul>
                     <li>
                        <div style="width:100%;text-align:center;">
                            <div style="width:40%;float:left;"><label>
                                   Welcome employee:
                                </label></div>
                            <div style="width:50%;float:left;">
                            <asp:Label ID="lg_username" runat="server" Text="User Name"></asp:Label>
                                </div>
                        </div>
                    </li>
                    <li>
                        <div style="width:100%;text-align:left;border-top:1px solid #808080;">
                            <div class="lg_usermail">
                                <div style="width:40%;float:left;"><label>E-mail Address:</label></div>
                                <div style="width:50%;float:left;">
                                <asp:Label ID="lg_usermail" runat="server" Text=""  CssClass="" ></asp:Label></div>
                            </div>
                        </div>
                    </li>
                    <li>
                        <div style="width:100%;text-align:left;">
                            <div class="lg_usermail">
                                 <div style="width:40%;float:left;"><label>Telephone:</label></div>
                                <div style="width:50%;float:left;">
                                <asp:Label ID="lbl_telephone" runat="server" Text=""  CssClass="" ></asp:Label></div>
                            </div>
                        </div>
                    </li>
                    <li>
                        <div style="width:100%;text-align:center">
                            <asp:Button ID="btn_register" runat="server" Text="Create New Users" OnClick="btn_register_Click" CssClass="btn btn-default track-number-btn org-btn" />
                        </div>
                    </li>
                </ul>

                 </div>

             </div>
            <div class="col-lg-4">

             </div>

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
