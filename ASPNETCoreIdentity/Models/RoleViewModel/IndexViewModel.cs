using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreIdentity.Models.RoleViewModel
{
    public class IndexViewModel
    {
        [Required]
        public string Name { get; set; }

        [Display(Name = "Normalized Name")]
        public string NormName { get; set; }

    }
}
