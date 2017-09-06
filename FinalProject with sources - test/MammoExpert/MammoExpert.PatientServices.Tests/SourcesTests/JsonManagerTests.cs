using System;
using System.Collections.Generic;
using System.IO;
using MammoExpert.PatientServices.Sources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace MammoExpert.PatientServices.Tests.SourcesTests
{
    [TestClass]
    public class JsonManagerTests
    {
        [TestMethod]
        public void LoadJson_JsonString_Object()
        {
            // Arrange
            string jsonString = "[{'Id': 229,'Type': 0, 'Description': 'Описание', 'Name': '', 'ConnectionString': '', 'Parameters': { 'Driver': '','Ip': '127.167.0.1','Port': '8080', 'UserName': 'Вася','Password': '1254'}," +
                                 "{'Id': 132,'Type': 1, 'Description': 'Описание 2', 'Name': '', 'ConnectionString': '','Parameters': { 'Header': '','Ip': '127.167.0.1','Port': '8080','Timeout': '2000'}]";

            List<Source> expected = new List<Source>()
            {
                new Source(SourceType.DataBase)
                {
                    Id = 229,
                    Description = "Описание",
                    Parameters = new Dictionary<string, string>()
                    {
                        {"Driver", "" },
                        {"Ip", "127.167.0.1"},
                        {"Port", "8080"},
                        {"UserName", "Вася"},
                        {"Password", "1254"}
                    }

                },
                new Source(SourceType.Worklist)
                {
                    Id = 132,
                    Description = "Описание 2",
                    Parameters = new Dictionary<string, string>()
                    {
                        {"Header", "" },
                        {"Ip", "127.167.0.1"},
                        {"Port", "8080"},
                        {"Timeout", "2000"}
                    }
                }
            };

            // Act

            List<Source> actual = JsonConvert.DeserializeObject<List<Source>>(jsonString);

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
