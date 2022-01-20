using DevExtreme.AspNet.Mvc.FileManagement;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.AppServices;
using Microsoft.Extensions.Logging;

namespace Intimex_project.Controllers
{
    public class DocumentController : Controller
    {
        IHostingEnvironment _hostingEnvironment;

        private readonly ILogger<DocumentController> _logger;
        public DocumentController(ILogger<DocumentController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Document()
        {
            return View("Document");
        }
        [Route("api/file-manager-file-system", Name = "FileManagementFileSystemApi")]
        public object FileSystem(FileSystemCommand command, string arguments)
        {
            var config = new FileSystemConfiguration
            {
                Request = Request,
                FileSystemProvider = new DbFileProvider(_hostingEnvironment.ContentRootPath + "/wwwroot"),
                AllowCopy = true,
                AllowCreate = true,
                AllowMove = true,
                AllowDelete = true,
                AllowRename = true,
                AllowUpload = true,
                AllowDownload = true,
            };
            var processor = new FileSystemCommandProcessor(config);
            var result = processor.Execute(command, arguments);
            return result.GetClientCommandResult();
        }
    }
}
