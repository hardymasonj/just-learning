using HS.Learning.DILibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Learning.DIConsole.Configuration
{
    public class UrlStoreModel : IUrlStore
    {
        public string CalendarAPI => "https://www.example.com/api/v1/calendar";

        public string CalendarSite => "https://www.example.com/calendar";
    }
}
