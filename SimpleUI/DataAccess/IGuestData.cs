namespace SimpleUI.DataAccess;
using Refit;
using SimpleUI.Models;

public interface IGuestData
{
    // to wire 
    [Get("/Guests")]
    Task<List<ClientGuestModel>> GetGuests();

    [Get("/Guests/{id}")]
    Task<ClientGuestModel> GetGuest(int id);

    [Post("/Guests")]
    Task CreateGuest([Body] ClientGuestModel guest);

    [Put("/Guests/{id}")]
    Task UpdateGuest(int id, [Body] ClientGuestModel guest);

    [Delete("/Guests/{id}")]
    Task DeleteGuest(int id);
}
