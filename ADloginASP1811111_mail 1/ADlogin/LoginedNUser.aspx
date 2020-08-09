<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginedNUser.aspx.cs" Inherits="ADlogin.LoginedNUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Current Normal User</title>
    <link href='CSS/bootstrap.min.3.3.7.css' rel="stylesheet" type="text/css" />
    <link href='CSS/mystyle.css' rel="stylesheet" type="text/css" />
     <link href='CSS/Mylogin.css' rel="stylesheet" type="text/css" />
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
    <div class="container-content" style="min-width:1680px;text-align:center;margin-top:0px;">
             <div class="col-lg-12" style="height:90px;width:100%;background-color:black;color:white;margin-top:0px;z-index:999;text-align:left; line-height:30px;">
                       <div class="col-lg-4">
                            <a href="UserWeb.aspx" title="homepage"> <img src="./images/logo-footer.png" width="181" style="margin: 16px 0px;margin-left:150px;" /></a>
                       </div>
                         <div class="col-lg-4">
                         </div>
                       <div class="col-lg-4">
                           <asp:LinkButton ID="lb_exit" runat="server" OnClick="lb_exit_Click" CssClass="nav_a"  >Sign out</asp:LinkButton>
                        </div>

              </div>

                <div class="col-sm-12" id="employeeuser"  style="display:none;" runat="server">
                <div class="col-sm-4">

                 </div>
                <div  class="col-sm-4" style="margin-top:40px;"> 

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
                <div class="col-sm-4">

                 </div>
       </div>
                <div class="col-sm-12" id="normaluser"   style="display:none;" runat="server">

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
       </div>
    
    </div>
    </form>
</body>
</html>
