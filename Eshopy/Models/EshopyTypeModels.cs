using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Eshopy.Models
{
    public class EshopyTypeModels
    {
        public EshopyTypeModels()
        {

        }

        public EshopyTypeModels(string Name)
        {
            this.Name = Name;
        }

        public virtual int EshopyTypeModelsId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string imageUrl { get; set; }
        public virtual List<EshopyItemModels> EshopyItems { get; set; }
    }
}