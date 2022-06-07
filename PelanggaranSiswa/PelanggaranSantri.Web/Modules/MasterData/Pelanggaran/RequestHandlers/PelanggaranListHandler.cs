using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<PelanggaranSantri.MasterData.PelanggaranRow>;
using MyRow = PelanggaranSantri.MasterData.PelanggaranRow;

namespace PelanggaranSantri.MasterData
{
    public interface IPelanggaranListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranListHandler
    {
        public PelanggaranListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}