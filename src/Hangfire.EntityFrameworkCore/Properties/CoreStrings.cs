﻿// <auto-generated />
using System.Resources;

namespace Hangfire.EntityFrameworkCore.Properties;

internal static class CoreStrings
{
    private static ResourceManager ResourceManager { get; } = new ResourceManager(
        "Hangfire.EntityFrameworkCore.Properties.CoreStrings",
        typeof(CoreStrings).Assembly);

    public static string ArgumentExceptionCollectionCannotBeEmpty
        => GetString("ArgumentExceptionCollectionCannotBeEmpty");

    public static string ArgumentExceptionStringCannotBeEmpty
        => GetString("ArgumentExceptionStringCannotBeEmpty");

    public static string ArgumentOutOfRangeExceptionNeedNonNegativeValue
        => GetString("ArgumentOutOfRangeExceptionNeedNonNegativeValue");

    public static string ArgumentOutOfRangeExceptionNeedPositiveValue
        => GetString("ArgumentOutOfRangeExceptionNeedPositiveValue");

    public static string CountersAggregatorExecuteCompleted(object tableName)
        => string.Format(
            GetString("CountersAggregatorExecuteCompleted", nameof(tableName)),
            tableName);

    public static string CountersAggregatorExecuteStarting(object tableName)
        => string.Format(
            GetString("CountersAggregatorExecuteStarting", nameof(tableName)),
            tableName);

    public static string EFCoreFetchedJobExecuteKeepAliveQueryCompleted(object id)
        => string.Format(
            GetString("EFCoreFetchedJobExecuteKeepAliveQueryCompleted", nameof(id)),
            id);

    public static string EFCoreFetchedJobExecuteKeepAliveQueryFailed(object id)
        => string.Format(
            GetString("EFCoreFetchedJobExecuteKeepAliveQueryFailed", nameof(id)),
            id);

    public static string ExpirationManagerRemoveExpiredCompleted(object tableName)
        => string.Format(
            GetString("ExpirationManagerRemoveExpiredCompleted", nameof(tableName)),
            tableName);

    public static string ExpirationManagerRemoveExpiredStarting(object tableName)
        => string.Format(
            GetString("ExpirationManagerRemoveExpiredStarting", nameof(tableName)),
            tableName);

    public static string ExpirationManagerUseLockFailed(object lockKey, object lockTimeoutSeconds, object expirationCheckIntervalSeconds)
        => string.Format(
            GetString("ExpirationManagerUseLockFailed", nameof(lockKey), nameof(lockTimeoutSeconds), nameof(expirationCheckIntervalSeconds)),
            lockKey, lockTimeoutSeconds, expirationCheckIntervalSeconds);

    public static string InvalidOperationExceptionJobDoesNotExists
        => GetString("InvalidOperationExceptionJobDoesNotExists");

    private static string GetString(string name, params string[] formatterNames)
    {
        var value = ResourceManager.GetString(name);
        for (var i = 0; i < formatterNames.Length; i++)
            value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");

        return value;
    }
}
