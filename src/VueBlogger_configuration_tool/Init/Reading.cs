using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueBlogger_configuration_tool.Models;
using System.IO;

namespace VueBlogger_configuration_tool.Init
{
    public class Reading
    {
        #region 获取信息
        public static BlogModel Open(string path)
        {
            BlogModel blogModel = new BlogModel();
            
            blogModel.blog_path = path;

            //查看是否存在node_modules文件夹
            if (Directory.Exists(path + @"node_modules"))
            {
                blogModel.IsNpmInstall = true;
            }
            else
            {
                blogModel.IsNpmInstall = false;
            }

            //查看是否存在posts文件夹
            if (Directory.Exists(path + @"posts"))
            {
                blogModel.IsInitPosts = true;
                string temp = path + @"posts\data";
                //查看文件(文件夹)存在情况
                if (Directory.Exists(temp)) { blogModel.IsExists_data = true; } else { blogModel.IsExists_data = false;}

                if (File.Exists(temp + @"\about.md")) { blogModel.IsExists_about = true; } else { blogModel.IsExists_data = false; }

                if (File.Exists(temp + @"\config.json")) { blogModel.IsExists_config = true; } else { blogModel.IsExists_data = false; }

                if (File.Exists(temp + @"\links.json")) { blogModel.IsExists_links = true; } else { blogModel.IsExists_links = false; }

                if (File.Exists(temp + @"\posts.json")) { blogModel.IsExists_posts = true; } else { blogModel.IsExists_posts = false; }

                if (File.Exists(temp + @"\projects.json")) { blogModel.IsExists_projects = true; } else { blogModel.IsExists_projects = false; }



                temp = temp + @"\";
                //记录必要文件的内容
                blogModel.string_about = File.ReadAllText(temp + "about.md");

                blogModel.string_config = File.ReadAllText(temp + "config.json");
                blogModel.string_links = File.ReadAllText(temp + "links.json");

                blogModel.string_posts = File.ReadAllText(temp + "posts.json");

                blogModel.string_projects = File.ReadAllText(temp + "projects.json");

            }
            else
            {
                blogModel.IsInitPosts = false;
            }


            return blogModel;


        }
        #endregion

    }
}
