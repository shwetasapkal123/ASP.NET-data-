using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagement
{
    public class FetchForJsonRiceData
    {
        public Rice Read(string path)
        {
            using(StreamReader file=new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }
                catch(Exception)
                {
                    return null;
                }
            }
        }
    }
}
