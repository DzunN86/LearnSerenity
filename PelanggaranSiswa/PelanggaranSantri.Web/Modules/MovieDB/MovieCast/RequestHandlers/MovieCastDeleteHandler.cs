using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = PelanggaranSantri.MovieDB.MovieCastRow;

namespace PelanggaranSantri.MovieDB
{
    public interface IMovieCastDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastDeleteHandler
    {
        public MovieCastDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}