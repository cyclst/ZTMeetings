using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ZTMeetings.Api.Specs.Models;

namespace ZTMeetings.Api.Specs
{
    public class MeetingsApiClient
    {
        private readonly HttpClient _client;
        public MeetingsApiClient()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7569/api/meetings")
            };
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync()
        {
            var response = await _client.GetAsync("");

            if (!response.IsSuccessStatusCode)
            {
                var error = response.Content.ReadAsStringAsync().Result;

                throw new ApplicationException(error);
            }

            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                return await JsonSerializer.DeserializeAsync
                    <IEnumerable<Booking>>(responseStream);
            }
        }

        public async Task BookSeatsAsync(IEnumerable<Employee> employees)
        {
            var response = await _client.PostAsJsonAsync(
                "", employees);

            if (!response.IsSuccessStatusCode)
            {
                var error = response.Content.ReadAsStringAsync().Result;

                throw new ApplicationException(error);
            }
        }

        public static MeetingsApiClient New()
        {
            return new MeetingsApiClient();
        }
    }
}
