using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using upload_web.Models;

namespace upload_web.Controllers
{
    public class Upload_Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Image = null;
            return View();
        }
        public IConfigurationRoot GetConnection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();
            return builder;
        }

        [HttpPost]
        public IActionResult Index(FileUpload Data)
        {
            try
            {
                Byte[] bytes = null;
                if (Data.File.FileName != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Data.File.OpenReadStream().CopyTo(ms);
                        bytes = ms.ToArray();
                    }
                    string connectionstring = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
                    SqlConnection con = new SqlConnection(connectionstring);
                    SqlCommand cmd = new SqlCommand("Insert into fileUpload(FileNames,Filepic,UploadDate) values(@FileNames,@Filepic,@UploadDate)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@FileNames", Data.Name);
                    cmd.Parameters.AddWithValue("@Filepic", bytes);
                    cmd.Parameters.AddWithValue("@UploadDate", DateTime.Now);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ViewBag.Image = ViewImage(bytes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View();
        }

        [NonAction]
        private string ViewImage(byte[] arrayImage)
        {
            string base64String = Convert.ToBase64String(arrayImage, 0, arrayImage.Length);
            return "data:image/png;base64," + base64String;
        }
    }
}