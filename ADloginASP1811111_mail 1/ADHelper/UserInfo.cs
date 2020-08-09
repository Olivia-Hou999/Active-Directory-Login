using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHelper
{
    public class UserInfo
    {
        public string givenname { get; set; }
        public string samaccountname { get; set; }
        public string pwdlastset { get; set; }
        public string whencreated { get; set; }
        public string badpwdcount { get; set; }
        public string displayname { get; set; }
        public string lastlogon { get; set; }
        public string samaccounttype { get; set; }
        public string countrycode { get; set; }
        public string objectguid { get; set; }
        public string usnchanged { get; set; }
        public string whenchanged { get; set; }
        public string name { get; set; }  //用户名
        public string objectsid { get; set; }
        public string logoncount { get; set; }
        public string badpasswordtime { get; set; }

        public string accountexpires { get; set; }
        public string primarygroupid { get; set; }
        public string objectcategory { get; set; }
        public string userprincipalname { get; set; }
        public string useraccountcontrol { get; set; }
        public string dscorepropagationdata { get; set; }
        public string distinguishedname { get; set; }
        public string objectclass1 { get; set; }

        public string objectclass2 { get; set; }
        public string objectclass3 { get; set; }
        public string objectclass4 { get; set; }
        public string usncreated { get; set; }
        public string mail { get; set; } //e-mail
        public string lastlogontimestamp { get; set; }
        public string telephonenumber { get; set; } //e-mail
        public string adspath { get; set; }
        public string lastlogoff { get; set; }
        public string instancetype { get; set; }

        public string codepage { get; set; }
        public string sn { get; set; }



    }

    public class UserInfo_Normal
    {
        //public int id { get; set; }
        //public string userName { get; set; }
        //public string password { get; set; }
        //public string email { get; set; }
        //public int state { get; set; }
        //public string actiCode { get; set; }
        //public DateTime expTime { get; set; }

        public int userId { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string password { get; set; }
        public string companyCode { get; set; }
        public string position { get; set; }
        public string workPhoneNumber { get; set; }
        public string mobileNumber { get; set; }
      //  public string userCreatedBy { get; set; }
        public string emailAddress { get; set; }

        public string userCreatedBy { get; set; }
        public DateTime userCreatedDatetime { get; set; }
        public DateTime userLatestEditedDatetime { get; set; }
        public string userLatestEditedBy { get; set; }
        public int state { get; set; }
        public int activited { get; set; }
        public string registrationToken { get; set; }
        public string actiCode { get; set; }
        public DateTime registrationDatetime { get; set; }
        public DateTime tokenExpiredDatetime { get; set; }

    }
}
