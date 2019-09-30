using System;

namespace HeidelbergCement.Foundation.Common.Interfaces.Enums
{
    [Flags]
    public enum PermissionType
    {
        None = 0,
        VIEW_ORDERS_DELIVERIES = 1 << 0,
        CHANGE_ORDERS = 1 << 1,
        VIEW_FINANCE = 1 << 2,
        VIEW_INVOICES = 1 << 3,
        CHANGE_INVOICES = 1 << 4,
        VIEW_QOUTES = 1 << 5,
        CHANGE_QUOTES = 1 << 6,
        CHANGE_TESTS = 1 << 7,
        VIEW_ALL_DATA = 1 << 8,
        CHANGE_ALL_DATA = 1 << 9,
        VIEW_USERS = 1 << 10,
        INVITE_USERS = 1 << 11,
        DELETE_USERS = 1 << 12,
        CHANGE_USERS = 1 << 13,
        GRANT_USER_MANAGEMENT_RIGHTS = 1 << 14,
        GRANT_SUPERADMIN_RIGHTS = 1 << 15,
        VIEW_TESTS = 1 << 16,
        VIEW_CUSTOMERS = 1 << 17,
        VIEW_SITES = 1 << 18,
        VIEW_PROJECTS = 1 << 19,
        VIEW_DOCUMENTS = 1 << 20,
        VIEW_MATERIALCERTIFICATES = 1 << 21,
        ASSIGN_ROLES = 1 << 22,
        VIEW_PLANTS = 1 << 23,
        ACCESS_PRODUCT_HUB = 1 << 24,
        DELETE_GLOBAL_ADMIN = 1 << 25,
    }
}