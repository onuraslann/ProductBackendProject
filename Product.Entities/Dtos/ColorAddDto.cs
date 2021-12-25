using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities.Dtos
{
    public class ColorAddDto:IDto
    {
        [DisplayName("Color_Name")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakteri geçemez")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden az olamaz geçemez")]
        public string ColorName { get; set; }

        [DisplayName("IsActive ? ")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public bool IsActive { get; set; }
    }
}
