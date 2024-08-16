using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.");
			RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen geçerli bir isim giriniz.");
			RuleFor(x => x.Mail).NotEmpty().WithMessage(" Maili kısmı boş geçilemez.");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre kısmı boş geçilemez.");
		}
    }
}
