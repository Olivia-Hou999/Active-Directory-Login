<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginedUser.aspx.cs" Inherits="ADlogin.LoginedUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>当前用户</title>
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
                            <a href="LoginedUser.aspx" title="homepage"> <img src="./images/logo-footer.png" width="181" style="margin: 16px 0px;margin-left:150px;" /></a>
                       </div>
                         <div class="col-lg-4">
                         </div>
                       <div class="col-lg-4">
                           <asp:LinkButton ID="lb_exit" runat="server" OnClick="lb_exit_Click" CssClass="nav_a"  >Sign out</asp:LinkButton>
                        </div>

              </div>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="LoginedUser.aspx.cs" Inherits="ADlogin.LoginedUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .mybtn {
            border-radius:50px !important;
            text-align:center !important;
            transition: box-shadow 0.3s ease-in-out !important;
            
            border: 1px solid #ff6633 !important;
            background: -webkit-linear-gradient(top, rgba(255,255,255,1) 0%, rgba(246,246,246,1) 74%, rgba(237,237,237,1) 100%) !important;
            color: #e96e30 !important;
            font-weight: 600 !important;
            webkit-box-shadow: 0px 0px 7px rgba(0,0,0,0.2), 0px 0px 0px 1px rgba(188,188,188,0.1) !important;
            -moz-box-shadow: 0px 0px 7px rgba(0,0,0,0.2), 0px 0px 0px 1px rgba(188,188,188,0.1) !important;
            box-shadow: 0px 0px 7px rgba(0,0,0,0.2), 0px 0px 0px 1px rgba(188,188,188,0.1) !important;
        }
        .mybtn:hover {
        transition: box-shadow 0.3s ease-in-out !important;
        border-radius: 50px !important;
        border: 1px solid #ff6633 !important;
        background: -webkit-linear-gradient(top, rgba(255,102,51,1) 0%, rgba(255,102,51,1) 74%, rgba(255,102,51,1) 100%) !important;
        color: #e96e30 !important;
        font-weight: 600 !important;
        webkit-box-shadow: 0px 0px 7px rgba(0,0,0,0.2), 0px 0px 0px 1px rgba(188,188,188,0.1) !important;
     
        -moz-box-shadow: 0px 0px 7px rgba(0,0,0,0.2), 0px 0px 0px 1px rgba(188,188,188,0.1) !important;
         box-shadow: 0px 0px 7px rgba(0,0,0,0.2), 0px 0px 0px 1px rgba(188,188,188,0.1) !important; 
       
        color:white !important;
    }
        .labeltitle {
            width:40%;float:left;margin:0px 10px;font-size:16px;
        }
            .labeltitle label {
                padding:0px 5px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="col-sm-12" id="employeeuser"  style="display:none;" runat="server">
                <div class="col-sm-12">

                 </div>
                <div  class="col-sm-12" style="margin-top:40px;"> 

                     <div class="password-form">

                        <ul>
                         <li>
                            <div style="width:100%;text-align:center;">
                                <div style="width:20%;float:left;"><label>
                                       Welcome:
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

                     <div class="col-lg-8"></div>
                     <div class="col-lg-8" style="margin-top:40px;">
                                  <div class="welcome" >
                                      Welcome：<asp:Label ID="lbl_username" runat="server" Text=""></asp:Label>
                       
                                    </div>
                                    <div  class="welcome">
                                         Your account has been successfully logged in.
                                    </div>
                             </div>
                     <div class="col-lg-4"></div>
       </div>
    

    </asp:Content>
