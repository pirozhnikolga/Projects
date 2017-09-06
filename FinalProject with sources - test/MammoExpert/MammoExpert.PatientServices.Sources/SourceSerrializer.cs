using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammoExpert.PatientServices.Sources
{
    public class SourceSerrializer
    {
        private static Dictionary<SourceType, Dictionary<string, string>> dic = new Dictionary<SourceType, Dictionary<string, string>>()
        {
            {SourceType.DataBase, new Dictionary<string, string>()
            {
                {"Driver", "" },
                {"Ip", ""},
                {"Port", ""},
                {"UserName", ""},
                {"Password", ""}
            } },
            {SourceType.Worklist, new Dictionary<string, string>()
            {
                {"Header", ""},
                {"Ip", ""},
                {"Port", ""},
                {"Timeout", ""}
            } }
        };

        public static S Serrialize(Source source)
        {
            S result = null;
            if (source.Type == SourceType.DataBase)
            {
                result = new DBSource()
                {
                    Id = source.Id,
                    Name = source.Name,
                    ConectionString = source.ConnectionString,
                    Driver = source.Parameters["Driver"],
                    Description = source.Description,
                    Ip = source.Parameters["Ip"],
                    Password = source.Parameters["Password"],
                    Port = source.Parameters["Port"],
                    UserName = source.Parameters["UserName"]
                };
            }
            if (source.Type == SourceType.Worklist)
            {
                result = new WLSource()
                {
                    Id = source.Id,
                    Name = source.Name,
                    ConectionString = source.ConnectionString,
                    Header = source.Parameters["Header"],
                    Description = source.Description,
                    Ip = source.Parameters["Ip"],
                    Timeout = source.Parameters["Timeout"],
                    Port = source.Parameters["Port"]
                };
            }
            return result;
        }

        //public static List<SourceDescription> Serrialize(List<Source> list)
        //{
        //    return list.Select(Serrialize).ToList();
        //}

        //public static Source Deserrialize(S source)
        //{
        //    var result = new Source(SourceType.DataBase);
        //    var t = source.GetType();
        //    if (t == typeof(DBSource))
        //    {
        //        result.Id = source.Id;

        //    }
            
        //    result.Id = source.Id;
        //    result.Description = source.Description;
        //    result.Parameters
        //    return result;
        //}

        //public static List<Source> Deserrialize(List<SourceDescription> list)
        //{
        //    return list.Select(Deserrialize).ToList();
        //}
    }

    public class SourceDescription
    {
        public int Id { get; set; }
        public SourceType Type { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Dictionary<string, string> Parameters { get; set; }

        public SourceDescription()
        {
            
        }
    }
 
}
