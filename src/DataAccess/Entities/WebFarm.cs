using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marketplace.SaaS.Accelerator.DataAccess.Entities;
public class WebFarm
{
    /// <summary>
    /// Unique ID of this web farm
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string ResourceGroupId { get; set; }

    public string ResourceGroupName { get; set; }

    public string AzureRegionName { get; set; }

    public bool IsSharedHosting { get; set; }

    /// <summary>
    /// If not shared hosting, add the subscription assocated with this farm
    /// </summary>
    public Subscriptions Subscriptions { get; set; }
}
