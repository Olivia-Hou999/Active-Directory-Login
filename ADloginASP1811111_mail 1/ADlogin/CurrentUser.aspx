<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="CurrentUser.aspx.cs" Inherits="ADlogin.CurrentUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-12" id="employeeuser"  style="display:none;" runat="server">
            
            <div  class="col-sm-12" style="margin-top:40px;"> 

                 <div class="password-form">

                    <ul>
                     <li>
                        <div style="width:100%;text-align:left;">
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
                    <%--<li>
                        <div style="width:100%;text-align:center">
                            <asp:Button ID="btn_register" runat="server" Text="Create New Users" OnClick="btn_register_Click" CssClass="btn btn-default track-number-btn org-btn" />
                        </div>
                    </li>--%>
                </ul>

                 </div>

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




</asp:Content>
