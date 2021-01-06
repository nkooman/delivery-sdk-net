﻿using AutoFixture;
using FluentAssertions;
using Kentico.Kontent.Delivery.Caching.Extensions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Kentico.Kontent.Delivery.Caching.Tests
{
    public class DeliveryCacheOptionsExtensionsTests
    {
        private static readonly Fixture _fixture = new Fixture();

        [Theory]
        [MemberData(nameof(GetDeliveryCacheOptionsData))]
        public void Configure(DeliveryCacheOptions options)
        {
            var o = new DeliveryCacheOptions();

            o.Configure(options);

            o.Should().BeEquivalentTo(options);
        }

        public static IEnumerable<object[]> GetDeliveryCacheOptionsData()
        {
            yield return new object[] { _fixture.Create<DeliveryCacheOptions>() };
            yield return new object[] { _fixture.Create<DeliveryCacheOptions>() };
        }
    }
}
