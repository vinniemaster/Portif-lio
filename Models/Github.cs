using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Portifólio.Models
{
    public class GHConnect
    {
        
        

        public static List<GH_repo> GetProfile()
        {
            HttpClient http = new HttpClient();
            http.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
            var response = http.GetAsync("https://api.github.com/users/vinniemaster/repos").Result;
            var dados_list = new List<GH_repo>();


            if (response.IsSuccessStatusCode)
            {
                foreach (var item in JsonConvert.DeserializeObject<IEnumerable<GH_repo>>(response.Content.ReadAsStringAsync().Result))
                {
                    dados_list.Add(item);
                }

            }
            return dados_list;
        }
        public static string GetIcon(string language)
        {
            var languagesXicons = new Dictionary<string, string>();
            languagesXicons.Add("TypeScript", "typescript-plain colored");
            languagesXicons.Add("HTML", "html5-plain-wordmark colored");
            languagesXicons.Add("CSS", "css3-plain-wordmark colored");
            languagesXicons.Add("C#", "csharp-plain colored");
            languagesXicons.Add("JavaScript", "javascript-plain colored");
            languagesXicons.Add("Java", "java-plain-wordmark colored");

            foreach (var lang in languagesXicons)
            {

                if(language == lang.Key)
                {
                    return lang.Value;
                }
            }

            return "";
        }

        public static Dictionary<string, string> GetLanguages(string URL)
        {
            HttpClient http = new HttpClient();
            http.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
            var response = http.GetAsync(URL).Result;
            var dados_dict = new Dictionary<string, string>();


            if (response.IsSuccessStatusCode)
            {
                foreach (var item in JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content.ReadAsStringAsync().Result))
                {
                    dados_dict.Add(item.Key, item.Value);
                }

            }
            return dados_dict;
        }



    }

 



    public class GH_props
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
    }

    public class GH_repo
    {
        public int id { get; set; }
        public string node_id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public bool @private { get; set; }
        public GH_props owner { get; set; }
        public string html_url { get; set; }
        public string description { get; set; }
        public bool fork { get; set; }
        public string url { get; set; }
        public string forks_url { get; set; }
        public string keys_url { get; set; }
        public string collaborators_url { get; set; }
        public string teams_url { get; set; }
        public string hooks_url { get; set; }
        public string issue_events_url { get; set; }
        public string events_url { get; set; }
        public string assignees_url { get; set; }
        public string branches_url { get; set; }
        public string tags_url { get; set; }
        public string blobs_url { get; set; }
        public string git_tags_url { get; set; }
        public string git_refs_url { get; set; }
        public string trees_url { get; set; }
        public string statuses_url { get; set; }
        public string languages_url { get; set; }
        public string stargazers_url { get; set; }
        public string contributors_url { get; set; }
        public string subscribers_url { get; set; }
        public string subscription_url { get; set; }
        public string commits_url { get; set; }
        public string git_commits_url { get; set; }
        public string comments_url { get; set; }
        public string issue_comment_url { get; set; }
        public string contents_url { get; set; }
        public string compare_url { get; set; }
        public string merges_url { get; set; }
        public string archive_url { get; set; }
        public string downloads_url { get; set; }
        public string issues_url { get; set; }
        public string pulls_url { get; set; }
        public string milestones_url { get; set; }
        public string notifications_url { get; set; }
        public string labels_url { get; set; }
        public string releases_url { get; set; }
        public string deployments_url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime pushed_at { get; set; }
        public string git_url { get; set; }
        public string ssh_url { get; set; }
        public string clone_url { get; set; }
        public string svn_url { get; set; }
        public object homepage { get; set; }
        public int size { get; set; }
        public int stargazers_count { get; set; }
        public int watchers_count { get; set; }
        public string language { get; set; }
        public bool has_issues { get; set; }
        public bool has_projects { get; set; }
        public bool has_downloads { get; set; }
        public bool has_wiki { get; set; }
        public bool has_pages { get; set; }
        public bool has_discussions { get; set; }
        public int forks_count { get; set; }
        public object mirror_url { get; set; }
        public bool archived { get; set; }
        public bool disabled { get; set; }
        public int open_issues_count { get; set; }
        public object license { get; set; }
        public bool allow_forking { get; set; }
        public bool is_template { get; set; }
        public bool web_commit_signoff_required { get; set; }
        public List<object> topics { get; set; }
        public string visibility { get; set; }
        public int forks { get; set; }
        public int open_issues { get; set; }
        public int watchers { get; set; }
        public string default_branch { get; set; }
    }
}
