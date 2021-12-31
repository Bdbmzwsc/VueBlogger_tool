// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using VueBlogger_configuration_tool;
using System;
using System.Net;
using System.IO;

Console.WriteLine("Running");
Console.WriteLine("Downloading");
VueBlogger_configuration_tool.Download.Default_download default_Download = new VueBlogger_configuration_tool.Download.Default_download();
default_Download.new_download_default_url(@"F:\VueBlogger tool hub\example\", @"F:\VueBlogger tool hub\example\src\");
Console.WriteLine("Downloaded");




//download_file("https://github.com/samzhangjy/VueBlogger/archive/refs/heads/main.zip", @"F:\VueBlogger tool hub\example\src.zip");


 static string download_file(string Url, string Path)
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
    return Path;
    
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
