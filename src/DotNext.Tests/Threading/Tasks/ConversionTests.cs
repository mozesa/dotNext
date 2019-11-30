﻿using System.Threading.Tasks;
using Xunit;

namespace DotNext.Threading.Tasks
{
    public sealed class ConversionTests : Assert
    {
        [Fact]
        public static void Nullable()
        {
            var t = Task.FromResult(10).ToNullable();
            Equal(10, t.Result);
        }

        [Fact]
        public static void TypeConversion()
        {
            var t = Task.FromResult("12").Convert(int.Parse);
            Equal(12, t.Result);
        }
    }
}
