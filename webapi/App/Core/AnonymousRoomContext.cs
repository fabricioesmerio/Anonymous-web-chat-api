using Microsoft.EntityFrameworkCore;

namespace webapi.App.Core
{
    public class AnonymousRoomContext : DbContext
    {

        public AnonymousRoomContext(DbContextOptions<AnonymousRoomContext> options) : base(options) 
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
}
