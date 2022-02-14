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
            if (UserInfo.UpdateDoc == true)
            {
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",    
                    AllowedPermissions = FileManagerPermissions.Full
                });
            }  
            else
            {
                fileManager.RootFolders[0].AccessControls.Add(new FileManagerAccessControl
                {
                    Path = @"\",
                    AllowedPermissions = FileManagerPermissions.ReadOnly,

                    
                });
            }
            
            //Attached event handlers should be static methods because they are raised out of the context of the host page.
            //If instance methods are attached (eg. an instance method of Page class), this would cause memory leaks. 

            //Before Events which are fired before the action is started.
            //Use e.Cancel("message") within a before event handler for canceling the event and displaying a message to the user, 
            //When an event is canceled, the corresponding action will be canceled and the after event will not be fired.
            fileManager.Expanding += FileManagerExpanding;
            fileManager.Listing += FileManagerListing;
            fileManager.Creating += FileManagerCreating;
            fileManager.Deleting += FileManagerDeleting;
            fileManager.Renaming += FileManagerRenaming;
            fileManager.Copying += FileManagerCopying;
            fileManager.Moving += FileManagerMoving;
            fileManager.Compressing += FileManagerCompressing;
            fileManager.Extracting += FileManagerExtracting;
            fileManager.Uploading += FileManagerUploading;
            fileManager.Downloading += FileManagerDownloading;
            fileManager.Previewing += FileManagerPreviewing;

            //After Events which are fired after the action is completed.
            fileManager.Expanded += FileManagerExpanded;
            fileManager.Listed += FileManagerListed;
            fileManager.Created += FileManagerCreated;
            fileManager.Deleted += FileManagerDeleted;
            fileManager.Renamed += FileManagerRenamed;
            fileManager.Copied += FileManagerCopied;
            fileManager.Moved += FileManagerMoved;
            fileManager.Compressed += FileManagerCompressed;
            fileManager.Extracted += FileManagerExtracted;
            fileManager.Uploaded += FileManagerUploaded;
            fileManager.Downloaded += FileManagerDownloaded;
            fileManager.Previewed += FileManagerPreviewed;
            fileManager.Failed += FileManagerFailed;
            return View("Document",fileManager);
        }
        #region  Example event handlers for before events
        private void FileManagerExpanding(object sender, FileManagerExpandingEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
            {
                {"Event Name", "Expanding"},
                {"Folder.FullPath", e.Folder.FullPath},
                {"IsRefresh", e.IsRefresh}
            });

        }

        private static void FileManagerListing(object sender, FileManagerListingEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Listing"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"IsRefresh", e.IsRefresh}
                });
        }

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
                        EventUtil.SaveEventInfo(new Dictionary<string, object>
                        {
                            {"Event Name", "Creating"},
                            {"Folder.FullPath", e.Folder.FullPath},
                            {"ItemName", e.ItemName}
                        });
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
            var Documents = ListDocument.GetListDocument();
            var path = e.Folder.Path;
            foreach (var item in Documents)
            {
                if (path.StartsWith(item.Name))
                {
                    if (item.Id == UserInfo.Department)
                    {
                        EventUtil.SaveEventInfo(new Dictionary<string, object>
                        {
                            {"Event Name", "Deleting"},
                            {"Folder.FullPath", e.Folder.FullPath},
                            {"ItemNames", e.ItemNames}
                        });
                    }
                    else if (UserInfo.DeleteDoc == false)   
                    {
                        e.Cancel("Bạn không có quyền thêm thư mục vào thư mục này");
                    }
                    else
                    {
                        e.Cancel("Bạn không có quyền thêm thư mục vào thư mục này");
                    }
                }
                else
                {
                    EventUtil.SaveEventInfo(new Dictionary<string, object>
                        {
                            {"Event Name", "Deleting"},
                            {"Folder.FullPath", e.Folder.FullPath},
                            {"ItemNames", e.ItemNames}
                        });
                }
            }
            
        }

        private static void FileManagerRenaming(object sender, FileManagerRenamingEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Renaming"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemName", e.ItemName},
                    {"ItemNewName", e.ItemNewName}
                });
        }

        private static void FileManagerCopying(object sender, FileManagerCopyingEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Copying"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames},
                    {"TargetFolder.FullPath", e.TargetFolder.FullPath}
                });
        }

        private static void FileManagerMoving(object sender, FileManagerMovingEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Moving"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames},
                    {"TargetFolder.FullPath", e.TargetFolder.FullPath}
                });
        }

        private static void FileManagerCompressing(object sender, FileManagerCompressingEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Compressing"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames},
                    {"ZipFileName", e.ZipFileName}
                });
        }

        private static void FileManagerExtracting(object sender, FileManagerExtractingEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Extracting"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ToSubfolder", e.ToSubfolder},
                    {"ArchiveFileName", e.ArchiveFileName}
                });
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
                        EventUtil.SaveEventInfo(new Dictionary<string, object>
                        {
                            {"Event Name", "Uploading"},
                            {"Folder.FullPath", e.Folder.FullPath},
                            {"Queue.Method", e.Queue.Method},
                            {"Items", e.Items.Select(item => new Dictionary<string, object>
                                {
                                    {"Name", item.Name},
                                    {"ContentType", item.ContentType},
                                    {"SizeAsString", item.SizeAsString},
                                    {"DateModified", item.DateModified }
                                })
                            }
                        });
                    }
                    else
                    {
                        e.Cancel("Bạn không có quyền tải tệp trong thư mục này");
                    }
                }
                else
                {
                    EventUtil.SaveEventInfo(new Dictionary<string, object>
                        {
                            {"Event Name", "Uploading"},
                            {"Folder.FullPath", e.Folder.FullPath},
                            {"Queue.Method", e.Queue.Method},
                            {"Items", e.Items.Select(item => new Dictionary<string, object>
                                {
                                    {"Name", item.Name},
                                    {"ContentType", item.ContentType},
                                    {"SizeAsString", item.SizeAsString},
                                    {"DateModified", item.DateModified }
                                })
                            }
                        });
                }
            }
            
        }

        private static void FileManagerDownloading(object sender, FileManagerDownloadingEventArgs e)
        {
            if (UserInfo.DownloadDoc == true)
            {
                EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Downloading"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames},
                    {"DownloadFileName", e.DownloadFileName},
                    {"OpenInBrowser", e.OpenInBrowser}
                });
            }
            else
            {
                e.Cancel("Bạn không có quyền download file này");
            }
            
        }

        private static void FileManagerPreviewing(object sender, FileManagerPreviewingEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Previewing"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemName", e.ItemName},
                    {"PreviewerType", e.PreviewerType}
                });
        }
        #endregion

        #region Example event handlers for after events

        private static void FileManagerExpanded(object sender, FileManagerExpandedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Expanded"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"IsRefresh", e.IsRefresh}
                });
        }

        private static void FileManagerListed(object sender, FileManagerListedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Listed"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"IsRefresh", e.IsRefresh}
                });
        }

        private static void FileManagerCreated(object sender, FileManagerCreatedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
            {
                {"Event Name", "Created"},
                {"Folder.FullPath", e.Folder.FullPath},
                {"ItemName", e.ItemName}
            });
        }

        private static void FileManagerDeleted(object sender, FileManagerDeletedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Deleted"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames}
                });
        }

        private static void FileManagerRenamed(object sender, FileManagerRenamedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Renamed"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemName", e.ItemName},
                    {"ItemNewName", e.ItemNewName}
                });
        }

        private static void FileManagerCopied(object sender, FileManagerCopiedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Copied"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames},
                    {"TargetFolder.FullPath", e.TargetFolder.FullPath},
                    {"TargetItemNames", e.TargetItemNames}
                });
        }

        private static void FileManagerMoved(object sender, FileManagerMovedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Moved"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames},
                    {"TargetFolder.FullPath", e.TargetFolder.FullPath},
                });
        }

        private static void FileManagerCompressed(object sender, FileManagerCompressedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Compressed"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames},
                    {"ZipFileName", e.ZipFileName}
                });
        }

        private static void FileManagerExtracted(object sender, FileManagerExtractedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Extracted"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ToSubfolder", e.ToSubfolder},
                    {"ArchiveFileName", e.ArchiveFileName}
                });
        }

        private static void FileManagerUploaded(object sender, FileManagerUploadedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Uploaded"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"Queue.Method", e.Queue.Method},
                    {"Items", e.Items.Select(item => new Dictionary<string, object>
                        {
                            {"Name", item.Name},
                            {"ContentType", item.ContentType},
                            {"SizeAsString", item.SizeAsString},
                            {"DateModified", item.DateModified},
                            {"Status", item.Status},
                            {"StatusMessage", item.StatusMessage}
                        })
                    },
                    {"Queue.TotalUploadedSizeAsString", e.Queue.TotalUploadedSizeAsString},
                    {"Queue.ElapsedTimeAsString", e.Queue.ElapsedTimeAsString},
                    {"Queue.TransferRateAsString", e.Queue.TransferRateAsString}
                });
        }

        private static void FileManagerDownloaded(object sender, FileManagerDownloadedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Downloaded"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemNames", e.ItemNames},
                    {"DownloadFileName", e.DownloadFileName},
                    {"OpenInBrowser", e.OpenInBrowser},
                    {"TotalDownloadedSizeAsString", e.TotalDownloadedSizeAsString},
                    {"ElapsedTimeAsString", e.ElapsedTimeAsString},
                    {"TransferRateAsString", e.TransferRateAsString}
                });
        }

        private static void FileManagerPreviewed(object sender, FileManagerPreviewedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Previewed"},
                    {"Folder.FullPath", e.Folder.FullPath},
                    {"ItemName", e.ItemName},
                    {"PreviewerType", e.PreviewerType}
                });
        }

        private static void FileManagerFailed(object sender, FileManagerFailedEventArgs e)
        {
            EventUtil.SaveEventInfo(new Dictionary<string, object>
                {
                    {"Event Name", "Failed"},
                    {"FailedActionInfo.Name", e.FailedActionInfo.Name},
                    {"FailedActionInfo.Parameters", e.FailedActionInfo.Parameters},
                    {"Exception", e.Exception}
                });
        }

        #endregion
        private static class EventUtil
        {
            public static void SaveEventInfo(Dictionary<string, object> eventInfo)
            {
                var now = DateTime.Now.ToString("T");
                var json = ComponentStateManager.SerializeState(eventInfo, true);
                var formattedValue = "[" + now + "]" + "\nEvent arguments: " + json + "\n\n";

                Stack<string> eventLog;
                if (!ComponentStateManager.TryGetState(EventLogSessionKey, out eventLog))
                    eventLog = new Stack<string>();

                if (eventLog.Count > 50)
                    eventLog.Clear();

                eventLog.Push(formattedValue);
                ComponentStateManager.SaveState(EventLogSessionKey, eventLog);
            }

        }
    }
}
