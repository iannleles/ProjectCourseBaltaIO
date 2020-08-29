﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernWebStore.Domain.Entities;

namespace ModernWebStore.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var category = new Category("Placa Mãe");

            var product = new Product("Processador", "Intel I7", 1200, 5, 1);

            var order = new Order(new List<OrderItem>(), 1);

            var orderItem = new OrderItem(1, 20);
            
            order.AddItem(orderItem);

            
           

            Assert.AreNotEqual(0, order.OrderItems);

            // Salvar categoria
        }
    }
}
