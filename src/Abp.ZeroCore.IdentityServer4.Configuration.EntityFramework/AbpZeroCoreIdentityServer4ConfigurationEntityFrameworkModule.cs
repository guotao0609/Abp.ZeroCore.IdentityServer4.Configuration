﻿// Project: Abp.ZeroCore.IdentityServer4.Configuration.EntityFramework
// File: AbpZeroCoreIdentityServer4ConfigurationEntityFrameworkModule.cs
// 
// Copyright 2018 Mjollnir<mjollnir@59k.org>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Abp.IdentityServer4
{
    [DependsOn(typeof(AbpZeroCoreIdentityServer4ConfigurationModule))]
    public class AbpZeroCoreIdentityServer4ConfigurationEntityFrameworkModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroCoreIdentityServer4ConfigurationEntityFrameworkModule).GetAssembly());
        }
    }
}
