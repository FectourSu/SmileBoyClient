﻿using System;

namespace SmileBoyClient.Helpers
{
    class Has
    {
        public static T NotNull<T>(T value, string name = null)
          where T : class
        {
            return value ?? throw new ArgumentNullException($"The argument: {name ?? nameof(value)}, must not be null");
        }
    }
}
