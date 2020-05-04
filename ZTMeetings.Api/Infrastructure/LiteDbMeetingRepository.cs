using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDB;
using ZTMeetings.Domain;

namespace ZTMeetings.Api.Infrastructure
{
    public class LiteDbMeetingRepository : IMeetingRepository
    {
        private readonly LiteDatabase _db;
        private readonly ILiteCollection<Meeting> _meetingsCollection;

        public LiteDbMeetingRepository()
        {
            _db = new LiteDatabase("data.db");

            _meetingsCollection = _db.GetCollection<Meeting>();
        }

        public Meeting GetMeeting(Guid id)
        {
            return _meetingsCollection.FindOne(x => x.Id == id);
        }

        public async Task AddMeetingAsync(Meeting meeting)
        {
            await Task.Run(() =>
            {
                _meetingsCollection.Insert(meeting);
                _meetingsCollection.EnsureIndex(x => x.Id);

            });
        }

        public async Task SaveMeetingAsync(Meeting meeting)
        {
            await Task.Run(() =>
            {
                _meetingsCollection.Update(meeting.Id, meeting);
            });
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
