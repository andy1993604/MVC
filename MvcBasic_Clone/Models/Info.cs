using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcBasic_Clone.Models
{
    public class Info
    {
        
        public int Id { get; set; }

        [Display(Name = "姓名")]
        [Required(ErrorMessage = "Name必須輸入")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "最好需要三個字元")]
        public string Name { get; set; }
        [Display(Name = "行動電話")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        [Required(ErrorMessage = "Phone必須輸入")]
        public string Phone { get; set; }

        [Display(Name = "電子郵件")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email必須輸入")]
        public string Email { get; set; }
 

        [Display(Name="性別")]
        [Required(ErrorMessage ="Gender必須輸入")]
        public string Gender { get; set; }
    }
}