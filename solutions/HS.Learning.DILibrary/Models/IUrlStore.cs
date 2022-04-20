using System;
using System.Collections.Generic;
using System.Text;

namespace HS.Learning.DILibrary.Services
{
    public interface IUrlStore
    {
        string CalendarAPI { get; }
        string CalendarSite { get; }
    }
}
