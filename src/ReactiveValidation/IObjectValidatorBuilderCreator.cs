﻿using ReactiveValidation.Internal;

namespace ReactiveValidation
{
    /// <summary>
    /// Allows get prepared builder for object validation creating.
    /// </summary>
    public interface IObjectValidatorBuilderCreator
    {
        /// <summary>
        /// Create prepared builder.
        /// </summary>
        IObjectValidatorBuilder Create();
    }
}
