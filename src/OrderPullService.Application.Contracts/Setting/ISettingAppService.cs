﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace OrderPullService.Setting
{
    public interface ISettingAppService : IApplicationService
    {
        Task<OrderPullServiceSettingDto> GetAsync();

        Task UpdateAsync(OrderPullServiceSettingDto input);
    }
}