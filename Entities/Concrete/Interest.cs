using CV.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.Entities.Concrete
{
    public class Interest:ITable
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
