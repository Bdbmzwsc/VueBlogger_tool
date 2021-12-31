using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VueBlogger_configuration_tool.Models
{
    public class BlogModel
    {
        public string blog_path { get; set; }//博客存放的文件夹路径，例如:C:\Blog\
        public bool IsNpmInstall { get; set; }//是否npm_install
        public bool IsInitPosts { get; set; }//是否配置完毕posts



        #region 收录文件存在情况
        //是否存在data文件夹
        public bool IsExists_data{ get; set; }

        public bool IsExists_about { get; set; }

        public bool IsExists_config { get; set; }

        public bool IsExists_links { get; set; }

        public bool IsExists_posts { get; set; }

        public bool IsExists_projects { get; set; }


        #endregion

        #region 记录每个必要文件的内容
        public string string_about { get; set; }

        public string string_config { get; set; }
        public string string_links { get; set; }

        public string string_posts { get; set; }

        public string string_projects { get; set; }

        #endregion


        
    }
}
