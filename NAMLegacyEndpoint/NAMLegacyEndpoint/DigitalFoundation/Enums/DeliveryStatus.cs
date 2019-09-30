namespace HeidelbergCement.Foundation.Common.Interfaces.Enums
{
    public enum DeliveryStatus
    {
        Unknown,
        Open,
        WaitingForLoad,
        Loading,
        InTransit,
        WaitingForUnload,
        Unloading,
        Unloaded,
        Completed,
		Returned,
		Invoiced,
        Cancelled,
        Loaded
    }
}
