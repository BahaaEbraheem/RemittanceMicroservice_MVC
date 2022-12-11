using Volo.Abp.Reflection;

namespace RemittanceManagement.Permissions;

public class RemittanceManagementPermissions
{
    public const string GroupName = "RemittanceManagement";
    public static class Remittances
    {
        public const string Default = GroupName + ".Remittances";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class Status
    {
        public const string Default = GroupName + ".Status";
        public const string Approved = Default + ".Approved";
        public const string Released = Default + ".Released";
        public const string Create = Default + ".Create";
        public const string Ready = Default + ".Ready";
    }
    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(RemittanceManagementPermissions));
    }
}
