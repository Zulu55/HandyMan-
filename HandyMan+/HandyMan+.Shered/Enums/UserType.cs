﻿using HandyMan_.Shared.Enums;
using System.ComponentModel;

namespace HandyMan_.Shared.Enums
{
    public enum UserType
    {
        [Description("Administrador")]
        Admin,

        [Description("Cliente")]
        Costumer,

        [Description("Usuario Premium")]
        CostumerPremium,

        [Description("Proveedor")]
        Provider,

        [Description("Proveedor Premium")]
        ProviderPremium,

        [Description("Especialista")]
        Specialist,

    }
}
public class UserTypeEnumToList
{
    public static List<string> GetList()
    {
        return [.. Enum.GetNames(typeof(UserType))];
    }
}