using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;

namespace VueBlogger_configuration_tool.Download
{
    public class Download
    {
        #region download file
        public static void download_file(string Url,string Path)
        {
            using (var download = new WebClient())
            {
                 download.DownloadFileAsync(new Uri(Url), Path);
            }

        }

        public static void new_download_file(string Url,string Path)
        {
            
                HttpWebRequest request = WebRequest.Create(Url) as HttpWebRequest;
                //发送请求并获取相应回应数据
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                Stream responseStream = response.GetResponseStream();
                //创建本地文件写入流
                Stream stream = new FileStream(Path, FileMode.Create);
                byte[] bArr = new byte[1024];
                int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                while (size > 0)
                {
                    stream.Write(bArr, 0, size);
                    size = responseStream.Read(bArr, 0, (int)bArr.Length);
                }
                stream.Close();
                responseStream.Close();

                /*
                try
                {
                    HttpResponseMessage client=new HttpClient().ge
                  //  using ()
                 //   {

                      //  client.DownloadFile(Url, Path);//下载文件
                      //  return Path;
                  //  }

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }


                */

            

        }
        #endregion
    }

    
}
