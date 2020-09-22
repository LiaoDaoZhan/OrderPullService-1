using OrderPullService.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace OrderPullService
{
    /// <summary>
    /// 店铺管理
    /// </summary>
    public interface IShopAppSerivce : ICrudAppService<ShopOutput, ShopGetListOutput, Guid, ShopGetListInput, ShopCreateInput, ShopUpdateInput>
    {

    }
}
