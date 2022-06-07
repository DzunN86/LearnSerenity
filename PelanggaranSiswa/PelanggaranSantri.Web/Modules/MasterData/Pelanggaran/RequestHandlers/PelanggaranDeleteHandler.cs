using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = PelanggaranSantri.MasterData.PelanggaranRow;

namespace PelanggaranSantri.MasterData
{
    public interface IPelanggaranDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranDeleteHandler
    {
        public PelanggaranDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}