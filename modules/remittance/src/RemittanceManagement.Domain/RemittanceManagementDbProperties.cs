namespace RemittanceManagement;

public static class RemittanceManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "App";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "RemittanceManagement";
    public const int MaxLength = 1000000000;
}
