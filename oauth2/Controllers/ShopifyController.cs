using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using oauth2.Models;
using System.IO;
using System.Web.Mvc;
using System.Text;

namespace oauth2.Controllers
{
    public class ShopifyController : Controller
    {

        public ShopifyController()
        {
        }

        public ActionResult TransactionCreation()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("TransactionCreation", documentContents);
            return View();
        }

        public ActionResult Process()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("process", documentContents);
            return View();
        }

        public ActionResult CartCreation()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("CartCreation", documentContents);
            return View();
        }

        public ActionResult CartUpdate()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("CardUpdate", documentContents);
            return View();
        }
        public ActionResult CheckoutCreation()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("CheckoutCreation", documentContents);
            return View();
        }
        public ActionResult CheckoutDeletion()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("CheckoutDeletion", documentContents);
            return View();
        }
        public ActionResult CustomerCreation()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("CustomerCreation", documentContents);
            return View();
        }
        public ActionResult OrderCreation()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("OrderCreation", documentContents);
            return View();
        }
        public ActionResult OrderPayment()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("OrderPayment", documentContents);
            return View();
        }
        public ActionResult OrderUpdate()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("OrderUpdate", documentContents);
            return View();
        }
        public ActionResult ProductCreation()
        {
            string documentContents = getDocumentContents(Request.InputStream);
            fileWriter("ProductCreation", documentContents);
            return View();
        }

        public void fileWriter(string fileName, string param1) {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\files\" + fileName + ".json"))
            {
                // If the line doesn't contain the word 'Second', write the line to the file.
                file.WriteLine(param1);
            }
        }

        public string getDocumentContents(Stream stream) {
            string documentContents;
            using (Stream receiveStream = Request.InputStream)
            {
                using (StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8))
                {
                    documentContents = readStream.ReadToEnd();
                }
            }
            return documentContents;
        }


    }
}