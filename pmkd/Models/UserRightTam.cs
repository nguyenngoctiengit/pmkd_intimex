using System;
using System.Collections.Generic;

#nullable disable

namespace pmkd.Models
{
    public partial class UserRightTam
    {
        public long UserId { get; set; }
        public string UserName1 { get; set; }
        public string FullName1 { get; set; }
        public string PassWord1 { get; set; }
        public string UnitName { get; set; }
        public long Department { get; set; }
        public string GroupId { get; set; }
        public bool Status { get; set; }
        public string ShowAll { get; set; }
        public string UnitCode { get; set; }
        public bool StatusUpdate { get; set; }
        public string ComputerInfor { get; set; }
        public bool WebPermission { get; set; }
        public bool Signer { get; set; }
        public bool ReadOnlyAllForm { get; set; }
        public bool Approve { get; set; }
        public bool AutoMaticSms { get; set; }
        public bool ShowAllDoc { get; set; }
        public bool RememberPw { get; set; }
        public bool ViewMeetingDoc { get; set; }
        public bool ShowContractReminder { get; set; }
        public bool ShowCustomerReminder { get; set; }
        public bool ViewPrice { get; set; }
        public bool ViewPresentation { get; set; }
        public bool UpdateDoc { get; set; }
        public bool CloseDoc { get; set; }
        public bool DeleteDoc { get; set; }
        public bool DownloadDoc { get; set; }
        public bool IsUnitLeader { get; set; }
        public bool IsDepartmentLeader { get; set; }
        public bool FullViewConTract { get; set; }
        public bool ExportOnReport { get; set; }
        public bool ViewAllStock { get; set; }
    }
}
