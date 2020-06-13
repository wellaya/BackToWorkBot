using BackToWorkBot.Application.Common.Interfaces;
using System;

namespace BackToWorkBot.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
