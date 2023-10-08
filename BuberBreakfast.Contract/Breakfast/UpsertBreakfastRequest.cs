using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberBreakfast.Contract.Breakfast
{
    public record UpsertBreakfastRequest
    {
        public string Name {  get; init; }
        public string Description { get; init; }
        public DateTime StartDateTime { get; init; }
        public DateTime EndDateTime { get; init; }
        public List<string> Savory {  get; init; }
        public List<string> Sweet { get; init; }
    }
}
