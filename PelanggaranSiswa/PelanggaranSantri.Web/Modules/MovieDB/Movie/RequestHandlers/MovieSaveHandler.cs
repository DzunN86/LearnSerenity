using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<PelanggaranSantri.MovieDB.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = PelanggaranSantri.MovieDB.MovieRow;

namespace PelanggaranSantri.MovieDB
{
    public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
    {
        public MovieSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}