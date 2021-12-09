using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataAnnotation_Demo.Models
{
    public class User
    {
        [DisplayName("姓名")]
        [Required(ErrorMessage = "{0}需要輸入")]
        [StringLength(5,ErrorMessage = "姓名必須介於3~5個字間",MinimumLength = 2)]
        public string Name { get; set; }

        [DisplayName("年齡")]
        [Range(0, 100, ErrorMessage = "{0}需介於0~100間")]
        public int Age { get; set; }


        [DisplayName("密碼")]
        [System.ComponentModel.DataAnnotations.Compare("RePassword",ErrorMessage = "兩次密碼輸入不一致")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("再確認密碼")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }

        [RegularExpression(@"^09[0-9]{8}", ErrorMessage = "請輸入正確的電話號碼")]
        public string Phone { get; set; }

        [EmailAddress( ErrorMessage = "這不是Email格式")]
        public string Email { get; set; }


        [Url(ErrorMessage = "這不是網址格式")]
        public string Url { get; set; }


        [FileExtensions(ErrorMessage = "上傳的檔案不是圖片")]
        public HttpPostedFileBase File { get; set; }

        [Remote("CheckName","Home",ErrorMessage = "NickName不等於ABC哦")]
        public string NickName { get; set; }

    }
}