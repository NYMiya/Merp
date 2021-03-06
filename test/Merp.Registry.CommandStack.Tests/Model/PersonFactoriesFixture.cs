﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SharpTestsEx;
using Merp.Registry.CommandStack.Model;

namespace Merp.Registry.CommandStack.Tests.Model
{
    [TestFixture]
    public class PersonFactoriesFixture
    {
        [Test]
        public void CreateNewEntry_should_throw_ArgumentException_on_null_firstName()
        {
            Executing.This(() => Person.Factory.CreateNewEntry(null, "Saltarello", "FAKE", "FAKE"))
                .Should()
                .Throw<ArgumentException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("firstName");
        }

        [Test]
        public void CreateNewEntry_should_throw_ArgumentException_on_blank_firstName()
        {
            Executing.This(() => Person.Factory.CreateNewEntry("", "Saltarello", "FAKE", "FAKE"))
                .Should()
                .Throw<ArgumentException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("firstName");
        }

        [Test]
        public void CreateNewEntry_should_throw_ArgumentException_on_null_lastName()
        {
            Executing.This(() => Person.Factory.CreateNewEntry("Andrea", null, "FAKE", "FAKE"))
                .Should()
                .Throw<ArgumentException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("lastName");
        }

        [Test]
        public void CreateNewEntry_should_throw_ArgumentException_on_blank_lastName()
        {
            Executing.This(() => Person.Factory.CreateNewEntry("Andrea", "", "FAKE", "FAKE"))
                .Should()
                .Throw<ArgumentException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("lastName");
        }

        [Test]
        public void CreateNewEntry_should_throw_ArgumentException_on_null_NationalIdentificationNumber()
        {
            Executing.This(() => Person.Factory.CreateNewEntry("Andrea", "Saltarello", null, "FAKE"))
                .Should()
                .Throw<ArgumentException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("nationalIdentificationNumber");
        }

        [Test]
        public void CreateNewEntry_should_throw_ArgumentException_on_blank_NationalIdentificationNumber()
        {
            Executing.This(() => Person.Factory.CreateNewEntry("Andrea", "Saltarello", string.Empty, "FAKE"))
                .Should()
                .Throw<ArgumentException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("nationalIdentificationNumber");
        }
    }
}
