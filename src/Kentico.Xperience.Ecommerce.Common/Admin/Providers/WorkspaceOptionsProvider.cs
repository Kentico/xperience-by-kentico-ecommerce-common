using CMS.DataEngine;
using CMS.Helpers;
using CMS.Workspaces;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace Kentico.Xperience.Ecommerce.Common.Admin.Providers
{
    public class WorkspaceOptionsProvider(
        IInfoProvider<WorkspaceInfo> workspaceInfoProvider,
        IProgressiveCache cache) : IDropDownOptionsProvider
    {
        public async Task<IEnumerable<DropDownOptionItem>> GetOptionItems() =>
            (await cache.LoadAsync(
                    GetWorkspaces,
                    new CacheSettings(120, $"{nameof(WorkspaceOptionsProvider)}|{nameof(GetOptionItems)}")))
                .Select(w => new DropDownOptionItem()
                {
                    Value = w.WorkspaceName,
                    Text = w.WorkspaceDisplayName
                });

        private async Task<IEnumerable<WorkspaceInfo>> GetWorkspaces(CacheSettings cs)
        {
            cs.CacheDependency = CacheHelper.GetCacheDependency($"{WorkspaceInfo.OBJECT_TYPE}|all");

            return await workspaceInfoProvider.Get().GetEnumerableTypedResultAsync();
        }
    }
}
