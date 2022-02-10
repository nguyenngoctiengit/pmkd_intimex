using Application.Parameter;
using Data.Models.Trading_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Public_class;

namespace Application.AppServices
{
    public class UpdateUserInfo
    {
        public static void UserInfoUpdate(string UserName)
        {
            tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);
            var user = _context.UserRights.Where(a => a.UserName1 == UserName).FirstOrDefault();
            UserInfo.UserId = user.UserId;
            UserInfo.UserName1 = user.UserName1;
            UserInfo.FullName1 = user.FullName1;
            UserInfo.PassWord1 = user.PassWord1;
            UserInfo.UnitName = user.UnitName;
            UserInfo.Department = user.Department;
            UserInfo.GroupId = user.GroupId;
            UserInfo.status = user.Status;
            UserInfo.showAll = user.ShowAll;
            UserInfo.UnitCode = user.UnitCode;
            UserInfo.StatusUpdate = user.StatusUpdate;
            UserInfo.ComputerInfor = user.ComputerInfor;
            UserInfo.WebPermission = user.WebPermission;
            UserInfo.DownloadDoc = user.DownloadDoc;
            UserInfo.Signer = user.Signer;
            UserInfo.ReadOnlyAllForm = user.ReadOnlyAllForm;
            UserInfo.Approve = user.Approve;
            UserInfo.AutoMaticSMS = user.AutoMaticSms;
            UserInfo.ShowAllDoc = user.ShowAllDoc;
            UserInfo.RememberPW = user.RememberPw;
            UserInfo.ViewMeetingDoc = user.ViewMeetingDoc;
            UserInfo.ShowContractReminder = user.ShowContractReminder;
            UserInfo.ShowCustomerReminder = user.ShowCustomerReminder;
        }
    }
}
