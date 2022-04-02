using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPI.Filters
{
    public class GzipCompressionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionContext)
        {
            HttpContent content = actionContext.Response.Content;
            byte[] contentBytes = content?.ReadAsByteArrayAsync().Result ?? new byte[0];

            byte[] compressedContent = GzipContent(contentBytes);
            actionContext.Response.Content = new ByteArrayContent(compressedContent);

            actionContext.Response.Content.Headers.Remove("Content-Type");
            actionContext.Response.Content.Headers.Add("Content-encoding", "gzip");
            actionContext.Response.Content.Headers.Add("Content-Type", "application/json");
            base.OnActionExecuted(actionContext);
        }

        private byte[] GzipContent(byte[] contentBytes)
        {
            using (MemoryStream output = new MemoryStream())
            {
                using (Ionic.Zlib.GZipStream compressor = new Ionic.Zlib.GZipStream(
                    output, Ionic.Zlib.CompressionMode.Compress, Ionic.Zlib.CompressionLevel.BestSpeed))
                {
                    compressor.Write(contentBytes, 0, contentBytes.Length); 
                }

                return output.ToArray();
            }
        }
    }


}
