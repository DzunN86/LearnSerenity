using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<PelanggaranSantri.MovieDB.GenreRow>;
using MyRow = PelanggaranSantri.MovieDB.GenreRow;

namespace PelanggaranSantri.MovieDB
{
    public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
    {
        public GenreListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}