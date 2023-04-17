using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SBS_2page_webApp.Models
{
    public class Info_Class
    {


        [Required]
        public int PersonId { get; set; }

        [Required]
        [StringLength(20)]
        public string TelNo { get; set; }

        [Required]
        [StringLength(20)]
        public string CellNo { get; set; }

        [Required]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [StringLength(100)]
        public string AddressLine3 { get; set; }

        [Required]
        [StringLength(10)]
        public string AddressCode { get; set; }

        [StringLength(100)]
        public string PostalAddress1 { get; set; }

        [StringLength(100)]
        public string PostalAddress2 { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }


    }
}