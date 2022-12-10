using Volo.Abp.Reflection;

namespace CurrencyManagment.Permissions;

public class CurrencyManagmentPermissions
{
    public const string GroupName = "CurrencyManagment";
    public static class Currencies
    {
        public const string Default = GroupName + ".Currencies";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CurrencyManagmentPermissions));
    }
}
