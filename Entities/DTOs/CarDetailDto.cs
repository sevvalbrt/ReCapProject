﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }

        public int CustomerId { get; set; }

        public int RentalId { get; set; }

        public string Description { get; set; }

        public string BrandName{ get; set; }

        public string ColorName { get; set; }

        public decimal DailyPrice { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string CompanyName { get; set; }
    }
}
