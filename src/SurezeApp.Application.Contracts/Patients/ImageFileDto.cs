using System;
using System.Collections.Generic;
using System.Text;

namespace SurezeApp.Patients
{
    public class ImageFileDto
    {
        public string Base64data { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
    }
}
