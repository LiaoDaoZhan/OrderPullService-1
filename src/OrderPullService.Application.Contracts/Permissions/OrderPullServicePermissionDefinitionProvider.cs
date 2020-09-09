using OrderPullService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OrderPullService.Permissions
{
    public class OrderPullServicePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OrderPullServicePermissions.GroupName, L("Permission:OrderPullService"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OrderPullServiceResource>(name);
        }
    }
}