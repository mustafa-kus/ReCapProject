using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class CarImage:IEntity
    {
        public CarImage()
        {
            Date = DateTime.Now;
        }

        //Id,CarId,ImagePath,Date
        public int Id { get; set; }

        public int CarID { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
