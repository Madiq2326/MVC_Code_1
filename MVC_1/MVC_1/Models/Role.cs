using MVC_1.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_1.Models
{
    [Table("TB_M_Role")]
    public class Role : BaseModel
    {
        public String Name { get; set; }
    }
}