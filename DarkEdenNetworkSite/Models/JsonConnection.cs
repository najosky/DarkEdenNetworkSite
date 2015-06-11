using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DarkEdenNetworkSite.Models
{
    public class JsonConnection
    {
        public T Read<T>(string path)
        {

            StreamReader re = new StreamReader(path);
            string json = re.ReadToEnd();
            re.Close();
            return JsonConvert.DeserializeObject<T>(json);
        }
        public void Write<T>(string path, T obj)
        {
            StreamWriter wr = new StreamWriter(path);
            JsonTextWriter writer = new JsonTextWriter(wr);
            JsonSerializer ser = new JsonSerializer();
            ser.Serialize(writer, obj);
            writer.Close();
        }
    }
}