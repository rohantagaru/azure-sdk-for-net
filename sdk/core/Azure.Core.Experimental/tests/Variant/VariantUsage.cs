﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;

namespace Azure.Core.Experimental.Tests
{
    public class VariantUsage
    {
        [Test]
        public void CanUseVariantAsString()
        {
            Variant variant = "hi";

            Assert.AreEqual("hi", (string)variant);

            Assert.IsTrue("hi" == (string)variant);
            Assert.IsTrue((string)variant == "hi");

            Assert.AreEqual("hi", $"{(string)variant}");
        }

        [Test]
        public void CanTestForNull()
        {
            Variant variant = Variant.Null;
            Assert.True(variant.IsNull);

            Assert.True(new Variant((object)null).IsNull);
        }

        [TestCaseSource(nameof(VariantValues))]
        public void CanGetAsString(Variant v, Variant s)
        {
            string value = (string)s;
            Assert.AreEqual(value, v.ToString());
        }

        #region Helpers
        public static IEnumerable<Variant[]> VariantValues()
        {
            yield return new Variant[] { (byte)42, "42" };
            yield return new Variant[] { (sbyte)42, "42" };
            yield return new Variant[] { (short)42, "42" };
            yield return new Variant[] { (ushort)42, "42" };
            yield return new Variant[] { 42U, "42" };
            yield return new Variant[] { 42UL, "42" };
            yield return new Variant[] { 42, "42" };
            yield return new Variant[] { 42L, "42" };
            yield return new Variant[] { 1.0, "1" };
            yield return new Variant[] { 1.1D, "1.1" };
            yield return new Variant[] { 1.1F, "1.1" };
            yield return new Variant[] { Variant.Null, "null" };
            yield return new Variant[] { 'a', "a" };
            yield return new Variant[] { true, "true" };
            yield return new Variant[] { false, "false" };
            DateTimeOffset dateTime = new(2002, 8, 9, 10, 11, 12, TimeSpan.Zero);
            yield return new Variant[] { dateTime.DateTime, dateTime.DateTime.ToString() };
            yield return new Variant[] { dateTime, dateTime.ToString() };
            ArraySegment<byte> bytes = new("variant"u8.ToArray());
            yield return new Variant[] { bytes, bytes.ToString() };
            ArraySegment<char> chars = new("variant".AsSpan().ToArray());
            yield return new Variant[] { chars, chars.ToString() };
            yield return new Variant[] { new(Color.Blue), Color.Blue.ToString() };
        }

        #endregion
    }
}
