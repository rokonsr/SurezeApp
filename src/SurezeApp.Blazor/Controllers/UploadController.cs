using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using SurezeApp.Patients;

namespace SurezeApp.Blazor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadController : ControllerBase
    {
        private readonly IWebHostEnvironment env;

        public UploadController(IWebHostEnvironment env)
        {
            this.env = env;
        }

        [HttpPost]
        public async Task Post([FromBody] ImageFileDto[] files)
        {
            foreach (var file in files)
            {
                string path = env.ContentRootPath + "\\wwwroot\\images";
                //string fileName = System.IO.Path.DirectorySeparatorChar + Guid.NewGuid().ToString("N") + "-" + file.FileName;
                var buf = Convert.FromBase64String(file.Base64data);
                await System.IO.File.WriteAllBytesAsync(path + System.IO.Path.DirectorySeparatorChar + file.FileName, buf);
            }
        }
    }
}
