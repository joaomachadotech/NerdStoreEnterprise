﻿using System.Threading.Tasks;
using FluentValidation.Results;
using NSE.Core.Data;

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

        protected async Task<ValidationResult> PersistirDados(IUnitOfWork uow)
        {
            if (!await uow.Commit())
                AdicionaErro("Houve um erro ao persistir os dados");

            return ValidationResult;
        }
    }
}