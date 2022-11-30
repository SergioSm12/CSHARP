using ustatickets.Data.ViewModels;
using ustatickets.Models;
using ustaTickets.Data.Base;

namespace ustatickets.Data.Services
{
    public interface IMovieService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
        Task DeleteMovieAsync(NewMovieVM data);
    }
}
