using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = PelanggaranSantri.MovieDB.PersonRow;

namespace PelanggaranSantri.MovieDB
{
    public interface IPersonDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPersonDeleteHandler
    {
        public PersonDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}