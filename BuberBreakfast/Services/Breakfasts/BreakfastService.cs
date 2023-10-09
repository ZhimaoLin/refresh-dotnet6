using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        private readonly Dictionary<Guid, Breakfast> _breakfasts = new Dictionary<Guid, Breakfast>();

        public ErrorOr<Created> CreateBreakfast(Breakfast breakfast)
        {
            _breakfasts.Add(breakfast.Id, breakfast);
            return Result.Created;
        }

        public ErrorOr<Breakfast> GetBreakfast(Guid id)
        {
            if (_breakfasts.TryGetValue(id, out var breakfast))
            {
                return breakfast;
            }
            return Errors.Breakfast.NotFound;
        }

        public ErrorOr<UpsertBreakfastResult> UpsertBreakfast(Breakfast breakfast)
        {
            var isNewlyCreated = !_breakfasts.ContainsKey(breakfast.Id);
            _breakfasts[breakfast.Id] = breakfast;
            return new UpsertBreakfastResult(isNewlyCreated);
        }

        public ErrorOr<Deleted> DeleteBreakfast(Guid id)
        {
            if (!_breakfasts.ContainsKey(id))
            {
                return Errors.Breakfast.NotFound;
            }

            _breakfasts.Remove(id);
            return Result.Deleted;
        }   
    }
}
