﻿using System.Threading.Tasks;
using LMS.BoilerPlate.Models.TokenAuth;
using LMS.BoilerPlate.Web.Controllers;
using Shouldly;
using Xunit;

namespace LMS.BoilerPlate.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerPlateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}