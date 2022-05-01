using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Entities.Concrete
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
