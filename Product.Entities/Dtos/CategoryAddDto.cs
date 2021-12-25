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
    public class CategoryAddDto:IDto
    {
        [DisplayName("Category_Name")]
        [Required(ErrorMessage ="{0} boş geçilemez")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakteri geçemez")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden az olamaz geçemez")]
        public string CategoryName { get; set; }
        
        [DisplayName("Description")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        [MaxLength(500,ErrorMessage ="{0} {1} karakteri geçemez")]
        [MinLength(5,ErrorMessage = "{0} {1} karakterden az olamaz geçemez")]
        public string Description { get; set; }

        [DisplayName("IsActive ? ")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public  bool IsActive { get; set; }
    }
}
