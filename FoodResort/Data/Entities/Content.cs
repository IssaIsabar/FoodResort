using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodResort.Data
{
    public class Content : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public Content(string _title, string _body)
        {
            Title = _title;
            Body = _body;
        }

        public Content()
        {
            Title = string.Empty;
            Body = string.Empty;
        }

    }
}
