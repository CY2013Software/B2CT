using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcShopping.Models
{
    [DisplayName("会员信息")]
    [DisplayColumn("Name")]
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("会员帐号(Email)")]
        [Required(ErrorMessage = "请输入Email地址")]
        [Description("我们直接以Email当成会员的登录帐号")]
        [MaxLength(250, ErrorMessage = "Email的长度不能超过250个字符")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("会员密码")]
        [Required(ErrorMessage = "请输入密码")]
        [Description("字符串长度皆为20个字符")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("中文姓名")]
        [Required(ErrorMessage = "请输入中文姓名")]
        [MaxLength(5,ErrorMessage="中文姓名不可超过5个字")]
        [Description("暂不考虑英文注册情况")]
        public string Name { get; set; }

        [DisplayName("地址")]
        [Required(ErrorMessage = "请输入您的地址")]
        [MaxLength(100, ErrorMessage = "网络昵称不可超过100个字符")]
        public string Address { get; set; }

        [DisplayName("电话号码")]
        [Required(ErrorMessage = "请输入您的电话号码")]
        [MaxLength(11, ErrorMessage = "请输入正确的手机号码")]
        [MinLength(11, ErrorMessage = "请输入正确的手机号码")]  
        public string Phone { get; set; }

        public virtual ICollection<OrderHeader> Orders { get; set; }
    }
}