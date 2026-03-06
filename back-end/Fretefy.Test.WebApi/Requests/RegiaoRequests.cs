using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fretefy.Test.WebApi.Requests
{
    public class CreateRegiaoRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(1)]
        public IEnumerable<Guid> CityIds { get; set; }
    }

    public class UpdateRegiaoRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(1)]
        public IEnumerable<Guid> CityIds { get; set; }
    }
}