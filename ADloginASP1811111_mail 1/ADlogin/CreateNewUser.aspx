<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="CreateNewUser.aspx.cs" Inherits="ADlogin.CreateNewUser" %>
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
            width:27%;float:left;margin:0px 10px;font-size:16px;
        }
            .labeltitle label {
                padding:0px 5px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="region-form">
        <div  class="createnewusertitle">Create New User</div>
                            <ul>
                                <li>
                                    <div style="width:100%;text-align:left;">
                                        <div class="labeltitle">First Name<label >  *</label></div>
                                        <div style="width:50%;float:left;"><asp:TextBox ID="txt_firstName" runat="server"></asp:TextBox></div>
                                        
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                        <div class="labeltitle">Surname<label> *</label>   </div>
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
                                        <div class="labeltitle">Company Code<label> *</label></div>
                                        
                                        <div style="width:50%;float:left;"><asp:TextBox ID="txt_companyCode" runat="server"></asp:TextBox></div>
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                         <div class="labeltitle">Position<label> </label></div>
                                        
                                         <div style="width:50%;float:left;"><asp:TextBox ID="txt_position" runat="server"></asp:TextBox></div>
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                        <div class="labeltitle">Work Phone Number<label> *</label></div>
                                        
                                        <div style="width:65%;float:left;">
                                            <asp:TextBox ID="txt_workPhoneNumber" runat="server"></asp:TextBox>
                                          
                                            <asp:RegularExpressionValidator ID="REV_worknum" runat="server" ErrorMessage="You Must Enter a Valid Numeric"  ControlToValidate="txt_workPhoneNumber" ValidationExpression="(^-?\d\d*\.\d*$)|(^-?\d\d*$)|(^-?\.\d\d*$)" ></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                        <div class="labeltitle">Mobile Number<label> </label></div>
                                        
                                        <div style="width:65%;float:left;"><asp:TextBox ID="txt_mobileNumber" runat="server"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="REV_mobileNumber" runat="server" ErrorMessage="You Must Enter a Valid Numeric"  ControlToValidate="txt_mobileNumber" ValidationExpression="(^-?\d\d*\.\d*$)|(^-?\d\d*$)|(^-?\.\d\d*$)" ></asp:RegularExpressionValidator>

                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div style="width:100%;text-align:left">
                                        <div class="labeltitle">E-mail Address<label > *</label></div>
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
                                        <asp:Button ID="btn_creat" runat="server" Text="Create" OnClick="btn_creat_Click" CssClass="btn btn-default track-number-btn org-btn mybtn"    />
                                    </div>
                                </li>
                            </ul>
                        </div>


</asp:Content>
