using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Facebook;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace SSOAuth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var accessToken = "EAAvdmwzfhi0BAAPlecRdRgZCh7CyX0q1claOngTbGzka5G4AtVJbosiCxv8Uaq7tHODzWYuCSPLILnuRE2zzQZBlcZCfYv3ubUuYNOoYPq7qT3B8R2kSqzSuYZC5GEZA6IS2qBX3e6VRPk5zSL4KZCsAAtDkp56ZAYp0EcAZAl11vwZDZD";
            var client = new FacebookClient(accessToken);
            dynamic me = client.Get("me");
            string aboutMe = me.about;
            CreateHostBuilder(args).Build().Run();

           
            /* using (StreamWriter writer = new StreamWriter(@"UserDetails.txt"))
             {
                 Console.SetOut(writer);
                 GetData();
             }*/
        }

        static void GetData()
        {
            WebClient fbaccess = new WebClient();
            fbaccess.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            var accesstoken = "EAAvdmwzfhi0BAJu9SG9QWkkIzYCZBLJP9YVFujzDiAS3wFjLDOSta0xlyznFpE6RTZCnZBdlP4qjKQbs8ZAKZCnr07ZBW8hZAgWZAa3hwdoKPwOkxojQlrR1QUZCFjY3ojEk1d9JNNCJQFasGGjhg6JSZBaGJYCwo6BefRQONuuKA5uYNp4750FJ6IuLSNEGdT2TqLiloZAAAJu1TYal3GRVt4DwzLZBr25D4hZB5uDC5F8ZCMuEZAWR4kiYyIE";

            WebClient fbdev = new WebClient();
            fbdev.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            var jdata = fbdev.DownloadString("https://graph.facebook.com/3184082885047179/feed?access_token=" + accesstoken + "");
            JObject jparse = JObject.Parse(jdata);
            var data = jparse["data"];
            int i = 0;
            foreach(JObject root in data)
            {
                try
                {
                    Console.WriteLine((string)data[i]["id"] + (string)data[i]["message"] + "|" + (string)data[i]["created_time"]);

                }
                catch (Exception)
                {
                    Console.WriteLine((string)data[i]["id"] + (string)data[i]["message"] + "|" + (string)data[i]["created_time"]);
                }
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


    }
}
