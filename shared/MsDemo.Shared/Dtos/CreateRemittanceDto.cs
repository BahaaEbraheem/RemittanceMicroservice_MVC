using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static MsDemo.Shared.Enums.Enums;
using System.Linq;
using System.Threading.Tasks;
using MsDemo.Shared.Dtos;

using System.ComponentModel.DataAnnotations;

namespace MsDemo.Shared.Dtos
{
    public class CreateRemittanceDto /*: IValidatableObject*/
    {
        [Required]
        public double Amount { get; set; }

        [Required]
        public RemittanceType Type { get; set; }
        public string SerialNumber { get;  set; }

        //[Required]

        public Guid? CreatorId { get; set; }
        public DateTime CreationTime { get; set; }

        public Guid? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }
        public Guid? ReleasedBy { get; set; }
        public DateTime? ReleasedDate { get; set; }
        [Required]
        public Guid SenderBy { get; set; }
        public string SenderName { get; set; }
        public Guid? ReceiverBy { get; set; }
        [Required]
        public string ReceiverFullName { get; set; }
        public string ReceiverName { get; set; }

        [Required]
        public Guid CurrencyId { get; set; }


        public string CurrencyName { get; set; }
        public Remittance_Status State { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Amount <= 0)
        //    {
        //        yield return new ValidationResult(
        //            "Fill Amount greater than 0!",
        //            new[] { "Amount" }
        //        );
        //    }
        //}
    }
}
