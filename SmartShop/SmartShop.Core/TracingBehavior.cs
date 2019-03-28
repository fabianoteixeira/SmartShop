using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartShop.Core
{
    public class TracingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
       where TRequest : IRequest<TResponse>

    {
        private readonly IEnumerable<IValidator> _validators;

        public TracingBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }


        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var failures = _validators
                .Select(v => v.Validate(request))
                .SelectMany(result => result.Errors)
                .Where(f => f != null)
                .ToList();
            
            //return failures.Any()
            //    ? Errors(failures)
            //    : next();

            

            if (failures.Count != 0)
            {
                throw new ValidationException(failures);
            }

            return next();
        }

        //private static Task<TResponse> Errors(IEnumerable<ValidationFailure> failures)
        //{
        //    var response = new Response();

        //    foreach (var failure in failures)
        //    {
        //        response.AddError(failure.ErrorMessage);
        //    }

        //    return Task.FromResult(response as TResponse);
        //}
    }
}
