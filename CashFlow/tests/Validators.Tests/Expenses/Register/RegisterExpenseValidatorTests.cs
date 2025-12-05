using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Enums;
using CashFlow.Exception;
using CommonTestUtilities.Requests;
using Shouldly;

namespace Validators.Tests.Expenses.Register
{
    public class RegisterExpenseValidatorTests
    {
        [Fact]
        public void Succes()
        {
            // Arrange -> A parte de configuração de instâncias
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();

            // Act -> A parte de execução do código a ser testado ( a validação )
            var result = validator.Validate(request);

            // Assert -> Resultado esperado
            result.ShouldNotBeNull();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Error_Title_Empty(string title)
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();
            request.Title = title;

            //Act
            var result = validator.Validate(request);

            //Assert
            result.Errors.ShouldHaveSingleItem();
            result.Errors[0].ErrorMessage.ShouldBe(ResourceErrorMessages.TITLE_REQUIRED);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Error_Description_Empty(string desc)
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();
            request.Description = desc;

            //Act
            var result = validator.Validate(request);

            //Assert
            result.Errors.ShouldHaveSingleItem();
            result.Errors[0].ErrorMessage.ShouldBe(ResourceErrorMessages.DESCRIPTION_REQUIRED);
        }


        [Fact]
        public void Error_Date_Future()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();
            request.Date = DateTime.UtcNow.AddDays(1);
            //Act
            var result = validator.Validate(request);
            //Assert
            result.Errors.ShouldHaveSingleItem();
            result.Errors[0].ErrorMessage.ShouldBe(ResourceErrorMessages.EXPENSES_CANNOT_FOR_THE_FUTURE);
        }

        [Fact]
        public void Error_Payments_Type()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();
            request.PaymentType = (PaymentType) 10;
            //Act
            var result = validator.Validate(request);
            //Assert
            result.Errors.ShouldHaveSingleItem();
            result.Errors[0].ErrorMessage.ShouldBe(ResourceErrorMessages.PAYMENT_TYPE_INVALID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        public void Error_Amount_Invalid(decimal amount)
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestRegisterExpenseJsonBuilder.Build();
            request.Amount = amount;
            //Act
            var result = validator.Validate(request);
            //Assert
            result.Errors.ShouldHaveSingleItem();
            result.Errors[0].ErrorMessage.ShouldBe(ResourceErrorMessages.AMOUNT_MOST_BE_GREATHER_THAN_ZERO);
        }




    }
}
