using FluentValidation.Results;

namespace NSE.Core.Messages
{
    public abstract class CommandHandler
    {
        protected ValidationResult ValidationResult;

        public CommandHandler()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AdicionaErro(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty,mensagem));
        }
    }
}