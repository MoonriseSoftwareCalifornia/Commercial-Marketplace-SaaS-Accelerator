using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marketplace.SaaS.Accelerator.DataAccess.Entities;
/// <summary>
/// Represents a customer install of Cosmos
/// </summary>
public class CosmosInstall
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Subscription Id
    /// </summary>
    public int SubscriptionId { get; set; }

    #region COSMOS WEB FARM INFORMATION

    /// <summary>
    /// Is a Cosmos CMS Site (if not is a comtainer site)
    /// </summary>
    [Display(Name = "Is Cosmos CMS Website?")]
    public bool IsCosmosSite { get; set; } = true;

    /// <summary>
    /// ID of the subscription (tenant) where instance is hosted with Cosmos WS
    /// </summary>
    [Display(Name = "CWS Subscription ID.")]
    public Guid AmpsubscriptionId { get; set; }

    /// <summary>
    /// Resource group where instance installed
    /// </summary>
    [Display(Name = "Resource Group Name.")]
    public string ResourceGroupName { get; set; }

    /// <summary>
    /// Publisher app plan name
    /// </summary>
    [Display(Name = "Publisher app plan")]
    public string PublisherAppPlan { get; set; }

    /// <summary>
    /// Editor app plan name
    /// </summary>
    [Display(Name = "Editor app plan")]
    public string EditorAppPlan { get; set; }

    /// <summary>
    /// Cosmos Account Name
    /// </summary>
    [Display(Name = "Cosmos Account Name")]
    public string CosmosAccount { get; set; }

    /// <summary>
    /// Storage Account Name
    /// </summary>
    [Display(Name = "Storage Account Name")]
    public string StorageAccount { get; set; }

    [Display(Name = "Front Door Name")]
    public string FrontDoorName { get; set; }

    [Display(Name = "Front CDN Name")]
    public string CdnName { get; set; }

    /// <summary>
    /// SignalR Name
    /// </summary>
    [Display(Name = "SignalR Name")]
    public string SignalRName { get; set; }

    [Display(Name = "Editor Url")]
    public string EditorUrl { get; set; }

    [Display(Name = "Publisher Url")]
    public string PublisherUrl { get; set; }

    #endregion

    #region USER QUESTIONAIRE

    /// <summary>
    /// Publisher DNS Names
    /// </summary>
    [Display(Name = "Publisher DNS Name(s)")]
    public string PublisherDnsNames { get; set; }

    /// <summary>
    /// Editor DNS Name(s)
    /// </summary>
    [Display(Name = "Editor DNS Name(s)")]
    public string EditorDnsNames { get; set; }

    /// <summary>
    /// DNS Names hosted by CWS
    /// </summary>
    [Display(Name = "DNS Names hosted by CWS")]
    public bool DomainHostedByCosmos { get; set; } = false;

    /// <summary>
    /// Allow local logins to Cosmos CMS
    /// </summary>
    [Display(Name = "Manage user accounts with website?")]
    public bool? AllowLocalLogins { get; set; } = false;

    /// <summary>
    /// Manage user accounts with Microsoft Entra ID
    /// </summary>
    [Display(Name = "Manage user accounts with Cosmos managed Microsoft Entra ID?")]
    public bool UseCWSEntraID { get; set; } = true;

    /// <summary>
    /// List the providers allows with CWS Entra ID
    /// </summary>
    public string CWSAzureB2CProviderList { get; set; }

    /// <summary>
    /// Manage user accounts with Microsoft Entra ID
    /// </summary>
    [Display(Name = "Manage user accounts with your Azure Active Directory (Entra ID)?")]
    public bool? UseCustomerEntraID { get; set; } = false;

    /// <summary>
    /// Last time this was updated by the customer
    /// </summary>
    public DateTimeOffset LastUpdatedByCustomer { get; set; }

    /// <summary>
    /// Date and time the site was provisioned and ready for customer use
    /// </summary>
    public DateTimeOffset DateTimeProvisioned { get; set; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// Use Cosmos malware protection?
    /// </summary>
    public bool MalwareScan { get; set; } = false;

    /// <summary>
    /// Customer comments
    /// </summary>
    public string Comments { get; set; }

    /// <summary>
    /// Internal notes for this installation (Cosmos staff only)
    /// </summary>
    public string InternalNotes { get; set; }

    /// <summary>
    /// Preload the website with this community layout
    /// </summary>
    public string PreloadLayout { get; set; }

    public virtual Subscriptions Subscription { get; set; }

    #endregion
}
