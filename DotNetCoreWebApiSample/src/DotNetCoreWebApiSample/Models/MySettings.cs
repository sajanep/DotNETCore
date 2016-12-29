using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiSample.Models
{
    public class MySettings
    {
        public string ApplicationName { get; set; }

        public string FileUploadPath { get; set; }

        public int FileUploadMaxSize { get; set; }
    }
}
