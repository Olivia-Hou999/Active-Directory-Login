<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Active.aspx.cs" Inherits="ADlogin.Active" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
        
        
        
        <div class="col-lg-4">

         </div>
        <div class="col-lg-4" style="margin-top:40px;">
             <div class="password-form">
               <ul>
                     <li style="text-align:center;">
                        <div style="width:500px;text-align:center;">
                           <label>Please update your password</label> 
                        </div>
                    </li>
                    <li style="text-align:center;">
                        <div style="width:500px;text-align:left;">
                         
                            
                             <div style="width:40%;float:left;"><label> Username:</label></div>
                            <div style="width:50%;float:left;">
                            <asp:Label ID="lbl_username" runat="server" Text=""></asp:Label></div>
                            <asp:HiddenField ID="hf_id" runat="server" />
                        </div>
                    </li>
                    <li style="display:none;">
                        <div style="width:500px;text-align:left;">
                          <div style="width:40%;float:left;"><label>Previous password：</label></div>
                            
                            <div style="width:50%;float:left;">
                            <asp:Label ID="lbl_oldpwd" runat="server" Text=""></asp:Label></div>
                         </div>
                    </li>
                    <li>
                        <div style="width:500px;text-align:left;">
                        <div style="width:40%;float:left;"><label>New Password ：</label></div>
                          <div style="width:50%;float:left;">  <asp:TextBox ID="txt_newpwd" TextMode="Password" runat="server"></asp:TextBox></div>
                        </div>
                    </li>
                    <li>
                        <div style="width:500px;text-align:left;">
                        <div style="width:40%;float:left;"><label>Confirm Password：</label></div>
                          <div style="width:50%;float:left;">  
                            <asp:TextBox ID="txt_confirmnewpwd" TextMode="Password" runat="server"></asp:TextBox>
                           </div>
                        </div>
                    </li>
                    <li>
                        <div style="width:500px;text-align:left;">
                            <asp:Label ID="lbl_info" runat="server" Text="" CssClass="alertmsg"></asp:Label>
                        </div>
                    </li>
                    <li>
                         <asp:Button ID="btn_changepwd" runat="server" Text="Save" OnClick="btn_changepwd_Click" CssClass="btn btn-default track-number-btn org-btn" />
                    </li>
                   <li>
                        <div style="width:500px;text-align:left;">
                            <asp:Label ID="lbl_msg" runat="server" Text="" CssClass="alertmsg"></asp:Label>
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
                       
                    </div>
                </footer>
            </div>--%>
    </div>
    </form>
</body>
</html>
