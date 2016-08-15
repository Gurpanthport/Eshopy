using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Eshopy.Models
{
    public class EshopyItemModels
    {
        public EshopyItemModels()
        {

        }

        public EshopyItemModels(string Name)
        {
            this.Name = Name;
        }
        [Display(Name ="Eshopy Item")]
        public virtual int EshopyItemModelsId { get; set; }
        [Display(Name ="Eshopy Type")]
        public virtual int EshopyTypeId { get; set; }
        public virtual EshopyTypeModels EshopyType { get; set; }
        public virtual string Name { get; set; }
        public virtual string description { get; set; }
        public virtual decimal Price { get; set; }
        [Display(Name ="Image Link")]
        public virtual string imgLink { get; set; }
    }
}