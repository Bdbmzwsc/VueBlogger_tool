using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VueBlogger_configuration_tool.Download
{
    public class Default_download
    {

        #region Download src
        public bool download_default_url(string path,string directory_path)
        {
            try
            {
                Download.download_file("https://github.com/samzhangjy/VueBlogger/archive/refs/heads/main.zip", path);
                //解压
          //      System.IO.Compression.ZipFile.ExtractToDirectory(path, directory_path);
                //删除src.zip
             //   File.Delete(path + "src.zip");
                return true;
            }
            catch
            {
                return false;
            }


        }

        public static bool new_download_default_url(string path, string directory_path,bool isgh=false)
        {
            try 
            {
                string origin_git = "github.com";
                if (isgh) origin_git = "hub.fastgit.org";
             //       Download.new_download_file("https://github.com/samzhangjy/VueBlogger/archive/refs/heads/main.zip", path + "src.zip");

                    Download.new_download_file(string.Format("https://{0}/samzhangjy/VueBlogger/archive/refs/heads/main.zip",origin_git), path + "src.zip");
       

   
                //解压
                     System.IO.Compression.ZipFile.ExtractToDirectory(path + "src.zip", directory_path);
                //删除src.zip
                   File.Delete(path + "src.zip");
                return true;
            }
            catch
            {
                return false;
            }


        }

        
        
        #endregion
    }
}
