using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marketplace.SaaS.Accelerator.DataAccess.Entities;
public class CosmosWebsite
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int? SubscriptionId { get; set; }

    public int PrimaryWebFarmId { get; set; }

    public int? SecondaryWebFarmId { get; set; }

    public string FrontDoorName { get; set; }

    public string CdnName { get; set; }

    public string PrimaryPublisherUrl { get; set; }

    public string SecondaryPublisherUrl { get; set; }

    public string PublisherCustomDnsNames { get; set; }

    public string PrimaryEditorUrl { get; set; }

    public string SecondaryEditorUrl { get; set; }

    public string EditorCustomDnsNames { get; set; }

    public string SendGridAccountName { get; set; }

    public string SignalRName { get; set; }

    public string CosmosServer { get; set; }

    #region Navigation

    [ForeignKey(nameof(SubscriptionId))]
    public Subscriptions Subscriptions { get; set; }

    [ForeignKey(nameof(PrimaryWebFarmId))]
    public WebFarm PrimaryWebFarm { get; set; }

    [ForeignKey(nameof(SecondaryWebFarmId))]
    public WebFarm SecondaryWebFarm { get; set; }

    #endregion
}
