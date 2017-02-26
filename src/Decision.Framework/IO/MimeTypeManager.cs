﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace Decision.Framework.IO
{
    public static class MimeTypeManager
    {
        private static readonly IDictionary<string, IAttachmentType> mimeMap =
            new Dictionary<string, IAttachmentType>(StringComparer.OrdinalIgnoreCase)
            {
                {"IVBOR", AttachmentType.Photo},
                {"/9J/4", AttachmentType.Photo},
                {"AAAAF", AttachmentType.Video},
                {"JVBER", AttachmentType.Document}
            };

        public static IAttachmentType GetMimeTypeFromBase64String(this string value)
        {
            IAttachmentType result;

            return string.IsNullOrEmpty(value)
                ? AttachmentType.UnknownMime
                : (mimeMap.TryGetValue(value.Substring(0, 5), out result) ? result : AttachmentType.Unknown);
        }

        private static string GetMimeType(string fileName)
        {
            var mimeType = "application/unknown";
            var extension = Path.GetExtension(fileName);
            if (extension == null) return mimeType;
            var ext = extension.ToLower();

            var regKey = Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
            {
                mimeType = regKey.GetValue("Content Type").ToString();
            }
            else if (ext == ".png")
            {
                mimeType = "image/png";
            }
            return mimeType;
        }
    }
}