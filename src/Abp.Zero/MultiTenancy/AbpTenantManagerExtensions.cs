using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Threading;
using Microsoft.AspNet.Identity;

namespace Abp.MultiTenancy
{
    public static class AbpTenantManagerExtensions
    {
        public static IdentityResult Create<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, TTenant tenant)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            return AsyncHelper.RunSync(() => tenantManager.CreateAsync(tenant));
        }

        public static IdentityResult Update<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, TTenant tenant)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            return AsyncHelper.RunSync(() => tenantManager.UpdateAsync(tenant));
        }

        public static TTenant FindById<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, int id)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            return AsyncHelper.RunSync(() => tenantManager.FindByIdAsync(id));
        }

        public static TTenant GetById<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, int id)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            return AsyncHelper.RunSync(() => tenantManager.GetByIdAsync(id));
        }

        public static TTenant FindByTenancyName<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, string tenancyName)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            return AsyncHelper.RunSync(() => tenantManager.FindByTenancyNameAsync(tenancyName));
        }

        public static IdentityResult Delete<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, TTenant tenant)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            return AsyncHelper.RunSync(() => tenantManager.DeleteAsync(tenant));
        }

        public static string GetFeatureValueOrNull<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, int tenantId, string featureName)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            return AsyncHelper.RunSync(() => tenantManager.GetFeatureValueOrNullAsync(tenantId, featureName));
        }

        public static IReadOnlyList<NameValue> GetFeatureValues<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, int tenantId)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            return AsyncHelper.RunSync(() => tenantManager.GetFeatureValuesAsync(tenantId));
        }

        public static void SetFeatureValues<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, int tenantId, params NameValue[] values)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            AsyncHelper.RunSync(() => tenantManager.SetFeatureValuesAsync(tenantId, values));
        }

        public static void SetFeatureValue<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, int tenantId, string featureName, string value)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            AsyncHelper.RunSync(() => tenantManager.SetFeatureValueAsync(tenantId, featureName, value));
        }

        public static void SetFeatureValue<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, TTenant tenant, string featureName, string value)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            AsyncHelper.RunSync(() => tenantManager.SetFeatureValueAsync(tenant, featureName, value));
        }

        public static void ResetAllFeatures<TTenant, TUser>(this AbpTenantManager<TTenant, TUser> tenantManager, int tenantId)
            where TTenant : AbpTenant<TUser>
            where TUser : AbpUser<TUser>
        {
            AsyncHelper.RunSync(() => tenantManager.ResetAllFeaturesAsync(tenantId));
        }

    }
}