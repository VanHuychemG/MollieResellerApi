﻿using System.ComponentModel;

namespace MollieResellerApi.Models.Reseller
{
    public enum LegalForm
    {
        [Description("eenmanszaak")]
        Eenmanszaak,
        [Description("eenmanszaak-be")]
        EenmanszaakBe,
        [Description("eenmans-bvba-be")]
        EenmansBvbaBe,
        [Description("maatschap")]
        Maatschap,
        [Description("vof")]
        Vof,
        [Description("vof-be")]
        VofBe,
        [Description("bv")]
        Bv,
        [Description("bvba-be")]
        BvbaBe,
        [Description("cv")]
        Cv,
        [Description("commv-be")]
        CommvBe,
        [Description("commva-be")]
        CommvaBe,
        [Description("nv")]
        Nv,
        [Description("nv-be")]
        NvBe,
        [Description("coöperatie")]
        Coöperatie,
        [Description("cvoa-be")]
        CvoaBe,
        [Description("cvba-be")]
        CvbaBe,
        [Description("stichting")]
        Stichting,
        [Description("stichting-be")]
        StichtingBe,
        [Description("vereniging")]
        Vereniging,
        [Description("vzw-be")]
        VzwBe,
        [Description("overheid")]
        Overheid,
        [Description("kerkgenootschap")]
        Kerkgenootschap,
        [Description("kroondomein")]
        Kroondomein,
        [Description("lbvn-be")]
        LbvnBe,
        [Description("esv-be")]
        EsvBe,
        [Description("es-be")]
        EsBe,
        [Description("vvzrl-be")]
        VvzrlBe,
        [Description("niet-be")]
        NietBe,
        [Description("buitenlandse-ven")]
        BuitenlandseVen,
        [Description("niet-nl")]
        NietNl
    }
}
