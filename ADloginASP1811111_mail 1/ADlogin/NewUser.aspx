<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="ADlogin.NewUser" %>

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
        .creatcssdisable {
            pointer-events:none;
            background-color: #d7d7d7;
            text-align: center;
            pointer-events:visible;
        }
        .creatcssenable {
           
        }
        #btn_creat {
            text-align:center;
        }
    </style>

    <script src="JS/jquery-1.7.2.min.js" type="text/javascript" ></script>    
    <script type="text/javascript" src="JS/bootstrap.min.3.3.7.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container-content" style="min-width:1280px;text-align:center;">
           <div class="col-lg-12" style="height:90px;width:100%;background-color:black;color:white;margin-top:0px;z-index:999;text-align:right; line-height:30px;">
               <div class="col-lg-4">
                   <img src="./images/KLNL-Bilingual_orange-white-72dpi.png" width="281" style="    margin: 16px 0px;" />
               </div>
               <div class="col-lg-4">

               </div>
               <div class="col-lg-4"  style="text-align: left;"> 
                   <asp:LinkButton ID="lb_exit" runat="server" OnClick="lb_exit_Click" CssClass="nav_a" >Sign out</asp:LinkButton>
                </div>

           </div>
             
            <div class="col-lg-2"></div>
            <div class="col-lg-8" style="margin-top:40px;">
                    <div class="col-lg-4 inner-menu-container" style="/*width:33.333333%;background-color:white;*/ height:100%;min-height:600px;">
                        <ul class="inner-main-menu-container" style="padding-left:0px;padding-right:0px;">
                            <li class="menu-item haveSub" style="padding-left:5px;border-left:4px solid #ff6633;">
                                <button>
                                    <img src="./images/right.png" width="7"/></button>
                                    <a href="" style="font-size:14px;color:#ff6633;" >Creat New User</a>
                                  <%--  <ul class="inner-sub-container-lv1">
                                        <li class="inner-sub-lv1 haveSub">
                                            <button>
                                                <img src="./images/right.png" width="7"/></button>
                                            <a href="">dd</a>
                                            <ul class="inner-sub-container-lv2">
                                                    <li class="inner-sub-lv2"><a href="">dd</a></li>
                                                    <li class="inner-sub-lv2"><a href="">dd</a></li>
                                             </ul>
                                        </li>
                                        <li class="inner-sub-lv1"><a href="">dd</a></li>
                                        <li class="inner-sub-lv1"><a href="">dd</a></li>
                                        <li class="inner-sub-lv1"><a href="">dd</a></li>
                                    </ul>--%>
                            </li>
                            
                        </ul>
                     </div>
                    <div class="col-lg-8" id="region-container" >
                        <div class="region-form">
                            <ul>
                                <li>
                                    <div style="width:100%;text-align:left;">
                                        <div style="width:40%;float:left;"><label> First Name *</label></div>
                                        <div style="width:50%;float:left;"><asp:TextBox ID="txt_firstName" runat="server"></asp:TextBox></div>
                                        
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                        <div style="width:40%;float:left;"><label>Surname *</label>   </div>
                                         <div style="width:50%;float:left;"><asp:TextBox ID="txt_surName" runat="server"></asp:TextBox></div>
                                    </div>
                                </li>
                               <%--  <li>
                                    <div style="width:100%;text-align:left">
                                        <div style="width:40%;float:left;"><label> Password *</label></div>
                                        <div style="width:50%;float:left;"><asp:TextBox ID="txt_password" runat="server"></asp:TextBox></div>
                                    </div>
                                </li>--%>
                                 <li>
                                    <div style="width:100%;text-align:left">
                                        <div style="width:40%;float:left;"><label>Company Code *</label></div>
                                        
                                        <div style="width:50%;float:left;"><asp:TextBox ID="txt_companyCode" runat="server"></asp:TextBox></div>
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                         <div style="width:40%;float:left;"><label>Position </label></div>
                                        
                                         <div style="width:50%;float:left;"><asp:TextBox ID="txt_position" runat="server"></asp:TextBox></div>
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                        <div style="width:40%;float:left;"><label>Work Phone Number *</label></div>
                                        
                                        <div style="width:50%;float:left;"><asp:TextBox ID="txt_workPhoneNumber" runat="server"></asp:TextBox></div>
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                        <div style="width:40%;float:left;"><label>Mobile Number </label></div>
                                        
                                        <div style="width:50%;float:left;"><asp:TextBox ID="txt_mobileNumber" runat="server"></asp:TextBox></div>
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                        <div style="width:40%;float:left;"><label >E-mail Address *</label></div>
                                         <div style="width:50%;float:left;">
                                                <asp:TextBox ID="txt_usermail" runat="server" Text="" OnTextChanged="txt_usermail_TextChanged"></asp:TextBox>
                                                <asp:HiddenField ID="hf_hadmail" runat="server"  Value="" />
                                               <%-- <div style="margin-right: 10px;height: 30px;float:right;margin-top:5px;" id="checkloginemail" class="btn btn-info">Validation</div>--%>
                                         </div>
                                    </div>
                            
                                </li>
                        
                                <li>
                                    <%--<span>* 表示必填项</span>--%>
                                      <asp:Label ID="lbl_msg" runat="server" Text="" CssClass="alertmsg"></asp:Label>
                                </li>
                                <li style=" padding-top: 20px;padding-bottom: 40px; border-top: 1px solid #c7c7c7;margin-top: 10px;">
                                    <div style="width:100%;text-align:center">
                                        <asp:Button ID="btn_creat" runat="server" Text="Create" OnClick="btn_creat_Click"  CssClass="btn btn-default track-number-btn creatcssdisable" />
                                    </div>
                                </li>
                            </ul>
                        </div>
                
                     </div>
             
              </div>
            <div class="col-lg-2"></div>
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

    <script>
        $(function()
        {      
            $('#checkloginemail').click(function () {

                var useremail = $("#txt_usermail").val()
                if (useremail == "") {
                    alert("User email address cannot be empty！");
                }
                else {
                    $.ajax({
                        type: "post",
                        url: "emailchk.ashx",                       
                        data: {                           
                            user_email: useremail
                        },
                        success: function (data) { //ajaxJson

                            $("#lbl_msg").html(data);
                            if (data == 'Email address can be used') {
                                $("#btn_creat").removeClass("creatcssdisable");
                            }
                            

                        },
                        error: function (data) {
                            alert("Wrong Parameter" + data);
                        }

                    });
                }

            });


        })
        </script>
</body>
</html>
