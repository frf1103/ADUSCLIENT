using System.ComponentModel;

namespace FarmPlannerClient.Enum
{
    public enum Combustivel
    {
        [Description("Diesel BS500")]
        DIESEBS500,

        [Description("Diesel S10")]
        DIESES10,

        [Description("Gasolina")]
        GASOLINA,

        [Description("Etanol")]
        ETANOL,

        [Description("Jet A1")]
        JETA1,

        [Description("Querosene")]
        QUEROSENE
    }
}