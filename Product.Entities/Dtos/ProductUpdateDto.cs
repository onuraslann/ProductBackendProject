using Product.Core.Entities.Abstract;
using Product.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities.Dtos
{
   public class ProductUpdateDto:IDto
    {
        [DisplayName("Product_Id")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public int Id { get; set; }

        [DisplayName("Category_Id")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [DisplayName("Brand_Id")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [DisplayName("Color_Id")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public int ColorId { get; set; }
        public Color Color { get; set; }
        [DisplayName("ProductName")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakteri geçemez")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden az olamaz geçemez")]
        public string ProductName { get; set; }
        [DisplayName("IsActive ? ")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public bool IsActive { get; set; }
        
        [DisplayName("IsDeleted ? ")]
        [Required(ErrorMessage = "{0} boş geçilemez")]
        public bool IsDeleted { get; set; }
    }
}
