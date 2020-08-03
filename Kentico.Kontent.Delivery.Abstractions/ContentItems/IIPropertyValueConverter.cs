﻿using System.Reflection;
using System.Threading.Tasks;

namespace Kentico.Kontent.Delivery.Abstractions
{
    /// <summary>
    /// Provides value conversion for the given property
    /// </summary>
    public interface IPropertyValueConverter<T> : IPropertyValueConverter
    {
        /// <summary>
        /// Gets the property value from property data
        /// </summary>
        /// <param name="property">Property info</param>
        /// <param name="elementData">Source element data</param>
        /// <param name="context">Context of the current resolving process</param>
        Task<object> GetPropertyValue<U>(PropertyInfo property, U elementData, ResolvingContext context) where U : IContentElementValue<T>;
    }

    /// <summary>
    /// Provides value conversion for the given property
    /// </summary>
    public interface IPropertyValueConverter
    {
    }
}
