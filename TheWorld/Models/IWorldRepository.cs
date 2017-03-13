using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
        IEnumerable<Trip> GetTripsByUsername( string username );
        Trip GetTripByName( string tripName );
        Trip GetUserTripByName( string tripName, string userName );

        void AddTrip( Trip newTrip );
        void AddStop( string tripName, Stop newStop, string username );

        Task<bool> SaveChangesAsync();
    }
}