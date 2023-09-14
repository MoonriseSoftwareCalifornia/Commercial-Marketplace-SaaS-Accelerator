using System;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.SaaS.Accelerator.CustomerSite.Models;

/// <summary>
/// Customer questionaire for initial sign
/// </summary>
public class CustomerQuestionaire
{
    public Guid AmpsubscriptionId { get; set; }

    /// <summary>
    /// Publisher DNS Names
    /// </summary>
    [Display(Name = "Public DNS Name(s) for your website:")]
    [Required(AllowEmptyStrings = false)]
    public string PublisherDnsNames { get; set; }

    /// <summary>
    /// Editor DNS Name(s)
    /// </summary>
    [Display(Name = "Editor DNS Name(s):")]
    public string EditorDnsNames { get; set; }

    /// <summary>
    /// Is a Cosmos CMS Site (if not is a comtainer site)
    /// </summary>
    [Display(Name = "Is Cosmos CMS Website?")]
    public bool IsCosmosSite { get; set; } = true;

    /// <summary>
    /// DNS Names hosted by CWS
    /// </summary>
    [Display(Name = "Do you want Cosmos to host your domain?")]
    public bool DomainHostedByCosmos { get; set; } = false;

    /// <summary>
    /// Allow local logins to Cosmos CMS
    /// </summary>
    [Display(Name = "Manage user accounts with website?")]
    public bool AllowLocalLogins { get; set; } = false;

    /// <summary>
    /// Manage user accounts with Microsoft Entra ID
    /// </summary>
    [Display(Name = "Manage user accounts with Cosmos/Microsoft Entra ID?")]
    public bool UseCWSEntraID { get; set; } = true;

    /// <summary>
    /// List the providers allows with CWS Entra ID
    /// </summary>
    public string CWSAzureB2CProviderList { get; set; }

    /// <summary>
    /// Manage user accounts with Microsoft Entra ID
    /// </summary>
    [Display(Name = "Manage user accounts with your own Entra ID?")]
    public bool UseCustomerEntraID { get; set; } = false;

    [Display(Name = "Do you want malware protection?")]
    public bool MalwareScan { get; set; } = false;

    [Display(Name = "Special notes/requests")]
    public string Comments { get; set; }
}
