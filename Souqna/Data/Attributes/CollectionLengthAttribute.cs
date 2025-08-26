using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Souqna.Data.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CollectionLengthAttribute : ValidationAttribute
    {
        private readonly int _maxLength;
        private readonly int _minLength;

        public CollectionLengthAttribute(int minLength, int maxLength)
        {
            _maxLength = maxLength;
            _minLength = minLength;
            ErrorMessage = $"The maximum allowed number of items is {_maxLength}.";
        }

        public override bool IsValid(object value)
        {
            if (value is ICollection collection)
            {
                if (collection.Count < _minLength)
                {
                    ErrorMessage = $"The minimum required number of images is {_minLength}.";
                    return false; // Not enough items
                }
                return collection.Count <= _maxLength;
            }
            return true; // Not a collection, so ignore
        }
    }
}