﻿namespace FeatureToggle.Interfaces
{
    using System;
    using Enums;

    public interface IFeatureToggle <T>
    {
        ToggleStatus GetToggleState(IConfigParser parser, string toggleKey);
        void ExecuteMethodIfToggleOn(Action methodToRun, string keyName);
        T ExecuteMethodIfToggleOn(Func<T> methodToRun, string keyName);
    }
}