using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace mvc201701.ActionResultMethods
{
    public class XmlActionResult<T> : ActionResult
    {
        public T Data { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            using (StringWriter w = new StringWriter())
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                s.Serialize(w,  Data);
                context.HttpContext.Response.ContentType = "text/xml";
                context.HttpContext.Response.Write(w);
            }
        }
    }
}