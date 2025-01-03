﻿using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    // Aspect: Metodun başında, sonunda vs. çalışacak yapı

    /* ValidationAspect aslında bir attribute. Bunu da şöyle anlıyoruz:
    MethodInterception'den kalıtım alıyor o da MethodInterceptionBaseAttribute'dan
    kalıtım alıyor. MethodInterceptionBaseAttribute'da bir attribute çünkü. */
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //Defensive Coding
            //yanlış bir tip atanmaması için. (Rastgele Product, Category vs tip atanmaması için.)

            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değildir.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
