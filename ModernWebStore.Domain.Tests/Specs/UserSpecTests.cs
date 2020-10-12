using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernWebStore.Domain.Entities;
using ModernWebStore.Domain.Specs;
using ModernWebStore.SharedKernel.Helpers;

namespace ModernWebStore.Domain.Tests.Specs
{
    [TestClass]
    public class UserSpecTests
    {
        private List<User> _users;

        public UserSpecTests()
        {
            this._users = new List<User>();
            _users.Add(new User("iannleles@uni9.edu.br", StringHelper.Encrypt("123456"), true));
        }

        [TestMethod]
        [TestCategory("User Specs - Authenticate")]
        public void ShouldAuthenticate()
        {
            var exp = UserSpecs.AuthenticateUser("iannleles@uni9.edu.br", "123456");
            var user = _users.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, user);
        }

        [TestMethod]
        [TestCategory("User Specs - Authenticate")]
        public void ShouldNotAuthenticateWhenEmailIsWrong()
        {
            var exp = UserSpecs.AuthenticateUser("iannleles@uni9.edu.br", "123456");
            var user = _users.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, user);
        }

        [TestMethod]
        [TestCategory("User Specs - Authenticate")]
        public void ShouldNotAuthenticateWhenPasswordIsWrong()
        {
            var exp = UserSpecs.AuthenticateUser("iannleles@hotmail.com", "1233456");
            var user = _users.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, user);
        }
    }
}
