using E_tickets.Data.Base;
using E_tickets.Data.ViewModels;
using E_tickets.Models;

namespace E_tickets.Data.Services
{

    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);

        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
    }

}
