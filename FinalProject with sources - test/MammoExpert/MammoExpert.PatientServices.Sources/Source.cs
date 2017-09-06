using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MammoExpert.PatientServices.Sources
{
    public class Source
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

        public int Id { get; set; }
        public SourceType Type { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public string ConnectionString { get; set; }

        public Dictionary<string, string> Parameters { get; set; }

        public Source(SourceType type)
        {
            Type = type;
            //Id = new Random().Next(0, 999);
            //Parameters = dic[type];
        }
    }

    //public abstract class Parameters
    //{

    //}

    //public class DBParameters : Parameters
    //{
    //    public string Driver { get; set; }
    //    public string Ip { get; set; }
    //    public string Port { get; set; }
    //    public string UserName { get; set; }
    //    public string Password { get; set; }

    //    public DBParameters(string driver, string ip, string port,  string userName, string password)
    //    {
    //        Driver = driver;
    //        Ip = ip;
    //        Port = port;
    //        UserName = userName;
    //        Password = password;
    //    }

    //    public DBParameters()
    //    {
    //        Driver = string.Empty;
    //        Ip = string.Empty;
    //        Port = string.Empty;
    //        UserName = string.Empty;
    //        Password = string.Empty;
    //    }
    //}

    //public class WLParameters : Parameters
    //{
    //    public string Header { get; set; }
    //    public string Ip { get; set; }
    //    public string Port { get; set; }
    //    public string Timeout { get; set; }

    //    public WLParameters(string header, string ip, string port, string timeout)
    //    {
    //        Header = header;
    //        Ip = ip;
    //        Port = port;
    //        Timeout = timeout;
    //    }

    //    public WLParameters()
    //    {
    //        Header = string.Empty;
    //        Ip = string.Empty;
    //        Port = string.Empty;
    //        Timeout = string.Empty;
    //    }
    //}

    public abstract class S
    {
        
    }
    public class DBSource : S
    {
        public string Driver { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string ConectionString { get; set; }

        public SourceType Type { get; set; }

        public string Description { get; set; }

        public DBSource()
        {
            Type = SourceType.DataBase;
        }
    }

    public class WLSource : S
    {
        public string Header { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Timeout { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string ConectionString { get; set; }

        public SourceType Type { get; set; }

        public string Description { get; set; }
        public WLSource()
        {
            Type = SourceType.Worklist;
        }
    }
}
