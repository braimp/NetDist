﻿using NetDist.Jobs;
using SimpleCalculator.Shared;

namespace SimpleCalculator.Jobs
{
    public class CalculatorJobSub : JobBase<CalculatorJobInput, CalculatorJobOutput>
    {
        public override CalculatorJobOutput Process(CalculatorJobInput input)
        {
            var result = new CalculatorJobOutput { Result = input.Number1 - input.Number2 };
            return result;
        }
    }
}
