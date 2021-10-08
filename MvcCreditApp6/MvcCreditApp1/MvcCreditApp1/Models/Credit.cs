using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcCreditApp1.Models
{
    public class Credit
    {
        
        public virtual int CreditId { get; set; }
        [DisplayName("Название")]
        [Required]
        public virtual string Head { get; set; }
        [DisplayName("Период")]
        public virtual int Period { get; set; }
        [DisplayName("Сумма кредита")]
        [Required]
        public virtual int Sum { get; set; }
        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }
       
    }
}