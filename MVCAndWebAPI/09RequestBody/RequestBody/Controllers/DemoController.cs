using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace _09RequestBody.Controllers
{
    public class DemoController : Controller
    {
        [HttpPost]
        public IActionResult UploadFile()
        {

            var stream = HttpContext.Request.Body;

            byte[] data = null;

            // 将文本内容读取到字节数组中
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                data = ms.ToArray();
            }

            // 提取文件名
            string fileName = HttpContext.Request.Headers["file-name"];

            return Ok($"已成功上传文件{fileName ?? "未知"},大小为{data.Length}字节");
        }
    }
}