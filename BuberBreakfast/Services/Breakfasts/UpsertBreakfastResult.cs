namespace BuberBreakfast.Services.Breakfasts
{
    public record struct UpsertBreakfastResult
    {
        public bool IsNewlyCreated {  get; set; }

        public UpsertBreakfastResult(bool isNewlyCreated)
        {
            IsNewlyCreated = isNewlyCreated;
        }
    }
}
