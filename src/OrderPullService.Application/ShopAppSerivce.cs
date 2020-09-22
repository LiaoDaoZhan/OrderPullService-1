using OrderPullService.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OrderPullService
{
    public class ShopAppSerivce : CrudAppService<Shop, ShopOutput, ShopGetListOutput, Guid, ShopGetListInput, ShopCreateInput, ShopUpdateInput>, IShopAppSerivce
    {
        public ShopAppSerivce(IRepository<Shop, Guid> repository) : base(repository)
        {
        }
    }
}
