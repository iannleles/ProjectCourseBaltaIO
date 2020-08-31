﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernWebStore.Domain.Entities;
using ModernWebStore.Domain.Scopes;

namespace ModernWebStore.Domain.Tests.Scopes
{
    [TestClass]
    public class CategoryScopeTests
    {
        [TestMethod]
        [TestCategory("Category")]
        public void ShouldRegisterCategory()
        {
            var category = new Category("Placa Mãe");
            category.Register();

            Assert.AreEqual(true, CategoryScopes.CreateCategoryScopeIsValid(category));
        }

        [TestMethod]
        [TestCategory("Category")]
        public void ShouldUpdateCategoryTitle()
        {
            var category = new Category("Placa Mãe");
            category.Register();

            Assert.AreEqual(true, CategoryScopes.UpdateCategoryScopeIsValid(category, "Motherboards"));
        }
    }
}
