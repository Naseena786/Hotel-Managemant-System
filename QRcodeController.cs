using MVC_project__curd_.Models;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static QRCoder.PayloadGenerator;
using MVC_project__curd_.Models;




namespace MVC_project__curd_.Controllers
{
    public class QRcodeController : Controller
    {
        // GET: QRcode
        public ActionResult create()
        {
            return View(new QRcode());
        }
        [HttpPost]
        public ActionResult create(QRcode Model)
        {
            Payload payload = new Url(Model.QRtext);
            QRCodeGenerator codeGenerator = new QRCodeGenerator();

            QRCodeData qrcodedata = codeGenerator.CreateQrCode(payload);
            QRCoder.PngByteQRCode pngByte = new PngByteQRCode(qrcodedata);
            var qrbyte = pngByte.GetGraphic(20);
            string base64url = Convert.ToBase64String(qrbyte);
            Model.QRImgurl = "data:image/png;base64," + base64url;
            return View("create", Model);

        }
    }
}