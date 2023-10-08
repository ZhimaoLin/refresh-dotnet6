using BuberBreakfast.Contract.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        Breakfast GetBreakfast(Guid id);
        //BreakfastResponse CreateBreakfast(CreateBreakfastRequest request);
        //BreakfastResponse GetBreakfast(Guid id);
        //BreakfastResponse UpdateBreakfast(Guid id, UpsertBreakfastRequest request);
        //BreakfastResponse DeleteBreakfast(Guid id);
    }
}
