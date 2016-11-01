using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
namespace MvcShopping.Models
{
    [DisplayName("商品信息")]
    [DisplayColumn("Name")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("产品类别")]
        //[Required(ErrorMessage = "请选择商品类别")]
        public virtual ProductCategory productCategory { get; set; }

        [DisplayName("产品名称")]
        [Required(ErrorMessage = "请输入商品名称")]
        [MaxLength(60, ErrorMessage = "商品名称不可超过60个字")]
        public string Name { get; set; }

        [DisplayName("商品简介")]
        [Required(ErrorMessage = "请输入商品简介")]
        [MaxLength(250, ErrorMessage = "商品名称不可超过250个字")]
        public string Description { get; set; }

        [DisplayName("产品价格")]
        [Required(ErrorMessage = "请输入产品价格")]
        [Range(99, 10000, ErrorMessage = "产品价格必须介于99-10000之间")]
        public int Price { get; set; }

        [DisplayName("商品库存")]
        [Required(ErrorMessage = "请输入商品库存")]
        public string Stock { get; set; }
    }
}