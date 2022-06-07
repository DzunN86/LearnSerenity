using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<PelanggaranSantri.MasterData.PelanggaranRow>;
using MyRow = PelanggaranSantri.MasterData.PelanggaranRow;

namespace PelanggaranSantri.MasterData
{
    public interface IPelanggaranRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranRetrieveHandler
    {
        public PelanggaranRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}