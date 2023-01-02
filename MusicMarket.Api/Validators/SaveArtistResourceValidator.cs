using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MusicMarket.Api.DTO;

namespace MusicMarket.Api.Validators
{
    public class SaveArtistResourceValidator : AbstractValidator<SaveArtistDTO>
    {
        public SaveArtistResourceValidator()
        {
            RuleFor(a => a.Name)
              .NotEmpty()
              .MaximumLength(50);
        }
    }
}