﻿using System;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public class CompressFilterAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        HttpResponseBase response = filterContext.HttpContext.Response;

        if (response.Filter is GZipStream || response.Filter is DeflateStream) return;

        HttpRequestBase request = filterContext.HttpContext.Request;

        string acceptEncoding = request.Headers["Accept-Encoding"];

        if (string.IsNullOrEmpty(acceptEncoding)) return;

        acceptEncoding = acceptEncoding.ToLower();

        if (acceptEncoding.Contains("gzip"))
        {
            response.AppendHeader("Content-encoding", "gzip");
            response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
        }
        else if (acceptEncoding.Contains("deflate"))
        {
            response.AppendHeader("Content-encoding", "deflate");
            response.Filter = new DeflateStream(response.Filter, CompressionMode.Compress);
        }

        response.Cache.SetExpires(DateTime.Now.AddYears(1));
        response.Cache.SetCacheability(HttpCacheability.Public);

        //Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
        //Response.Cache.SetCacheability(HttpCacheability.Public);
        response.Cache.SetValidUntilExpires(true);
    }
}