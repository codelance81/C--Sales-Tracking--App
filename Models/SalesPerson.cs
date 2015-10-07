﻿using SalesApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp2.Models
{
    class SalesPerson:BaseModel,IActive

    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }


        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }

        public virtual ObservableListSource<Sale> Sales { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal SalesTarget { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName).Trim();
            }

        }
    }
}
