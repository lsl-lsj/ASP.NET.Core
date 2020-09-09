using System;
using System.Net.Http;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Send();
        }

        public async static void Send()
        {
            // 请求的url
            string url = "http://localhost:5000/demo/uploadfile";

            // 测试文件名
            string FileName = "sample.bat";

            // 产生的字节数
            int byteCount = 8000;
            byte[] bytes = new byte[byteCount];
            new Random().NextBytes(bytes);

            using (HttpClient client = new HttpClient())
            {
                // 设置Http头
                client.DefaultRequestHeaders.Add("file-name", FileName);

                // 创建正文内容
                ByteArrayContent content = new ByteArrayContent(bytes);
                // 发送请求
                Console.WriteLine("正在发送请求,请稍后。。。。。");
                HttpResponseMessage response = await client.PostAsync(url, content);

                // 响应结果
                string respmsg = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"服务器返回消息:\n{respmsg}");
            }
        }
    }
}
