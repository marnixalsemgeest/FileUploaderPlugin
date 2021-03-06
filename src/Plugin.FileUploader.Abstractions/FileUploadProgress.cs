﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.FileUploader.Abstractions
{
    public class FileUploadProgress
    {
        public long TotalBytesSent { get; }
        public long TotalLength { get; }
        public double Percentage { get { return TotalLength > 0 ? 100.0f * ((double)TotalBytesSent / (double)TotalLength) : 0.0f; } }

        public FileUploadProgress(long totalBytesSent,long totalLength)
        {
            TotalBytesSent = totalBytesSent;
            TotalLength = totalLength;
        }
    }
}
