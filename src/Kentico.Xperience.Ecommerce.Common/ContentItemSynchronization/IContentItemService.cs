using CMS.ContentEngine;

namespace Kentico.Xperience.Ecommerce.Common.ContentItemSynchronization;

/// <summary>
/// Interface for content items management
/// </summary>
public interface IContentItemService
{
    /// <summary>
    /// Add and publish content item.
    /// </summary>
    /// <param name="addParams"></param>
    /// <returns>ID of created content item.</returns>
    Task<int> AddContentItem(ContentItemAddParams addParams);


    /// <summary>
    /// Get content items of given content type and query params.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="contentType"></param>
    /// <param name="queryParams"></param>
    /// <returns>Collection of content items.</returns>
    Task<IEnumerable<T>> GetContentItems<T>(string contentType, Action<ContentTypeQueryParameters> queryParams)
        where T : IContentItemFieldsSource, new();


    /// <summary>
    /// Get content items of given content type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="contentType"></param>
    /// <returns>Collection of content items.</returns>
    Task<IEnumerable<T>> GetContentItems<T>(string contentType)
        where T : IContentItemFieldsSource, new();


    /// <summary>
    /// Get content items of given content type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="contentType"></param>
    /// <param name="linkedItemsLevel">>Max. level for linked items</param>
    /// <returns>Collection of content items.</returns>
    Task<IEnumerable<T>> GetContentItems<T>(string contentType, int linkedItemsLevel)
         where T : IContentItemFieldsSource, new();


    /// <summary>
    /// Updates content item.
    /// </summary>
    /// <param name="updateParams"></param>
    /// <returns>True when update succeeds, else False.</returns>
    Task<bool> UpdateContentItem(ContentItemUpdateParams updateParams);


    /// <summary>
    /// Deletes content item.
    /// </summary>
    /// <param name="contentItemID"></param>
    /// <param name="languageName"></param>
    /// <param name="userID"></param>
    /// <returns></returns>
    Task DeleteContentItem(int contentItemID, string languageName, int userID);


    /// <summary>
    /// Delete content items.
    /// </summary>
    /// <param name="contentItemIDs">Content type IDs</param>
    /// <param name="languageName"></param>
    /// <param name="userID"></param>
    /// <returns></returns>
    Task DeleteContentItems(IEnumerable<int> contentItemIDs, string languageName, int userID);
}

