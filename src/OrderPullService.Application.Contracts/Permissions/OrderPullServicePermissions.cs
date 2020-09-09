using Volo.Abp.Reflection;

namespace OrderPullService.Permissions
{
    public class OrderPullServicePermissions
    {
        public const string GroupName = "OrderPullService";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(OrderPullServicePermissions));
        }
    }
}