﻿using NetDist.Core;
using System;

namespace NetDist.Server
{
    [Serializable]
    public class JobHandlerInitializeResult
    {
        public bool HasError { get; set; }
        public AddJobHandlerErrorReason ErrorReason { get; set; }
        public string ErrorMessage { get; set; }
        public Guid HandlerId { get; set; }
        public string PackageName { get; set; }
        public string HandlerName { get; set; }
        public string JobName { get; set; }

        public void SetError(AddJobHandlerErrorReason errorReason, string errorMessage)
        {
            HasError = true;
            ErrorMessage = errorMessage;
            ErrorReason = errorReason;
        }
    }
}