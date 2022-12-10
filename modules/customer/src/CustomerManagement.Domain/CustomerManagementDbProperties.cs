namespace CustomerManagement;

public static class CustomerManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "App";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CustomerManagement";
}
