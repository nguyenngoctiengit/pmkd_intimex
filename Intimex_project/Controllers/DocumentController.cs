using DevExtreme.AspNet.Mvc.FileManagement;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.AppServices;
using Microsoft.Extensions.Logging;
using GleamTech.FileUltimate.AspNet.UI;
using GleamTech.AspNet.UI;
using System.Text;
using Data.Models.Trading_system;
using Application.Parameter;
using Microsoft.AspNetCore.Http;
using Data.Public_class;
using System.IO;

namespace Intimex_project.Controllers
{
    public class DocumentController : Controller
    {
        private const string EventLogSessionKey = "EventLog.CS";

        IHostingEnvironment _hostingEnvironment;

        public tradingsystemContext _context = new tradingsystemContext(ConnectionParameter.connectionString);

        private readonly ILogger<DocumentController> _logger;
        public DocumentController(ILogger<DocumentController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Document()
        {
            var fileManager = new FileManager
            {
                Width = CssLength.Percentage(100),
                Height = 800,
                DisplayLanguage = "en"
            };
            fileManager.RootFolders.Add(new FileManagerRootFolder
            {
                Name = "Root",
                Location = @"C:\Users\User\Desktop\project_intimex\Intimex_project\wwwroot\Document"
            });
            if (UserInfo.UpdateDoc && UserInfo.DeleteDoc && UserInfo.DownloadDoc)
            {
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",
                    AllowedPermissions = FileManagerPermissions.Full,
                });
            } else if (UserInfo.UpdateDoc && UserInfo.DeleteDoc)
            {
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",
                    AllowedPermissions = FileManagerPermissions.Full,
                    DeniedPermissions = FileManagerPermissions.Download
                });
            }
            else if (UserInfo.DeleteDoc && UserInfo.DownloadDoc)
            {
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",
                    AllowedPermissions = FileManagerPermissions.Full,
                    DeniedPermissions = FileManagerPermissions.Upload
                });
            }
            else if (UserInfo.UpdateDoc && UserInfo.DownloadDoc)
            {
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",
                    AllowedPermissions = FileManagerPermissions.Full,
                    DeniedPermissions = FileManagerPermissions.Delete
                });
            }
            else if (UserInfo.UpdateDoc == true)
            {
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",
                    AllowedPermissions = FileManagerPermissions.Full,
                    DeniedPermissions = FileManagerPermissions.Delete | FileManagerPermissions.Download,

                });
            } else if(UserInfo.DeleteDoc == true){
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",
                    AllowedPermissions = FileManagerPermissions.Full,
                    DeniedPermissions = FileManagerPermissions.Upload | FileManagerPermissions.Download,
                });
            } 
            else if (UserInfo.DownloadDoc)
            {
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",
                    AllowedPermissions = FileManagerPermissions.ReadOnly,
                    DeniedPermissions = FileManagerPermissions.Upload | FileManagerPermissions.Delete
                });
            }
            fileManager.Creating += FileManagerCreating;
            fileManager.Deleting += FileManagerDeleting;
            fileManager.Uploading += FileManagerUploading;
            fileManager.Downloading += FileManagerDownloading;
            return View("Document",fileManager);
        }
        #region  Example event handlers for before events


        public void FileManagerCreating(object sender, FileManagerCreatingEventArgs e)
        {
            var Documents = ListDocument.GetListDocument();
            var path = e.Folder.Path;
            List<string> lines = System.IO.File.ReadLines("Documents.txt").ToList();
            TextWriter tw = new StreamWriter("Documents.txt");
            foreach (var item in lines)
            {
                var Name = item.Substring(3);
                var id = item.Substring(0, 1);
                if (path.StartsWith(Name))
                {
                    if (long.Parse(id) == UserInfo.Department)
                    {
                        tw.WriteLine(id + "||" + path);
                    }
                    else
                    {
                        e.Cancel("Bạn không có quyền thêm thư mục vào thư mục này");
                    }
                }
                tw.WriteLine(item);
            }
            tw.Close();
        }

        private void FileManagerDeleting(object sender, FileManagerDeletingEventArgs e)
        {
            List<string> lines = System.IO.File.ReadLines("FileLogsDocument.txt").ToList();
            TextWriter tw = new StreamWriter("FileLogsDocument.txt");
            foreach (var item in lines)
            {
                tw.WriteLine(item);
            }
            var ItemNames = e.ItemNames;
            var itemName = ItemNames[0];
            tw.WriteLine(UserInfo.UserName1 + "||" + e.Folder.Path + "||" + itemName);
            tw.Close();

        }
        private static void FileManagerUploading(object sender, FileManagerUploadingEventArgs e)
        {
            var Documents = ListDocument.GetListDocument();
            var path = e.Folder.Path;
            foreach (var item in Documents)
            {
                if (path.StartsWith(item.Name))
                {
                    if (item.Id == UserInfo.Department)
                    {

                    }
                    else
                    {
                        e.Cancel("Bạn không có quyền tải tệp trong thư mục này");
                    }
                }
                else
                {

                }
            }
            
        }

        private static void FileManagerDownloading(object sender, FileManagerDownloadingEventArgs e)
        {
            if (UserInfo.DownloadDoc == true)
            {
            }
            else
            {
                e.Cancel("Bạn không có quyền download file này");
            }
            
        }
        #endregion

    }
}
