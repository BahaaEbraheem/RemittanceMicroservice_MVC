namespace CurrencyManagment;

public static class CurrencyManagmentDbProperties
{
    public static string DbTablePrefix { get; set; } = "App";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CurrencyManagment";
}
