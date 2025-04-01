using CMS.Workspaces.Internal;

using Kentico.Xperience.Admin.Base.FormAnnotations;
using Kentico.Xperience.Ecommerce.Common.Admin.FormComponentConfigurator;
using Kentico.Xperience.Ecommerce.Common.Admin.Providers;

namespace Kentico.Xperience.Ecommerce.Common.Admin
{
    public class SynchronizationSettingsModel
    {
        [RequiredValidationRule]
        [DropDownComponent(Label = EcommerceCommonConstants.SettingsWorkspaceName, DataProviderType = typeof(WorkspaceOptionsProvider), Order = 0)]
        public string WorkspaceName { get; set; } = WorkspaceConstants.WORKSPACE_DEFAULT_CODE_NAME;

        [RequiredValidationRule]
        [ContentFolderSelectorComponent(Label = EcommerceCommonConstants.SettingsProductSKUFolderGuid, Order = 10)]
        [FormComponentConfiguration(ContentFolderWorkspaceConfigurator.IDENTIFIER, nameof(WorkspaceName))]
        public int ProductFolderId { get; set; }

        [RequiredValidationRule]
        [ContentFolderSelectorComponent(Label = EcommerceCommonConstants.SettingsProductVariantFolderGuid, Order = 20)]
        [FormComponentConfiguration(ContentFolderWorkspaceConfigurator.IDENTIFIER, nameof(WorkspaceName))]
        public int ProductVariantFolderId { get; set; }

        [RequiredValidationRule]
        [ContentFolderSelectorComponent(Label = EcommerceCommonConstants.SettingsProductImageFolderGuid, Order = 30)]
        [FormComponentConfiguration(ContentFolderWorkspaceConfigurator.IDENTIFIER, nameof(WorkspaceName))]
        public int ImageFolderId { get; set; }
    }
}
