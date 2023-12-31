﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberBreakfast.Contract.Breakfast
{
    public record BreakfastResponse
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public DateTime StartDateTime { get; init; }
        public DateTime EndDateTime { get; init; }
        public DateTime LastModifiedDateTime { get; init; }
        public List<string> Savory { get; init; }
        public List<string> Sweet { get; init; }

        public BreakfastResponse(
            Guid id, 
            string name, 
            string description, 
            DateTime startDateTime, 
            DateTime endDateTime, 
            DateTime lastModifiedDateTime, 
            List<string> savory, 
            List<string> sweet)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
            Savory = savory;
            Sweet = sweet;
        }
    }
}
