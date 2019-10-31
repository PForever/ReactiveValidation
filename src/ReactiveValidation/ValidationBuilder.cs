﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ReactiveValidation
{
    /// <inheritdoc cref="IValidationBuilder{TObject}" />
    /// <inheritdoc cref="IObjectValidatorBuilder{TObject}" />
    public class ValidationBuilder<TObject> : ValidationRuleBuilder<TObject>, IValidationBuilder<TObject>, IObjectValidatorBuilder<TObject>
        where TObject : IValidatableObject
    {
        /// <inheritdoc />
        public new ISinglePropertyRuleBuilderInitial<TObject, TProp> RuleFor<TProp>(Expression<Func<TObject, TProp>> property)
        {
            return base.RuleFor(property);
        }

        /// <inheritdoc />
        public new ISinglePropertyRuleBuilderInitial<TObject, object> RuleFor(string propertyName)
        {
            return base.RuleFor(propertyName);
        }

        /// <inheritdoc />
        public new IPropertiesRuleBuilderInitial<TObject> RuleFor(params Expression<Func<TObject, object>>[] properties)
        {
            return base.RuleFor(properties);
        }

        /// <inheritdoc />
        public new IPropertiesRuleBuilderInitial<TObject> RuleFor(params string[] propertiesNames)
        {
            return base.RuleFor(propertiesNames);
        }

        /// <inheritdoc />
        public new ICollectionRuleBuilderInitial<TObject, TCollection, TProp> RuleForCollection<TCollection, TProp>(
            Expression<Func<TObject, TCollection>> collection)
            where TCollection : IEnumerable<TProp>
        {
            return base.RuleForCollection<TCollection, TProp>(collection);
        }

        /// <inheritdoc />
        public IObjectValidator Build(TObject instance)
        {
            return CreateBuilder().Build(instance);
        }
    }
}
