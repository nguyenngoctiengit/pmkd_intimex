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
            var fileManager = new FileManager
            {
                Width = 800,
                Height = 600,
                DisplayLanguage = "en"
            };
            fileManager.RootFolders.Add(new FileManagerRootFolder
            {
                Name = "Root",
                Location = "~/wwwroot/"
            });
            return View("Document",fileManager);
        }

    }
}
