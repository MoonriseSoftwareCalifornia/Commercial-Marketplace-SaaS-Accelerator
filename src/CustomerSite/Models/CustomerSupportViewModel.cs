using System.ComponentModel.DataAnnotations;

namespace Marketplace.SaaS.Accelerator.CustomerSite.Models;

public class CustomerSupportViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "From Email Address")]
    public string CustomerEmail { get; set; }

    [Phone]
    [Display(Name = "Telephone Number")]
    public string CustomerPhone { get; set; } = string.Empty;

    [Display(Name = "Use WhatsApp with this number?")]
    public bool WhatsAppPhone { get; set; } = false;

    [EmailAddress]
    [Display(Name = "CC Email Address")]
    public string CcEmail { get; set; } = string.Empty;

    [Display(Name = "Subject")]
    [Required(AllowEmptyStrings = false)]
    public string Subject { get; set; }

    [DataType(DataType.Html)]
    [Required(AllowEmptyStrings = false)]
    [Display(Name = "Message")]
    public string MessageContent { get; set; }
}
