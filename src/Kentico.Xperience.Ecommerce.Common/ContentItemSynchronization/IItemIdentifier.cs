namespace Kentico.Xperience.Ecommerce.Common.ContentItemSynchronization;

/// <summary>
/// Interface to set external identifier for api objects.
/// </summary>
/// <typeparam name="TType">External ID type.</typeparam>
public interface IItemIdentifier<out TType>
{
    /// <summary>
    /// External identifier.
    /// </summary>
    public TType ExternalId { get; }
}
