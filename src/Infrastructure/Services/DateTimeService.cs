using BackToWorkBot.Application.Common.Interfaces;
using System;

namespace BackToWorkBot.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
