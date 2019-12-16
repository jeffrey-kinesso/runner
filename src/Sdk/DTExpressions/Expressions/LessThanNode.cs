﻿using System;

namespace GitHub.DistributedTask.Expressions
{
    internal sealed class LessThanNode : FunctionNode
    {
        protected sealed override Boolean TraceFullyRealized => false;

        protected sealed override Object EvaluateCore(EvaluationContext context)
        {
            return Parameters[0].Evaluate(context).CompareTo(context, Parameters[1].Evaluate(context)) < 0;
        }
    }
}