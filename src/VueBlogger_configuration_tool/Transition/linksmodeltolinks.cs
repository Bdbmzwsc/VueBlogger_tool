using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VueBlogger_configuration_tool.Models;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace VueBlogger_configuration_tool.Transition
{
    public class linksmodeltolinks
    {
        #region LinksModel_to_LinksJson

        
        
        public static string linksm_linksj(LinksModel linksModel)
        {
            JObject links_json=new JObject();
            links_json.Add("title", linksModel.title);
            links_json.Add("desc",linksModel.desc);
            links_json.Add("link",linksModel.link);
            return links_json.ToString();
        }

        #endregion

        #region LinksJson_to_LinksModel
        public static LinksModel linksj_linksm(string linksJson)
        {
            LinksModel linksModel = new LinksModel();
            JObject links_json=JObject.Parse(linksJson);
            linksModel.title=links_json["title"].ToString();
            linksModel.desc=links_json["desc"].ToString();
            linksModel.link=links_json["link"].ToString();
            return linksModel;
        }
        #endregion
    }
}
