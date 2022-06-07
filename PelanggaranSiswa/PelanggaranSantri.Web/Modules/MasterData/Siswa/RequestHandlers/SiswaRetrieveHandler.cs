using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<PelanggaranSantri.MasterData.SiswaRow>;
using MyRow = PelanggaranSantri.MasterData.SiswaRow;

namespace PelanggaranSantri.MasterData
{
    public interface ISiswaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SiswaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISiswaRetrieveHandler
    {
        public SiswaRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}