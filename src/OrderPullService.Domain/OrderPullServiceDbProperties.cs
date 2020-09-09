namespace OrderPullService
{
    public static class OrderPullServiceDbProperties
    {
        public static string DbTablePrefix { get; set; } = "OrderPullService";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "OrderPullService";
    }
}
