using Volo.Abp.Reflection;

namespace CustomerManagement.Permissions;

public class CustomerManagementPermissions
{
    public const string GroupName = "CustomerManagement";
    public static class Customers
    {
        public const string Default = GroupName + ".Customers";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CustomerManagementPermissions));
    }
}
