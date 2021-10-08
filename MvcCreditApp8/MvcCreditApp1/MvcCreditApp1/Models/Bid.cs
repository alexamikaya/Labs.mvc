using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcCreditApp1.Models
{
    public class Bid
    {

        public virtual int BidId { get; set; }
        [DisplayName("Имя заявителя")]
        public virtual string Name { get; set; }

        [DisplayName("Название кредита")]
        public virtual string CreditHead { get; set; }

        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        [Required]
        public virtual DateTime bidDate { get; set; }
    }

}