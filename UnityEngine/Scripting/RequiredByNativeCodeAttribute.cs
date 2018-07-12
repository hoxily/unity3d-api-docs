﻿using System;

namespace UnityEngine.Scripting
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
    internal class RequiredByNativeCodeAttribute : Attribute
    {
        public RequiredByNativeCodeAttribute()
        {
        }

        public RequiredByNativeCodeAttribute(string name)
        {
        }

        public RequiredByNativeCodeAttribute(bool optional)
        {
        }

        public RequiredByNativeCodeAttribute(string name, bool optional)
        {
        }

        public string Name { get; set; }

        public bool Optional { get; set; }
    }
}