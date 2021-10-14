/*using DevExtreme.AspNet.Mvc.FileManagement;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.IHostEnvironment;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Intimex_project.Controllers
{
    public class DocComeController : Controller
    {
        public IHostingEnvironment _hostingEnvironment;

        public DocComeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult DocCome()
        {
            return View("DocCome");
        }
        [Route("api/file-manager-file-system-images", Name = "FileManagement")]
        public object FileManagement(FileSystemCommand command, string arguments)
        {
            var config = new FileSystemConfiguration
            {
                Request = Request,
                FileSystemProvider = new PhysicalFileSystemProvider(_hostingEnvironment.ContentRootPath + "/wwwroot")
                //...
            };
            var processor = new FileSystemCommandProcessor(config);
            var result = processor.Execute(command, arguments);
            return result.GetClientCommandResult();
        }

    }
}
*/