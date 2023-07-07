using System.ComponentModel.DataAnnotations;

namespace Marketplace.SaaS.Accelerator.CustomerSite.Models;

public class CustomerSupportViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "From Email Address")]
    public string CustomerEmail { get; set; }

    [EmailAddress]
    [Display(Name = "CC Email Address")]
    public string? CcEmail { get; set; }

    [Display(Name = "Subject")]
    [Required(AllowEmptyStrings = false)]
    public string Subject { get; set; }

    [DataType(DataType.Html)]
    [Required(AllowEmptyStrings = false)]
    [Display(Name = "Message")]
    public string MessageContent { get; set; }
}
