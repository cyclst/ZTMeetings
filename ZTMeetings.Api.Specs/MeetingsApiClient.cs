using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ZTMeetings.Api.Dtos;

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

        public async Task CreateMeetingAsync(Guid meetingId, DateTime meetingDateTime)
        {
            var dto = new MeetingDto
            {
                Id = meetingId,
                DateTime = meetingDateTime
            };

            var response = await _client.PostAsJsonAsync(
                "", dto);

            if (!response.IsSuccessStatusCode)
            {
                var error = response.Content.ReadAsStringAsync().Result;

                throw new ApplicationException(error);
            }
        }

        public async Task BookSeatsAsync(Guid meetingId, IReadOnlyCollection<EmployeeDto> employees)
        {
            var response = await _client.PostAsJsonAsync(
                $"{meetingId}/bookings", employees);

            if (!response.IsSuccessStatusCode)
            {
                var error = response.Content.ReadAsStringAsync().Result;

                throw new ApplicationException(error);
            }
        }

        public async Task<IEnumerable<BookingDto>> GetBookingsAsync(Guid meetingId)
        {
            var response = await _client.GetAsync($"{meetingId}/bookings");

            if (!response.IsSuccessStatusCode)
            {
                var error = response.Content.ReadAsStringAsync().Result;

                throw new ApplicationException(error);
            }

            using (var s = await response.Content.ReadAsStreamAsync())
            using (StreamReader sr = new StreamReader(s))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                JsonSerializer serializer = new JsonSerializer();

                return serializer.Deserialize<IEnumerable<BookingDto>>(reader);
            }
        }

        public static MeetingsApiClient New()
        {
            return new MeetingsApiClient();
        }
    }
}
