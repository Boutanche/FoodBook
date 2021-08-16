using API;
using BO.Entity;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTest
{
    public class BookingControllerIntegrationTest : IntegrationTest
    {
        public BookingControllerIntegrationTest(WebApplicationFactory<Startup> factory) : base(factory)
        {
        }
    }
}
