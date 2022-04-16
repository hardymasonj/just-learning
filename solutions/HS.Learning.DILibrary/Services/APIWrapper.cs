using HS.Learning.DILibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HS.Learning.DILibrary.Models
{
    public class APIWrapper : IAPIWrapper
    {
        private readonly IUrlStore _urlStore;

        public APIWrapper(IUrlStore urlStore)
        {
            this._urlStore = urlStore;
        }
        public string CalendarAPI => _urlStore.CalendarAPI;
    }
}
