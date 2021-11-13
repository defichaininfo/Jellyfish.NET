using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jellyfish.API.Loan;

public enum VaultState
{
    Unknown,
    Active,
    InLiquidation,
    Frozen,
    MayLiquidate
}
