﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appusion.Core.Common.RequestModels.Email
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ToName { get; set; }
        public List<IFormFile> Attachments { get; set; }
        public MailRequest()
        {
            Attachments = new List<IFormFile>();
        }
    }
}